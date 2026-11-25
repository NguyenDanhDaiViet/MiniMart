using System.Net.Mail;
using Microsoft.EntityFrameworkCore;
using MiniMart.Data;
using MiniMart.Model;

namespace MiniMart.Services;

public class DichVuKho
{
    public string NhapKho(int IdSanPham, int SoLuong, decimal GiaVon, ThongTinNhaCungCap nhaCungCap, string maLo = "", DateTime? ngaySanXuat = null, DateTime? ngayHetHan = null)
    {
        if (SoLuong <= 0 || GiaVon <= 0)
        {
            throw new InvalidOperationException("Số lượng nhập và giá nhập phải lớn hơn 0.");
        }

        var ncc = ChuanHoaNhaCungCap(nhaCungCap);

        using var db = new CoSoDuLieu();
        var sp = db.SanPhams.Find(IdSanPham)?? throw new InvalidOperationException("Không tìm thấy sản phẩm");
        
        if (GiaVon >= sp.GiaBan) throw new InvalidOperationException("Giá nhập phải thấp hơn giá bán hiện tại. Hãy cập nhật giá bán trước nếu cần.");
        sp.SoLuongHangTon += SoLuong;
        
        sp.GiaVon = GiaVon;
        
        if (ngaySanXuat.HasValue && !ngayHetHan.HasValue)
            throw new InvalidOperationException("Đã nhập ngày sản xuất thì cần nhập cả hạn sử dụng.");
        
        if (ngayHetHan.HasValue)
        {
            if (ngayHetHan.Value.Date < DateTime.Today || (ngaySanXuat.HasValue && ngaySanXuat.Value.Date > ngayHetHan.Value.Date))
                throw new InvalidOperationException("Ngày sản xuất/hạn sử dụng không hợp lệ.");
            
            string maLoChuan = string.IsNullOrWhiteSpace(maLo) ? "LO" + DateTime.Now.ToString("yyyyMMddHHmmssfff") : maLo.Trim();
            
            if (db.LoHangs.Any(x => x.MaLo == maLoChuan)) throw new InvalidOperationException("Mã lô đã tồn tại.");
            
            db.LoHangs.Add(new LoHang { IdSanPham = IdSanPham, MaLo = maLoChuan, SoLuongNhap = SoLuong, SoLuongConLai = SoLuong, NgaySanXuat = ngaySanXuat, NgayHetHan = ngayHetHan.Value.Date });
        }
        var phieu = new PhieuNhapKho
        {
            MaBienNhan = "PN" + DateTime.Now.ToString("yyyyMMddHHmmssfff"),
            MaSanPham = IdSanPham,
            SoLuong = SoLuong,
            GiaVon = GiaVon,
            DuocTaoVao = DateTime.Now,
            MaNhaCungCap = ncc.Ma,
            TenNhaCungCap = ncc.Ten,
            SoDienThoaiNhaCungCap = ncc.SoDienThoai,
            DiaChiNhaCungCap = ncc.DiaChi,
            EmailNhaCungCap = ncc.Email,
            GhiChu = ncc.GhiChu
        };
        db.PhieuNhapKhos.Add(phieu);
        
        db.SaveChanges();
        DichVuLichSuHoatDong.Ghi("Nhập kho", $"{sp.Ten} +{SoLuong}; phiếu {phieu.MaBienNhan}");
        return phieu.MaBienNhan;
    }
    
    public ThongTinNhaCungCap? LayNhaCungCapTheoMa(string ma)
    {
        string c = (ma ?? "").Trim().ToLower();
        if (c.Length == 0) return null;

        using var db = new CoSoDuLieu();
        var p = db.PhieuNhapKhos.AsNoTracking()
            .Where(x => x.MaNhaCungCap.ToLower() == c)
            .OrderByDescending(x => x.DuocTaoVao)
            .ThenByDescending(x => x.Id)
            .FirstOrDefault();
        
        return p == null
            ? null
            : new ThongTinNhaCungCap(p.MaNhaCungCap, p.TenNhaCungCap, p.SoDienThoaiNhaCungCap,
                p.DiaChiNhaCungCap, p.EmailNhaCungCap, "");
    }
    
    public List<PhieuNhapKhoChiTiet> LayLichSuNhapKho(DateTime tuNgay, DateTime denNgay, string tuKhoa = "")
    {
        using var db = new CoSoDuLieu();
        var batDau = tuNgay.Date;
        var ketThuc = denNgay.Date.AddDays(1);

        var danhSach = (from p in db.PhieuNhapKhos.AsNoTracking()
                        join s in db.SanPhams.AsNoTracking() on p.MaSanPham equals s.Id
                        where p.DuocTaoVao >= batDau && p.DuocTaoVao < ketThuc
                        orderby p.DuocTaoVao descending, p.Id descending
                        select new PhieuNhapKhoChiTiet(
                            p.Id, p.MaBienNhan, p.DuocTaoVao,
                            p.MaNhaCungCap, p.TenNhaCungCap, p.SoDienThoaiNhaCungCap,
                            p.DiaChiNhaCungCap, p.EmailNhaCungCap, p.GhiChu,
                            s.Ma, s.Ten, s.DonVi, p.SoLuong, p.GiaVon))
            .ToList();

        string k = (tuKhoa ?? "").Trim();
        if (k.Length == 0) return danhSach;

       
        return danhSach.Where(x => x.MaBienNhan.Contains(k, StringComparison.CurrentCultureIgnoreCase)
                                || x.MaNhaCungCap.Contains(k, StringComparison.CurrentCultureIgnoreCase)
                                || x.TenNhaCungCap.Contains(k, StringComparison.CurrentCultureIgnoreCase)
                                || x.SoDienThoaiNhaCungCap.Contains(k)
                                || x.MaSanPham.Contains(k, StringComparison.CurrentCultureIgnoreCase)
                                || x.TenSanPham.Contains(k, StringComparison.CurrentCultureIgnoreCase))
                       .ToList();
    }

    private static ThongTinNhaCungCap ChuanHoaNhaCungCap(ThongTinNhaCungCap? ncc)
    {
        string ma = (ncc?.Ma ?? "").Trim();
        string ten = (ncc?.Ten ?? "").Trim();
        string diaChi = (ncc?.DiaChi ?? "").Trim();
        string email = (ncc?.Email ?? "").Trim();
        string ghiChu = (ncc?.GhiChu ?? "").Trim();
        string sdt = ChuanHoaSoDienThoaiNhaCungCap(ncc?.SoDienThoai);

        if (ma.Length == 0) throw new InvalidOperationException("Vui lòng nhập mã nhà cung cấp.");
        if (ma.Length > 30) throw new InvalidOperationException("Mã nhà cung cấp tối đa 30 ký tự.");
        if (ma.Any(char.IsWhiteSpace)) throw new InvalidOperationException("Mã nhà cung cấp không được chứa khoảng trắng.");
        if (ten.Length == 0) throw new InvalidOperationException("Vui lòng nhập tên nhà cung cấp.");
        if (ten.Length > 100) throw new InvalidOperationException("Tên nhà cung cấp tối đa 100 ký tự.");
        if (diaChi.Length > 200) throw new InvalidOperationException("Địa chỉ nhà cung cấp tối đa 200 ký tự.");
        if (email.Length > 0 && (email.Length > 100 || !EmailHopLe(email)))
            throw new InvalidOperationException("Email nhà cung cấp không hợp lệ (vd. ncc@example.com).");
        if (ghiChu.Length > 500) throw new InvalidOperationException("Ghi chú tối đa 500 ký tự.");

        return new ThongTinNhaCungCap(ma, ten, sdt, diaChi, email, ghiChu);
    }
    
    private static string ChuanHoaSoDienThoaiNhaCungCap(string? so)
    {
        string s = new((so ?? "").Where(c => !char.IsWhiteSpace(c) && c is not ('.' or '-' or '(' or ')')).ToArray());
        if (s.Length == 0) return "";
        if (s.StartsWith("+84")) s = "0" + s[3..];
        if (!s.All(char.IsAsciiDigit) || s.Length is < 8 or > 15)
            throw new InvalidOperationException("Số điện thoại nhà cung cấp không hợp lệ. Hãy nhập 8-15 chữ số (vd. 0912345678).");
        return s;
    }

    private static bool EmailHopLe(string email)
        => MailAddress.TryCreate(email, out var m)
           && string.Equals(m.Address, email, StringComparison.OrdinalIgnoreCase)
           && m.Host.Contains('.');
}

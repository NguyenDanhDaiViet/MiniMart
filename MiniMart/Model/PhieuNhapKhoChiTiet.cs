namespace MiniMart.Model;

public record PhieuNhapKhoChiTiet(
    int Id,
    string MaBienNhan,
    DateTime NgayNhap,
    string MaNhaCungCap,
    string TenNhaCungCap,
    string SoDienThoaiNhaCungCap,
    string DiaChiNhaCungCap,
    string EmailNhaCungCap,
    string GhiChu,
    string MaSanPham,
    string TenSanPham,
    string DonVi,
    int SoLuong,
    decimal GiaNhap)
{
    public decimal ThanhTien => SoLuong * GiaNhap;
}
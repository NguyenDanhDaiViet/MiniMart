using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniMart.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaHoaDon = table.Column<string>(type: "TEXT", nullable: false),
                    NgayLapHoaDon = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TongPhu = table.Column<double>(type: "REAL", nullable: false),
                    ChietKhau = table.Column<double>(type: "REAL", nullable: false),
                    TongTien = table.Column<double>(type: "REAL", nullable: false),
                    TienDaTra = table.Column<double>(type: "REAL", nullable: false),
                    TienThua = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDung",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TenNguoiDung = table.Column<string>(type: "TEXT", nullable: false),
                    MatKhauBam = table.Column<string>(type: "TEXT", nullable: false),
                    TenHienThi = table.Column<string>(type: "TEXT", nullable: false),
                    VaiTro = table.Column<string>(type: "TEXT", nullable: false),
                    DangHoatDong = table.Column<bool>(type: "INTEGER", nullable: false),
                    DuocTaoVao = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDung", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ma = table.Column<string>(type: "TEXT", nullable: false),
                    Ten = table.Column<string>(type: "TEXT", nullable: false),
                    DonVi = table.Column<string>(type: "TEXT", nullable: false),
                    GiaVon = table.Column<double>(type: "REAL", nullable: false),
                    GiaBan = table.Column<double>(type: "REAL", nullable: false),
                    CoPhan = table.Column<int>(type: "INTEGER", nullable: false),
                    TonKhoToiThieu = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdHoaDon = table.Column<int>(type: "INTEGER", nullable: false),
                    IdSanPham = table.Column<int>(type: "INTEGER", nullable: false),
                    MaSanPham = table.Column<string>(type: "TEXT", nullable: false),
                    TenSanPham = table.Column<string>(type: "TEXT", nullable: false),
                    SoLuong = table.Column<int>(type: "INTEGER", nullable: false),
                    DonGia = table.Column<double>(type: "REAL", nullable: false),
                    ChietKhau = table.Column<double>(type: "REAL", nullable: false),
                    ThanhTienDong = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_SanPham_IdSanPham",
                        column: x => x.IdSanPham,
                        principalTable: "SanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhieuNhapKho",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    MaBienNhan = table.Column<string>(type: "TEXT", nullable: false),
                    MaSanPham = table.Column<int>(type: "INTEGER", nullable: false),
                    SoLuong = table.Column<int>(type: "INTEGER", nullable: false),
                    GiaVon = table.Column<double>(type: "REAL", nullable: false),
                    DuocTaoVao = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuNhapKho", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhieuNhapKho_SanPham_Id",
                        column: x => x.Id,
                        principalTable: "SanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "NguoiDung",
                columns: new[] { "Id", "DangHoatDong", "DuocTaoVao", "MatKhauBam", "TenHienThi", "TenNguoiDung", "VaiTro" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2D16797D627B8ACDB0ECDD3028102F52B87A73EDAED769070FBDC6019F6C8710", "Quản Lý", "quanly", "Quản Lý" },
                    { 2, true, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "42FAE8A13D42327ABBB8D700B0E2A7452F4198A63DFD3C88D6D052AD6AEE7F20", "Nhân Viên A", "nhanvien", "Nhân Viên" }
                });

            migrationBuilder.InsertData(
                table: "SanPham",
                columns: new[] { "Id", "CoPhan", "DonVi", "GiaBan", "GiaVon", "Ma", "Ten", "TonKhoToiThieu" },
                values: new object[,]
                {
                    { 1, 50, "Chai", 7000.0, 4000.0, "SP001", "Nước suối 500ml", 10 },
                    { 2, 80, "Gói", 5000.0, 3500.0, "SP002", "Mì ăn liền", 15 },
                    { 3, 25, "Gói", 16000.0, 12000.0, "SP003", "Bánh quy", 5 },
                    { 4, 8, "Hộp", 9000.0, 6500.0, "SP004", "Sữa tươi", 10 },
                    { 5, 40, "Lon", 10000.0, 7000.0, "SP005", "Coca Cola 330ml", 10 },
                    { 6, 35, "Lon", 10000.0, 7000.0, "SP006", "Pepsi 330ml", 10 },
                    { 7, 30, "Chai", 12000.0, 8000.0, "SP007", "Trà xanh 0 độ", 10 },
                    { 8, 25, "Gói", 13000.0, 9000.0, "SP008", "Bánh Oreo", 8 },
                    { 9, 20, "Hộp", 32000.0, 25000.0, "SP009", "Bánh Chocopie", 5 },
                    { 10, 15, "Lon", 23000.0, 18000.0, "SP010", "Sữa đặc Ông Thọ", 5 },
                    { 11, 30, "Lon", 13000.0, 9000.0, "SP011", "Nước tăng lực Red Bull", 10 },
                    { 12, 50, "Gói", 8000.0, 5000.0, "SP012", "Khăn giấy", 10 },
                    { 13, 100, "Gói", 5000.0, 3500.0, "SP013", "Mì Hảo Hảo", 20 },
                    { 14, 20, "Chai", 20000.0, 15000.0, "SP014", "Nước rửa chén", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_IdHoaDon",
                table: "ChiTietHoaDon",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_IdSanPham",
                table: "ChiTietHoaDon",
                column: "IdSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaHoaDon",
                table: "HoaDon",
                column: "MaHoaDon",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDung_TenNguoiDung",
                table: "NguoiDung",
                column: "TenNguoiDung",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_Ma",
                table: "SanPham",
                column: "Ma",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietHoaDon");

            migrationBuilder.DropTable(
                name: "NguoiDung");

            migrationBuilder.DropTable(
                name: "PhieuNhapKho");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eShopSolution.Data.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BANAN",
                columns: table => new
                {
                    SOBAN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SOGHE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BANAN", x => x.SOBAN);
                });

            migrationBuilder.CreateTable(
                name: "BOPHAN",
                columns: table => new
                {
                    MABOPHAN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CHUCNANG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TENBOPHAN = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOPHAN", x => x.MABOPHAN);
                });

            migrationBuilder.CreateTable(
                name: "CaLamViec",
                columns: table => new
                {
                    MACA = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GioBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaLamViec", x => x.MACA);
                });

            migrationBuilder.CreateTable(
                name: "Khach",
                columns: table => new
                {
                    MAKH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TENKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DIACHIKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDTKH = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khach", x => x.MAKH);
                });

            migrationBuilder.CreateTable(
                name: "KHO",
                columns: table => new
                {
                    MAKHO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KHO", x => x.MAKHO);
                });

            migrationBuilder.CreateTable(
                name: "KhuyenMai",
                columns: table => new
                {
                    MAKM = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TENKM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuyenMai", x => x.MAKM);
                });

            migrationBuilder.CreateTable(
                name: "LoaiMon",
                columns: table => new
                {
                    MALOAI = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TENLOAI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MOTA = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiMon", x => x.MALOAI);
                });

            migrationBuilder.CreateTable(
                name: "NHACUNGCAP",
                columns: table => new
                {
                    MANCC = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TENCC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DIACHINCC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDTNCC = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHACUNGCAP", x => x.MANCC);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MANV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HOTENNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDTNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NGAYSINH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GIOITINH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DIACHINV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MABOPHAN = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MANV);
                    table.ForeignKey(
                        name: "FK_NhanVien_BOPHAN_MABOPHAN",
                        column: x => x.MABOPHAN,
                        principalTable: "BOPHAN",
                        principalColumn: "MABOPHAN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PHIEUDAT",
                columns: table => new
                {
                    SOPHIEUDAT = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SOLUONGBAN = table.Column<int>(type: "int", nullable: false),
                    NGAYGIODAT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MAKH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SOBAN = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PHIEUDAT", x => x.SOPHIEUDAT);
                    table.ForeignKey(
                        name: "FK_PHIEUDAT_BANAN_SOBAN",
                        column: x => x.SOBAN,
                        principalTable: "BANAN",
                        principalColumn: "SOBAN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PHIEUDAT_Khach_MAKH",
                        column: x => x.MAKH,
                        principalTable: "Khach",
                        principalColumn: "MAKH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NGUYENLIEU",
                columns: table => new
                {
                    MANGUYENLIEU = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TENNGUYENLIEU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DONVITINH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MAKHO = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NGUYENLIEU", x => x.MANGUYENLIEU);
                    table.ForeignKey(
                        name: "FK_NGUYENLIEU_KHO_MAKHO",
                        column: x => x.MAKHO,
                        principalTable: "KHO",
                        principalColumn: "MAKHO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MON_AN",
                columns: table => new
                {
                    MAMONAN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TENMON = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DONVITINh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MOTA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DONGIA = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MALOAI = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MON_AN", x => x.MAMONAN);
                    table.ForeignKey(
                        name: "FK_MON_AN_LoaiMon_MALOAI",
                        column: x => x.MALOAI,
                        principalTable: "LoaiMon",
                        principalColumn: "MALOAI",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NV_CA",
                columns: table => new
                {
                    MANV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MACA = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NV_CA", x => new { x.MANV, x.MACA });
                    table.ForeignKey(
                        name: "FK_NV_CA_CaLamViec_MACA",
                        column: x => x.MACA,
                        principalTable: "CaLamViec",
                        principalColumn: "MACA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NV_CA_NhanVien_MANV",
                        column: x => x.MANV,
                        principalTable: "NhanVien",
                        principalColumn: "MANV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "THANH_TOAN",
                columns: table => new
                {
                    SOPHIEUTT = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HINHTHUCTT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SOTIEN = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NGAYGIO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SOPHIEUGOI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MAKH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MANV = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_THANH_TOAN", x => x.SOPHIEUTT);
                    table.ForeignKey(
                        name: "FK_THANH_TOAN_Khach_MAKH",
                        column: x => x.MAKH,
                        principalTable: "Khach",
                        principalColumn: "MAKH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_THANH_TOAN_NhanVien_MANV",
                        column: x => x.MANV,
                        principalTable: "NhanVien",
                        principalColumn: "MANV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phieu_CC",
                columns: table => new
                {
                    MANCC = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MANGUYENLIEU = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phieu_CC", x => new { x.MANCC, x.MANGUYENLIEU });
                    table.ForeignKey(
                        name: "FK_Phieu_CC_NGUYENLIEU_MANGUYENLIEU",
                        column: x => x.MANGUYENLIEU,
                        principalTable: "NGUYENLIEU",
                        principalColumn: "MANGUYENLIEU",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Phieu_CC_NHACUNGCAP_MANCC",
                        column: x => x.MANCC,
                        principalTable: "NHACUNGCAP",
                        principalColumn: "MANCC",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuNhap",
                columns: table => new
                {
                    SOPHIEUNHAP = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NgayNhap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DonGiaNhap = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuongNhap = table.Column<int>(type: "int", nullable: false),
                    MANV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MANGUYENLIEU = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuNhap", x => x.SOPHIEUNHAP);
                    table.ForeignKey(
                        name: "FK_PhieuNhap_NGUYENLIEU_MANGUYENLIEU",
                        column: x => x.MANGUYENLIEU,
                        principalTable: "NGUYENLIEU",
                        principalColumn: "MANGUYENLIEU",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhieuNhap_NhanVien_MANV",
                        column: x => x.MANV,
                        principalTable: "NhanVien",
                        principalColumn: "MANV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietMonAn",
                columns: table => new
                {
                    MAMONAN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MANGUYENLIEU = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietMonAn", x => new { x.MAMONAN, x.MANGUYENLIEU });
                    table.ForeignKey(
                        name: "FK_ChiTietMonAn_MON_AN_MAMONAN",
                        column: x => x.MAMONAN,
                        principalTable: "MON_AN",
                        principalColumn: "MAMONAN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietMonAn_NGUYENLIEU_MANGUYENLIEU",
                        column: x => x.MANGUYENLIEU,
                        principalTable: "NGUYENLIEU",
                        principalColumn: "MANGUYENLIEU",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MON_AN_KM",
                columns: table => new
                {
                    MAKM = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MAMONAN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NGAYBD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NGAYKT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NDKM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GIATRIKM = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MON_AN_KM", x => new { x.MAKM, x.MAMONAN });
                    table.ForeignKey(
                        name: "FK_MON_AN_KM_KhuyenMai_MAKM",
                        column: x => x.MAKM,
                        principalTable: "KhuyenMai",
                        principalColumn: "MAKM",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MON_AN_KM_MON_AN_MAMONAN",
                        column: x => x.MAMONAN,
                        principalTable: "MON_AN",
                        principalColumn: "MAMONAN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PHIEU_GOI",
                columns: table => new
                {
                    SOPHIEUGOI = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MAKH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MAMONAN = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PHIEU_GOI", x => x.SOPHIEUGOI);
                    table.ForeignKey(
                        name: "FK_PHIEU_GOI_Khach_MAKH",
                        column: x => x.MAKH,
                        principalTable: "Khach",
                        principalColumn: "MAKH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PHIEU_GOI_MON_AN_MAMONAN",
                        column: x => x.MAMONAN,
                        principalTable: "MON_AN",
                        principalColumn: "MAMONAN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BANAN",
                columns: new[] { "SOBAN", "SOGHE" },
                values: new object[,]
                {
                    { "1", 10 },
                    { "2", 5 },
                    { "3", 3 },
                    { "4", 4 },
                    { "5", 6 },
                    { "6", 7 },
                    { "7", 9 }
                });

            migrationBuilder.InsertData(
                table: "BOPHAN",
                columns: new[] { "MABOPHAN", "CHUCNANG", "TENBOPHAN" },
                values: new object[,]
                {
                    { "BP1", "Quan Li", "QuanLi" },
                    { "BP2", "Bep", "Bep" },
                    { "BP3", "Phuc Vu", "Phuc Vu" }
                });

            migrationBuilder.InsertData(
                table: "CaLamViec",
                columns: new[] { "MACA", "GioBatDau", "GioKetThuc" },
                values: new object[,]
                {
                    { "C1", new DateTime(2023, 3, 22, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "C2", new DateTime(2023, 3, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 22, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "KHO",
                columns: new[] { "MAKHO", "Soluong" },
                values: new object[] { "1", 20 });

            migrationBuilder.InsertData(
                table: "Khach",
                columns: new[] { "MAKH", "DIACHIKH", "SDTKH", "TENKH" },
                values: new object[,]
                {
                    { "N111", " Hà Nội ", "0987654321", " Lê Hiệp " },
                    { "N112", " Hà Nội ", "0984822124", " Nguyễn Hoàng " },
                    { "N113", " Thanh Hóa ", "093422112", " Eo Vì " },
                    { "N114", " Sài Gòn ", "0984322221", " Tuấn Đỗ  " },
                    { "N115", " Hà Nội ", "0987654323", " Hiixu " },
                    { "N116", " Đà Nẵng ", "0987632121", " Nợi Tạ " },
                    { "N117", " Hà Tĩnh ", "0989832258", " Kie Nguyen " }
                });

            migrationBuilder.InsertData(
                table: "KhuyenMai",
                columns: new[] { "MAKM", "TENKM" },
                values: new object[,]
                {
                    { "KM1", "KMNL" },
                    { "KM2", "KMNL" },
                    { "KM3", "KMNL" },
                    { "KM4", "KMNL" },
                    { "KM5", "KMNL" },
                    { "KM6", "KMNL" },
                    { "KM7", "KMNL" }
                });

            migrationBuilder.InsertData(
                table: "LoaiMon",
                columns: new[] { "MALOAI", "MOTA", "TENLOAI" },
                values: new object[,]
                {
                    { "L1", "0", "Special" },
                    { "L2", "0", "Special" },
                    { "L3", "0", "Gia Cầm" },
                    { "L4", "0", "Thủy Sản" },
                    { "L5", "0", "Thủy Sản" },
                    { "L6", "0", "Hải Sản" },
                    { "L7", "0", "Thủy Sản" }
                });

            migrationBuilder.InsertData(
                table: "NHACUNGCAP",
                columns: new[] { "MANCC", "DIACHINCC", "SDTNCC", "TENCC" },
                values: new object[,]
                {
                    { "NC1", "HN", "0923182341", "Nha" },
                    { "NC2", "HN", "0923322341", "Cung" }
                });

            migrationBuilder.InsertData(
                table: "MON_AN",
                columns: new[] { "MAMONAN", "DONGIA", "DONVITINh", "MALOAI", "MOTA", "TENMON" },
                values: new object[,]
                {
                    { "Q01", 40000m, "Phần", "L1", "0", "Phở Cuốn" },
                    { "Q02", 50000m, "Phần", "L2", "0", "Phở Trộn" },
                    { "Q03", 60000m, "Đĩa", "L3", "0", "Thịt Gà Luộc" },
                    { "Q04", 70000m, "Con", "L4", "0", "Ba Ba om chuối" },
                    { "Q05", 80000m, "Bát", "L5", "0", "Ếch om chuối đậu" },
                    { "Q06", 90000m, "Con", "L6", "0", "Tôm giang muối" },
                    { "Q07", 100000m, "Kg", "L7", "0", "Cá Tầm Hấp xì dầu" }
                });

            migrationBuilder.InsertData(
                table: "NGUYENLIEU",
                columns: new[] { "MANGUYENLIEU", "DONVITINH", "MAKHO", "TENNGUYENLIEU" },
                values: new object[,]
                {
                    { "MNL1", "Phần", "1", "Phở" },
                    { "MNL2", "Phần", "1", "Phở" },
                    { "MNL3", "Đĩa", "1", "Gà" },
                    { "MNL4", "Con", "1", "Ba Ba" },
                    { "MNL5", "Bát", "1", "Ếch" },
                    { "MNL6", "Con", "1", "Tôm" },
                    { "MNL7", "Kg", "1", "Cá" }
                });

            migrationBuilder.InsertData(
                table: "NhanVien",
                columns: new[] { "MANV", "DIACHINV", "GIOITINH", "HOTENNV", "MABOPHAN", "NGAYSINH", "SDTNV" },
                values: new object[,]
                {
                    { "V01", "HN", "Nu", "Nguyen Van A", "BP1", new DateTime(2000, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), " 09284124100" },
                    { "V02", "HN", "Nam", "Nguyen Van B", "BP3", new DateTime(2000, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), " 09284121230" },
                    { "V03", "HN", "Nu", "Nguyen Van C", "BP2", new DateTime(2000, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), " 09284124532" },
                    { "V04", "HN", "Nam", "Nguyen Van D", "BP2", new DateTime(2000, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), " 09284124234" },
                    { "V05", "HN", "Nu", "Nguyen Van E", "BP3", new DateTime(2000, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), " 09284124100" },
                    { "V06", "HN", "Nu", "Nguyen Van G", "BP3", new DateTime(2000, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), " 09284124123" },
                    { "V07", "HN", "Nam", "Nguyen Van H", "BP2", new DateTime(2000, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), " 09234124100" }
                });

            migrationBuilder.InsertData(
                table: "PHIEUDAT",
                columns: new[] { "SOPHIEUDAT", "MAKH", "NGAYGIODAT", "SOBAN", "SOLUONGBAN" },
                values: new object[,]
                {
                    { "N01", "N111", new DateTime(1991, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 20 },
                    { "N02", "N112", new DateTime(1991, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", 10 },
                    { "N03", "N113", new DateTime(1992, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", 45 },
                    { "N04", "N114", new DateTime(1989, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", 7 },
                    { "N05", "N115", new DateTime(1910, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "5", 23 },
                    { "N06", "N116", new DateTime(1948, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "6", 30 },
                    { "N07", "N117", new DateTime(1920, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "7", 27 }
                });

            migrationBuilder.InsertData(
                table: "ChiTietMonAn",
                columns: new[] { "MAMONAN", "MANGUYENLIEU" },
                values: new object[,]
                {
                    { "Q01", "MNL1" },
                    { "Q02", "MNL2" },
                    { "Q03", "MNL3" },
                    { "Q04", "MNL4" },
                    { "Q05", "MNL5" },
                    { "Q06", "MNL6" },
                    { "Q07", "MNL7" }
                });

            migrationBuilder.InsertData(
                table: "MON_AN_KM",
                columns: new[] { "MAKM", "MAMONAN", "GIATRIKM", "NDKM", "NGAYBD", "NGAYKT" },
                values: new object[,]
                {
                    { "KM1", "Q07", 20000m, "THICH", new DateTime(2022, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "KM2", "Q01", 20000m, "THICH", new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "KM3", "Q02", 30000m, "THICH", new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "KM4", "Q03", 40000m, "THICH", new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "KM5", "Q04", 50000m, "THICH", new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "KM6", "Q05", 60000m, "THICH", new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "KM7", "Q06", 70000m, "THICH", new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "NV_CA",
                columns: new[] { "MACA", "MANV" },
                values: new object[,]
                {
                    { "C1", "V01" },
                    { "C1", "V02" },
                    { "C2", "V03" },
                    { "C1", "V04" },
                    { "C1", "V05" },
                    { "C2", "V06" },
                    { "C2", "V07" }
                });

            migrationBuilder.InsertData(
                table: "PHIEU_GOI",
                columns: new[] { "SOPHIEUGOI", "MAKH", "MAMONAN" },
                values: new object[,]
                {
                    { "A1", "N111", "Q01" },
                    { "A2", "N112", "Q01" },
                    { "A3", "N113", "Q02" },
                    { "A4", "N114", "Q03" },
                    { "A5", "N115", "Q04" },
                    { "A6", "N116", "Q05" },
                    { "A7", "N117", "Q06" }
                });

            migrationBuilder.InsertData(
                table: "PhieuNhap",
                columns: new[] { "SOPHIEUNHAP", "DonGiaNhap", "MANGUYENLIEU", "MANV", "NgayNhap", "SoLuongNhap" },
                values: new object[,]
                {
                    { "PN1", 10000m, "MNL1", "V01", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { "PN2", 20000m, "MNL1", "V01", new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { "PN3", 15000m, "MNL2", "V01", new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { "PN4", 12000m, "MNL3", "V02", new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "PN5", 13000m, "MNL4", "V02", new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "Phieu_CC",
                columns: new[] { "MANCC", "MANGUYENLIEU" },
                values: new object[,]
                {
                    { "NC1", "MNL1" },
                    { "NC1", "MNL3" },
                    { "NC1", "MNL5" },
                    { "NC1", "MNL7" },
                    { "NC2", "MNL2" },
                    { "NC2", "MNL4" },
                    { "NC2", "MNL6" }
                });

            migrationBuilder.InsertData(
                table: "THANH_TOAN",
                columns: new[] { "SOPHIEUTT", "HINHTHUCTT", "MAKH", "MANV", "NGAYGIO", "SOPHIEUGOI", "SOTIEN" },
                values: new object[,]
                {
                    { "T01", "Cash", "N111", "V01", new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "A1", 0m },
                    { "T02", "Cash", "N112", "V02", new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "A2", 0m },
                    { "T03", "CK", "N113", "V03", new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "A3", 0m },
                    { "T04", "CK", "N114", "V04", new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "A4", 0m },
                    { "T05", "Cash", "N115", "V05", new DateTime(2021, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "A5", 0m },
                    { "T06", "CK", "N116", "V06", new DateTime(2020, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "A6", 0m },
                    { "T07", "Cash", "N117", "V07", new DateTime(1998, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "A7", 0m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietMonAn_MANGUYENLIEU",
                table: "ChiTietMonAn",
                column: "MANGUYENLIEU");

            migrationBuilder.CreateIndex(
                name: "IX_MON_AN_MALOAI",
                table: "MON_AN",
                column: "MALOAI");

            migrationBuilder.CreateIndex(
                name: "IX_MON_AN_KM_MAMONAN",
                table: "MON_AN_KM",
                column: "MAMONAN");

            migrationBuilder.CreateIndex(
                name: "IX_NGUYENLIEU_MAKHO",
                table: "NGUYENLIEU",
                column: "MAKHO");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MABOPHAN",
                table: "NhanVien",
                column: "MABOPHAN");

            migrationBuilder.CreateIndex(
                name: "IX_NV_CA_MACA",
                table: "NV_CA",
                column: "MACA");

            migrationBuilder.CreateIndex(
                name: "IX_Phieu_CC_MANGUYENLIEU",
                table: "Phieu_CC",
                column: "MANGUYENLIEU");

            migrationBuilder.CreateIndex(
                name: "IX_PHIEU_GOI_MAKH",
                table: "PHIEU_GOI",
                column: "MAKH");

            migrationBuilder.CreateIndex(
                name: "IX_PHIEU_GOI_MAMONAN",
                table: "PHIEU_GOI",
                column: "MAMONAN");

            migrationBuilder.CreateIndex(
                name: "IX_PHIEUDAT_MAKH",
                table: "PHIEUDAT",
                column: "MAKH");

            migrationBuilder.CreateIndex(
                name: "IX_PHIEUDAT_SOBAN",
                table: "PHIEUDAT",
                column: "SOBAN");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhap_MANGUYENLIEU",
                table: "PhieuNhap",
                column: "MANGUYENLIEU");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhap_MANV",
                table: "PhieuNhap",
                column: "MANV");

            migrationBuilder.CreateIndex(
                name: "IX_THANH_TOAN_MAKH",
                table: "THANH_TOAN",
                column: "MAKH");

            migrationBuilder.CreateIndex(
                name: "IX_THANH_TOAN_MANV",
                table: "THANH_TOAN",
                column: "MANV");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietMonAn");

            migrationBuilder.DropTable(
                name: "MON_AN_KM");

            migrationBuilder.DropTable(
                name: "NV_CA");

            migrationBuilder.DropTable(
                name: "Phieu_CC");

            migrationBuilder.DropTable(
                name: "PHIEU_GOI");

            migrationBuilder.DropTable(
                name: "PHIEUDAT");

            migrationBuilder.DropTable(
                name: "PhieuNhap");

            migrationBuilder.DropTable(
                name: "THANH_TOAN");

            migrationBuilder.DropTable(
                name: "KhuyenMai");

            migrationBuilder.DropTable(
                name: "CaLamViec");

            migrationBuilder.DropTable(
                name: "NHACUNGCAP");

            migrationBuilder.DropTable(
                name: "MON_AN");

            migrationBuilder.DropTable(
                name: "BANAN");

            migrationBuilder.DropTable(
                name: "NGUYENLIEU");

            migrationBuilder.DropTable(
                name: "Khach");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "LoaiMon");

            migrationBuilder.DropTable(
                name: "KHO");

            migrationBuilder.DropTable(
                name: "BOPHAN");
        }
    }
}

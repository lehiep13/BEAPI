using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Extensions
{
	public static class ModelBuilderExtensions
	{


		public static void Seed (this ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<BanAn>().HasData(
				new BanAn() { SOBAN = "1", SOGHE = 10 },
				new BanAn() { SOBAN = "2", SOGHE = 5 },
				new BanAn() { SOBAN = "3", SOGHE = 3 },
				new BanAn() { SOBAN = "4", SOGHE = 4 },
				new BanAn() { SOBAN = "5", SOGHE = 6 },
				new BanAn() { SOBAN = "6", SOGHE = 7 },
				new BanAn() { SOBAN = "7", SOGHE = 9 }
			);
			modelBuilder.Entity<PhieuDat>().HasData(
				
				new PhieuDat() { SOPHIEUDAT = "N01",SOLUONGBAN = 20,NGAYGIODAT= DateTime.Parse("1991-04-21"),MAKH="N111",SOBAN="1" },
				new PhieuDat() { SOPHIEUDAT = "N02", SOLUONGBAN = 10, NGAYGIODAT = DateTime.Parse("1991-04-21"), MAKH = "N112", SOBAN = "2" },
				new PhieuDat() { SOPHIEUDAT = "N03", SOLUONGBAN = 45, NGAYGIODAT = DateTime.Parse("1992-04-21"), MAKH = "N113", SOBAN = "3" },
				new PhieuDat() { SOPHIEUDAT = "N04", SOLUONGBAN = 7, NGAYGIODAT = DateTime.Parse("1989-03-21"), MAKH = "N114", SOBAN = "4" },
				new PhieuDat() { SOPHIEUDAT = "N05", SOLUONGBAN = 23, NGAYGIODAT = DateTime.Parse("1910-08-21"), MAKH = "N115", SOBAN = "5" },
				new PhieuDat() { SOPHIEUDAT = "N06", SOLUONGBAN = 30, NGAYGIODAT = DateTime.Parse("1948-05-21"), MAKH = "N116", SOBAN = "6" },
				new PhieuDat() { SOPHIEUDAT = "N07", SOLUONGBAN = 27, NGAYGIODAT = DateTime.Parse("1920-01-21"), MAKH = "N117", SOBAN = "7" }
				

			);
			modelBuilder.Entity<Khach>().HasData(

				new Khach() { MAKH ="N111",DIACHIKH=" Hà Nội ",TENKH=" Lê Hiệp ",SDTKH ="0987654321" },
				new Khach() { MAKH = "N112", DIACHIKH = " Hà Nội ", TENKH = " Nguyễn Hoàng ", SDTKH = "0984822124" },
				new Khach() { MAKH = "N113", DIACHIKH = " Thanh Hóa ", TENKH = " Eo Vì ", SDTKH = "093422112" },
				new Khach() { MAKH = "N114", DIACHIKH = " Sài Gòn ", TENKH = " Tuấn Đỗ  ", SDTKH = "0984322221" },
				new Khach() { MAKH = "N115", DIACHIKH = " Hà Nội ", TENKH = " Hiixu ", SDTKH = "0987654323" },
				new Khach() { MAKH = "N116", DIACHIKH = " Đà Nẵng ", TENKH = " Nợi Tạ ", SDTKH = "0987632121" },
				new Khach() { MAKH = "N117", DIACHIKH = " Hà Tĩnh ", TENKH = " Kie Nguyen ", SDTKH = "0989832258" }
				

			);
			modelBuilder.Entity<PhieuGoi>().HasData(
				new PhieuGoi() { SOPHIEUGOI = "A1",MAKH="N111",MAMONAN="Q01" },
				new PhieuGoi() { SOPHIEUGOI = "A2", MAKH = "N112", MAMONAN = "Q01" },
				new PhieuGoi() { SOPHIEUGOI = "A3", MAKH = "N113", MAMONAN = "Q02" },
				new PhieuGoi() { SOPHIEUGOI = "A4", MAKH = "N114", MAMONAN = "Q03" },
				new PhieuGoi() { SOPHIEUGOI = "A5", MAKH = "N115", MAMONAN = "Q04" },
				new PhieuGoi() { SOPHIEUGOI = "A6", MAKH = "N116", MAMONAN = "Q05" },
				new PhieuGoi() { SOPHIEUGOI = "A7", MAKH = "N117", MAMONAN = "Q06" }
				
			);
			modelBuilder.Entity<ThanhToan>().HasData(
				new ThanhToan() { SOPHIEUTT="T01",HINHTHUCTT="Cash", NGAYGIO=DateTime.Parse("2022-12-30"),SOPHIEUGOI="A1", MAKH="N111",MANV="V01" },
				new ThanhToan() { SOPHIEUTT = "T02", HINHTHUCTT = "Cash", NGAYGIO = DateTime.Parse("2021-11-13"), SOPHIEUGOI = "A2", MAKH = "N112", MANV = "V02" },
				new ThanhToan() { SOPHIEUTT = "T03", HINHTHUCTT = "CK", NGAYGIO = DateTime.Parse("2023-09-07"), SOPHIEUGOI = "A3", MAKH = "N113", MANV = "V03" },
				new ThanhToan() { SOPHIEUTT = "T04", HINHTHUCTT = "CK", NGAYGIO = DateTime.Parse("2022-08-05"), SOPHIEUGOI = "A4", MAKH = "N114", MANV = "V04" },
				new ThanhToan() { SOPHIEUTT = "T05", HINHTHUCTT = "Cash", NGAYGIO = DateTime.Parse("2021-02-08"), SOPHIEUGOI = "A5", MAKH = "N115", MANV = "V05" },
				new ThanhToan() { SOPHIEUTT = "T06", HINHTHUCTT = "CK", NGAYGIO = DateTime.Parse("2020-03-23"), SOPHIEUGOI = "A6", MAKH = "N116", MANV = "V06" },
				new ThanhToan() { SOPHIEUTT = "T07", HINHTHUCTT = "Cash", NGAYGIO = DateTime.Parse("1998-08-27"), SOPHIEUGOI = "A7", MAKH = "N117", MANV = "V07" }

			);
			modelBuilder.Entity<MonAnKM>().HasData(
				new MonAnKM() { MAKM = "KM1",MAMONAN="Q07",NGAYBD=DateTime.Parse("2022-11-03"),NGAYKT=DateTime.Parse("2012-11-10"),NDKM="THICH",GIATRIKM=20000,},
				new MonAnKM() { MAKM = "KM2", MAMONAN = "Q01", NGAYBD = DateTime.Parse("2022-11-11"), NGAYKT = DateTime.Parse("2012-11-15"), NDKM = "THICH", GIATRIKM = 20000, },
				new MonAnKM() { MAKM = "KM3", MAMONAN = "Q02", NGAYBD = DateTime.Parse("2022-11-16"), NGAYKT = DateTime.Parse("2012-11-20"), NDKM = "THICH", GIATRIKM = 30000, },
				new MonAnKM() { MAKM = "KM4", MAMONAN = "Q03", NGAYBD = DateTime.Parse("2022-11-25"), NGAYKT = DateTime.Parse("2012-11-30"), NDKM = "THICH", GIATRIKM = 40000, },
				new MonAnKM() { MAKM = "KM5", MAMONAN = "Q04", NGAYBD = DateTime.Parse("2022-12-05"), NGAYKT = DateTime.Parse("2012-12-10"), NDKM = "THICH", GIATRIKM = 50000, },
				new MonAnKM() { MAKM = "KM6", MAMONAN = "Q05", NGAYBD = DateTime.Parse("2022-12-15"), NGAYKT = DateTime.Parse("2012-12-20"), NDKM = "THICH", GIATRIKM = 60000, },
				new MonAnKM() { MAKM = "KM7", MAMONAN = "Q06", NGAYBD = DateTime.Parse("2022-12-25"), NGAYKT = DateTime.Parse("2012-12-30"), NDKM = "THICH", GIATRIKM = 70000, }

				);
			modelBuilder.Entity<KhuyenMai>().HasData(
				new KhuyenMai() { MAKM = "KM1",TENKM="KMNL"},
				new KhuyenMai() { MAKM = "KM2", TENKM = "KMNL" },
				new KhuyenMai() { MAKM = "KM3", TENKM = "KMNL" },
				new KhuyenMai() { MAKM = "KM4", TENKM = "KMNL" },
				new KhuyenMai() { MAKM = "KM5", TENKM = "KMNL" },
				new KhuyenMai() { MAKM = "KM6", TENKM = "KMNL" },
				new KhuyenMai() { MAKM = "KM7", TENKM = "KMNL" }
				);
			modelBuilder.Entity<Product>().HasData(
				new Product() { MAMONAN="Q01",TENMON="Phở Cuốn",DONVITINh="Phần",MOTA="0",DONGIA=40000,MALOAI="L1"},
				new Product() { MAMONAN = "Q02", TENMON = "Phở Trộn", DONVITINh = "Phần", MOTA = "0", DONGIA = 50000, MALOAI = "L2" },
				new Product() { MAMONAN = "Q03", TENMON = "Thịt Gà Luộc", DONVITINh = "Đĩa", MOTA = "0", DONGIA = 60000, MALOAI = "L3"},
				new Product() { MAMONAN = "Q04", TENMON = "Ba Ba om chuối", DONVITINh = "Con", MOTA = "0", DONGIA = 70000, MALOAI = "L4" },
				new Product() { MAMONAN = "Q05", TENMON = "Ếch om chuối đậu", DONVITINh = "Bát", MOTA = "0", DONGIA = 80000, MALOAI = "L5" },
				new Product() { MAMONAN = "Q06", TENMON = "Tôm giang muối", DONVITINh = "Con", MOTA = "0", DONGIA = 90000, MALOAI = "L6" },
				new Product() { MAMONAN = "Q07", TENMON = "Cá Tầm Hấp xì dầu", DONVITINh = "Kg", MOTA = "0", DONGIA = 100000, MALOAI = "L7" }
				);
			modelBuilder.Entity<Loaimon>().HasData(
				new Loaimon() { MALOAI="L1",MOTA="0",TENLOAI="Special"},
				new Loaimon() { MALOAI = "L2", MOTA = "0", TENLOAI = "Special" },
				new Loaimon() { MALOAI = "L3", MOTA = "0", TENLOAI = "Gia Cầm" },
				new Loaimon() { MALOAI = "L4", MOTA = "0", TENLOAI = "Thủy Sản" },
				new Loaimon() { MALOAI = "L5", MOTA = "0", TENLOAI = "Thủy Sản" },
				new Loaimon() { MALOAI = "L6", MOTA = "0", TENLOAI = "Hải Sản" },
				new Loaimon() { MALOAI = "L7", MOTA = "0", TENLOAI = "Thủy Sản" }
				);
			modelBuilder.Entity<BoPhan>().HasData(
				new BoPhan() { MABOPHAN ="BP1",CHUCNANG="Quan Li",TENBOPHAN="QuanLi"},
				new BoPhan() { MABOPHAN = "BP2", CHUCNANG = "Bep", TENBOPHAN = "Bep" },
				new BoPhan() { MABOPHAN = "BP3", CHUCNANG = "Phuc Vu", TENBOPHAN = "Phuc Vu" }

				);
			modelBuilder.Entity<NhanVien>().HasData(
				new NhanVien() { MANV="V01",HOTENNV="Nguyen Van A",SDTNV=" 09284124100",NGAYSINH=DateTime.Parse("2000-12-2"),GIOITINH="Nu",DIACHINV="HN",MABOPHAN="BP1"},
				new NhanVien() { MANV = "V02", HOTENNV = "Nguyen Van B", SDTNV = " 09284121230", NGAYSINH = DateTime.Parse("2000-02-3"), GIOITINH = "Nam", DIACHINV = "HN", MABOPHAN = "BP3" },
				new NhanVien() { MANV = "V03", HOTENNV = "Nguyen Van C", SDTNV = " 09284124532", NGAYSINH = DateTime.Parse("2000-06-4"), GIOITINH = "Nu", DIACHINV = "HN", MABOPHAN = "BP2" },
				new NhanVien() { MANV = "V04", HOTENNV = "Nguyen Van D", SDTNV = " 09284124234", NGAYSINH = DateTime.Parse("2000-10-5"), GIOITINH = "Nam", DIACHINV = "HN", MABOPHAN = "BP2" },
				new NhanVien() { MANV = "V05", HOTENNV = "Nguyen Van E", SDTNV = " 09284124100", NGAYSINH = DateTime.Parse("2000-11-6"), GIOITINH = "Nu", DIACHINV = "HN", MABOPHAN = "BP3" },
				new NhanVien() { MANV = "V06", HOTENNV = "Nguyen Van G", SDTNV = " 09284124123", NGAYSINH = DateTime.Parse("2000-02-16"), GIOITINH = "Nu", DIACHINV = "HN", MABOPHAN = "BP3" },
				new NhanVien() { MANV = "V07", HOTENNV = "Nguyen Van H", SDTNV = " 09234124100", NGAYSINH = DateTime.Parse("2000-04-24"), GIOITINH = "Nam", DIACHINV = "HN", MABOPHAN = "BP2" }
				);
			modelBuilder.Entity<NVCa>().HasData(
				new NVCa() { MANV="V01",MACA="C1"},
				new NVCa() { MANV = "V02", MACA = "C1" },
				new NVCa() { MANV = "V03", MACA = "C2" },
				new NVCa() { MANV = "V04", MACA = "C1" },
				new NVCa() { MANV = "V05", MACA = "C1" },
				new NVCa() { MANV = "V06", MACA = "C2" },
				new NVCa() { MANV = "V07", MACA = "C2" }
				);
			modelBuilder.Entity<CaLamViec>().HasData(
				new CaLamViec() { MACA= "C1",GioBatDau=DateTime.Parse("9:00"),GioKetThuc=DateTime.Parse("15:00") },
				new CaLamViec() { MACA = "C2", GioBatDau = DateTime.Parse("15:00"), GioKetThuc = DateTime.Parse("22:00") }
				);
			modelBuilder.Entity<ChiTietMA>().HasData(
				new ChiTietMA() { MAMONAN="Q01",MANGUYENLIEU="MNL1"},
				new ChiTietMA() { MAMONAN = "Q02", MANGUYENLIEU = "MNL2" },
				new ChiTietMA() { MAMONAN = "Q03", MANGUYENLIEU = "MNL3" },
				new ChiTietMA() { MAMONAN = "Q04", MANGUYENLIEU = "MNL4" },
				new ChiTietMA() { MAMONAN = "Q05", MANGUYENLIEU = "MNL5" },
				new ChiTietMA() { MAMONAN = "Q06", MANGUYENLIEU = "MNL6" },
				new ChiTietMA() { MAMONAN = "Q07", MANGUYENLIEU = "MNL7" }
				);
			modelBuilder.Entity<NguyenLieu>().HasData(
				new NguyenLieu() { MANGUYENLIEU ="MNL1",DONVITINH ="Phần",TENNGUYENLIEU="Phở",MAKHO="1"},
				new NguyenLieu() { MANGUYENLIEU = "MNL2", DONVITINH = "Phần", TENNGUYENLIEU = "Phở", MAKHO = "1" },
				new NguyenLieu() { MANGUYENLIEU = "MNL3", DONVITINH = "Đĩa", TENNGUYENLIEU = "Gà", MAKHO = "1" },
				new NguyenLieu() { MANGUYENLIEU = "MNL4", DONVITINH = "Con", TENNGUYENLIEU = "Ba Ba", MAKHO = "1" },
				new NguyenLieu() { MANGUYENLIEU = "MNL5", DONVITINH = "Bát", TENNGUYENLIEU = "Ếch", MAKHO = "1" },
				new NguyenLieu() { MANGUYENLIEU = "MNL6", DONVITINH = "Con", TENNGUYENLIEU = "Tôm", MAKHO = "1" },
				new NguyenLieu() { MANGUYENLIEU = "MNL7", DONVITINH = "Kg", TENNGUYENLIEU = "Cá", MAKHO = "1" }
				);
			modelBuilder.Entity<Kho>().HasData(
				new Kho() { MAKHO="1",Soluong=20}
				);
			modelBuilder.Entity<PhieuCC>().HasData(
				new PhieuCC() { MANCC ="NC1",MANGUYENLIEU="MNL1"},
				new PhieuCC() { MANCC = "NC2", MANGUYENLIEU = "MNL2" },
				new PhieuCC() { MANCC = "NC1", MANGUYENLIEU = "MNL3" },
				new PhieuCC() { MANCC = "NC2", MANGUYENLIEU = "MNL4" },
				new PhieuCC() { MANCC = "NC1", MANGUYENLIEU = "MNL5" },
				new PhieuCC() { MANCC = "NC2", MANGUYENLIEU = "MNL6" },
				new PhieuCC() { MANCC = "NC1", MANGUYENLIEU = "MNL7" }

				);
			modelBuilder.Entity<NhaCungCap>().HasData(
				new NhaCungCap() { MANCC ="NC1",TENCC="Nha",DIACHINCC="HN",SDTNCC="0923182341"},
				new NhaCungCap() { MANCC = "NC2", TENCC = "Cung", DIACHINCC = "HN", SDTNCC = "0923322341" }
				);
			modelBuilder.Entity<PhieuNhap>().HasData(
				new PhieuNhap() { SOPHIEUNHAP="PN1",NgayNhap=DateTime.Parse("2023-01-01"),DonGiaNhap=10000,SoLuongNhap=4,MANV="V01",MANGUYENLIEU="MNL1"},
				new PhieuNhap() { SOPHIEUNHAP = "PN2", NgayNhap = DateTime.Parse("2023-01-02"), DonGiaNhap = 20000, SoLuongNhap = 4, MANV = "V01", MANGUYENLIEU = "MNL1" },
				new PhieuNhap() { SOPHIEUNHAP = "PN3", NgayNhap = DateTime.Parse("2023-01-03"), DonGiaNhap = 15000, SoLuongNhap = 4, MANV = "V01", MANGUYENLIEU = "MNL2" },
				new PhieuNhap() { SOPHIEUNHAP = "PN4", NgayNhap = DateTime.Parse("2023-01-04"), DonGiaNhap = 12000, SoLuongNhap = 1, MANV = "V02", MANGUYENLIEU = "MNL3" },
				new PhieuNhap() { SOPHIEUNHAP = "PN5", NgayNhap = DateTime.Parse("2023-01-05"), DonGiaNhap = 13000, SoLuongNhap = 4, MANV = "V02", MANGUYENLIEU = "MNL4" }
				);
			}




		}


	}


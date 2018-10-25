--tạo ràng buộc quy định trong trung tâm sẽ ntn? 
--ngày giờ trong xuất hóa đơn
--nộp bản mô tả chức năng, kế hoạch, file script, project
--báo cáo thống kê theo tuần,, quý năm
USE master
go

DROP DATABASE QLKD
create DATABASE QLKD
ON PRIMARY
(
	NAME=N'QLKD',
	FILENAME='D:\Database\QLKD.mdf'
)
LOG ON
(
	NAME=N'QLKD_log',
	FILENAME='D:\Database\QLKD_log.ldf'
)
USE QLKD
go
create TABLE NHANVIEN
(
	MaNV varchar(10) not null PRIMARY KEY,
	TenNV nvarchar(50)not null,
	EmailNV varchar(50)not null UNIQUE,
	SdtNV char(11) not null UNIQUE,
	LoaiTK int not null default(1)
)
go
create TABLE KHACHHANG
(
	MaKH varchar(10) not null PRIMARY KEY,
	TenKH nvarchar(50)not null,
	EmailKH varchar(50)not null UNIQUE,
	SdtKH char(11) not null UNIQUE
	
)
go
create TABLE QUANLY
(
	MaNQL varchar(10) PRIMARY KEY,
	TenNQL nvarchar(50) not null,
	EmailNQL varchar(50)not null UNIQUE,
	SdtNQL char(11) not null UNIQUE,
	LoaiTK int not null default(2)
)
go
CREATE TABLE TENDN_MK
(
	PRIMARY KEY(MaDN,LoaiTK),
	MaDN int not null ,
	MaNV varchar(10)  UNIQUE,
	MaNQL varchar(10) UNIQUE,
	LoaiTK int not null ,
	TENDN varchar(20) not null UNIQUE,
	MK nvarchar(20) not null
)
go
create TABLE DICHVU
(
	MaDV varchar(10) not null PRIMARY KEY,
	TenDV nvarchar(50) not null UNIQUE,
	MaSP varchar(10),
	MotaDV	nvarchar(100),
	GiaDV money not null default(100000)--bang gia san pham X So luong san pham
)
go
create TABLE SANPHAM
(
	MaSP varchar(10) not null PRIMARY KEY,
	TenSP nvarchar(50)not null UNIQUE,
	MotaSP nvarchar(100),
	GiaSP money not null default (100000),
	SoluongSP int not null DEFAULT (0)
)
go
create TABLE CTHD
(
	MaHD varchar(10)not null PRIMARY KEY,
	MaKH varchar(10) not null UNIQUE,
	TenKH nvarchar(50) not null ,
	MaDV varchar(10)not null UNIQUE,
	TenDV nvarchar(50),
	GiaDV money not null,
	MaNV varchar(10) not null UNIQUE,
	Ngayxuat date,
	TongTien money
)
go
create table HOADON
(
	PRIMARY KEY(MaHD),
	MaHD varchar(10),
	MaKH varchar(10) not null,
	MaDV varchar(10),
	MaNV varchar(10)not null,
	Ngayxuat date,
	TongTien money
)
go
create TABLE BAOCAO
(
	PRIMARY KEY(MaBC,MaNV,MaNQL),
	MaBC int not null ,
	MaNV varchar(10)not null,
	MaNQL varchar(10) not null,
	MaSP varchar(10) not null,
	MaDV varchar(10) not null,
	MaHD varchar(10) not null
)
go
-- rang buoc khoa ngoai cho tendn_mk--nhanvien
ALTER TABLE TENDN_MK ADD CONSTRAINT FK_TDNMK_NV FOREIGN KEY (MaNV) REFERENCES NHANVIEN (MaNV)
go
ALTER TABLE TENDN_MK ADD CONSTRAINT FK_TDNMK_QL FOREIGN KEY (MaNQL) REFERENCES QUANLY (MaNQL)
go
--rang buoc khoa ngoai cthd--hoadon
ALTER TABLE CTHD ADD CONSTRAINT FK_CT_HD FOREIGN KEY (MaCTHD) REFERENCES HOADON (MaHD)
go
--rang buoc khoa ngoai cthd--kh
ALTER TABLE	HOADON ADD CONSTRAINT FK_HD_KH FOREIGN KEY (MaKH) REFERENCES KHACHHANG (MaKH)
go
--rang buoc khoa ngoai cthd--nv
ALTER TABLE HOADON ADD CONSTRAINT FK_HD_NV FOREIGN KEY (MaNV) REFERENCES NHANVIEN (MaNV)
go
--rang buoc khoa ngoai cthd--dv
ALTER TABLE HOADON ADD CONSTRAINT FK_HD_DV FOREIGN KEY (MaDV) REFERENCES DICHVU (MaDV)
go
--rang buoc khoa ngoai cthd--sp
ALTER TABLE HOADON ADD CONSTRAINT FK_HD_SP FOREIGN KEY (MaSP) REFERENCES SANPHAM (MaSP)
go
--rang buoc khoa ngoai baocao--sp
ALTER TABLE BAOCAO ADD CONSTRAINT FK_BC_SP FOREIGN KEY (MaSP) REFERENCES SANPHAM (MaSP)
go
--rang buoc khoa ngoai baocao--dv
ALTER TABLE BAOCAO ADD CONSTRAINT FK_BC_DV FOREIGN KEY (MaDV) REFERENCES DICHVU (MaDV)
go
--rang buoc khoa ngoai baocao--quanly
ALTER TABLE BAOCAO ADD CONSTRAINT FK_BC_QL FOREIGN KEY (MaNQL) REFERENCES QUANLY (MaNQL)
--success
go
USE QLKD
set dateformat dmy
go
--------------- INSERT VAO BANG NHANVIEN --------------------
insert NHANVIEN values('NV001',N'Nguyễn Thị Mộng Thường','mongthuong1997@gmail.com',N'01677641996','1')
insert NHANVIEN values('NV002',N'Nguyễn Thị Mộng Thường','mongthuong1998@gmail.com',N'01677641997','1')
insert NHANVIEN values('NV003',N'Nguyễn Thị Mộng Thường','mongthuong1999@gmail.com',N'01677641998','1')
insert NHANVIEN values('NV004',N'Nguyễn Thị Mộng Thường','mongthuong2000@gmail.com',N'01677641999','1')
insert NHANVIEN values('NV005',N'Nguyễn Thị Mộng Thường','mongthuong2001@gmail.com',N'01677642000','1')
insert NHANVIEN values('NV006',N'Nguyễn Thị Mộng Thường','mongthuong2002@gmail.com',N'01677642001','1')
insert NHANVIEN values('NV007',N'Nguyễn Thị Mộng Thường','mongthuong2003@gmail.com',N'01677642002','1')
insert NHANVIEN values('NV008',N'Nguyễn Thị Mộng Thường','mongthuong2004@gmail.com',N'01677642003','1')
insert NHANVIEN values('NV009',N'Nguyễn Thị Mộng Thường','mongthuong2005@gmail.com',N'01677642004','1')
insert NHANVIEN values('NV010',N'Nguyễn Thị Mộng Thường','mongthuong2006@gmail.com',N'01677642005','1')
go
--------------- INSERT VAO BANG QUANLY --------------------
insert QUANLY values('QL001',N'Trần Hồ Bảo Hoàng','tranhobaohoang1997@gmail.com',N'01683061717','2')
insert QUANLY values('QL002',N'Trần Hồ Bảo Hoàng','tranhobaohoang1998@gmail.com',N'01683061718','2')
insert QUANLY values('QL003',N'Trần Hồ Bảo Hoàng','tranhobaohoang1999@gmail.com',N'01683061719','2')
insert QUANLY values('QL004',N'Trần Hồ Bảo Hoàng','tranhobaohoang2000@gmail.com',N'01683061720','2')
insert QUANLY values('QL005',N'Trần Hồ Bảo Hoàng','tranhobaohoang2001@gmail.com',N'01683061721','2')
insert QUANLY values('QL006',N'Trần Hồ Bảo Hoàng','tranhobaohoang2002@gmail.com',N'01683061722','2')
insert QUANLY values('QL007',N'Trần Hồ Bảo Hoàng','tranhobaohoang2003@gmail.com',N'01683061723','2')
insert QUANLY values('QL008',N'Trần Hồ Bảo Hoàng','tranhobaohoang2004@gmail.com',N'01683061724','2')
insert QUANLY values('QL009',N'Trần Hồ Bảo Hoàng','tranhobaohoang2005@gmail.com',N'01683061725','2')
insert QUANLY values('QL010',N'Trần Hồ Bảo Hoàng','tranhobaohoang2006@gmail.com',N'01683061726','2')
--------------- INSERT VAO BANG TENDN_MK QL --------------------
go
INSERT INTO TENDN_MK(MaNQL, LoaiTK,TENDN,MK)  
VALUES ('QL001','2','nguyenvana','123');
--------------- INSERT VAO BANG TENDN_MK NV --------------------
go
INSERT INTO TENDN_MK(MaNV, LoaiTK,TENDN,MK)  
VALUES ('NV001','1','nguyenvanb','123');

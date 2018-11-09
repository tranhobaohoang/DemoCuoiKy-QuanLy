--tạo ràng buộc quy định trong trung tâm sẽ ntn? 
/*
Quy định về dịch vụ
Quy định về khách hàng tới chăm sóc da. liệu trình 2 tuần 1 lần. kháchnếu quá hạn từ 3 tháng trở lên thì hủy gói dịch vụ hiện đó.
*/
--ngày giờ trong xuất hóa đơn  --ok
--nộp bản mô tả chức năng, kế hoạch, file script, project--ok
--báo cáo thống kê theo tuần,, quý năm
USE master
go

DROP DATABASE QLKD
go
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
go
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
	MaDN varchar (10) not null ,
	MaNV varchar(10)  UNIQUE,
	MaNQL varchar(10) UNIQUE,
	LoaiTK int not null ,
	TENDN varchar(20) not null UNIQUE,
	MK nvarchar(20) not null
)
go
create TABLE DICHVU --mot dich vu co the bao gom nhieu san pham
(
	MaDV varchar(10) not null PRIMARY KEY,
	TenDV nvarchar(50) not null UNIQUE,
	MotaDV	nvarchar(100),
)
go
create TABLE SANPHAM --mot san pham co the co trong nhieu dich vu khac nhau
(
	MaSP varchar(10) not null PRIMARY KEY,
	TenSP nvarchar(50)not null UNIQUE,
	MotaSP nvarchar(100),
	GiaSP money not null default (100000),
	SoluongSP int not null DEFAULT (0) --so luong con lai-- de quan ly xuat nhap kho
)
create TABLE DVSP
(
	PRIMARY KEY(MaDV,MaSP),
	MaDV varchar (10) not null,
	MaSP varchar(10) not null,
	GiaSP money not null,
	GiaDV money not null default(100000)--bang gia san pham + gia san pham....
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
	GiaDV money,
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

GO
ALTER TABLE [dbo].[BAOCAO]  WITH CHECK ADD  CONSTRAINT [FK_BAOCAO_HOADON] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[BAOCAO] CHECK CONSTRAINT [FK_BAOCAO_HOADON]
GO
ALTER TABLE [dbo].[BAOCAO]  WITH CHECK ADD  CONSTRAINT [FK_BAOCAO_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[BAOCAO] CHECK CONSTRAINT [FK_BAOCAO_NHANVIEN]
GO
ALTER TABLE [dbo].[BAOCAO]  WITH CHECK ADD  CONSTRAINT [FK_BAOCAO_QUANLY] FOREIGN KEY([MaNQL])
REFERENCES [dbo].[QUANLY] ([MaNQL])
GO
ALTER TABLE [dbo].[BAOCAO] CHECK CONSTRAINT [FK_BAOCAO_QUANLY]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_HOADON] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_HOADON]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG]
GO
ALTER TABLE [dbo].[TENDN_MK]  WITH CHECK ADD  CONSTRAINT [FK_TENDN_MK_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[TENDN_MK] CHECK CONSTRAINT [FK_TENDN_MK_NHANVIEN]
GO
ALTER TABLE [dbo].[TENDN_MK]  WITH CHECK ADD  CONSTRAINT [FK_TENDN_MK_QUANLY] FOREIGN KEY([MaNQL])
REFERENCES [dbo].[QUANLY] ([MaNQL])
GO
ALTER TABLE [dbo].[TENDN_MK] CHECK CONSTRAINT [FK_TENDN_MK_QUANLY]
GO
ALTER TABLE [dbo].[DVSP]  WITH CHECK ADD  CONSTRAINT [FK_DVSP_CTHD] FOREIGN KEY([MaDV])
REFERENCES [dbo].[CTHD] ([MaDV])
GO
ALTER TABLE [dbo].[DVSP] CHECK CONSTRAINT [FK_DVSP_CTHD]
GO
ALTER TABLE [dbo].[DVSP]  WITH CHECK ADD  CONSTRAINT [FK_DVSP_DICHVU] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DICHVU] ([MaDV])
GO
ALTER TABLE [dbo].[DVSP] CHECK CONSTRAINT [FK_DVSP_DICHVU]
GO
ALTER TABLE [dbo].[DVSP]  WITH CHECK ADD  CONSTRAINT [FK_DVSP_SANPHAM] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SANPHAM] ([MaSP])
GO
ALTER TABLE [dbo].[DVSP] CHECK CONSTRAINT [FK_DVSP_SANPHAM]
GO


USE QLKD
go
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
INSERT INTO TENDN_MK(MaDN,MaNQL,LoaiTK,TENDN,MK)  
VALUES ('QL001','QL001','2','nguyenvana','123');
--------------- INSERT VAO BANG TENDN_MK NV --------------------
go
INSERT INTO TENDN_MK(MaDN,MaNV,LoaiTK,TENDN,MK)  
VALUES ('NV001','NV001','1','nguyenvanb','123');
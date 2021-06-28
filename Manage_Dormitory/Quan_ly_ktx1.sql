create database quanlyktx1

use quanlyktx1
go

drop database quanlyktx

CREATE TABLE TaiKhoan(
	UserName NCHAR(30) NOT NULL PRIMARY KEY,
	Pass NCHAR(30) NOT NULL,
	HoTen NVARCHAR(50) NOT NULL,
	--Gender nvarchar(20) check(Gender in ('nam', N'nữ')) not null,
	Quyen nvarchar(30) check(Quyen in ('admin', N'user')) NOT NULL
	)
insert into TaiKhoan values ('user','user','user', 'user')

select Quyen from TaiKhoan where UserName = 'admin'
select Quyen from TaiKhoan where UserName = 'admin' and Quyen = 'admin'


CREATE TABLE SinhVien(
	MaSV NCHAR(8) NOT NULL PRIMARY KEY,
	HoTen NVARCHAR(30),
	CMND NVARCHAR(10) check (CMND like'[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') not null,
	Gender nvarchar(20) check(Gender in ('nam', N'nữ')) not null,
	NgaySinh DATE,
	SDT int check (SDT like'[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') not null,
	QueQuan NVARCHAR(50),
	NgayLamHopDong DATE,
	MaPhong NCHAR(10),
	MaKhu NCHAR(10) NOT NULL,
	--HoTenGiamHo NVARCHAR(30),
	--SDTGH int check (SDTGH like'[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') not null,
	--QuanHe NVARCHAR(20),
	--NgheNghiep NVARCHAR(50)
	)

CREATE TABLE Phong(
	MaPhong NCHAR(10) NOT NULL PRIMARY KEY,
	MaKhu NCHAR(10) NOT NULL,
	TenPhong NVARCHAR(10) NOT NULL,
	LoaiPhong nvarchar(30),
	SoNguoiHienTai INT,
	SoNguoiToiDa INT,
	 )
Insert into Phong values ('001', 'A1', 'Phong 001', 'Thuong', 6, 8)
Insert into Phong values ('002', 'B1', 'Phong 001', 'Thuong', 6, 8)
Insert into Phong values ('003', 'C1', 'Phong 001', 'Vip', 7, 8)
Insert into Phong values ('004', 'D1', 'Phong 001', 'Vip', 7, 8)


CREATE TABLE Khu(
	MaKhu NCHAR(10) NOT NULL PRIMARY KEY,
	TenKhu NVARCHAR(30) NOT NULL,
	SoPhong int not null
	)
Insert into Khu values ('A1', N'Toa A', 100)
Insert into Khu values ('B1', N'Toa B', 200)
Insert into Khu values ('C1', N'Toa C', 300)
Insert into Khu values ('D1', N'Toa D', 400)




CREATE TABLE SinhHoat(
	MaPhong NCHAR(10) NOT NULL PRIMARY KEY,
	Thang int check (Thang > 0 and Thang < 13) not null, 
	Nam int check (Nam > 0) not null,
	CSMoiDien INT NOT NULL,
	CSMoiNuoc INT NOT NULL,
	CSCuDien INT NOT NULL,
	CSCuNuoc INT NOT NULL,
	)
Insert into SinhHoat values ('001', 11, 2020, 100, 200, 300, 350)
Insert into SinhHoat values ('002', 10, 2020, 150, 200, 310, 350)
Insert into SinhHoat values ('003', 9, 2020, 120, 200, 320, 350)
Insert into SinhHoat values ('004', 12, 2020, 130, 200, 330, 350)


Create Table GuiXe(
	BienSoXe nchar(8) primary key,
	TenChuXe nvarchar(30) not null,
	MaSV NCHAR(8) NOT NULL,
	MaKhu NCHAR(10) NOT NULL,
	MaPhong NCHAR(10) NOT NULL,
	NgayDangKy date not null,
	NgayHetHan date not null,
	MoTa nvarchar(50) not null,
	GiaGui int not null,
	GhiChu varchar(100)
	)
Insert into GuiXe values ('01233214','Nguyen A', '001', 'A1','001', '2020-11-10', '2021-01-01', 'o to', 100000, 'xe may')
Insert into GuiXe values ('75378946','Nguyen A', '001', 'A1','001', '2020-12-10', '2021-02-01', 'may bay', 300000, 'xe tang')

Create Table QuanLyThietBi(
	MaThietBi nchar(10) primary key,
	TenThietBi nvarchar(30) not null,
	GiaTien int not null,
	ThoiHanBaoHanh int not null
	)
Insert into QuanLyThietBi values ('A001', 'Cong tac', 20000, '2') 
Insert into QuanLyThietBi values ('B001', 'Giuong', 3000000, '12') 
Insert into QuanLyThietBi values ('C001', 'Bong den', 50000, '24') 
Insert into QuanLyThietBi values ('D001', 'Binh nong lanh', 5000000, '36') 


Create Table QuanLyThietBiHong(
	MaThietBi nchar(10) not null,
	MaKhu NCHAR(10) NOT NULL,
	MaPhong NCHAR(10) NOT NULL,
	SoLuongHong int not null,
	NgayLapDat date not null,
	NgayHetBaoHanh date not null
	)
Insert into QuanLyThietBiHong values ('A001', 'A1', '001', 1, '2020-10-20', '2020-12-20') 
Insert into QuanLyThietBiHong values ('B001', 'B1', '002', 1, '2020-10-20', '2021-10-20')

Create table NhanVien(
		MaNV nvarchar(10) primary key,
		HoTen nvarchar(50),
		SDT int check (SDT like'[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') not null,
		QueQuan nvarchar(50),
		ChucVu nvarchar(50),
		Luong int
	);

insert into NhanVien values('QL','Vũ Văn Vương',0988123124,'Thái Nguyên','Quản Lý Ký túc',1000000)
insert into NhanVien values('PT01','Vũ Đức Đạt',0981345124,'Thái Bình','Phụ Trách Nhà 1',2000000)
insert into NhanVien values('PT02','Vũ Việt Thái',0981657492,'Ninh Bình','Phụ Trách Nhà 2',3000000)
insert into NhanVien values('PT03','Vũ Thị Dung',0981026482,'Hòa Bình','Phụ Trách Nhà 3',4000000)
insert into NhanVien values('PT04','Vũ Vân Thúy',0123645124,'Tây Nguyên','Phụ Trách Nhà 4',5000000)
insert into NhanVien values('PT05','Vũ Hoàng Nam',0576245124,'Thanh Hóa','Phụ Trách Nhà xe',6000000)
insert into NhanVien values('BV01','Nguyễn Văn Vũ',0945386924,'Hà Nội','Bảo vệ',7000000)
insert into NhanVien values('BV02','Nguyễn Quang Hùng',0155386924,'Hà Nội','Bảo vệ',8000000)
insert into NhanVien values('BV03','Trịnh Thị Quyên',0945386924,'Hà Tĩnh','Bảo vệ',9000000)

alter table QuanLyThietBiHong add foreign key (MaThietBi) references QuanLyThietBi (MaThietBi);
alter table QuanLyThietBiHong add foreign key (MaKhu) references Khu (MaKhu);
alter table QuanLyThietBiHong add foreign key (MaPhong) references Phong (MaPhong);

alter table GuiXe add foreign key (MaSV) references SinhVien (MaSV);
alter table GuiXe add foreign key (MaKhu) references Khu (MaKhu);
alter table GuiXe add foreign key (MaPhong) references Phong (MaPhong);

alter table Phong add foreign key (MaKhu) references Khu (MaKhu);

--alter table SinhVien add foreign key (MaKhu) references Khu (MaKhu);
alter table SinhVien add foreign key (MaPhong) references Phong (MaPhong);



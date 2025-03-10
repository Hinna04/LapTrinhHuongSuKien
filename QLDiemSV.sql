Create database DiemSinhVien
go
use DiemSinhVien
go
create table tblGIAOVIEN
(
	sMaGV varchar(50) primary key,
	sHoTen nvarchar(255) not null,
	sEmail nvarchar(50) null,
	sSoDienThoai varchar(30) null
);

create table tblLOP
(
	sMaLop varchar(50) primary key,
	sMaGV varchar(50) not null foreign key references tblGIAOVIEN(sMaGV)
);

create table tblSINHVIEN
(
	sMaSV varchar(50) primary key,
	sHoTen nvarchar(255) not null,
	dNgaySinh date null,
	sDiaChi nvarchar(255) null,
	sSoDienThoai nvarchar(30) null,
	bGioiTinh bit not null,
	sMaLop varchar(50) null foreign key references tblLOP(SMaLop)
);

create table tblMONHOC
(
	sMaHocPhan varchar(50) primary key,
	sTenHocPhan nvarchar(255) not null,
	iSoTinChi int not null
);

create table tblDiem
(
	sMaSV varchar(50) not null foreign key references tblSINHVIEN(sMaSV),
	sMaHocPhan varchar(50) not null foreign key references tblMONHOC(sMaHocPhan),
	fDiemQT float not null,
	fDiemCK float not null
);
/*

	(@sMaSV varchar(50),
	 @sMaGV varchar(50),
	 @sHoTen nvarchar(255),
	 @sDiaChi nvarchar(255),
	 @dNgaySinh date,
	 @sSoDienThoai nvarchar(30),
	 @sMaLop varchar(50),
	 @bGioiTinh bit,
	 @HoTenGV nvarchar(255))*/
create proc Select_TongHop
AS
	Select sv.sMaSV, gv.sMaGV, sv.sHoTen, sv.sDiaChi, sv.dNgaySinh, sv.sSoDienThoai, sv.sMaLop, sv.bGioiTinh, gv.sHoTen
	from tblSINHVIEN sv, tblGIAOVIEN gv
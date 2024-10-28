create database ThamMyVien
use ThamMyVien
go
create table tblBenhNhan_TTTH
(
	MaBN_TTTH int primary key,
	TenBN_TTTH nvarchar(50)
);
create table tblHopDong_TTTH
(
	Ngay_TTTH date,
	MaBN_TTTH int foreign key references tblBenhNhan_TTTH(MaBN_TTTH),
	DichVu_TTTH nvarchar(100)
);
create table tblDichVu_TTTH
(
	IDDV_TTTH int primary key,
	TenDV_TTTH nvarchar(100)
);

insert into tblBenhNhan_TTTH
values 
	(101, N'Nguyễn Thị Hà'),
	(102, N'Bùi Văn Thắng'),
	(103, N'Trần Thu Huyên'),
	(104, N'Bá Phương Anh');


insert into tblDichVu_TTTH
values 
	(001, N'Lăn kim'),
	(002, N'Triệt lông'),
	(003, N'Nâng mũi'),
	(004, N'Cắt môi trái tim'),
	(005, N'Cắt mí mắt'),
	(006, N'Xăm lông mày'),
	(007, N'Xăm môi');

select * from tblDichVu_TTTH

create proc Insert_BenhNhan
@mabn int,
@tenbn nvarchar(50)
as
insert into tblBenhNhan_TTTH
values (@mabn, @tenbn)

create proc Insert_HopDong
@ngay date,
@maBN int,
@dichVu nvarchar(100)
as
insert into tblHopDong_TTTH
values (@ngay, @maBN , @dichVu)

create proc Select_BenhNhan
as
select MaBN_TTTH, TenBN_TTTH
from tblBenhNhan_TTTH

create proc Select_HopDong
as
select Ngay_TTTH, MaBN_TTTH, DichVu_TTTH
from tblHopDong_TTTH

create proc Update_BenhNhan
	@mabn int,
	@tenbn nvarchar(50)
as 
	update tblBenhNhan_TTTH
	set
	TenBN_TTTH = @tenbn
	where MaBN_TTTH = @mabn

create proc Delete_BenhNhan @mabn int
as
	delete
	from tblBenhNhan_TTTH
	where MaBN_TTTH = @mabn


select * from tblBenhNhan_TTTH
select * from tblHopDong_TTTH
select * from tblDichVu_TTTH

ALTER TABLE tblHopDong_TTTH
ADD CONSTRAINT UC_MaBN_Ngay UNIQUE (MaBN_TTTH, Ngay_TTTH);

create proc Update_HopDong
	@ngay date,
	@mabn int,
	@dichvu nvarchar(100)
as 
	update tblHopDong_TTTH
	set
	Ngay_TTTH = @ngay, MaBN_TTTH = @mabn, DichVu_TTTH = @dichvu
	where MaBN_TTTH = @mabn and Ngay_TTTH = @ngay
/*
create proc Delete_HopDong (@ngay date, @mabn int, @dichvu nvarchar(100))
as
	delete
	from tblHopDong_TTTH
	where MaBN_TTTH = @mabn and Ngay = @ngay
*/
delete from tblHopDong_TTTH
where MaBN_TTTH = 103;

Create proc Select_TongHop
as
	select hd.Ngay_TTTH, bn.TenBN_TTTH, hd.DichVu_TTTH
	from tblBenhNhan_TTTH bn, tblHopDong_TTTH hd
	where bn.MaBN_TTTH = hd.MaBN_TTTH;
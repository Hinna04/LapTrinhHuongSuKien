create proc Insert_SinhVien
@maSV varchar(255),
@ngaySinh date,
@gioiTinh bit
as
insert into tblSinhVien(sMaSV, dNgaySinh, bGioiTinh)
values (@maSV, @ngaySinh, @gioiTinh)

create proc KiemTraKhoaChinh_SinhVien
@maSV varchar(255)
as
select sMaSV
from tblSinhVien
where sMaSV = 'a' --> true truy van ra 1 du lieu duy nhat

create proc Select_tblSinhVien
as
select sMaSV, dNgaySinh, bGioiTinh
from tblSinhVien

create proc Update_tblSinhVien
	@maSV varchar(255),
	@ngaySinh date,
	@gioiTinh bit
as 
	update tblSinhVien
	set
	dNgaySinh = @ngaySinh,
	bGioiTinh = @gioiTinh
	where sMaSV = @maSV

create proc Delete_tblSinhVien @maSV varchar(255)
as
	delete
	from tblSinhVien
	where sMaSV = @maSV

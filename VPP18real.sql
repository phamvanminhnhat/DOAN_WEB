create database VanPhongPham
go
use VanPhongPham

create table ADMIN 
(
ID int identity primary key not null,
TenAD nvarchar(50) ,
TenDangNhap nvarchar(50) unique not null,
MatKhau varchar(20) not null
)
create table NGUOIDUNG
(
IdND int identity primary key,
TenND nvarchar(50) not null,
SDT char(11) unique not null,
Email varchar(30) unique not null,
MatKhau varchar(20) not null
)
create table DANHMUCSANPHAM
(
IdDM int  identity primary key,
TenDM nvarchar(50) unique not null,
HinhAnh varchar(100)
)
create table NCC
(
IdNCC int identity primary key,
TenNCC nvarchar(50) not null unique,
HinhAnh varchar(100),
SDT char(11),
DiaChi nvarchar(100),
Email varchar(50) unique
)
create table SANPHAM
(
IdSP varchar(20) primary key not null,
IdDM int references DANHMUCSANPHAM(IdDM),
IdNCC int references NCC(IdNCC),
TenSP nvarchar(50) not null,
HinhAnh varchar(100),
DonGia Decimal(18,0),
SoLuongTon int,
MoTa nvarchar(500),
)

create table DONHANG
(
MaDH int identity primary key,
IdSP varchar(20) references SANPHAM(IdSP),
IdND int references NGUOIDUNG(IdND),
TongTien Decimal(18,0),
TinhTrang nvarchar(50)
)
create table THANHTOAN
(
MaDH int references DONHANG(MaDH),
IdSP varchar(20) references SANPHAM(IdSP),
ThanhTien Decimal(18,0),
SoLuong int
 )
 
 go 
 insert into ADMIN values (  N'Nguyễn Thị Thiên ý', 'ADMIN','123456')
 insert into ADMIN values (  N'Trần Văn Tuấn', 'NV','12345')

 go 
 insert into NGUOIDUNG values (  N'Phạm Văn Minh Nhật',0334470440, 'minhnhat@gmail.com','123456')
 insert into NGUOIDUNG values (  N'Trần Thị Nga',0334470888, 'trannga@gmail.com','123456')
  insert into NGUOIDUNG values (  N'Nguyễn Văn lam ',0995540440, 'nguyuenlamt@gmail.com','12345')
  go 
   insert into DANHMUCSANPHAM values (  N'Bút viết','But1.jpg')
   insert into DANHMUCSANPHAM values (  N'Tập vở','Vo1.jpg')
   insert into DANHMUCSANPHAM values (  N'Giấy in','Giay1.jpg')
   go 
   insert into NCC values (  N'Thiên Long ','But1.jpg', 0336688900, N'Quận 1','thienlong@gmail.com' )
   insert into NCC values (  N'Hồng Hà ','Vo1.jpg', 033655900, N'Hà Nội','honngha@gmail.com' )
   go
   insert into SANPHAM values ('SP1',1,1, N'But chì B2','But1.jpg', 1200, 1000,'Bút chì để viết' )
   insert into SANPHAM values ('SP2',2,2, N'Vở hồng hà','Vo1.jpg', 6000, 1000,'vở viết' )
   go 
   insert into DONHANG values ('SP1',1,3600, 'đang giao hàng' )
   insert into DONHANG values ('SP1',1,3600, 'đang giao hàng' )
   go
   insert into THANHTOAN values (1,'SP1',3600,14)
   insert into THANHTOAN values (1,'SP2',4800,14)


   
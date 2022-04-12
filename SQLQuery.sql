create database VanPhongPhamnew

go
use  VanPhongPhamnew

set dateformat dmy
create table ADMIN 
(
ID int identity primary key not null,
TenAD nvarchar(50) not null,
TenDangNhap nvarchar(50) unique not null,
MatKhau varchar(20) not null
)
create table NGUOIDUNG
(
IdND int identity primary key not null,
TenND nvarchar(50) not null,
SDT char(11) unique not null,
DiaChi nvarchar(100) not null,
Email varchar(30) unique not null,
MatKhau varchar(20) not null
)
create table DANHMUCSANPHAM
(
IdDM int  identity primary key not null,
TenDM nvarchar(50) unique not null,
HinhAnh varchar(100)
)
create table NCC
(
IdNCC int identity primary key not null,
TenNCC nvarchar(50) not null unique,
HinhAnh varchar(100),
SDT char(11),
DiaChi nvarchar(100),
)
create table SANPHAM
(
IdSP varchar(20) primary key not null,
IdDM int references DANHMUCSANPHAM(IdDM) not null,
IdNCC int references NCC(IdNCC) not null,
TenSP nvarchar(50) not null,
HinhAnh varchar(100),
DonGia Decimal(18,0),
SoLuongTon int not null,
MoTa nvarchar(500)
)

create table DONHANG
(
MaDH int identity primary key not null,
IdND int references NGUOIDUNG(IdND) not null,
ThanhTien Decimal(18,0),
TinhTrang nvarchar(50) not null,
NgayDat datetime not null,
NgayGiao datetime not null
)

create table THANHTOAN
(
MaTT int identity primary key not null,
MaDH int references DONHANG(MaDH)not null,
IdSP varchar(20) references SANPHAM(IdSP) not null,
SoLuong int not null,
TongTien Decimal(18,0),

)

 go 
 insert into ADMIN values (  N'Nguyễn Thị Thiên ý', 'ADMIN','123456')
 insert into ADMIN values (  N'Trần Văn Tuấn', 'NV','12345')

 go 
 insert into NGUOIDUNG values (  N'Phạm Văn Minh Nhật',0334470440,'Quận 1','minhnhat@gmail.com','123456')
 insert into NGUOIDUNG values (  N'Trần Thị Nga',0334470888,'Quận 1','trannga@gmail.com','123456')
  insert into NGUOIDUNG values (  N'Nguyễn Văn lam ',0995540440,'Quận 1','nguyuenlamt@gmail.com','12345')
  go 
   insert into DANHMUCSANPHAM values (  N'Bút viết','But1.jpg')
   insert into DANHMUCSANPHAM values (  N'Tập vở','Vo1.jpg')
   insert into DANHMUCSANPHAM values (  N'Giấy in','Giay1.jpg')
   go 
   insert into NCC values (  N'Thiên Long ','But1.jpg', 0336688900, N'Quận 1' )
   insert into NCC values (  N'Hồng Hà ','Vo1.jpg', 033655900, N'Hà Nội')
   go
   insert into SANPHAM values ('SP1',1,1, N'But chì B2','But1.jpg', 1200, 1000,'Bút chì để viết' )
   insert into SANPHAM values ('SP2',2,2, N'Vở hồng hà','Vo1.jpg', 6000, 1000,'Vở viết' )
   go 
   insert into DONHANG values (1,3600, 'Đang giao hàng', '12/04/2022','04/04/2022')
   insert into DONHANG values (1,3600, 'Đang xử lý','14/04/2022','04/04/2022' )
   go
   insert into THANHTOAN values (1,'SP1',12,24000)
   insert into THANHTOAN values (2,'SP2',9,36000)

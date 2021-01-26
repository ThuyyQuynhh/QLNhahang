CREATE DATABASE NhaHang
Go
USE NhaHang
go
create table KhachHang(
	id_KhachHang varchar(20) primary key ,
	HoTen nvarchar(200)	not null,
	NgaySinh date not null ,
	SDT varchar(100)   not null,
	DiaChi nvarchar(200) ,
	GioiTinh nvarchar(50) 
);
create table NhanVien(
	id_NhanVien varchar(20) primary key ,
	HoTen	nvarchar(200) not null,
	GioiTinh  nvarchar(200),
	NgaySinh date ,
	ChucVu nvarchar(200) not null	default 'nhân viên',
	SDT varchar(200),
	Luong float default 0,
	KyNang nvarchar(200),
);
create table admin(
	id_NhanVien varchar(20)  references NhanVien(id_NhanVien),
	TaiKhoan char(200) not null,
	MatKhau char(200) not null,
	
);
create table DanhMuc(
	id_DanhMuc varchar(20) primary key,
	Ten nvarchar(200)
);
create table ThucPham(
	id_ThucPham int identity(1,1) primary key,
	id_DanhMuc varchar(20) ,
	Ten nvarchar(200) not null,
	Gia float default 0,
	MoTa nvarchar(200),
	 foreign key(id_DanhMuc) references DanhMuc (id_DanhMuc)
);
create table HoaDon(
	id_HoaDon varchar(20) primary key ,
	id_NhanVien varchar(20),
	id_KhachHang varchar(20) ,
	NgayTao date default getdate(),
	TongGia float default 0,
	TinhTrang int default 0,	-- 0 là chưa thanh toán
	KhuyenMai int default 0,
	 foreign key (id_NhanVien)  references NhanVien(id_NhanVien) ,
	  foreign key (id_KhachHang) references KhachHang(id_KhachHang)
);

create table Ban(
	TenBan int identity(1,1) primary key,
	SoGhe int not null,
	TrangThai nvarchar(50) default N'Trống'
)

create table HoaDonBan(
	id_HDBan int primary key identity(1,1),
	id_HoaDon varchar(20) references HoaDon(id_HoaDon) on update cascade,
	TenBan int references Ban(TenBan),
	TongGia int default 0
);
create table ChiTietHoaDon(
	So_ChiTietHD int primary key identity(1,1),
	id_HDBan int references HoaDonBan(id_HDBan),
	id_ThucPham int  references ThucPham(id_ThucPham),
	SoLuong int default 0,
	tonggia int default 0
);
create table NguyenLieu(
	id_NguyenLieu int primary key identity(1,1),
	TenNL  nvarchar(50) not null,
	SoLuong int,
);

create table PhieuNhapKho(
	id_PhieuNhapKho int primary key identity(1,1),
	id_NhanVien varchar(20) references NhanVien(id_NhanVien),
	NgayNhap date default getdate()
);
create table ChiTietNhapKho(
	id_PhieuNhapKho int references PhieuNhapKho(id_PhieuNhapKho),
	id_NguyenLieu int references NguyenLieu(id_NguyenLieu),
	SoLuong int not null,
	Gia int not null,
);

-- thêm dữ liệu trong bảng danh lục
--------------------------------------------------------------------- DANH MỤC------------------------------------------------------------------------------------------------------


INSERT INTO DanhMuc VALUES('DM01',  N'Súp');
INSERT INTO DanhMuc VALUES('DM02',  N'Rau');
INSERT INTO DanhMuc VALUES('DM03',  N'Sa lát');
INSERT INTO DanhMuc VALUES( 'DM04', N'Món chiên');
INSERT INTO DanhMuc VALUES('DM05',  N'Thịt heo');
INSERT INTO DanhMuc VALUES( 'DM06', N'Thịt bò');
INSERT INTO DanhMuc VALUES('DM07',N'Thịt cừu');
INSERT INTO DanhMuc VALUES('DM08',  N'Thịt gà');
INSERT INTO DanhMuc VALUES('DM09',  N'Hải sản');
INSERT INTO DanhMuc VALUES('DM10',  N'Món mặn');
INSERT INTO DanhMuc VALUES('DM11',  N'Lẩu');
INSERT INTO DanhMuc VALUES('DM12',  N'Cơm & Mỳ');
INSERT INTO DanhMuc VALUES('DM13',  N'Tráng miệng');
-- thêm dữ liệu trong bảng món ăn
------------------------------------------------------------------ THỰC PHẨM  -------------------------------------------------------------------------------------------------------

                                 /*    SÚP _ 7 món   */
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM01' ,N'Súp gà ngô kem', 45000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM01' ,N'Súp hải sản tuyết nhĩ', 68000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM01' ,N'Súp cá bớp lá lốt', 68000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM01' ,N'Súp tôm chua cay kiểu Thái', 68000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM01' ,N'Súp bào ngư Nam Phi nấm tươi', 660000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM01' ,N'Súp vi cá đặc biệt', 980000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM01' ,N'Súp tổ yến', 1280000);

                                  /*	RAU _ 7 món */
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM02' ,N'Rau dền luộc', 58000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM02' ,N'Rau muống xào', 58000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM02' ,N'Rau mồng tơi xào tỏi', 58000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM02' ,N'Rau bí xào tỏi', 58000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM02' ,N'Măng tây tươi xào tôm', 210000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM02' ,N'Củ quả luộc chấm muối vừng', 66000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM02' ,N'Rau bò khai xào trứng', 98000);

                                  /*	SA LÁT _ 7 món */
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM03' ,N'Salad cà chua dưa chuột', 68000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM03' ,N'Gỏi mướp đắng ruốc', 82000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM03' ,N'Salad rau trộn', 99000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM03' ,N'Nộm hoa chuối tai heo', 110000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM03' ,N'Nộm bắp bò cần mỹ', 115000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM03' ,N'Nộm ngó sen tôm thịt', 128000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM03' ,N'Nộm sứa gà xé', 128000);

                                  /*	MÓN CHIÊN _ 5 món */
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM04' ,N'Ngô mỹ chiên', 66000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM04',N'Khoai lang Nhật chiên', 78000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM04' ,N'Khoai tây chiên', 66000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM04' ,N'Nem Sài Gòn', 66000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM04' ,N'Đậu mơ lướt ván', 68000);

                                  /*	THỊT HEO _ 5 món */
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM05' ,N'Ba chỉ quay', 138000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM05' ,N'Đùi heo phá lẩu+bành mỳ', 298000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM05' ,N'Đùi heo hầm củ sen', 320000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM05' ,N'Đùi heo hầm kiểu Đức', 380000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM05' ,N'Sườn lợn nướng sốt BBQ', 298000);

                                  /*	THỊT BÒ _ 5 món */
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM06' ,N'Bò xào rau', 198000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM06',N'Bò cuốn lá cải', 198000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM06' ,N'Bò nướng mật ong', 228000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM06' ,N'Bò sốt tiêu đen', 252000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM06' ,N'Đuôi bò hầm cà ri sốt dừa', 560000);

                                  /*	THỊT CỪU _ 2 món */
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM07' ,N'Sườn cừu nướng sốt tỏi lá thơm', 580000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM07' ,N'Đùi cừu nướng sốt tỏi lá thơm', 580000);

                                  /*	THỊT GÀ _ 8 món */
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM08',N'Gà hấp lá chanh', 218000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM08' ,N'Gà rang muối', 228000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM08' ,N'Gà quay mật ong', 238000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM08' ,N'Gà quay sốt nấm Đông Cô', 260000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM08' ,N'Gà rút xương quay', 238000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM08' ,N'Gà Đông Tảo hấp xả gừng', 680000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM08' ,N'Gà Đông Tảo xào lăn', 680000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM08',N'Gà Đông Tảo rang muối', 680000);

                                  /*	HẢI SẢN _ 12 món */
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM09' ,N'Tôm sú hấp bia', 1050000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM09' ,N'Tôm he rang muối', 135000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM09' ,N'Tôm hùm bỏ lò phô mai', 2500000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM09' ,N'Cua chiên bơ tỏi', 125000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM09' ,N'Cua thịt hấp bia', 900000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM09' ,N'Cua gạch sốt cay', 850000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM09' ,N'Bào ngư Úc sốt sò điệp', 520000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM09' ,N'Bào ngư Úc hầm gà ác đậu đỏ', 538000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM09' ,N'Bào ngư Nam Phi sốt nấm', 1630000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM09' ,N'Cá hồi Sapa nướng sốt bơ tỏi', 1050000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM09' ,N'Cá hồi Nauy nướng sốt kem nấm', 1280000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM09' ,N'Cá song nướng ngũ vị', 890000);

                                  /*	MÓN MẶN _ 5 món */
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM10' ,N'Trứng đúc thịt', 72000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM10' ,N'Ba chỉ rang cháy cạnh', 85000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM10' ,N'Sườn xào chua ngọt', 160000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM10' ,N'Cá kho tộ', 110000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM10' ,N'Ba chỉ luộc chấm mắm tép', 85000);

                                  /*	LẨU _ 5 món */
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM11',N'lẩu đuôi bò', 780000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM11',N'Lẩu riêu cua bò Úc', 946000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM11' ,N'Lẩu bò Waybu Nhật', 1880000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM11' ,N'Lẩu bắp bò Kobe', 1560000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM11' ,N'Lẩu Thái hải sản', 1100000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM11' ,N'Lẩu gà Đông Tảo', 980000);

                                  /*	CƠM & MỲ _ 5 món */
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM12' ,N'Mỳ xào bò', 95000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM12' ,N'Mỳ xào hải sản', 110000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM12' ,N'Phở xào bò', 95000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM12' ,N'Cơm rang thập cẩm', 95000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM12' ,N'Cơm rang hải sản', 110000);

                                  /*	TRÁNG MIỆNG _ 5 món */
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM13' ,N'Bưởi da xang', 158000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM13' ,N'Hoa quả thập cẩm', 132000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM13' ,N'Cam canh', 120000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM13' ,N'Dưa hấu', 95000);
INSERT INTO ThucPham(id_DanhMuc , Ten, Gia) VALUES ('DM13',N'Kem Nga nhập khẩu', 55000);
--thêm dữ liệu bảng nhân viên
--------------------------------------------------------------------------- NHÂN VIÊN ------------------------------------------------------------------------------------------------------------

insert into NhanVien(id_NhanVien,HoTen,GioiTinh,NgaySinh,ChucVu,SDT,Luong)
Values('NV01',N'Nguyễn Ngọc Anh',N'nữ','1999-04-23',N'thu ngân','0954321864',2000000)
insert into NhanVien(id_NhanVien,HoTen,GioiTinh,Ngaysinh,Chucvu,SDT,Luong,KyNang) 
values('NV02',N'Nhữ Ngọc Anh',N'nam','1999-12-11',N'bồi bàn','0943554879',1200000,N'đánh máy')
insert into NhanVien(id_NhanVien,HoTen,GioiTinh,Ngaysinh,SDT,Luong) 
Values('NV03',N'Trần Thị Vân Anh',N'nữ','1999-05-21','0976886123',1800000)
insert into NhanVien(id_NhanVien,HoTen,GioiTinh,Ngaysinh,Chucvu,SDT,Luong,KyNang) 
Values('NV04',N'Hoàng Trọng Bình',N'nam','1999-05-19',N'quản lý','0965432887',2500000,N'ngoại ngữ')
insert into NhanVien(id_NhanVien,HoTen,GioiTinh,Ngaysinh,SDT,Luong) 
Values('NV05',N'Phạm Tiến Duật',N'nam','1999-02-23','0941286976',1000000)
insert into NhanVien(id_NhanVien,HoTen,GioiTinh,Ngaysinh,Chucvu,SDT,Luong) 
Values('NV06',N'Ma Đình Diện',N'nam','1999-05-29',N'bảo vệ','0974764934',1500000)
insert into NhanVien(id_NhanVien,HoTen,GioiTinh,Ngaysinh,Chucvu,SDT,Luong) 
Values('NV07',N'Đỗ Văn Hoàng',N'nam','1997-02-11',N'bảo vệ','0953865994',1800000)
insert into NhanVien(id_NhanVien,HoTen,GioiTinh,Ngaysinh,Chucvu,SDT,Luong) 
Values('NV08',N'Nguyễn Duy Ninh',N'nam','1998-09-07',N'bồi bàn','0935879924',900000)
insert into NhanVien(id_NhanVien,HoTen,GioiTinh,Ngaysinh,SDT,Luong) 
Values('NV09',N'Nguyễn Thanh Hà',N'nam','1996-06-01','0942764882',2200000)
insert into NhanVien(id_NhanVien,HoTen,GioiTinh,Ngaysinh,Chucvu,SDT,Luong,KyNang) 
Values('NV10',N'Nguyễn Hữu Hải',N'nam','1998-12-02',N'đầu bếp','0978532753',2100000,N'da trắng')
-- thêm dữ liệu vàng bảng admin
-------------------------------------------------------------------------- ADMIN ---------------------------------------------------------------------------------------------------------------
INSERT INTO admin(id_NhanVien,TaiKhoan , MatKhau)
VALUES('NV01', 'NgocAnh' , '1'),
		('NV04','TrongBinh' , '1'),
		('NV05', 'TrongTien', '1'),
		('Nv06','XuanTung','1')
-- thêm dữ liệu bảng khách hàng	
--------------------------------------------------- KHÁCH HÀNG ------------------------------------------------------------------------
 insert into KhachHang 
values ('KH1',N'Nguyễn Trọng Linh','19821020','4743737808',N'Hải Dương',N'Nam'),('KH2',N'Nguyễn Trọng Anh','19790819','1682277363',N'Hà Tĩnh',N'Nam'),('KH3',N'Nguyễn Trọng Đức','19590901','9251384480',N'Bà Rịa',N'Nữ'),('KH4',N'Nguyễn Trọng Quỳnh','19971015','5774713864',N'Nghệ An',N'Nam'),('KH5',N'Nguyễn Trọng Nga','19850411','9718469408',N'Thanh Hóa',N'Nữ'),('KH6',N'Nguyễn Trọng Tá','19700621','7165430508',N'Hải Dương',N'Nữ'),('KH7',N'Nguyễn Trọng Thắng','19590915','2289939762',N'Hà Tĩnh',N'Nữ'),('KH8',N'Nguyễn Trọng Hà','19980214','1292137586',N'Sơn Tây',N'Nam'),('KH9',N'Nguyễn Trọng Tú','20000320','3394472338',N'Bà Rịa',N'Nam'),('KH10',N'Nguyễn Trọng Phong','19560425','1795434643',N'Nam Định',N'Nam'),('KH11',N'Nguyễn Bá Linh','19630322','6397162559',N'Vĩnh Phúc',N'Nam'),('KH12',N'Nguyễn Bá Anh','19720118','7410089582',N'Sơn Tây',N'Nam'),('KH13',N'Nguyễn Bá Đức','20031021','4182257053',N'Sơn Tây',N'Nam'),('KH14',N'Nguyễn Bá Quỳnh','19730113','5816852270',N'Nam Định',N'Nam'),('KH15',N'Nguyễn Bá Nga','19530702','1511831407',N'Hải Dương',N'Nữ'),('KH16',N'Nguyễn Bá Tá','19740817','7502573102',N'Sài Gòn',N'Nam'),('KH17',N'Nguyễn Bá Thắng','19810114','8275585080',N'Hải Dương',N'Nam'),('KH18',N'Nguyễn Bá Hà','19910205','7758957638',N'Hà Nội',N'Nam'),('KH19',N'Nguyễn Bá Tú','19530422','2028884030',N'Nghệ An',N'Nam'),('KH20',N'Nguyễn Bá Phong','19870709','6817568614',N'Hải Dương',N'Nam'),('KH21',N'Nguyễn Đức Linh','19850214','8394991627',N'Hà Nội',N'Nữ'),('KH22',N'Nguyễn Đức Anh','19911124','6718922497',N'Hà Nội',N'Nam'),('KH23',N'Nguyễn Đức Đức','19671009','7376729029',N'Hà Tĩnh',N'Nam'),('KH24',N'Nguyễn Đức Quỳnh','19840910','8907143599',N'Bà Rịa',N'Nam'),('KH25',N'Nguyễn Đức Nga','19590225','2646697539',N'Hải Dương',N'Nữ'),('KH26',N'Nguyễn Đức Tá','20020803','6601095073',N'Hải Dương',N'Nam'),('KH27',N'Nguyễn Đức Thắng','19771110','7153256018',N'Sơn Tây',N'Nữ'),('KH28',N'Nguyễn Đức Hà','20030110','4958461007',N'Sơn Tây',N'Nam'),('KH29',N'Nguyễn Đức Tú','20030201','5802736910',N'Thanh Hóa',N'Nữ'),('KH30',N'Nguyễn Đức Phong','19751116','2495785997',N'Nghệ An',N'Nam'),('KH31',N'Nguyễn Văn Linh','19540311','3395546645',N'Hà Nội',N'Nữ'),('KH32',N'Nguyễn Văn Anh','19610104','8758091140',N'Bà Rịa',N'Nam'),('KH33',N'Nguyễn Văn Đức','19920707','4653148719',N'Hà Tĩnh',N'Nữ'),('KH34',N'Nguyễn Văn Quỳnh','19550127','6816381196',N'Nghệ An',N'Nữ'),('KH35',N'Nguyễn Văn Nga','19790901','7002043559',N'Thanh Hóa',N'Nữ'),('KH36',N'Nguyễn Văn Tá','19591123','2436279039',N'Thanh Hóa',N'Nam'),('KH37',N'Nguyễn Văn Thắng','19881021','4576974853',N'Hà Tĩnh',N'Nam'),('KH38',N'Nguyễn Văn Hà','19930420','4727788324',N'Hà Tĩnh',N'Nam'),('KH39',N'Nguyễn Văn Tú','19850527','6544855309',N'Sơn Tây',N'Nam'),('KH40',N'Nguyễn Văn Phong','19610219','5758133684',N'Nam Định',N'Nữ'),('KH41',N'Nguyễn Thị Linh','19640516','6967925961',N'Thanh Hóa',N'Nam'),('KH42',N'Nguyễn Thị Anh','19640312','1634288185',N'Nghệ An',N'Nam'),('KH43',N'Nguyễn Thị Đức','19640421','5523382555',N'Hà Tĩnh',N'Nữ'),('KH44',N'Nguyễn Thị Quỳnh','19801015','3372962712',N'Sơn Tây',N'Nữ'),('KH45',N'Nguyễn Thị Nga','19990113','5116937285',N'Sơn Tây',N'Nữ'),('KH46',N'Nguyễn Thị Tá','19920214','7236233478',N'Sài Gòn',N'Nam'),('KH47',N'Nguyễn Thị Thắng','19810711','6712338852',N'Sơn Tây',N'Nữ'),('KH48',N'Nguyễn Thị Hà','19511126','5112772816',N'Sài Gòn',N'Nữ'),('KH49',N'Nguyễn Thị Tú','19720119','6324862273',N'Nam Định',N'Nam'),('KH50',N'Nguyễn Thị Phong','19841111','6090074916',N'Thanh Hóa',N'Nam'),('KH51',N'Nguyễn Đình Linh','19960314','5907774068',N'Thanh Hóa',N'Nam'),('KH52',N'Nguyễn Đình Anh','19850327','3385911903',N'Hà Nội',N'Nam'),('KH53',N'Nguyễn Đình Đức','19500623','6446786354',N'Thanh Hóa',N'Nam'),('KH54',N'Nguyễn Đình Quỳnh','19550910','7120459649',N'Sài Gòn',N'Nữ'),('KH55',N'Nguyễn Đình Nga','19531126','6393542548',N'Hà Tĩnh',N'Nữ'),('KH56',N'Nguyễn Đình Tá','20010506','9874760663',N'Hải Dương',N'Nữ'),('KH57',N'Nguyễn Đình Thắng','19680821','6037045263',N'Hà Nội',N'Nam'),('KH58',N'Nguyễn Đình Hà','20040617','8856011265',N'Hà Nội',N'Nam'),('KH59',N'Nguyễn Đình Tú','19990220','2441850087',N'Hà Tĩnh',N'Nam'),('KH60',N'Nguyễn Đình Phong','19870116','6935345645',N'Thanh Hóa',N'Nam'),('KH61',N'Phạm Trọng Linh','19850703','3569128482',N'Hải Dương',N'Nam'),('KH62',N'Phạm Trọng Anh','19560721','2438697159',N'Hải Dương',N'Nam'),('KH63',N'Phạm Trọng Đức','19910403','4128360018',N'Hải Dương',N'Nam'),('KH64',N'Phạm Trọng Quỳnh','19970602','2057664959',N'Hà Tĩnh',N'Nữ'),('KH65',N'Phạm Trọng Nga','20010318','9961758846',N'Nam Định',N'Nữ'),('KH66',N'Phạm Trọng Tá','19830610','8278178559',N'Nam Định',N'Nữ'),('KH67',N'Phạm Trọng Thắng','19501121','5292646038',N'Bà Rịa',N'Nữ'),('KH68',N'Phạm Trọng Hà','19670526','8562530621',N'Sơn Tây',N'Nam'),('KH69',N'Phạm Trọng Tú','19590122','6352168483',N'Thanh Hóa',N'Nam'),('KH70',N'Phạm Trọng Phong','19590206','4831292827',N'Nghệ An',N'Nữ'),('KH71',N'Phạm Bá Linh','19800904','8145892673',N'Bà Rịa',N'Nữ'),('KH72',N'Phạm Bá Anh','19860423','2892191294',N'Sơn Tây',N'Nữ'),('KH73',N'Phạm Bá Đức','19580816','3822455957',N'Bà Rịa',N'Nam'),('KH74',N'Phạm Bá Quỳnh','19620712','2007687370',N'Vĩnh Phúc',N'Nữ'),('KH75',N'Phạm Bá Nga','19520623','5320927604',N'Sài Gòn',N'Nữ'),('KH76',N'Phạm Bá Tá','19520921','3794717242',N'Nghệ An',N'Nữ'),('KH77',N'Phạm Bá Thắng','19711115','7718761474',N'Hà Tĩnh',N'Nam'),('KH78',N'Phạm Bá Hà','19560701','4687077462',N'Nam Định',N'Nam'),('KH79',N'Phạm Bá Tú','19880809','1530257130',N'Bà Rịa',N'Nữ'),('KH80',N'Phạm Bá Phong','19911116','7369095085',N'Hà Nội',N'Nữ'),('KH81',N'Phạm Đức Linh','19500903','4871432402',N'Bà Rịa',N'Nữ'),('KH82',N'Phạm Đức Anh','19701023','3589662871',N'Thanh Hóa',N'Nữ'),('KH83',N'Phạm Đức Đức','19541026','5014067077',N'Thanh Hóa',N'Nam'),('KH84',N'Phạm Đức Quỳnh','19640510','6011181036',N'Sài Gòn',N'Nữ'),('KH85',N'Phạm Đức Nga','19521118','6638758131',N'Thanh Hóa',N'Nữ'),('KH86',N'Phạm Đức Tá','20051003','5505961687',N'Hà Tĩnh',N'Nữ'),('KH87',N'Phạm Đức Thắng','19930609','9425739494',N'Sơn Tây',N'Nam'),('KH88',N'Phạm Đức Hà','19640818','3800865077',N'Sơn Tây',N'Nam'),('KH89',N'Phạm Đức Tú','19990921','5136579886',N'Hà Tĩnh',N'Nữ'),('KH90',N'Phạm Đức Phong','19870209','1473995944',N'Hà Nội',N'Nữ'),('KH91',N'Phạm Văn Linh','20031003','1538984243',N'Hải Dương',N'Nữ'),('KH92',N'Phạm Văn Anh','19850113','5154117191',N'Sơn Tây',N'Nam'),('KH93',N'Phạm Văn Đức','19671121','9305366906',N'Thanh Hóa',N'Nam'),('KH94',N'Phạm Văn Quỳnh','19520403','8180013355',N'Sơn Tây',N'Nam'),('KH95',N'Phạm Văn Nga','20001103','4354882718',N'Hải Dương',N'Nữ'),('KH96',N'Phạm Văn Tá','19640709','8083262731',N'Thanh Hóa',N'Nữ'),('KH97',N'Phạm Văn Thắng','20060307','7269480648',N'Hà Tĩnh',N'Nam'),('KH98',N'Phạm Văn Hà','19570710','3903766394',N'Bà Rịa',N'Nam'),('KH99',N'Phạm Văn Tú','19641125','8088844240',N'Hà Tĩnh',N'Nam'),('KH100',N'Phạm Văn Phong','19550520','3447162508',N'Thanh Hóa',N'Nam'),('KH101',N'Phạm Thị Linh','19570602','1417513160',N'Thanh Hóa',N'Nam'),('KH102',N'Phạm Thị Anh','19551002','3270528660',N'Vĩnh Phúc',N'Nam'),('KH103',N'Phạm Thị Đức','19520921','2632451387',N'Nam Định',N'Nữ'),('KH104',N'Phạm Thị Quỳnh','20060527','2849180350',N'Hà Tĩnh',N'Nữ'),('KH105',N'Phạm Thị Nga','19740625','2814027807',N'Bà Rịa',N'Nam'),('KH106',N'Phạm Thị Tá','19650427','6323438454',N'Nam Định',N'Nam'),('KH107',N'Phạm Thị Thắng','19801005','2557954390',N'Hà Tĩnh',N'Nữ'),('KH108',N'Phạm Thị Hà','19551102','2112120876',N'Sơn Tây',N'Nam'),('KH109',N'Phạm Thị Tú','19970104','3280883605',N'Vĩnh Phúc',N'Nam'),('KH110',N'Phạm Thị Phong','19520219','1085244623',N'Nam Định',N'Nam'),('KH111',N'Phạm Đình Linh','19830921','2293296499',N'Thanh Hóa',N'Nữ'),('KH112',N'Phạm Đình Anh','19511013','3596012029',N'Hải Dương',N'Nữ'),('KH113',N'Phạm Đình Đức','19541010','1693192159',N'Hà Nội',N'Nam'),('KH114',N'Phạm Đình Quỳnh','19691012','5484728019',N'Bà Rịa',N'Nữ'),('KH115',N'Phạm Đình Nga','19590614','1976733836',N'Vĩnh Phúc',N'Nam'),('KH116',N'Phạm Đình Tá','20050314','2437645037',N'Thanh Hóa',N'Nam'),('KH117',N'Phạm Đình Thắng','20050822','8157690254',N'Sơn Tây',N'Nam'),('KH118',N'Phạm Đình Hà','20030427','5246238126',N'Hải Dương',N'Nữ'),('KH119',N'Phạm Đình Tú','19860407','7847969287',N'Sơn Tây',N'Nam'),('KH120',N'Phạm Đình Phong','19601124','7819125306',N'Nam Định',N'Nữ'),('KH121',N'Trần Trọng Linh','20021003','5712258732',N'Sài Gòn',N'Nam'),('KH122',N'Trần Trọng Anh','19900711','3776498967',N'Thanh Hóa',N'Nam'),('KH123',N'Trần Trọng Đức','19860607','9570986407',N'Nam Định',N'Nữ'),('KH124',N'Trần Trọng Quỳnh','19720310','7574970744',N'Sài Gòn',N'Nữ'),('KH125',N'Trần Trọng Nga','19521122','7494754695',N'Hà Tĩnh',N'Nữ'),('KH126',N'Trần Trọng Tá','20041001','7939238306',N'Bà Rịa',N'Nữ'),('KH127',N'Trần Trọng Thắng','19751026','7031842304',N'Hải Dương',N'Nam'),('KH128',N'Trần Trọng Hà','19950815','3889798819',N'Hà Tĩnh',N'Nữ'),('KH129',N'Trần Trọng Tú','19950914','8798715221',N'Thanh Hóa',N'Nữ'),('KH130',N'Trần Trọng Phong','19830718','5427282602',N'Hà Tĩnh',N'Nữ'),('KH131',N'Trần Bá Linh','19600319','5810164453',N'Hải Dương',N'Nam'),('KH132',N'Trần Bá Anh','19530526','3843973080',N'Hải Dương',N'Nam'),('KH133',N'Trần Bá Đức','19720307','5587498030',N'Sài Gòn',N'Nam'),('KH134',N'Trần Bá Quỳnh','20010605','3308530200',N'Hà Nội',N'Nam'),('KH135',N'Trần Bá Nga','19600424','5970061146',N'Sơn Tây',N'Nam'),('KH136',N'Trần Bá Tá','19941017','4436651846',N'Hải Dương',N'Nam'),('KH137',N'Trần Bá Thắng','19810720','4213934002',N'Nam Định',N'Nam'),('KH138',N'Trần Bá Hà','20050506','8457173839',N'Nghệ An',N'Nữ'),('KH139',N'Trần Bá Tú','19650608','4425227055',N'Hà Nội',N'Nam'),('KH140',N'Trần Bá Phong','19930124','2193445582',N'Sơn Tây',N'Nam'),('KH141',N'Trần Đức Linh','19570717','5618473852',N'Bà Rịa',N'Nữ'),('KH142',N'Trần Đức Anh','20010510','9619767640',N'Sài Gòn',N'Nữ'),('KH143',N'Trần Đức Đức','19910806','8730537350',N'Bà Rịa',N'Nam'),('KH144',N'Trần Đức Quỳnh','19500414','3479022166',N'Hải Dương',N'Nam'),('KH145',N'Trần Đức Nga','19621022','8841855327',N'Sài Gòn',N'Nữ'),('KH146',N'Trần Đức Tá','19670724','9998580808',N'Bà Rịa',N'Nam'),('KH147',N'Trần Đức Thắng','19741111','5941322136',N'Hải Dương',N'Nam'),('KH148',N'Trần Đức Hà','19650802','1823126078',N'Hà Nội',N'Nam'),('KH149',N'Trần Đức Tú','19630204','6168653487',N'Thanh Hóa',N'Nữ'),('KH150',N'Trần Đức Phong','19540719','2231398698',N'Hà Nội',N'Nam'),('KH151',N'Trần Văn Linh','19980412','5654191687',N'Hải Dương',N'Nam'),('KH152',N'Trần Văn Anh','19910216','1002998645',N'Hà Nội',N'Nam'),('KH153',N'Trần Văn Đức','19940926','3924890391',N'Nghệ An',N'Nam'),('KH154',N'Trần Văn Quỳnh','19740903','3732042483',N'Nghệ An',N'Nam'),('KH155',N'Trần Văn Nga','19730810','2343732726',N'Hải Dương',N'Nam'),('KH156',N'Trần Văn Tá','19820712','3438986964',N'Sơn Tây',N'Nữ'),('KH157',N'Trần Văn Thắng','19820714','5484040971',N'Thanh Hóa',N'Nữ'),('KH158',N'Trần Văn Hà','19960809','1830650929',N'Hà Tĩnh',N'Nữ'),('KH159',N'Trần Văn Tú','19620412','5920470444',N'Hà Nội',N'Nam'),('KH160',N'Trần Văn Phong','19980309','7591981532',N'Sơn Tây',N'Nam'),('KH161',N'Trần Thị Linh','19530606','1342775482',N'Thanh Hóa',N'Nam'),('KH162',N'Trần Thị Anh','19950723','1151221865',N'Nghệ An',N'Nữ'),('KH163',N'Trần Thị Đức','19530117','8179668933',N'Bà Rịa',N'Nam'),('KH164',N'Trần Thị Quỳnh','19911110','2651979089',N'Nghệ An',N'Nam'),('KH165',N'Trần Thị Nga','19930320','5943762790',N'Bà Rịa',N'Nam'),('KH166',N'Trần Thị Tá','19530221','7544623315',N'Thanh Hóa',N'Nữ'),('KH167',N'Trần Thị Thắng','19800712','5857958034',N'Thanh Hóa',N'Nam'),('KH168',N'Trần Thị Hà','20030822','2259918142',N'Sơn Tây',N'Nữ'),('KH169',N'Trần Thị Tú','19981009','9639194886',N'Sơn Tây',N'Nam'),('KH170',N'Trần Thị Phong','19760202','5907384639',N'Bà Rịa',N'Nữ'),('KH171',N'Trần Đình Linh','19541001','5561836597',N'Nghệ An',N'Nam'),('KH172',N'Trần Đình Anh','19861106','3105519169',N'Hà Nội',N'Nam'),('KH173',N'Trần Đình Đức','19731123','5464890305',N'Hà Tĩnh',N'Nam'),('KH174',N'Trần Đình Quỳnh','19930506','2842760503',N'Nam Định',N'Nam'),('KH175',N'Trần Đình Nga','20060502','7339368944',N'Hải Dương',N'Nữ'),('KH176',N'Trần Đình Tá','19860924','8154334861',N'Vĩnh Phúc',N'Nữ'),('KH177',N'Trần Đình Thắng','19910206','8571780151',N'Sơn Tây',N'Nam'),('KH178',N'Trần Đình Hà','19520302','9433224356',N'Hà Tĩnh',N'Nam'),('KH179',N'Trần Đình Tú','19670909','7609322816',N'Sài Gòn',N'Nữ'),('KH180',N'Trần Đình Phong','19800218','5022382945',N'Hà Tĩnh',N'Nam'),('KH181',N'Trịnh Trọng Linh','19891121','6544452841',N'Nam Định',N'Nam'),('KH182',N'Trịnh Trọng Anh','19701102','8035155791',N'Hải Dương',N'Nam'),('KH183',N'Trịnh Trọng Đức','19930126','5458764976',N'Thanh Hóa',N'Nữ'),('KH184',N'Trịnh Trọng Quỳnh','19530709','2204428960',N'Nam Định',N'Nam'),('KH185',N'Trịnh Trọng Nga','19720706','9720434652',N'Hà Nội',N'Nam'),('KH186',N'Trịnh Trọng Tá','19680410','7151437770',N'Vĩnh Phúc',N'Nữ'),('KH187',N'Trịnh Trọng Thắng','20040326','6702472285',N'Thanh Hóa',N'Nam'),('KH188',N'Trịnh Trọng Hà','20040821','2796923976',N'Vĩnh Phúc',N'Nam'),('KH189',N'Trịnh Trọng Tú','19770518','3388015002',N'Hải Dương',N'Nam'),('KH190',N'Trịnh Trọng Phong','19961027','3113827242',N'Sài Gòn',N'Nữ'),('KH191',N'Trịnh Bá Linh','19960713','3720640160',N'Vĩnh Phúc',N'Nam'),('KH192',N'Trịnh Bá Anh','19780503','5667389628',N'Sơn Tây',N'Nữ'),('KH193',N'Trịnh Bá Đức','19930512','2067692116',N'Sơn Tây',N'Nữ'),('KH194',N'Trịnh Bá Quỳnh','19730823','3276784908',N'Nam Định',N'Nam'),('KH195',N'Trịnh Bá Nga','19721104','5504355442',N'Thanh Hóa',N'Nam'),('KH196',N'Trịnh Bá Tá','20010404','8381597809',N'Vĩnh Phúc',N'Nam'),('KH197',N'Trịnh Bá Thắng','19920627','2537347223',N'Nghệ An',N'Nam'),('KH198',N'Trịnh Bá Hà','19560602','3512417497',N'Sơn Tây',N'Nữ'),('KH199',N'Trịnh Bá Tú','19520711','5525080846',N'Sơn Tây',N'Nam'),('KH200',N'Trịnh Bá Phong','19511103','4418652333',N'Bà Rịa',N'Nam'),('KH201',N'Trịnh Đức Linh','19670424','9430675534',N'Bà Rịa',N'Nam'),('KH202',N'Trịnh Đức Anh','19541019','4768483512',N'Hà Nội',N'Nam'),('KH203',N'Trịnh Đức Đức','19620208','4794556781',N'Hải Dương',N'Nữ'),('KH204',N'Trịnh Đức Quỳnh','19680923','2696330288',N'Hà Tĩnh',N'Nữ'),('KH205',N'Trịnh Đức Nga','19951020','9488883710',N'Hải Dương',N'Nam'),('KH206',N'Trịnh Đức Tá','19690223','4196119157',N'Bà Rịa',N'Nữ'),('KH207',N'Trịnh Đức Thắng','19540827','9733288794',N'Sài Gòn',N'Nữ'),('KH208',N'Trịnh Đức Hà','20041022','9555158073',N'Thanh Hóa',N'Nữ'),('KH209',N'Trịnh Đức Tú','19920127','5524623822',N'Hà Tĩnh',N'Nữ'),('KH210',N'Trịnh Đức Phong','19771108','9980174245',N'Hải Dương',N'Nữ'),('KH211',N'Trịnh Văn Linh','19530624','4762455138',N'Sài Gòn',N'Nam'),('KH212',N'Trịnh Văn Anh','19621007','4149268585',N'Hà Tĩnh',N'Nam'),('KH213',N'Trịnh Văn Đức','20061123','3563689416',N'Hà Tĩnh',N'Nam'),('KH214',N'Trịnh Văn Quỳnh','19981017','9533319479',N'Bà Rịa',N'Nữ'),('KH215',N'Trịnh Văn Nga','20050817','2454978292',N'Sài Gòn',N'Nam'),('KH216',N'Trịnh Văn Tá','19801125','1293550738',N'Nghệ An',N'Nam'),('KH217',N'Trịnh Văn Thắng','19580915','5523592480',N'Sài Gòn',N'Nam'),('KH218',N'Trịnh Văn Hà','19900614','8482759943',N'Bà Rịa',N'Nữ'),('KH219',N'Trịnh Văn Tú','19760406','4565826448',N'Hải Dương',N'Nam'),('KH220',N'Trịnh Văn Phong','19600707','9029277225',N'Bà Rịa',N'Nam'),('KH221',N'Trịnh Thị Linh','19641113','4867821845',N'Hà Nội',N'Nam'),('KH222',N'Trịnh Thị Anh','19750119','2699887392',N'Bà Rịa',N'Nam'),('KH223',N'Trịnh Thị Đức','19680208','2834825221',N'Bà Rịa',N'Nữ'),('KH224',N'Trịnh Thị Quỳnh','19860802','3429036094',N'Sài Gòn',N'Nam'),('KH225',N'Trịnh Thị Nga','19840427','2525528674',N'Sài Gòn',N'Nữ'),('KH226',N'Trịnh Thị Tá','19720113','4809779536',N'Nghệ An',N'Nam'),('KH227',N'Trịnh Thị Thắng','19610601','3905552782',N'Sài Gòn',N'Nam'),('KH228',N'Trịnh Thị Hà','19891124','6200498279',N'Nam Định',N'Nam'),('KH229',N'Trịnh Thị Tú','19590517','8575015996',N'Sài Gòn',N'Nữ'),('KH230',N'Trịnh Thị Phong','19510923','6871779447',N'Hà Tĩnh',N'Nam'),('KH231',N'Trịnh Đình Linh','19940926','4568426857',N'Thanh Hóa',N'Nam'),('KH232',N'Trịnh Đình Anh','20030112','8331095553',N'Hà Tĩnh',N'Nam'),('KH233',N'Trịnh Đình Đức','19830225','3039365446',N'Hải Dương',N'Nữ'),('KH234',N'Trịnh Đình Quỳnh','19831007','7354061571',N'Thanh Hóa',N'Nữ'),('KH235',N'Trịnh Đình Nga','19880306','7333435870',N'Nam Định',N'Nam'),('KH236',N'Trịnh Đình Tá','19601125','8142297166',N'Vĩnh Phúc',N'Nam'),('KH237',N'Trịnh Đình Thắng','19510306','2044140788',N'Thanh Hóa',N'Nữ'),('KH238',N'Trịnh Đình Hà','19741112','2400050120',N'Thanh Hóa',N'Nữ'),('KH239',N'Trịnh Đình Tú','19890806','6528497390',N'Nam Định',N'Nữ'),('KH240',N'Trịnh Đình Phong','19560308','6968330496',N'Vĩnh Phúc',N'Nam'),('KH241',N'Thái Trọng Linh','19740112','6827823862',N'Hải Dương',N'Nữ'),('KH242',N'Thái Trọng Anh','19830115','3078296451',N'Vĩnh Phúc',N'Nam'),('KH243',N'Thái Trọng Đức','19810907','8574892663',N'Hải Dương',N'Nam'),('KH244',N'Thái Trọng Quỳnh','19600814','9977574485',N'Nghệ An',N'Nữ'),('KH245',N'Thái Trọng Nga','19751125','2029243224',N'Thanh Hóa',N'Nữ'),('KH246',N'Thái Trọng Tá','19780127','3625829044',N'Hải Dương',N'Nữ'),('KH247',N'Thái Trọng Thắng','19710803','1093830935',N'Nghệ An',N'Nam'),('KH248',N'Thái Trọng Hà','19960116','3783189066',N'Sài Gòn',N'Nam'),('KH249',N'Thái Trọng Tú','19871107','4937578024',N'Bà Rịa',N'Nam'),('KH250',N'Thái Trọng Phong','19560804','6322672965',N'Nam Định',N'Nữ'),('KH251',N'Thái Bá Linh','19810302','7361994344',N'Nghệ An',N'Nam'),('KH252',N'Thái Bá Anh','20060522','5355094390',N'Thanh Hóa',N'Nữ'),('KH253',N'Thái Bá Đức','19950418','5415656529',N'Nghệ An',N'Nam'),('KH254',N'Thái Bá Quỳnh','19980924','5101962510',N'Nghệ An',N'Nam'),('KH255',N'Thái Bá Nga','19731108','5796827498',N'Bà Rịa',N'Nữ'),('KH256',N'Thái Bá Tá','19840608','9472141456',N'Hải Dương',N'Nữ'),('KH257',N'Thái Bá Thắng','20040618','8363232280',N'Vĩnh Phúc',N'Nam'),('KH258',N'Thái Bá Hà','19550609','2643580697',N'Hà Tĩnh',N'Nữ'),('KH259',N'Thái Bá Tú','19640319','4183311788',N'Hà Nội',N'Nam'),('KH260',N'Thái Bá Phong','20040616','7689275427',N'Vĩnh Phúc',N'Nữ'),('KH261',N'Thái Đức Linh','19810406','2507341603',N'Nghệ An',N'Nam'),('KH262',N'Thái Đức Anh','19860325','4023043869',N'Bà Rịa',N'Nam'),('KH263',N'Thái Đức Đức','19691109','4679918356',N'Hải Dương',N'Nam'),('KH264',N'Thái Đức Quỳnh','19830710','3966726496',N'Vĩnh Phúc',N'Nữ'),('KH265',N'Thái Đức Nga','19540201','5685115831',N'Thanh Hóa',N'Nam'),('KH266',N'Thái Đức Tá','19500215','4909416864',N'Hải Dương',N'Nữ'),('KH267',N'Thái Đức Thắng','19510917','6791840288',N'Sài Gòn',N'Nữ'),('KH268',N'Thái Đức Hà','19690317','6707087065',N'Thanh Hóa',N'Nữ'),('KH269',N'Thái Đức Tú','19971026','2510752000',N'Nam Định',N'Nam'),('KH270',N'Thái Đức Phong','19961016','3803734123',N'Nam Định',N'Nữ'),('KH271',N'Thái Văn Linh','20050910','1149113261',N'Nam Định',N'Nữ'),('KH272',N'Thái Văn Anh','19890916','8620621937',N'Nam Định',N'Nữ'),('KH273',N'Thái Văn Đức','20000520','2876596654',N'Nam Định',N'Nam'),('KH274',N'Thái Văn Quỳnh','19650705','6486389074',N'Sơn Tây',N'Nữ'),('KH275',N'Thái Văn Nga','19680106','1616569206',N'Bà Rịa',N'Nam'),('KH276',N'Thái Văn Tá','19850310','8380322373',N'Hà Nội',N'Nam'),('KH277',N'Thái Văn Thắng','19680505','4006299810',N'Hải Dương',N'Nam'),('KH278',N'Thái Văn Hà','19551026','3746795448',N'Nghệ An',N'Nam'),('KH279',N'Thái Văn Tú','19730220','2418651959',N'Sơn Tây',N'Nữ'),('KH280',N'Thái Văn Phong','19940510','5273066493',N'Nam Định',N'Nam'),('KH281',N'Thái Thị Linh','19720508','8428042331',N'Vĩnh Phúc',N'Nam'),('KH282',N'Thái Thị Anh','19650126','8926266874',N'Thanh Hóa',N'Nam'),('KH283',N'Thái Thị Đức','19930407','7375722382',N'Nam Định',N'Nam'),('KH284',N'Thái Thị Quỳnh','19870806','7041220713',N'Thanh Hóa',N'Nam'),('KH285',N'Thái Thị Nga','19980915','4331690374',N'Nam Định',N'Nam'),('KH286',N'Thái Thị Tá','19770820','6311650151',N'Sài Gòn',N'Nam'),('KH287',N'Thái Thị Thắng','19650904','8508353432',N'Thanh Hóa',N'Nam'),('KH288',N'Thái Thị Hà','19930201','5411015019',N'Hà Nội',N'Nữ'),('KH289',N'Thái Thị Tú','19580120','3161774491',N'Vĩnh Phúc',N'Nam'),('KH290',N'Thái Thị Phong','19790512','7649913809',N'Bà Rịa',N'Nữ'),('KH291',N'Thái Đình Linh','19560608','7223039470',N'Sài Gòn',N'Nữ'),('KH292',N'Thái Đình Anh','19970111','6728097153',N'Sài Gòn',N'Nữ'),('KH293',N'Thái Đình Đức','20000603','8535439651',N'Bà Rịa',N'Nữ'),('KH294',N'Thái Đình Quỳnh','19691109','7565882456',N'Sài Gòn',N'Nam'),('KH295',N'Thái Đình Nga','19550821','4962270424',N'Thanh Hóa',N'Nữ'),('KH296',N'Thái Đình Tá','19950918','7554814908',N'Sơn Tây',N'Nữ'),('KH297',N'Thái Đình Thắng','19840409','7733631868',N'Nghệ An',N'Nữ'),('KH298',N'Thái Đình Hà','20010418','7415616677',N'Hà Nội',N'Nữ'),('KH299',N'Thái Đình Tú','20041121','5701316337',N'Nghệ An',N'Nam'),('KH300',N'Thái Đình Phong','19610721','3672850557',N'Hà Nội',N'Nữ'),('KH301',N'Huỳnh Trọng Linh','19560503','3474388608',N'Hà Tĩnh',N'Nữ'),('KH302',N'Huỳnh Trọng Anh','20050121','6058741427',N'Thanh Hóa',N'Nam'),('KH303',N'Huỳnh Trọng Đức','19910206','6374752119',N'Hà Nội',N'Nữ'),('KH304',N'Huỳnh Trọng Quỳnh','19611023','9857037901',N'Hà Tĩnh',N'Nữ'),('KH305',N'Huỳnh Trọng Nga','19750712','8131054415',N'Hà Nội',N'Nữ'),('KH306',N'Huỳnh Trọng Tá','19740722','2806745063',N'Sơn Tây',N'Nữ'),('KH307',N'Huỳnh Trọng Thắng','20040127','7490913955',N'Sài Gòn',N'Nam'),('KH308',N'Huỳnh Trọng Hà','19890713','9843697926',N'Hà Nội',N'Nữ'),('KH309',N'Huỳnh Trọng Tú','19660325','6070710665',N'Sài Gòn',N'Nam'),('KH310',N'Huỳnh Trọng Phong','19930415','8701046655',N'Nghệ An',N'Nữ'),('KH311',N'Huỳnh Bá Linh','19720508','1705628630',N'Sơn Tây',N'Nữ'),('KH312',N'Huỳnh Bá Anh','19641007','3394667835',N'Hải Dương',N'Nam'),('KH313',N'Huỳnh Bá Đức','19961121','5648814988',N'Nam Định',N'Nam'),('KH314',N'Huỳnh Bá Quỳnh','19861004','4439795613',N'Nghệ An',N'Nữ'),('KH315',N'Huỳnh Bá Nga','19990506','6729951352',N'Sơn Tây',N'Nam'),('KH316',N'Huỳnh Bá Tá','20010209','7929527815',N'Bà Rịa',N'Nam'),('KH317',N'Huỳnh Bá Thắng','19660801','4282971949',N'Thanh Hóa',N'Nam'),('KH318',N'Huỳnh Bá Hà','19690926','4166727925',N'Hải Dương',N'Nữ'),('KH319',N'Huỳnh Bá Tú','19890221','3301637798',N'Vĩnh Phúc',N'Nam'),('KH320',N'Huỳnh Bá Phong','19850111','2648240771',N'Sơn Tây',N'Nữ'),('KH321',N'Huỳnh Đức Linh','19920525','8717164611',N'Sài Gòn',N'Nam'),('KH322',N'Huỳnh Đức Anh','19500210','3366419931',N'Hải Dương',N'Nữ'),('KH323',N'Huỳnh Đức Đức','19660315','3342665257',N'Hà Tĩnh',N'Nam'),('KH324',N'Huỳnh Đức Quỳnh','19790606','9001557916',N'Sài Gòn',N'Nữ'),('KH325',N'Huỳnh Đức Nga','19600719','4117757207',N'Hà Tĩnh',N'Nam'),('KH326',N'Huỳnh Đức Tá','19780116','6331342963',N'Hải Dương',N'Nam'),('KH327',N'Huỳnh Đức Thắng','20060519','2786790213',N'Bà Rịa',N'Nữ'),('KH328',N'Huỳnh Đức Hà','20021010','7551332122',N'Bà Rịa',N'Nữ'),('KH329',N'Huỳnh Đức Tú','20050807','1669594017',N'Hà Tĩnh',N'Nam'),('KH330',N'Huỳnh Đức Phong','20020823','6272267846',N'Nam Định',N'Nam'),('KH331',N'Huỳnh Văn Linh','19881122','3229342030',N'Hà Nội',N'Nam'),('KH332',N'Huỳnh Văn Anh','19890615','6770132354',N'Bà Rịa',N'Nữ'),('KH333',N'Huỳnh Văn Đức','19850407','3508592635',N'Thanh Hóa',N'Nam'),('KH334',N'Huỳnh Văn Quỳnh','19790415','4894468432',N'Nghệ An',N'Nữ'),('KH335',N'Huỳnh Văn Nga','19841003','3236745384',N'Hà Tĩnh',N'Nữ'),('KH336',N'Huỳnh Văn Tá','19770707','9009173765',N'Bà Rịa',N'Nam'),('KH337',N'Huỳnh Văn Thắng','19740808','7166286713',N'Bà Rịa',N'Nam'),('KH338',N'Huỳnh Văn Hà','19670709','7521092276',N'Sơn Tây',N'Nữ'),('KH339',N'Huỳnh Văn Tú','19960305','7359653150',N'Nam Định',N'Nữ'),('KH340',N'Huỳnh Văn Phong','19720503','8696921605',N'Sơn Tây',N'Nữ'),('KH341',N'Huỳnh Thị Linh','19720104','2886968323',N'Vĩnh Phúc',N'Nữ'),('KH342',N'Huỳnh Thị Anh','19920303','8171882477',N'Nam Định',N'Nam'),('KH343',N'Huỳnh Thị Đức','19790909','5310684688',N'Nam Định',N'Nam'),('KH344',N'Huỳnh Thị Quỳnh','19600218','3061446068',N'Thanh Hóa',N'Nam'),('KH345',N'Huỳnh Thị Nga','19970302','7510891595',N'Nghệ An',N'Nữ'),('KH346',N'Huỳnh Thị Tá','19790225','3395366686',N'Sài Gòn',N'Nam'),('KH347',N'Huỳnh Thị Thắng','20010102','7067198163',N'Thanh Hóa',N'Nữ'),('KH348',N'Huỳnh Thị Hà','19710924','3691551312',N'Thanh Hóa',N'Nữ'),('KH349',N'Huỳnh Thị Tú','20050606','3225473629',N'Nam Định',N'Nam'),('KH350',N'Huỳnh Thị Phong','19540125','9088183691',N'Hà Tĩnh',N'Nữ'),('KH351',N'Huỳnh Đình Linh','19620501','2800149514',N'Hải Dương',N'Nam'),('KH352',N'Huỳnh Đình Anh','19810708','4790315550',N'Nghệ An',N'Nam'),('KH353',N'Huỳnh Đình Đức','19740213','5028219020',N'Hà Tĩnh',N'Nữ'),('KH354',N'Huỳnh Đình Quỳnh','19510815','9305558681',N'Sài Gòn',N'Nam'),('KH355',N'Huỳnh Đình Nga','19940223','2447275466',N'Hà Nội',N'Nam'),('KH356',N'Huỳnh Đình Tá','19551005','1179828522',N'Sơn Tây',N'Nữ'),('KH357',N'Huỳnh Đình Thắng','19971112','6807980612',N'Hà Tĩnh',N'Nữ'),('KH358',N'Huỳnh Đình Hà','19750618','7467111669',N'Sài Gòn',N'Nữ'),('KH359',N'Huỳnh Đình Tú','19650606','9083237487',N'Hà Nội',N'Nam'),('KH360',N'Huỳnh Đình Phong','19640522','4008259541',N'Hà Nội',N'Nam')

 -- thêm dữ liệu cho bảng bàn 
declare @i int = 1
while @i <=20
begin
	insert Ban(SoGhe , TrangThai) values(4, N'Trống')
	set @i = @i + 1
end
go
declare @k int = 1
while @k <=10
begin
	insert Ban(SoGhe , TrangThai) values(8, N'Trống')
	set @k = @k + 1
end
go
----------------------------------------------------------------------------- hÓA ĐƠN ----------------------------------------------------------------------------------------------------------
insert into HoaDon(id_HoaDon, id_NhanVien, id_KhachHang , NgayTao, TongGia, TinhTrang,KhuyenMai)
values ('HD1','NV01','KH241','20190520',0,1,19),('HD2','NV01','KH224','20180727',0,1,4),('HD3','NV01','KH167','20181001',0,1,77),('HD4','NV01','KH337','20190216',0,1,69),('HD5','NV01','KH122','20180306',0,1,42),('HD6','NV01','KH83','20170408',0,1,41),('HD7','NV01','KH128','20180518',0,1,33),('HD8','NV01','KH107','20190415',0,1,78),('HD9','NV01','KH133','20190317',0,1,43),('HD10','NV01','KH242','20171019',0,1,56),('HD11','NV01','KH135','20180817',0,1,20),('HD12','NV01','KH173','20180304',0,1,1),('HD13','NV01','KH108','20170319',0,1,55),('HD14','NV01','KH9','20190317',0,1,54),('HD15','NV01','KH225','20190717',0,1,40),('HD16','NV01','KH45','20170714',0,1,68),('HD17','NV01','KH138','20180806',0,1,12),('HD18','NV01','KH247','20171002',0,1,73),('HD19','NV01','KH37','20190303',0,1,55),('HD20','NV01','KH36','20170615',0,1,41),('HD21','NV01','KH160','20180320',0,1,7),('HD22','NV01','KH276','20170124',0,1,10),('HD23','NV01','KH320','20180802',0,1,49),('HD24','NV01','KH234','20190104',0,1,1),('HD25','NV01','KH73','20170212',0,1,46),('HD26','NV01','KH157','20170618',0,1,32),('HD27','NV01','KH217','20180114',0,1,33),('HD28','NV01','KH50','20181122',0,1,30),('HD29','NV01','KH224','20171101',0,1,3),('HD30','NV01','KH147','20180214',0,1,3),('HD31','NV01','KH9','20170517',0,1,25),('HD32','NV01','KH103','20190919',0,1,51),('HD33','NV01','KH88','20180522',0,1,41),('HD34','NV01','KH298','20170314',0,1,39),('HD35','NV01','KH256','20180417',0,1,30),('HD36','NV01','KH91','20170211',0,1,14),('HD37','NV01','KH107','20170108',0,1,30),('HD38','NV01','KH72','20170514',0,1,11),('HD39','NV01','KH116','20190326',0,1,11),('HD40','NV01','KH70','20180210',0,1,17),('HD41','NV01','KH75','20190809',0,1,26),('HD42','NV01','KH266','20180902',0,1,5),('HD43','NV01','KH47','20180518',0,1,28),('HD44','NV01','KH76','20170222',0,1,25),('HD45','NV01','KH138','20170807',0,1,13),('HD46','NV01','KH158','20180422',0,1,15),('HD47','NV01','KH40','20190923',0,1,76),('HD48','NV01','KH235','20190812',0,1,51),('HD49','NV01','KH154','20170524',0,1,79),('HD50','NV01','KH320','20180708',0,1,73),('HD51','NV01','KH18','20170402',0,1,66),('HD52','NV01','KH178','20190508',0,1,70),('HD53','NV01','KH148','20181118',0,1,75),('HD54','NV01','KH114','20190724',0,1,55),('HD55','NV01','KH177','20180903',0,1,71),('HD56','NV01','KH358','20171002',0,1,22),('HD57','NV01','KH298','20180108',0,1,11),('HD58','NV01','KH269','20190917',0,1,37),('HD59','NV01','KH89','20190520',0,1,18),('HD60','NV01','KH157','20170912',0,1,54),('HD61','NV01','KH110','20190916',0,1,34),('HD62','NV01','KH114','20170411',0,1,66),('HD63','NV01','KH228','20180506',0,1,5),('HD64','NV01','KH134','20170804',0,1,16),('HD65','NV01','KH198','20171124',0,1,36),('HD66','NV01','KH14','20180107',0,1,36),('HD67','NV01','KH91','20180522',0,1,76),('HD68','NV01','KH26','20170613',0,1,65),('HD69','NV01','KH168','20170508',0,1,66),('HD70','NV01','KH316','20190308',0,1,68),('HD71','NV01','KH261','20170703',0,1,11),('HD72','NV01','KH125','20181010',0,1,31),('HD73','NV01','KH106','20190127',0,1,46),('HD74','NV01','KH66','20180723',0,1,78),('HD75','NV01','KH330','20180302',0,1,58),('HD76','NV01','KH64','20180820',0,1,45),('HD77','NV01','KH286','20180914',0,1,58),('HD78','NV01','KH235','20170420',0,1,49),('HD79','NV01','KH70','20190204',0,1,42),('HD80','NV01','KH157','20180512',0,1,52),('HD81','NV01','KH109','20190522',0,1,75),('HD82','NV01','KH178','20170617',0,1,76),('HD83','NV01','KH246','20190226',0,1,47),('HD84','NV01','KH191','20170611',0,1,73),('HD85','NV01','KH297','20191016',0,1,63),('HD86','NV01','KH290','20190211',0,1,24),('HD87','NV01','KH276','20190304',0,1,22),('HD88','NV01','KH140','20181119',0,1,19),('HD89','NV01','KH46','20170912',0,1,74),('HD90','NV01','KH15','20170209',0,1,79),('HD91','NV01','KH322','20180107',0,1,66),('HD92','NV01','KH165','20190925',0,1,11),('HD93','NV01','KH138','20170218',0,1,15),('HD94','NV01','KH155','20180105',0,1,17),('HD95','NV01','KH199','20191021',0,1,63),('HD96','NV01','KH29','20190509',0,1,60),('HD97','NV01','KH228','20190909',0,1,32),('HD98','NV01','KH270','20191114',0,1,64),('HD99','NV01','KH205','20180120',0,1,67),('HD100','NV05','KH358','20170211',0,1,40)
--------------------------------------------------------------------------- HOÁ ĐƠN BÀN -------------------------------------------------------------------------
insert into HoaDonBan(id_HoaDon, TenBan,TongGia)
values ('HD1',25,0),('HD1',22,0),('HD2',27,0),('HD2',21,0),('HD3',2,0),('HD3',6,0),('HD4',23,0),('HD4',20,0),('HD5',10,0),('HD6',4,0),('HD7',15,0),('HD7',16,0),('HD8',21,0),('HD8',12,0),('HD9',2,0),('HD10',2,0),('HD10',15,0),('HD11',13,0),('HD11',22,0),('HD12',9,0),('HD13',23,0),('HD13',6,0),('HD14',19,0),('HD14',7,0),('HD15',5,0),('HD16',11,0),('HD16',24,0),('HD17',21,0),('HD17',6,0),('HD18',24,0),('HD18',9,0),('HD19',25,0),('HD20',8,0),('HD20',4,0),('HD21',6,0),('HD22',13,0),('HD23',18,0),('HD24',5,0),('HD25',28,0),('HD25',29,0),('HD26',21,0),('HD27',1,0),('HD28',29,0),('HD28',9,0),('HD29',14,0),('HD29',28,0),('HD30',1,0),('HD30',8,0),('HD31',7,0),('HD31',3,0),('HD32',11,0),('HD33',18,0),('HD33',2,0),('HD34',25,0),('HD34',25,0),('HD35',1,0),('HD36',1,0),('HD36',7,0),('HD37',7,0),('HD38',28,0),('HD39',2,0),('HD40',18,0),('HD41',27,0),('HD41',27,0),('HD42',15,0),('HD43',7,0),('HD44',17,0),('HD45',8,0),('HD46',6,0),('HD46',25,0),('HD47',4,0),('HD47',27,0),('HD48',11,0),('HD48',10,0),('HD49',25,0),('HD50',5,0),('HD51',10,0),('HD52',27,0),('HD53',3,0),('HD54',17,0),('HD55',16,0),('HD56',5,0),('HD56',28,0),('HD57',15,0),('HD58',29,0),('HD59',22,0),('HD60',24,0),('HD60',3,0),('HD61',26,0),('HD61',29,0),('HD62',1,0),('HD62',24,0),('HD63',27,0),('HD63',24,0),('HD64',21,0),('HD64',28,0),('HD65',17,0),('HD66',26,0),('HD66',10,0),('HD67',12,0),('HD68',11,0),('HD68',23,0),('HD69',6,0),('HD69',6,0),('HD70',21,0),('HD71',3,0),('HD72',18,0),('HD72',1,0),('HD73',20,0),('HD73',5,0),('HD74',3,0),('HD75',18,0),('HD75',12,0),('HD76',16,0),('HD77',22,0),('HD78',24,0),('HD78',20,0),('HD79',3,0),('HD79',23,0),('HD80',23,0),('HD81',26,0),('HD81',20,0),('HD82',23,0),('HD83',17,0),('HD83',4,0),('HD84',10,0),('HD84',17,0),('HD85',26,0),('HD86',10,0),('HD87',10,0),('HD88',15,0),('HD89',7,0),('HD89',17,0),('HD90',12,0),('HD90',18,0),('HD91',8,0),('HD92',29,0),('HD92',22,0),('HD93',25,0),('HD94',4,0),('HD94',22,0),('HD95',22,0),('HD95',11,0),('HD96',17,0),('HD96',16,0),('HD97',9,0),('HD98',9,0),('HD98',14,0),('HD99',5,0),('HD100',5,0)


---------------------------------------------------------------------------  CHI TIẾT HÓA ĐƠN ---------------------------------------------------------------------------------------------------
insert into ChiTietHoaDon(id_HDBan, id_ThucPham, SoLuong,tonggia)
values (1,33,4,0),(1,60,2,0),(2,53,3,0),(3,10,2,0),(3,10,3,0),(4,70,3,0),(4,45,4,0),(5,75,2,0),(6,44,1,0),(6,2,2,0),(7,53,4,0),(7,41,4,0),(7,56,1,0),(8,38,3,0),(8,29,4,0),(8,66,2,0),(9,78,2,0),(9,31,1,0),(9,15,1,0),(9,59,1,0),(10,43,4,0),(11,30,3,0),(11,67,4,0),(11,34,2,0),(12,10,4,0),(13,59,4,0),(13,45,1,0),(13,42,2,0),(14,50,1,0),(14,77,3,0),(15,40,3,0),(15,37,3,0),(15,78,1,0),(15,66,4,0),(16,6,2,0),(16,24,2,0),(17,76,3,0),(17,51,4,0),(17,29,1,0),(18,35,4,0),(18,11,3,0),(19,77,1,0),(19,23,2,0),(20,48,4,0),(20,38,2,0),(21,51,2,0),(22,69,1,0),(23,11,1,0),(23,41,3,0),(24,74,2,0),(24,4,2,0),(25,56,4,0),(25,12,3,0),(26,9,4,0),(26,11,4,0),(26,37,2,0),(26,58,1,0),(27,75,1,0),(27,71,4,0),(28,3,4,0),(29,13,4,0),(29,60,2,0),(29,58,2,0),(30,2,2,0),(30,31,4,0),(30,40,3,0),(31,65,1,0),(31,24,3,0),(32,27,1,0),(32,74,1,0),(32,43,4,0),(32,32,3,0),(33,1,4,0),(34,73,4,0),(34,41,4,0),(34,10,2,0),(35,38,1,0),(36,20,4,0),(37,14,3,0),(37,68,2,0),(38,12,1,0),(38,32,2,0),(38,1,4,0),(38,30,3,0),(39,37,2,0),(39,36,4,0),(39,5,4,0),(40,37,1,0),(41,52,3,0),(41,6,2,0),(42,58,3,0),(42,8,1,0),(42,38,2,0),(43,50,1,0),(43,73,4,0),(44,7,4,0),(44,42,3,0),(44,26,1,0),(45,27,2,0),(45,24,1,0),(46,57,3,0),(46,28,3,0),(46,45,3,0),(47,65,4,0),(47,55,4,0),(48,78,3,0),(48,45,1,0),(48,78,4,0),(49,12,4,0),(49,32,2,0),(49,71,1,0),(50,61,2,0),(50,57,4,0),(51,39,2,0),(51,31,3,0),(52,25,3,0),(52,34,3,0),(52,76,2,0),(53,34,3,0),(53,17,2,0),(54,39,3,0),(54,38,3,0),(54,17,3,0),(55,39,3,0),(55,10,3,0),(55,44,1,0),(55,19,2,0),(56,39,2,0),(56,46,2,0),(57,5,1,0),(58,71,4,0),(58,59,3,0),(59,63,3,0),(59,37,4,0),(60,63,4,0),(60,10,2,0),(60,74,4,0),(61,15,4,0),(61,72,2,0),(62,28,3,0),(63,64,1,0),(63,28,4,0),(63,53,1,0),(63,2,2,0),(64,39,2,0),(64,74,3,0),(65,7,2,0),(65,45,4,0),(66,38,1,0),(66,10,2,0),(67,78,4,0),(68,48,1,0),(68,51,3,0),(69,24,3,0),(69,75,3,0),(69,53,2,0),(70,36,3,0),(71,65,3,0),(72,68,4,0),(73,21,2,0),(73,41,1,0),(74,6,2,0),(74,24,4,0),(74,27,4,0),(75,36,2,0),(75,41,4,0),(75,8,4,0),(76,40,1,0),(76,62,1,0),(76,2,2,0),(76,30,1,0),(77,28,3,0),(77,59,2,0),(78,39,3,0),(78,33,2,0),(79,59,2,0),(79,38,3,0),(79,23,3,0),(80,73,1,0),(80,48,4,0),(81,35,1,0),(81,38,4,0),(82,54,3,0),(82,23,4,0),(83,31,4,0),(84,6,4,0),(84,41,2,0),(85,49,4,0),(85,26,1,0),(86,41,3,0),(86,20,3,0),(86,67,1,0),(87,6,2,0),(88,47,2,0),(88,24,1,0),(89,5,2,0),(89,54,3,0),(89,21,1,0),(89,28,2,0),(90,34,4,0),(90,11,1,0),(91,72,4,0),(92,12,2,0),(93,38,2,0),(94,65,3,0),(94,21,1,0),(94,5,1,0),(95,16,2,0),(95,74,2,0),(96,14,2,0),(97,73,4,0),(98,38,3,0),(99,19,4,0),(99,26,2,0),(99,78,4,0),(100,44,1,0),(101,78,3,0),(101,62,1,0),(102,25,2,0),(102,72,2,0),(102,62,1,0),(103,4,4,0),(103,28,1,0),(103,9,2,0),(104,19,1,0),(104,67,4,0),(104,9,4,0),(105,54,2,0),(106,72,2,0),(106,32,1,0),(106,16,3,0),(107,41,2,0),(107,37,4,0),(108,40,4,0),(108,54,1,0),(109,73,3,0),(109,66,3,0),(109,69,3,0),(110,35,3,0),(110,55,1,0),(110,8,2,0),(111,27,3,0),(111,50,1,0),(111,76,1,0),(112,78,3,0),(113,38,2,0),(113,28,1,0),(113,66,4,0),(114,3,1,0),(114,66,2,0),(115,16,3,0),(116,20,3,0),(117,3,3,0),(117,15,1,0),(117,60,3,0),(117,18,3,0),(118,25,3,0),(118,43,4,0),(119,3,1,0),(120,42,4,0),(120,78,4,0),(121,64,3,0),(121,11,2,0),(122,47,4,0),(122,33,3,0),(122,49,1,0),(122,69,1,0),(123,22,2,0),(123,54,4,0),(124,52,2,0),(125,68,4,0),(125,70,2,0),(126,21,1,0),(126,30,2,0),(127,49,3,0),(128,75,4,0),(128,76,4,0),(128,33,1,0),(128,19,4,0),(129,26,4,0),(129,43,3,0),(129,58,4,0),(129,54,4,0),(130,71,1,0),(131,22,4,0),(131,14,2,0),(132,70,4,0),(133,11,1,0),(133,35,4,0),(133,5,3,0),(133,6,4,0),(134,55,1,0),(135,27,4,0),(136,72,4,0),(136,66,3,0),(136,2,3,0),(137,77,3,0),(137,51,3,0),(137,30,3,0),(138,31,2,0),(139,10,1,0),(139,10,4,0),(139,44,4,0),(139,6,1,0),(140,47,1,0),(141,78,1,0),(141,70,2,0),(142,44,2,0),(142,48,3,0),(143,42,4,0),(143,56,3,0),(144,55,4,0),(145,47,1,0),(145,27,4,0),(145,41,4,0),(145,31,1,0),(146,66,4,0),(146,45,2,0),(147,30,4,0),(148,32,2,0),(148,50,4,0),(149,21,2,0),(149,53,1,0),(149,18,3,0),(149,8,3,0),(150,23,2,0)


----------------------------------------------------------------------------Nguyên liệu ----------------------------------------------------------
insert into NguyenLieu
values (N'thịt bò',0),
(N'thịt lợn',0),
(N'thịt gà',0),
(N'cá',0),
(N'tôm',0),
(N'ghẹ',0),
(N'rau cải',0),
(N'rau muống',0),
(N'hành lá',0),
(N'hành tây',0)
------------------------------------------------------------------------------- Phiếu nhập kho ------------------------------------------------------
insert into PhieuNhapKho(id_NhanVien , NgayNhap)
values (  'NV05','20190620'),(  'NV05','20180421'),(  'NV05','20190807'),(  'NV05','20180703'),(  'NV05','20190317'),(  'NV05','20180422'),(  'NV05','20180410'),(  'NV05','20180215'),(  'NV05','20190111'),(  'NV05','20180318'),(  'NV05','20180714'),(  'NV05','20180225'),(  'NV05','20180610'),(  'NV05','20180901'),(  'NV05','20180824'),(  'NV05','20180421'),(  'NV05','20180513'),(  'NV05','20190213'),(  'NV05','20181010'),(  'NV05','20180506'),(  'NV05','20190413'),(  'NV05','20190901'),(  'NV05','20191003'),(  'NV05','20180325'),(  'NV05','20181114'),('NV09','20190714'),('NV09','20190122'),('NV09','20180822'),('NV09','20181013'),('NV09','20190708'),('NV09','20180202'),('NV09','20190813'),('NV09','20191024'),('NV09','20190811'),('NV09','20190607'),('NV09','20190804'),('NV09','20190607'),('NV09','20180612'),('NV09','20190918'),('NV09','20190425'),('NV09','20190708'),('NV09','20190202'),('NV09','20180408'),('NV09','20190921'),('NV09','20180908'),('NV09','20191106'),('NV09','20180806'),('NV09','20180104'),('NV09','20190819'),('NV09','20190926')
-------------------------------------------------------------------------------- chi tiết phiếu nhập kho -----------------------------------------------------------------
insert into ChiTietNhapKho
values (1,9,21,108000),(1,5,29,243000),(1,5,4,82000),(2,7,8,127000),(2,5,27,53000),(2,3,5,142000),(3,1,6,127000),(3,1,4,73000),(3,8,6,283000),(3,5,10,221000),(4,3,2,194000),(4,3,10,108000),(4,6,23,260000),(4,7,16,265000),(5,9,18,103000),(5,1,1,291000),(6,1,11,280000),(6,6,10,244000),(6,9,10,257000),(7,8,3,216000),(7,4,8,267000),(8,1,19,136000),(8,1,24,59000),(9,6,4,142000),(9,8,2,209000),(10,1,10,199000),(10,3,1,97000),(10,2,6,235000),(11,2,23,158000),(11,3,20,100000),(12,3,24,124000),(12,9,12,204000),(13,7,6,233000),(13,8,2,183000),(13,3,6,139000),(14,4,11,273000),(14,6,24,190000),(14,9,29,120000),(15,8,7,64000),(15,8,4,281000),(15,1,14,295000),(16,4,23,287000),(16,1,26,131000),(16,4,28,131000),(17,8,19,258000),(17,2,14,255000),(17,3,9,122000),(18,3,22,109000),(18,8,27,190000),(18,4,24,253000),(19,4,21,183000),(19,3,22,295000),(20,3,23,120000),(20,5,16,88000),(21,6,3,205000),(21,6,8,66000),(22,5,4,147000),(22,1,4,112000),(23,3,27,299000),(23,3,11,284000),(23,5,3,202000),(24,5,9,133000),(24,5,10,242000),(25,3,8,129000),(25,9,27,156000),(25,2,1,169000),(26,2,14,75000),(26,3,21,86000),(26,9,13,56000),(27,1,16,266000),(27,9,9,50000),(27,6,22,110000),(27,5,1,57000),(28,6,27,200000),(28,1,26,63000),(28,1,3,291000),(29,8,9,299000),(29,8,27,270000),(29,1,6,155000),(29,6,21,264000),(30,7,4,60000),(30,8,4,269000),(30,9,19,252000),(30,8,6,58000),(31,9,28,251000),(31,2,4,261000),(31,5,21,95000),(31,5,5,98000),(32,4,25,169000),(32,9,6,80000),(33,3,3,224000),(33,9,12,166000),(34,9,6,197000),(34,9,6,232000),(34,4,21,123000),(35,6,5,179000),(35,2,29,64000),(35,7,20,272000),(36,7,19,97000),(36,8,7,93000),(36,3,15,230000),(36,8,9,176000),(37,4,1,137000),(37,5,16,242000),(38,5,8,246000),(38,5,21,83000),(39,1,6,222000),(39,1,10,87000),(39,6,24,268000),(40,5,13,52000),(40,8,29,82000),(41,4,16,198000),(41,9,17,87000),(41,1,23,234000),(41,4,11,69000),(42,1,18,79000),(42,9,10,268000),(42,7,11,81000),(43,2,29,73000),(43,7,5,126000),(44,6,6,212000),(44,1,18,257000),(45,9,22,285000),(45,5,6,104000),(45,2,21,287000),(46,1,22,102000),(46,7,23,162000),(46,9,7,208000),(47,9,8,99000),(47,3,29,192000),(48,5,26,91000),(48,9,22,130000),(48,6,11,96000),(49,9,17,157000),(49,1,20,166000),(50,3,11,179000),(50,9,8,290000),(50,9,19,282000),(50,3,10,170000)




------- update  tổng giá chi tiết hóa đơn  ----------------
update ChiTietHoaDon set tonggia =(ChiTietHoaDon.SoLuong*ThucPham.Gia)  from ChiTietHoaDon, ThucPham where ChiTietHoaDon.id_ThucPham = ThucPham.id_ThucPham
 
 ---------------- update tổng giá hóa đơn bàn ------------------------
 update HoaDonBan set TongGia =TongBan.TongGiaBan  from (select id_HDBan , sum(tonggia) as TongGiaBan from ChiTietHoaDon group by id_HDBan ) as TongBan where HoaDonBan.id_HDBan = TongBan.id_HDBan
 
 --------------- update tổng giá hóa đơn ---------------------------------
 update HoaDon set TongGia =Tong.TongHoaDon -(Tong.TongHoaDon*KhuyenMai)/100 from (select id_HoaDon , sum(TongGia) as TongHoaDon from HoaDonBan group by id_HoaDon) as Tong where Tong.id_HoaDon = HoaDon.id_HoaDon

 --------------- update số lượng thực phẩm trong kho ---------------------------------
update NguyenLieu set SoLuong =Tong.TongSo from (select id_NguyenLieu, sum(SoLuong) as TongSo from ChiTietNhapKho group by id_NguyenLieu) as Tong where NguyenLieu.id_NguyenLieu = Tong.id_NguyenLieu


---------------------------- PROC Linh----------------------------------------------
-- proc thêm dữ liệu cho khách hàng và nhân viên mặc định của quán
create proc ThêmKHVaNVMacDinh
as
begin
	insert into KhachHang 
	values ('KH000',N'Mặc Định','20200101','000000000',N'Nhà hàng',N'Nam')
	insert into NhanVien(id_NhanVien,HoTen,GioiTinh,NgaySinh,ChucVu,SDT,Luong)
	Values('NV00',N'NV_Mặc định',N'nữ','2020-01-01',N'thu ngân','0000000',0)

end
-- lấy danh sách hóa đơn theo id bàn chưa thanh toán\
create proc GetIdHDTheoSoBan(@So_Ban int)
as
begin
	select HoaDon.id_HoaDon from HoaDon, HoaDonBan where HoaDon.id_HoaDon = HoaDonBan.id_HoaDon and HoaDonBan.TenBan = @So_Ban and HoaDon.TinhTrang = 0
end

-- lấy danh sách nhân viên thu ngân lên
create proc GetNhanVienThuNgan
as
begin
	select * from NhanVien where ChucVu=N'Thu ngân'
end
go
--  lấy danh sách các bàn đang trống
create proc GetDanhSachBanTrong
as 
begin
	select * from Ban where TrangThai=N'Trống'
end
go
-- lấy danh sách hóa đơn chưa thanh toán
create proc GetHDChuaThanhToan
as
begin
	select id_HoaDon , KhachHang.HoTen as N'Tên khách hàng',NhanVien.HoTen as N'Tên nhân viên',KhachHang.SDT, NgayTao ,TongGia  from NhanVien, HoaDon,KhachHang where NhanVien.id_NhanVien=HoaDon.id_NhanVien and HoaDon.id_KhachHang = KhachHang.id_KhachHang and TinhTrang =0

end
go
-- lấy bảng khách hàng lên
create proc GetKH
as
begin
	select * from KhachHang
end
-- lấy thông tin khách hàng theo id_KhachHang
create proc GetKHTheoId (@id_KH varchar(20))
as
begin
	select * from KhachHang where id_KhachHang = @id_KH
end

-- lấy thông tin khách hàng theo số điện thoại
create proc GetKHTheoSDT (@sdt varchar(100))
as 
begin
	select id_KhachHang, SDT, HoTen from KhachHang where SDT =@sdt
end
go
-- lấy các hóa đơn bàn chưa thanh toán theo hóa đơn
create proc GetBanCuaHD(@id_HD varchar(20))
as
begin
	select id_HDBan, TenBan, HoaDonBan.TongGia from HoaDonBan where id_HoaDon =@id_HD
end
go
-- proc lấy danh sách bàn ăn lên
create proc GetDSBan
as
begin
	select * from Ban
end
go
-- proc lấy danh mục
create proc GetDanhMuc
as 
begin
	select * from DanhMuc
end
go
-- lấy danh sách món theo danh mục có sẵn
create proc GetMon (@id_DanhMuc varchar(20))
as 
begin
	select * from ThucPham where id_DanhMuc = @id_DanhMuc
end
go
-- lấy danh sách các món đã đặt trong bàn ăn có id là id bàn hiện tại
create proc GetBillInfo(@id_Ban int )
as
begin
	select  HoaDonBan.id_HDBan,ThucPham.Ten,SoLuong,ThucPham.Gia ,(SoLuong*ThucPham.Gia) as TongGia from HoaDon , HoaDonBan, ChiTietHoaDon , Ban, ThucPham 
	where ThucPham.id_ThucPham = ChiTietHoaDon.id_ThucPham 
	and ChiTietHoaDon.id_HDBan = HoaDonBan.id_HDBan 
	and HoaDonBan.id_HoaDon = HoaDon.id_HoaDon 
	and HoaDonBan.TenBan = Ban.TenBan
	and HoaDon.TinhTrang = 0 and Ban.TenBan = @id_Ban
end
go
-- check bàn xem đã có hóa đơn nào chưa thanh toán không

create proc CheckTable(@id_Ban int)
as 
begin
	select HoaDonBan.id_HDBan from HoaDon, HoaDonBan where HoaDon.id_HoaDon = HoaDonBan.id_HoaDon and HoaDonBan.TenBan = @id_Ban and HoaDon.TinhTrang = 0
end
go
-- insert thêm bill mới vào cơ sở dữ liệu

create proc insertHoaDon
as
begin
	declare @id int = 0
	select @id = COUNT(*) from HoaDon 
	set @id = @id +1
	insert HoaDon values('HD' + CONVERT(varchar(20), @id) ,'NV00' ,'KH000',GETDATE() , 0 ,0, 0 )
end
go
exec insertHoaDon
create proc InsertHDDatTruoc (@id_NhanVien varchar(20), @id_KhachHang varchar(20))
as
begin
	declare @id int = 0
	select @id = COUNT(*) from HoaDon 
	set @id = @id +1
	insert HoaDon values('HD' + CONVERT(varchar(20), @id) , @id_NhanVien , @id_KhachHang ,GETDATE() , 0 ,0, 0 )
end
go


-- lấy ra hóa đơn vừa tạo
create proc MaxIdHoaDon
as 
begin
	select count(*) from HoaDon 
end
go
-- insert HoaDonBan
create proc InsertHoaDonBan(@id_HoaDon varchar(20) , @TenBan int )
as 
begin
	update Ban set TrangThai =N'Có Người' from Ban where TenBan = @TenBan
	insert into HoaDonBan(id_HoaDon , TenBan)
	values(@id_HoaDon , @TenBan)
end
GO


-- lấy ra id của hóa đơn vừa được insert vào bảng Hóa đơn bàn
create proc MaxIdHDBan
as
begin
	select max(id_HDBan) from HoaDonBan
end
GO
-- insert chi tiết hóa đơn, có kiểm tra xem món đó đã có trong hóa đơn chưa, nếu có thì cập nhật số lượng, còn chưa thì thêm hóa đơn mới
create proc InsertChiTietHoaDon(@idHDBan int, @idThucPham int, @SoLuong int)
as
begin
	declare @KTraMon int = 0;
	select @KTraMon = count(*) from ChiTietHoaDon where id_HDBan =@idHDBan and id_ThucPham = @idThucPham
	if(@KTraMon > 0)
	begin
		update ChiTietHoaDon set SoLuong = SoLuong+@SoLuong from ChiTietHoaDon where id_HDBan = @idHDBan and id_ThucPham = @idThucPham
		
	end
	else
	begin
		insert into ChiTietHoaDon
		values(@idHDBan , @idThucPham ,@SoLuong , 0)
	end
end
go
-- trigger thêm chi tiết hóa đơn sẽ cập nhật lại tổng giá của hóa đơn bàn và hóa đơn

create trigger insertChiTietHD 
on ChiTietHoaDon
for insert
as
declare @SL int , @idThuPham int , @idChiTietHD int, @idHDBan int , @idHD varchar(20)
begin
	select @SL= SoLuong, @idThuPham = id_ThucPham, @idChiTietHD=So_ChiTietHD from inserted
	------- update  tổng giá chi tiết hóa đơn  ----------------
	update ChiTietHoaDon set tonggia =(ChiTietHoaDon.SoLuong*ThucPham.Gia)  from ChiTietHoaDon, ThucPham where ChiTietHoaDon.id_ThucPham = ThucPham.id_ThucPham and So_ChiTietHD =@idChiTietHD
	
	-- lấy hóa đơn bàn vừa được thêm món vào
	select @idHDBan =id_HDBan from ChiTietHoaDon where So_ChiTietHD = @idChiTietHD
	update HoaDonBan set TongGia =TongBan.Tong from  HoaDonBan,(select id_HDBan,sum(ChiTietHoaDon.tonggia) as Tong from ChiTietHoaDon group by id_HDBan having id_HDBan = @idHDBan) as TongBan where TongBan.id_HDBan = HoaDonBan.id_HDBan
	select @idHD = id_HoaDon from HoaDonBan where id_HDBan = @idHDBan
	update HoaDon set TongGia =TongHD.Tong from (select id_HoaDon,sum(HoaDonBan.TongGia) as Tong from  HoaDonBan group by id_HoaDon having id_HoaDon =@idHD) as TongHD where TongHD.id_HoaDon = HoaDon.id_HoaDon

end
go
-- trigger update lại tổng giá khi update số lượng
create trigger updateSoLuongMon 
on ChiTietHoaDon
for update
as
declare @SL int , @idThuPham int , @idChiTietHD int, @idHDBan int , @idHD varchar(20)
begin
	select @SL= SoLuong, @idThuPham = id_ThucPham, @idChiTietHD=So_ChiTietHD from inserted
	------- update  tổng giá chi tiết hóa đơn  ----------------
	update ChiTietHoaDon set tonggia =(ChiTietHoaDon.SoLuong*ThucPham.Gia)  from ChiTietHoaDon, ThucPham where ChiTietHoaDon.id_ThucPham = ThucPham.id_ThucPham and So_ChiTietHD =@idChiTietHD
	
	-- lấy hóa đơn bàn vừa được thêm món vào
	select @idHDBan =id_HDBan from ChiTietHoaDon where So_ChiTietHD = @idChiTietHD
	update HoaDonBan set TongGia =TongBan.Tong from  HoaDonBan,(select id_HDBan,sum(ChiTietHoaDon.tonggia) as Tong from ChiTietHoaDon group by id_HDBan having id_HDBan = @idHDBan) as TongBan where TongBan.id_HDBan = HoaDonBan.id_HDBan
	select @idHD = id_HoaDon from HoaDonBan where id_HDBan = @idHDBan
	update HoaDon set TongGia =TongHD.Tong from (select id_HoaDon,sum(HoaDonBan.TongGia) as Tong from  HoaDonBan group by id_HoaDon having id_HoaDon =@idHD) as TongHD where TongHD.id_HoaDon = HoaDon.id_HoaDon

end
go
-- xóa hóa đơn chưa thanh toán

create proc XoaHoaDon(@id_HD varchar(20))
as
	declare @id_HoaDonBan int
begin
	
	declare ConTro cursor forward_only
	for select id_HDBan from HoaDonBan where id_HoaDon= @id_HD
	open ConTro
	FETCH NEXT FROM ConTro
	into @id_HoaDonBan
	while @@FETCH_STATUS = 0
	begin
		delete  from ChiTietHoaDon where id_HDBan = @id_HoaDonBan
		update Ban set TrangThai=N'Trống' from Ban, HoaDonBan where HoaDonBan.id_HDBan = @id_HoaDonBan and HoaDonBan.TenBan = Ban.TenBan
		delete from HoaDonBan where id_HDBan =@id_HoaDonBan
		FETCH NEXT FROM ConTro
		into @id_HoaDonBan

	end 
	close ConTro
	DEALLOCATE ConTro
	delete from HoaDon where id_HoaDon =@id_HD
	
end
go

exec XoaHoaDon 'HD102'

select * from HoaDon
select * from HoaDonBan
select * from ChiTietHoaDon
-- trigger khi xóa 1 hóa đơn thì cập nhật lại các id_hóa đơn
create trigger CapNhatIdHD
on HoaDon
for delete
as
begin
	
	declare @dem int = 1 , @id_HD varchar(20)
	declare ConTro cursor forward_only
	for select id_HoaDon from HoaDon
	open ConTro
	FETCH NEXT FROM ConTro
	into @id_HD
	while @@FETCH_STATUS = 0
	begin
		
		
		update HoaDon set id_HoaDon = 'HD' + CONVERT(varchar(20) , @dem) where id_HoaDon = @id_HD
		set @dem = @dem+1
		FETCH NEXT FROM ConTro
		into @id_HD
		

	end 
	close ConTro
	DEALLOCATE ConTro
end
go
-- chuyển bàn có TenBan1 sang bàn có TenBan2
create proc ChuyenBan (@id_HDBan1 int , @id_HDBan2 int)
as
begin
	-- chuyển id hóa đơn bàn 1 thành id hóa đơn bàn 2
	update ChiTietHoaDon set id_HDBan = @id_HDBan2 where id_HDBan =@id_HDBan1
	-- update lại tổng giá của hóa đơn
	update HoaDon set TongGia = HoaDon.TongGia - HoaDonBan.TongGia from HoaDon , HoaDonBan where HoaDon.id_HoaDon = HoaDonBan.id_HoaDon and HoaDonBan.id_HDBan = @id_HDBan1
	update Ban set TrangThai=N'Trống' from Ban, HoaDonBan where id_HDBan =@id_HDBan1 and HoaDonBan.TenBan = Ban.TenBan
	delete from HoaDonBan where id_HDBan = @id_HDBan1
end


--- lấy thông tin để in ra hóa đơn 
create proc ReportHoaDon(@id_HD varchar(20))
as
begin
	select HoaDon.id_HoaDon ,HoaDon.NgayTao,  NhanVien.HoTen as NhanVien , KhachHang.HoTen as KhachHang, HoaDonBan.TenBan , ThucPham.Ten, ChiTietHoaDon.SoLuong ,ThucPham.Gia, ChiTietHoaDon.tonggia as TongGiaMon , HoaDon.TongGia as TongHD , KhuyenMai
	from HoaDon, HoaDonBan, ChiTietHoaDon, ThucPham , NhanVien , KhachHang
	where HoaDon.id_HoaDon = @id_HD
	and HoaDon.id_HoaDon = HoaDonBan.id_HoaDon
	and HoaDonBan.id_HDBan = ChiTietHoaDon.id_HDBan
	and ChiTietHoaDon.id_ThucPham = ThucPham.id_ThucPham
	and HoaDon.id_NhanVien = NhanVien.id_NhanVien
	and HoaDon.id_KhachHang = KhachHang .id_KhachHang
end
-- proc thanh toán hóa đơn
create proc ThanhToan(@id_HD varchar(20) , @KhuyenMai int )
as
begin
	update HoaDon set TinhTrang = 1,KhuyenMai = @KhuyenMai  where id_HoaDon = @id_HD
	update HoaDon set TongGia = TongGia - (TongGia*KhuyenMai)/100 where id_HoaDon =@id_HD
	update Ban set TrangThai =N'Trống' from HoaDonBan,  Ban where HoaDonBan.id_HoaDon =@id_HD and HoaDonBan.TenBan = Ban.TenBan
end
exec ThanhToan 'HD103' ,30
select * from HoaDon where id_HoaDon = 'HD103'
-- proc thêm khách hàng mới
create proc ThemKH (@HoTen nvarchar(200) , @NgaySinh varchar(20) , @SDT varchar(100) ,@DiaChi nvarchar(200) , @GioiTinh nvarchar(20) )
as
begin
	declare @max int, @id_KH varchar(20)
	select @max = count(*) from KhachHang
	set @max = @max +1
	set @id_KH = 'KH'+ CONVERT(varchar(20) , @max)
	insert KhachHang
	values( @id_KH , @HoTen , @NgaySinh , @SDT ,@DiaChi ,@GioiTinh)
end



---------------- T-SQL ---------------------------------------

1. cập nhật lại tổng giá hóa đơn bàn và hóa đơn khi insert 1 chi tiết hóa đơn
create trigger insertChiTietHD 
on ChiTietHoaDon
for insert
as
declare @SL int , @idThuPham int , @idChiTietHD int, @idHDBan int , @idHD varchar(20)
begin
	select @SL= SoLuong, @idThuPham = id_ThucPham, @idChiTietHD=So_ChiTietHD from inserted
	------- update  tổng giá chi tiết hóa đơn  ----------------
	update ChiTietHoaDon set tonggia =(ChiTietHoaDon.SoLuong*ThucPham.Gia)  
	from ChiTietHoaDon, ThucPham 
	where ChiTietHoaDon.id_ThucPham = ThucPham.id_ThucPham and So_ChiTietHD =@idChiTietHD
	-- lấy hóa đơn bàn vừa được thêm món vào
	select @idHDBan =id_HDBan from ChiTietHoaDon where So_ChiTietHD = @idChiTietHD

	update HoaDonBan set TongGia =TongBan.Tong 
	from  HoaDonBan,(select id_HDBan,sum(ChiTietHoaDon.tonggia) as Tong from ChiTietHoaDon group by id_HDBan having id_HDBan = @idHDBan) as TongBan 
	where TongBan.id_HDBan = HoaDonBan.id_HDBan

	select @idHD = id_HoaDon from HoaDonBan where id_HDBan = @idHDBan

	update HoaDon set TongGia =TongHD.Tong 
	from (select id_HoaDon,sum(HoaDonBan.TongGia) as Tong from  HoaDonBan group by id_HoaDon having id_HoaDon =@idHD) as TongHD 
	where TongHD.id_HoaDon = HoaDon.id_HoaDon

end
2. khi thêm 1 món vào bàn sẽ kiểm tra xem món đó đã tồn tại chưa, nếu tồn tại r thì update lại số lượng, còn chưa thì thêm chi tiết hóa đơn về món đó

create proc InsertChiTietHoaDon(@idHDBan int, @idThucPham int, @SoLuong int)
as
begin
	declare @KTraMon int = 0;
	select @KTraMon = count(*) from ChiTietHoaDon where id_HDBan =@idHDBan and id_ThucPham = @idThucPham
	if(@KTraMon > 0)
	begin
		update ChiTietHoaDon set SoLuong = SoLuong+@SoLuong 
		from ChiTietHoaDon 
		where id_HDBan = @idHDBan and id_ThucPham = @idThucPham
		
		update ChiTietHoaDon set tonggia =(ChiTietHoaDon.SoLuong*ThucPham.Gia)  
		from ChiTietHoaDon, ThucPham 
		where ChiTietHoaDon.id_ThucPham = ThucPham.id_ThucPham and id_HDBan = @idHDBan and ThucPham.id_ThucPham = @idThucPham

	end
	else
	begin
		insert into ChiTietHoaDon
		values(@idHDBan , @idThucPham ,@SoLuong , 0)
	end
end
3.dùng con trỏ cập nhật lại tổng giá của hóa đơn 
	ALTER TABLE HoaDon add TongGia float
	declare @id_HoaDon varchar(20), @TongGia float
	declare ConTro cursor forward_only
	for select id_HoaDon, sum(TongGia) from HoaDonBan group by id_HoaDon
	open ConTro
	FETCH NEXT FROM ConTro
	into @id_HoaDon , @TongGia
	while @@FETCH_STATUS = 0
	begin
		update HoaDon set TongGia = @TongGia where id_HoaDon =@id_HoaDon
		FETCH NEXT FROM ConTro
		into @id_HoaDon , @TongGia

	end 
	close ConTro
	DEALLOCATE ConTro
4.xóa hóa đơn gồm có chi tiết hóa đơn và hóa đơn bàn truyển vào id_HD
create proc XoaHoaDon(@id_HD varchar(20))
as
	declare @id_HoaDonBan int
begin
	
	declare ConTro cursor forward_only
	for select id_HDBan from HoaDonBan where id_HoaDon= @id_HD
	open ConTro
	FETCH NEXT FROM ConTro
	into @id_HoaDonBan
	while @@FETCH_STATUS = 0
	begin
		delete  from ChiTietHoaDon where id_HDBan = @id_HoaDonBan
		delete from HoaDonBan where id_HDBan =@id_HoaDonBan
		FETCH NEXT FROM ConTro
		into @id_HoaDonBan

	end 
	close ConTro
	DEALLOCATE ConTro
	delete from HoaDon where id_HoaDon =@id_HD
	
end
5. trigger khi xóa 1 hóa đơn thì cập nhật lại tất cả id_HD theo thứ tự để dễ quản lý
create trigger CapNhatIdHD
on HoaDon
for delete
as
begin
	declare @dem int = 1 , @id_HD varchar(20)
	declare ConTro cursor forward_only
	for select id_HoaDon from HoaDon
	open ConTro
	FETCH NEXT FROM ConTro
	into @id_HD
	while @@FETCH_STATUS = 0
	begin
		update HoaDon set id_HoaDon = 'HD' + CONVERT(varchar(20) , @dem) where id_HoaDon = @id_HD
		set @dem = @dem+1
		FETCH NEXT FROM ConTro
		into @id_HD
		

	end 
	close ConTro
	DEALLOCATE ConTro
end
6. proc chuyển bàn từ bàn có id hóa đơn bàn thứ nhất sang bàn có id hóa đơn bàn thứ 2 và set cho bàn được chuyển trống
create proc ChuyenBan (@id_HDBan1 int , @id_HDBan2 int)
as
begin
	-- chuyển id hóa đơn bàn 1 thành id hóa đơn bàn 2
	update ChiTietHoaDon set id_HDBan = @id_HDBan2 where id_HDBan =@id_HDBan1
	-- update lại tổng giá của hóa đơn
	update HoaDon set TongGia = HoaDon.TongGia - HoaDonBan.TongGia from HoaDon , HoaDonBan where HoaDon.id_HoaDon = HoaDonBan.id_HoaDon and HoaDonBan.id_HDBan = @id_HDBan1
	update Ban set TrangThai=N'Trống' from Ban, HoaDonBan where id_HDBan =@id_HDBan1 and HoaDonBan.TenBan = Ban.TenBan
	delete from HoaDonBan where id_HDBan = @id_HDBan1
end        
7. tự động insert bàn vào cơ sở dữ liệu
declare @i int = 1
while @i <=50
begin
	insert Ban(SoGhe , TrangThai) values(4, N'Trống')
	set @i = @i + 1
end
go
declare @k int = 1
while @k <=10
begin
	insert Ban(SoGhe , TrangThai) values(8, N'Trống')
	set @k = @k + 1
end
go
8.trigger update lại tổng giá của hóa đơn, hóa đơn bàn, chi tiết hóa đơn khi chi tiết hóa đơn được update số lượng
create trigger updateSoLuongMon 
on ChiTietHoaDon
for update
as
declare @SL int , @idThuPham int , @idChiTietHD int, @idHDBan int , @idHD varchar(20)
begin
	select @SL= SoLuong, @idThuPham = id_ThucPham, @idChiTietHD=So_ChiTietHD from inserted
	------- update  tổng giá chi tiết hóa đơn  ----------------
	update ChiTietHoaDon set tonggia =(ChiTietHoaDon.SoLuong*ThucPham.Gia)  
	from ChiTietHoaDon, ThucPham
	where ChiTietHoaDon.id_ThucPham = ThucPham.id_ThucPham and So_ChiTietHD =@idChiTietHD
	
	-- lấy hóa đơn bàn vừa được thêm món vào
	select @idHDBan =id_HDBan 
	from ChiTietHoaDon 
	where So_ChiTietHD = @idChiTietHD

	update HoaDonBan set TongGia =TongBan.Tong 
	from  HoaDonBan,(select id_HDBan,sum(ChiTietHoaDon.tonggia) as Tong from ChiTietHoaDon group by id_HDBan having id_HDBan = @idHDBan) as TongBan 
	where TongBan.id_HDBan = HoaDonBan.id_HDBan

	select @idHD = id_HoaDon from HoaDonBan where id_HDBan = @idHDBan
	update HoaDon set TongGia =TongHD.Tong 
	from (select id_HoaDon,sum(HoaDonBan.TongGia) as Tong from  HoaDonBan group by id_HoaDonhaving id_HoaDon =@idHD) as TongHD 
	where TongHD.id_HoaDon = HoaDon.id_HoaDon

end
go
9. proc thêm chi tiết hóa đơn vào cơ sở dữ liệu
create proc InsertChiTietHoaDon(@idHDBan int, @idThucPham int, @SoLuong int)
as
begin
	declare @KTraMon int = 0;
	select @KTraMon = count(*) from ChiTietHoaDon where id_HDBan =@idHDBan and id_ThucPham = @idThucPham
	if(@KTraMon > 0)
	begin
		update ChiTietHoaDon set SoLuong = SoLuong+@SoLuong from ChiTietHoaDon where id_HDBan = @idHDBan and id_ThucPham = @idThucPham
		
	end
	else
	begin
		insert into ChiTietHoaDon
		values(@idHDBan , @idThucPham ,@SoLuong , 0)
	end
end
go

10.thêm vào 1 hóa đơn do khách hàng đặt trước bàn 
create proc InsertHDDatTruoc (@id_NhanVien varchar(20), @id_KhachHang varchar(20))
as
begin
	declare @id int = 0
	select @id = COUNT(*) from HoaDon 
	set @id = @id +1
	insert HoaDon values('HD' + CONVERT(varchar(20), @id) , @id_NhanVien , @id_KhachHang ,GETDATE() , 0 ,0, 0 )
end
go


---------------------------------- PROC QUỲNH ---------------------------------------------------
------------------------------------
;----------------------------------
;-------------------------------
-- get nguyên liệu lên
create proc GetNguyenLieu
as
begin
	select * from NguyenLieu
end
--thong ke doanh thu theo ngay
CREATE PROC doanhthu_ngay(@ngay date)
AS
BEGIN
SELECT HoaDon.id_HoaDon, ChiTietHoaDon.So_ChiTietHD, ThucPham.id_ThucPham, ThucPham.Ten, ChiTietHoaDon.SoLuong,ThucPham.Gia
FROM HoaDon, HoaDonBan, ChiTietHoaDon, ThucPham
WHERE HoaDon.id_HoaDon = HoaDonBan.id_HoaDon
AND HoaDonBan.id_HDBan = ChiTietHoaDon.id_HDBan
AND ChiTietHoaDon.id_ThucPham =ThucPham.id_ThucPham
AND HoaDon.NgayTao = @ngay
END
--thong ke doanh thu theo thang
CREATE PROC doanhthu_thang(@thang int, @nam int)
AS
BEGIN
SELECT HoaDon.id_HoaDon, ChiTietHoaDon.So_ChiTietHD, ThucPham.id_ThucPham, ThucPham.Ten, ChiTietHoaDon.SoLuong,ThucPham.Gia
FROM HoaDon, HoaDonBan, ChiTietHoaDon, ThucPham
WHERE HoaDon.id_HoaDon = HoaDonBan.id_HoaDon
AND HoaDonBan.id_HDBan = ChiTietHoaDon.id_HDBan
AND ChiTietHoaDon.id_ThucPham =ThucPham.id_ThucPham
AND MONTH(HoaDon.NgayTao) = @thang
AND YEAR(HoaDon.NgayTao)  =@nam
END
--thong ke doanh thu theo nam
CREATE PROC doanhthu_nam( @nam int)
AS
BEGIN
SELECT HoaDon.id_HoaDon, ChiTietHoaDon.So_ChiTietHD, ThucPham.id_ThucPham, ThucPham.Ten, ChiTietHoaDon.SoLuong,ThucPham.Gia
FROM HoaDon, HoaDonBan, ChiTietHoaDon, ThucPham
WHERE HoaDon.id_HoaDon = HoaDonBan.id_HoaDon
AND HoaDonBan.id_HDBan = ChiTietHoaDon.id_HDBan
AND ChiTietHoaDon.id_ThucPham =ThucPham.id_ThucPham
AND YEAR(HoaDon.NgayTao)  =@nam
END
---------------------------------------------------------------------------
---------------------------------------------------------------------------
--tinh tong doanh thu theo ngay
CREATE PROC tinhtong_dtngay(@ngay date)
AS
BEGIN 
SELECT SUM(TKNGAY.SoLuong * TKNGAY.Gia) AS doanhthu
FROM (SELECT HoaDon.id_HoaDon, ChiTietHoaDon.So_ChiTietHD, ThucPham.id_ThucPham, ThucPham.Ten, ChiTietHoaDon.SoLuong,ThucPham.Gia
FROM HoaDon, HoaDonBan, ChiTietHoaDon, ThucPham
WHERE HoaDon.id_HoaDon = HoaDonBan.id_HoaDon
AND HoaDonBan.id_HDBan = ChiTietHoaDon.id_HDBan
AND ChiTietHoaDon.id_ThucPham =ThucPham.id_ThucPham
AND HoaDon.NgayTao = @ngay) AS TKNGAY
END
--tinh tong doanh thu theo thang
CREATE PROC tinhtong_dtthang(@thang int, @nam int)
AS
BEGIN 
SELECT SUM(TKTHANG.SoLuong * TKTHANG.Gia) AS doanhthu
FROM (SELECT HoaDon.id_HoaDon, ChiTietHoaDon.So_ChiTietHD, ThucPham.id_ThucPham, ThucPham.Ten, ChiTietHoaDon.SoLuong,ThucPham.Gia
FROM HoaDon, HoaDonBan, ChiTietHoaDon, ThucPham
WHERE HoaDon.id_HoaDon = HoaDonBan.id_HoaDon
AND HoaDonBan.id_HDBan = ChiTietHoaDon.id_HDBan
AND ChiTietHoaDon.id_ThucPham =ThucPham.id_ThucPham
AND MONTH(HoaDon.NgayTao) = @thang
AND YEAR(HoaDon.NgayTao)  =@nam) AS TKTHANG
END
--tinh tong doanh thu theo nam
CREATE PROC tinhtong_dtnam(@nam int)
AS
BEGIN 
SELECT SUM(TKNAM.SoLuong * TKNAM.Gia) AS doanhthu
FROM (SELECT HoaDon.id_HoaDon, ChiTietHoaDon.So_ChiTietHD, ThucPham.id_ThucPham, ThucPham.Ten, ChiTietHoaDon.SoLuong,ThucPham.Gia
FROM HoaDon, HoaDonBan, ChiTietHoaDon, ThucPham
WHERE HoaDon.id_HoaDon = HoaDonBan.id_HoaDon
AND HoaDonBan.id_HDBan = ChiTietHoaDon.id_HDBan
AND ChiTietHoaDon.id_ThucPham =ThucPham.id_ThucPham
AND YEAR(HoaDon.NgayTao)  =@nam) AS TKNAM
END
----------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------
--hien thi danh sach hoa don cua khach hang co tu ngay d1 den ngay d2
CREATE PROC thongke_listKH(@ngay1 date, @ngay2 date)
AS
BEGIN
SELECT KhachHang.id_KhachHang, KhachHang.HoTen, KhachHang.SDT, HoaDon.id_HoaDon, HoaDon.NgayTao, HoaDon.TongGia
FROM KhachHang INNER JOIN HoaDon ON KhachHang.id_KhachHang = HoaDon.id_KhachHang
WHERE HoaDon.NgayTao BETWEEN @ngay1 AND @ngay2
END
------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------
--thong ke nguyen lieu nhap kho
--thong ke nhap nguyen lieu theo ngay
CREATE PROC thongke_nguyenlieungay(@ngay date)
AS
BEGIN
SELECT PhieuNhapKho.id_PhieuNhapKho, ChiTietNhapKho.id_NguyenLieu, NguyenLieu.TenNL, ChiTietNhapKho.SoLuong, ChiTietNhapKho.Gia--nguyen lieu thua so luong
FROM PhieuNhapKho, ChiTietNhapKho, NguyenLieu
WHERE PhieuNhapKho.id_PhieuNhapKho = ChiTietNhapKho.id_PhieuNhapKho
AND ChiTietNhapKho.id_NguyenLieu = NguyenLieu.id_NguyenLieu
AND PhieuNhapKho.NgayNhap = @ngay
END
--thong ke nhap nguyen lieu theo thang
CREATE PROC thongke_nguyenlieuthang(@thang int, @nam int)
AS
BEGIN
SELECT PhieuNhapKho.id_PhieuNhapKho, ChiTietNhapKho.id_NguyenLieu, NguyenLieu.TenNL, ChiTietNhapKho.SoLuong, ChiTietNhapKho.Gia--nguyen lieu thua so luong
FROM PhieuNhapKho, ChiTietNhapKho, NguyenLieu
WHERE PhieuNhapKho.id_PhieuNhapKho = ChiTietNhapKho.id_PhieuNhapKho
AND ChiTietNhapKho.id_NguyenLieu = NguyenLieu.id_NguyenLieu
AND MONTH(PhieuNhapKho.NgayNhap) = @thang
AND YEAR (PhieuNhapKho.NgayNhap) = @nam
END
--thong ke nhap nguyen lieu theo nam
CREATE PROC thongke_nguyenlieuthang( @nam int)
AS
BEGIN
SELECT PhieuNhapKho.id_PhieuNhapKho, ChiTietNhapKho.id_NguyenLieu, NguyenLieu.TenNL, ChiTietNhapKho.SoLuong, ChiTietNhapKho.Gia--nguyen lieu thua so luong
FROM PhieuNhapKho, ChiTietNhapKho, NguyenLieu
WHERE PhieuNhapKho.id_PhieuNhapKho = ChiTietNhapKho.id_PhieuNhapKho
AND ChiTietNhapKho.id_NguyenLieu = NguyenLieu.id_NguyenLieu
AND YEAR (PhieuNhapKho.NgayNhap) = @nam
END
--thong ke nguyen lieu theo ten nguyenlieu
CREATE PROC thongke_nguyenlieuten(@ten nvarchar(50))
AS
BEGIN
SELECT NguyenLieu.id_NguyenLieu, NguyenLieu.TenNL, ChiTietNhapKho.SoLuong, ChiTietNhapKho.Gia, PhieuNhapKho.id_PhieuNhapKho, PhieuNhapKho.NgayNhap
FROM PhieuNhapKho, ChiTietNhapKho, NguyenLieu
WHERE PhieuNhapKho.id_PhieuNhapKho = ChiTietNhapKho.id_PhieuNhapKho
AND ChiTietNhapKho.id_NguyenLieu = NguyenLieu.id_NguyenLieu
AND NguyenLieu.TenNL = @ten
END


------------------------------ PROC ĐỨC  ANH --------------------------------
create proc LSNhapKho
as begin
	select CTNK.id_PhieuNhapKho,PNK.id_NhanVien,NV.HoTen,PNK.NgayNhap,sum(Gia) as Gia 
	from ChiTietNhapKho as CTNK, PhieuNhapKho as PNK, NhanVien as NV 
	where PNK.id_PhieuNhapKho = CTNK.id_PhieuNhapKho and NV.id_NhanVien=PNK.id_NhanVien
	group by CTNK.id_PhieuNhapKho,PNK.id_NhanVien,NV.HoTen,PNK.NgayNhap
end
go

create proc select_NL
as select *from NguyenLieu
go

create proc add_NL
(@ten_NL nvarchar(50), @SL int)
as begin
	insert into NguyenLieu values(@ten_NL,@SL)
end
go

create proc update_NL
(@ma_NL int, @ten_NL nvarchar(50), @SL int)
as begin
	update NguyenLieu set TenNL = @ten_NL,SoLuong = @SL where id_NguyenLieu = @ma_NL
end
go

create proc delete_NL
(@ma_NL int)
as begin
	delete from ChiTietNhapKho where id_NguyenLieu = @ma_NL
	delete from NguyenLieu where id_NguyenLieu = @ma_NL
end
go

create proc add_CTNK
(@ma_PNK int, @ma_NL int, @SL int, @Gia int)
as begin
	declare @count int
	select @count = count(*) from ChiTietNhapKho where id_NguyenLieu = @ma_NL and id_PhieuNhapKho = @ma_PNK 
	if @count = 0
		insert into ChiTietNhapKho values (@ma_PNK,@ma_NL,@SL,@Gia)
	else
		update ChiTietNhapKho set SoLuong = SoLuong + @SL , Gia = Gia + @Gia where id_NguyenLieu = @ma_NL and id_PhieuNhapKho = @ma_PNK
end
go

create proc add_PNK
(@ma_NV varchar(20), @ngayNhap date)
as begin
	insert into PhieuNhapKho(id_NhanVien,NgayNhap) values(@ma_NV,@ngayNhap)
end
go

create proc PNK
@ma_PNK int
as begin
	select CTNK.id_NguyenLieu,NL.TenNL,CTNK.SoLuong,Gia from ChiTietNhapKho as CTNK,NguyenLieu as NL 
	where id_PhieuNhapKho = @ma_PNK and CTNK.id_NguyenLieu=NL.id_NguyenLieu
end
go

create trigger insertCTNK 
on ChiTietNhapKho
for insert
as declare @SL int, @MaNL int 
begin
	select @MaNL = id_NguyenLieu ,@SL = SoLuong from inserted
	update NguyenLieu set SoLuong = SoLuong + @SL where id_NguyenLieu = @MaNL
end


------------------------- PROC TÚ --------------------------------------
use NhaHang
go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

alter table NhanVien add NgayVaoLam date default getdate(),
						NgayBatDau date default getdate(),
						NgayChinhSua datetime default getdate()
update NhanVien set NgayVaoLam = GETDATE(), NgayBatDau = GETDATE(), NgayChinhSua = GETDATE()
go

create proc load_nv
as
begin
	select id_NhanVien, HoTen, GioiTinh, NgaySinh, ChucVu, SDT, Luong, KyNang, NgayVaoLam, NgayChinhSua, NgayBatDau from NhanVien
end
go

create proc add_nv
@id_NhanVien varchar(20), 
@HoTen nvarchar(200),
@GioiTinh nvarchar(200),
@NgaySinh date,
@ChucVu nvarchar(200),
@SDT varchar(200),
@Luong float,
@KyNang nvarchar(200)
as
begin
	insert into NhanVien(id_NhanVien, HoTen, GioiTinh, NgaySinh, ChucVu, SDT, Luong, KyNang) values (@id_NhanVien, @HoTen, @GioiTinh, @NgaySinh, @ChucVu, @SDT, @Luong, @KyNang)
end
go

create proc edit_nv
@id_NhanVien varchar(20), 
@HoTen nvarchar(200),
@GioiTinh nvarchar(200),
@NgaySinh date,
@ChucVu nvarchar(200),
@SDT varchar(200),
@Luong float,
@KyNang nvarchar(200)
as
begin
	update NhanVien set HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, ChucVu = @ChucVu, SDT = @SDT, Luong = @Luong, KyNang = @KyNang where id_NhanVien = @id_NhanVien
end
go

create proc del_nv
@id_NhanVien varchar(20)
as
begin
	delete NhanVien where id_NhanVien = @id_NhanVien
end
go

create trigger del_nv_ad on NhanVien instead of delete
as
	declare @id_nv_del varchar(20)
begin
	select @id_nv_del = id_NhanVien from deleted
	delete [admin] where id_NhanVien = @id_nv_del
	delete NhanVien where id_NhanVien = @id_nv_del
end
go

create proc search_nv_id
@id varchar(20)
as
begin
	select * from NhanVien where id_NhanVien = @id
end
go

create proc search_nv_name
@name nvarchar(200)
as
begin
	select * from NhanVien where HoTen = @name
end
go

create proc search_nv_work
@work nvarchar(200)
as
begin
	select * from NhanVien where ChucVu = @work
end
go

create proc search_nv_gt
@gt nvarchar(200)
as
begin
	select * from NhanVien where GioiTinh = @gt
end
go

create proc search_nv_ns
@ns date
as
begin
	select * from NhanVien where NgaySinh = @ns
end
go

create proc search_nv_luong
@luong float
as
begin
	select * from NhanVien where Luong = @luong
end
go

create proc search_nv_sdt
@sdt varchar(200)
as
begin
	select * from NhanVien where SDT = @sdt
end
go


create trigger add_nv_timeadd on NhanVien for insert
as
begin
	update NhanVien set NgayVaoLam = GETDATE() where id_NhanVien in (select id_NhanVien from inserted)
	update NhanVien set NgayBatDau = GETDATE() where id_NhanVien in (select id_NhanVien from inserted)
	update NhanVien set NgayChinhSua = GETDATE() where id_NhanVien in (select id_NhanVien from inserted)
end
go

create trigger add_nv_timeedit on NhanVien for update
as
begin
	update NhanVien set NgayChinhSua = GETDATE() where id_NhanVien in (select id_NhanVien from deleted)
end
go

create proc add_nv_timestart
@id_nv varchar(20),
@timestart date
as
begin
	update NhanVien set NgayBatdau = @timestart where id_NhanVien = @id_nv
end
go

create proc return_nv_day
@id_nv varchar(20),
@now date
as
begin
	select DATEDIFF(day, NgayBatDau, @now) from NhanVien where id_NhanVien = @id_nv
end
go
 


 -------------------------------- PROC ĐÌNH HÀ -------------------------------------------
 --======================================================================================================================================================================--

--Procedure (Thủ tục) là một chương trình trong cơ sở dữ liệu gồm nhiều câu lệnh mà bạn lưu lại cho những lần sử dụng sau.

-- Tạo Procedure để kiểm tra tài khoản đăng nhập
create procedure USP_Login
@userName nvarchar(100) , @passWord nvarchar(100)
as
begin
	select * from dbo.admin where TaiKhoan =@userName and MatKhau =@passWord
end
go

-- Load thông tin của tài khoản
create PROCEDURE [dbo].[sp_load_account]
AS
BEGIN
	SELECT id_NhanVien AS N'ID',TaiKhoan AS N'Tài khoản',TaiKhoan AS N'Tên hiển thị', MatKhau AS N'Mật khẩu' FROM dbo.admin
END
GO

-- Thêm một tài khoản mới
create PROCEDURE [dbo].[sp_Add_Account]
 @ID nvarchar(100)
,@USERNAME nvarchar(100)
,@PASSWORD nvarchar(100)
AS
BEGIN
	INSERT INTO dbo.admin(id_NhanVien,TaiKhoan,MatKhau) VALUES (@ID,@USERNAME,@PASSWORD)
END
GO

-- Xóa một tài khoản
create PROCEDURE [dbo].[sp_Del_Account]
@USERNAME nvarchar(100)
AS
BEGIN
	DELETE dbo.admin WHERE Taikhoan = @USERNAME
END
GO

-- Cập nhật thông tin của một tài khoản
create PROCEDURE [dbo].[sp_Update_Account]
 @ID nvarchar(100)
,@USERNAME nvarchar(100)
,@PASSWORD nvarchar(100)
,@Where_USERNAME nvarchar(100)
AS
BEGIN
	UPDATE dbo.admin SET id_NhanVien=@ID, TaiKhoan = @USERNAME ,MatKhau =@PASSWORD WHERE TaiKhoan =@Where_USERNAME
END
GO

--======================================================================================================================================================================--

-- Load thông tin của nhân viên
create procedure sp_load_nhanvien
as
begin
	select id_NhanVien as N'ID', HoTen as N'Họ tên', GioiTinh as N'Giới tính',NgaySinh as N'Ngày sinh',
	ChucVu as N'Chức vụ',SDT as N'SĐT',Luong as N'Lương',KyNang as N'Kỹ năng' from dbo.NhanVien
end
go

-- Thêm mới một nhân viên
create procedure sp_Add_NhanVien
@ID varchar(100), @USERNAME nvarchar(100), @GT nvarchar(100), @NS date,
@CV nvarchar(100), @SDT nvarchar(100), @LUONG float,@KN nvarchar(100)
as
begin
	insert into dbo.NhanVien(id_NhanVien,HoTen,GioiTinh,NgaySinh,ChucVu,SDT,Luong,KyNang)
	values(@ID,@USERNAME,@GT,@NS,@CV,@SDT,@LUONG,@KN)
end
go

-- Xóa một nhân viên
CREATE PROCEDURE [dbo].[sp_Del_NhanVien]
@USERNAME nvarchar(100)
AS
BEGIN
	DELETE dbo.NhanVien WHERE HoTen = @USERNAME
END
GO

-- Sủa thông tin một nhân viên]
create proc sp_Update_NhanVien
@ID varchar(100), @USERNAME nvarchar(100), @GT nvarchar(100), @NS date,
@CV nvarchar(100), @SDT nvarchar(100), @LUONG float,@KN nvarchar(100)
,@Where_USERNAME nvarchar(100)
AS
BEGIN
	UPDATE dbo.NhanVien SET id_NhanVien=@ID,HoTen=@USERNAME,GioiTinh=@GT,NgaySinh=@NS,ChucVu=@CV,SDT=@SDT,Luong=@LUONG,KyNang=@KN WHERE HoTen =@Where_USERNAME
END
GO


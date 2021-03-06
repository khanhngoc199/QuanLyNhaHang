CREATE DATABASE QLNHang
GO

 USE  QLNHang
 GO
CREATE TABLE KHUVUC
(
	MAKV INT NOT NULL,
	TENKV NVARCHAR(20),
	TRANGTHAI NVARCHAR(20),
	PRIMARY KEY (MAKV),
);
 
 
 
CREATE TABLE BAN
(
	MABAN INT NOT NULL,
	TENBAN NVARCHAR(6),
	MAKV INT NOT NULL,
	TRANGTHAI NVARCHAR(20),
	TENKV NVARCHAR(20),
	PRIMARY KEY (MABAN),
	FOREIGN KEY (MAKV) REFERENCES KHUVUC,
);



CREATE TABLE BOPHAN
(
	MABP INT NOT NULL,
	TENBP NVARCHAR(50),
	PRIMARY KEY (MABP),
);
CREATE TABLE BAOCAO
(
	TENBAN NVARCHAR(6) NOT NULL,
	NGAY DATETIME,
	TONGTIEN float,
);

CREATE TABLE NHANVIEN
(
	MANV INT NOT NULL,
	MABP INT NOT NULL,
	TENNV NVARCHAR(50),
	GIOITINH NVARCHAR(3),
	NGAYSINH DATETIME,
	DIACHI NVARCHAR(50),
	DIENTHOAI NVARCHAR(20),
	TENBP NVARCHAR(50),
	PRIMARY KEY (MANV),
	FOREIGN KEY(MABP)REFERENCES BOPHAN,
);



CREATE TABLE NHOMNGUYENLIEU
(
	MANNL INT NOT NULL,
	TENNNL NVARCHAR(50),
	PRIMARY KEY (MANNL),
);

CREATE TABLE NGUYENLIEU
(
	MANL INT NOT NULL,
	MANNL INT NOT NULL,
	TENNL NVARCHAR(50),
	TENNNL NVARCHAR(50),
	DONGIA FLOAT,
	DONVITINH NVARCHAR(50),
	PRIMARY KEY (MANL),
	FOREIGN KEY(MANNL)REFERENCES NHOMNGUYENLIEU,
);


CREATE TABLE NHOMMONAN
(
	MANMA INT NOT NULL,
	TENNMA NVARCHAR(50),
	PRIMARY KEY (MANMA),
);


CREATE TABLE MONAN
(
	MAMA INT NOT NULL,
	MANMA INT NOT NULL,
	TENMA NVARCHAR(50),
	DONGIA FLOAT,
	DONVITINH NVARCHAR(50),
	TENNMA NVARCHAR(50),
	SOLUONG INT,
	TRANGTHAI NVARCHAR(20),
	PRIMARY KEY (MAMA),
	FOREIGN KEY(MANMA)REFERENCES NHOMMONAN,
);




CREATE TABLE DINHLUONG
(
	MADL INT NOT NULL,
	MAMA INT NOT NULL, 
	MANL INT NOT NULL,
	SOLUONG FLOAT,
	PRIMARY KEY (MADL),
	FOREIGN KEY(MAMA)REFERENCES MONAN,
	FOREIGN KEY(MANL)REFERENCES NGUYENLIEU,
);

CREATE TABLE HOADONXUAT
(
	MAHDX INT NOT NULL,
	MABAN INT NOT NULL,
	MANV INT NOT NULL,
	TONGTIEN FLOAT,
	THOIGIANVAO DATETIME,
	THOIGIANRA DATETIME,
	GIAMGIA FLOAT,
	TRANGTHAI INT NOT NULL,
	PRIMARY KEY (MAHDX),
	FOREIGN KEY(MABAN)REFERENCES BAN,
	FOREIGN KEY(MANV)REFERENCES NHANVIEN,
);



CREATE TABLE CHITIETHOADONXUAT
(
	MACTHDX INT NOT NULL,
	MAHDX INT NOT NULL,
	MAMA INT NOT NULL,
	SOLUONG FLOAT,
	GIAMGIA FLOAT,
	SOORDERS NVARCHAR(50),
	PRIMARY KEY (MACTHDX),
	FOREIGN KEY(MAHDX)REFERENCES HOADONXUAT,
	FOREIGN KEY(MAMA)REFERENCES MONAN,
);

CREATE TABLE NGUOIDUNG
(
	MAND INT NOT NULL,
	TENND NVARCHAR(50),
	MATKHAU NVARCHAR(50),
	PRIMARY KEY (MAND),
);

CREATE TABLE FORM
(
	TENFORM NVARCHAR(50) NOT NULL,
	PRIMARY KEY(TENFORM),
);

CREATE TABLE QUYEN_FORM
(
	MAQUYEN_FORM INT NOT NULL,
	TENFORM NVARCHAR(50) NOT NULL,
	MAND INT NOT NULL,
	MANV INT NOT NULL,
	TONGQUYEN NVARCHAR(10),
	PRIMARY KEY (MAQUYEN_FORM),
	FOREIGN KEY(MAND)REFERENCES NGUOIDUNG,
	FOREIGN KEY(MANV)REFERENCES NHANVIEN,
	FOREIGN KEY(TENFORM) REFERENCES FORM,
);
GO
SELECT * FROM DBO.NHANVIEN
-----------Nhân viên-----------
GO
CREATE PROC USP_insertNhanVien
@manv INT,
@tenbp NVARCHAR(50),
@ten NVARCHAR(100),
@gioitinh NVARCHAR(100),
@ngaysinh DATETIME,
@diachi NVARCHAR(100),
@dienthoai NVARCHAR(20)
AS
BEGIN
DECLARE @mabp INT
SELECT @mabp = b.MABP FROM dbo.BOPHAN b WHERE TENBP = @tenbp
	INSERT dbo.NHANVIEN
	        ( 
			  MANV,
			  MABP ,			  
			  TENBP,
	          TENNV ,
	          GIOITINH ,
	          NGAYSINH,
			  DIACHI,
			  DIENTHOAI
	        )
	VALUES  ( 
				@manv,
				@mabp,				
				@tenbp,				
				@ten,
				@gioitinh,
				@ngaysinh,
				@diachi,
				@dienthoai
	        )
END
GO
CREATE PROC USP_update
@manv INT,
@tenbp NVARCHAR(50),
@ten NVARCHAR(100),
@gioitinh NVARCHAR(100),
@ngaysinh DATETIME,
@diachi NVARCHAR(100),
@dienthoai NVARCHAR(20)
AS
BEGIN
DECLARE @mabp INT
SELECT @mabp = b.MABP FROM dbo.BOPHAN b WHERE TENBP = @tenbp
UPDATE dbo.NHANVIEN 
SET MABP = @mabp,
	TENBP = @tenbp,
	TENNV = @ten,
	GIOITINH = @gioitinh,
	NGAYSINH = @ngaysinh,
	DIACHI =@diachi,
	DIENTHOAI = @dienthoai	 
WHERE MANV=@manv
END
GO
CREATE PROC USP_deleteNhanVien
@manv INT
AS
BEGIN
DELETE dbo.NHANVIEN WHERE MANV = @manv
END
GO
-----------Khu vực-----------
GO
CREATE PROC USP_insertKhuVuc
@makv INT,
@tenkv NVARCHAR(20),
@trangthai NVARCHAR(20)
AS
BEGIN
INSERT dbo.KHUVUC(MAKV,TENKV,TRANGTHAI)
VALUES (@makv,@tenkv,@trangthai)
END

GO
CREATE PROC usp_updateKhuVuc
@makv INT,
@tenkv NVARCHAR(20),
@trangthai NVARCHAR(20)
AS
BEGIN
UPDATE dbo.KHUVUC
SET TENKV = @tenkv,
	TRANGTHAI = @trangthai
WHERE MAKV = @makv
END
GO
SELECT * FROM DBO.BAN
-----------Bàn-----------
GO
CREATE PROC USP_insertBan
@maban INT,
@tenban NVARCHAR(6),
@tenkhuvuc NVARCHAR(20),
@trangthai NVARCHAR(20)
AS
BEGIN
DECLARE @makv INT
SELECT @makv = kv.MAKV FROM dbo.KHUVUC kv WHERE TENKV = @tenkhuvuc
INSERT dbo.BAN(MABAN,TENBAN,MAKV,TENKV,TRANGTHAI)
VALUES (@maban,@tenban,@makv,@makv,@trangthai)
END
GO

GO
CREATE PROC USP_updateBan
@maban INT,
@tenban NVARCHAR(6),
@tenkhuvuc NVARCHAR(20),
@trangthai NVARCHAR(20)
AS
BEGIN
DECLARE @makv INT
SELECT @makv = kv.MAKV  FROM dbo.KHUVUC kv WHERE TENKV = @tenkhuvuc
UPDATE dbo.BAN
SET 
	TENBAN = @tenban,
	MAKV = @makv,
	TENKV = @tenkhuvuc,
	TRANGTHAI = @trangthai
WHERE MABAN = @maban
END
GO

GO
CREATE PROC USP_deleteBan
@maban INT
AS
BEGIN
DELETE dbo.BAN WHERE MABAN = @maban
END
-----------Nhóm món ăn-----------
GO
CREATE PROC USP_insertMaMA
@manma INT,
@tennma NVARCHAR(50)
AS
BEGIN
INSERT dbo.NHOMMONAN(MANMA,TENNMA)
VALUES(@manma,@tennma)
END
GO
CREATE PROC USP_updateMaMA
@manma INT,
@tennma NVARCHAR(50)
AS
BEGIN
UPDATE dbo.NHOMMONAN
SET 
	TENNMA = @tennma
WHERE MANMA = @manma
END
GO
CREATE PROC USP_deleteMaMA
@manma INT
AS
BEGIN
DELETE dbo.NHOMMONAN  WHERE MANMA = @manma
END
GO
-----------Món ăn-----------
Go
CREATE PROC USP_insertMonAn
@tennhommonan NVARCHAR(50),
@mamonan INT,
@tenmonan NVARCHAR(50),
@dongia float,
@donvitinh NVARCHAR(50),
@trangthai NVARCHAR(20)
AS
BEGIN
DECLARE @manhom INT
SELECT @manhom = dbn.MANMA FROM dbo.NHOMMONAN dbn WHERE TENNMA = @tennhommonan
INSERT dbo.MONAN(MAMA,MANMA,TENNMA,TENMA,DONGIA,DONVITINH,TRANGTHAI)
VALUES(@mamonan,@manhom,@tennhommonan,@tenmonan,@dongia,@donvitinh,@trangthai)
END
select*from dbo.MONAN
Go
CREATE PROC USP_updateMonAn
@tennhommonan NVARCHAR(50),
@mamonan INT,
@tenmonan NVARCHAR(50),
@dongia float,
@donvitinh NVARCHAR(50),
@trangthai NVARCHAR(20)
AS
BEGIN
DECLARE @manhom INT
SELECT @manhom = dbn.MANMA FROM dbo.NHOMMONAN dbn WHERE TENNMA = @tennhommonan
UPDATE dbo.MONAN
SET MANMA = @manhom,
	TENMA =@tenmonan,
	TENNMA = @tennhommonan,
	DONGIA = @dongia,
	DONVITINH= @donvitinh,
	TRANGTHAI = @trangthai
WHERE MAMA = @mamonan
END

GO
CREATE PROC USP_deleteMonAn
@mamon INT
AS
BEGIN
DELETE dbo.MONAN
WHERE MAMA = @mamon
END
GO
CREATE PROC USP_getListFood
@id INT
AS
BEGIN
SELECT * FROM dbo.MONAN WHERE MANMA = @id
END
GO
CREATE PROC USP_getMaMon
@ten NVARCHAR(50)
AS
BEGIN
SELECT ma.MANMA FROM DBO.MONAN ma WHERE TENMA = @ten
END
GO
----Insert user và bộ phận ----
INSERT dbo.NGUOIDUNG(MAND,TENND,MATKHAU)
VALUES (1,'admin','admin')
GO
INSERT dbo.BOPHAN(MABP,TENBP)
VALUES (1,N'Quản Lý')
GO
INSERT dbo.BOPHAN(MABP,TENBP)
VALUES (2,N'Nhân Viên')
----Nhóm nguyên liệu ----
GO
CREATE PROC USP_insertNhomNL
@mannl INT,
@tennnl NVARCHAR(50)
AS
BEGIN
INSERT dbo.NHOMNGUYENLIEU(MANNL,TENNNL)
VALUES(@mannl,@tennnl)
END
GO
CREATE PROC USP_updateNhomNL
@mannl INt,
@tennnl NVARCHAR(50)
AS
BEGIN
UPDATE dbo.NHOMNGUYENLIEU
SET TENNNL = @tennnl
WHERE MANNL = @mannl
END
GO
CREATE PROC USP_deleteNhomNL
@mannl INT
AS
BEGIN
DELETE dbo.NGUYENLIEU WHERE MANNL = @mannl
DELETE dbo.NHOMNGUYENLIEU
WHERE MANNL = @mannl
END
GO
------------Nguyên liệu------
GO
CREATE PROC USP_insertNguyenLieu
@manl INT,
@tennl NVARCHAR(50),
@dongia FLOAT,
@donvitinh NVARCHAR(50),
@ten NVARCHAR(50)
AS
BEGIN
DECLARE @mannl INT
SELECT @mannl = nl.MANNL FROM dbo.NHOMNGUYENLIEU nl WHERE TENNNL = @ten
INSERT dbo.NGUYENLIEU(MANL,MANNL,TENNL,DONGIA,DONVITINH)
VALUES(@manl,@mannl,@tennl,@dongia,@donvitinh)
END
GO
CREATE PROC USP_updateNLL
@manl INT,
@tennnl NVARCHAR(50),
@tennl NVARCHAR(50),
@dongia FLOAT,
@donvitinh NVARCHAR(50)
AS
BEGIN
DECLARE @mannl INT
SELECT @mannl = nl.MANNL FROM dbo.NHOMNGUYENLIEU nl WHERE TENNNL = @tennnl
UPDATE dbo.NGUYENLIEU
SET MANNL = @mannl , TENNL = @tennl , DONGIA =@dongia,DONVITINH= @donvitinh
WHERE MANL = @manl
END
GO 
CREATE PROC USP_deletenNL
@manl INT
AS
BEGIN
DELETE dbo.NGUYENLIEU
WHERE MANL = @manl
END
----Bộ phận ----
GO
CREATE PROC USP_insertBoPhan
@ma INT,
@ten NVARCHAR(50)
AS
BEGIN
INSERT dbo.BOPHAN(MABP,TENBP)
VALUES(@ma,@ten)
END
GO
CREATE PROC USP_creatUser
@manv int,
@user NVARCHAR(50),
@matkhau NVARCHAR(50)
AS
BEGIN
INSERT dbo.NGUOIDUNG(MAND,TENND,MATKHAU)
VALUES(@manv,@user,@matkhau)
END
----Đổi mật khẩu ----
GO
CREATE PROC USP_updateUser
@user NVARCHAR(50),
@pass NVARCHAR(50),
@pass1 NVARCHAR(50)
AS
BEGIN
UPDATE dbo.NGUOIDUNG
SET 
	MATKHAU = @pass1
WHERE TENND = @user AND MATKHAU = @pass
END
INSERT INTO KHUVUC VALUES ('1',N'Trong nhà',N'Hoạt động'),
						  ('2',N'Sân vườn',N'Hoạt động'),
						  ('3',N'Sân thượng',N'Hoạt động'),
						  ('4',N'Tầng 2',N'Hoạt động'),
						  ('5',N'Tầng 3',N'Hoạt động')
						  
select * from dbo.BAN				  
INSERT INTO BAN VALUES ('1',N'Bàn 1','1',N'Còn trống','Trong nhà'),
					   ('2',N'Bàn 2','1',N'Còn trống','Trong nhà'),
					   ('3',N'Bàn 3','3',N'Còn trống','Sân thượng'),
					   ('4',N'Bàn 4','3',N'Còn trống','Sân thượng'),
					   ('5',N'Bàn 5','4',N'Còn trống','Tầng 2'),
					   ('6',N'Bàn 6','4',N'Còn trống','Tầng 2'),
					   ('7',N'Bàn 7','5',N'Còn trống','Tần 3'),
					   ('8',N'Bàn 8','1',N'Còn trống','Trong nhà'),
					   ('9',N'Bàn 9','2',N'Còn trống','Sân vườn'),
					   ('10',N'Bàn 10','3',N'Còn trống','Sân thượng'),
					   ('11',N'Bàn 11','1',N'Còn trống','Trong nhà'),
					   ('12',N'Bàn 12','1',N'Còn trống','Trong nhà')


INSERT INTO NHANVIEN VALUES ('1','1',N'Vũ Hoàng Anh',N'Nam','02/01/1999',N'TP.HCM','023458692',N'Quản Lý'),
							('2','2',N'Nguyễn Quốc Cường',N'Nam','12/01/1999',N'TP.HCM','0163438672',N'Nhân Viên'),
							('3','2',N'Đỗ Thị Ánh Nguyệt',N'Nữ','05/005/1999',N'TP.HCM','0167640901',N'Nhân Viên'),
							('4','2',N'Ngô Duy Tuấn',N'Nam','09/11/1999',N'TP.HCM','0165509035',N'Nhân Viên'),
							('5','2',N'Dương Thiên Phong',N'Nữ','02/11/1995',N'TP.HCM','0964432932',N'Nhân Viên')

Select * from dbo.NHANVIEN
INSERT INTO NHOMNGUYENLIEU VALUES ('1',N'Cá'),
								  ('2',N'Thịt'),
								  ('3',N'Rau'),
								  ('4',N'Nước')	
								  
INSERT INTO NGUYENLIEU VALUES ('1','1',N'Cá thu','100000',N'Con'),
							  ('2','1',N'Cá chép','120000',N'Con'),
							  ('3','1',N'Cá lóc','80000',N'Con'),
							  ('4','2',N'Thịt bò','30000',N'Lạng'),
							  ('5','2',N'Thịt ba rọi','20000',N'Lạng'),
							  ('6','2',N'Thịt heo sườn','250000',N'Ký'),
							  ('7','3',N'Rau muống','60000',N'Ký'),
							  ('8','3',N'Rau cải','60000',N'Ký'),
							  ('9','3',N'Bông cải trắng','100000',N'Ký')								  					


INSERT INTO NHOMMONAN VALUES ('1',N'Hải sản'),
							 ('2',N'Nước uống'),
							 ('3',N'Cháo'),
							 ('4',N'Tráng miệng'),
							 ('5',N'Món chính')

select * from dbo.MONAN
INSERT INTO MONAN VALUES ('1','1',N'Lẩu tôm hùm','30000',N'Con',N'Còn hàng','Hải sản'),
						 ('2','1',N'Ốc xào sả','60000',N'Đĩa',N'Còn hàng','Hải sản'),
						 ('3','1',N'Sò chua ngọt','70000',N'Đĩa',N'Còn hàng','Hải sản'),
						 ('4','2',N'Rượu vang','500000',N'Chai',N'Còn hàng','Nước uống'),
						 ('5','2',N'Nước suối','20000',N'Chai',N'Còn hàng','Nước uống'),
						 ('6','2',N'Coca','30000',N'Lon',N'Còn hàng','Nước uống'),
						 ('7','3',N'Cháo vịt','100000',N'Tô',N'Còn hàng','Cháo'),
						 ('8','3',N'Cháo gà','120000',N'Tô',N'Còn hàng','Cháo'),
						 ('9','4',N'Kem','30000',N'Ly',N'Còn hàng','Tráng miệng'),
						 ('10','4',N'Chè hạt sen','40000',N'Ly',N'Còn hàng','Tráng miệng'),
						 ('11','4',N'Chè trái cây','40000',N'Ly',N'Còn hàng','Tráng miệng'),
						 ('12','4',N'Chè thập cẩm','40000',N'Ly',N'Còn hàng','Tráng miệng'),
						 ('13','5',N'Bắp bò hấp cải thìa','80000',N'Đĩa',N'Còn hàng','Món chính'),
						 ('14','5',N'Cà ri dê','150000',N'Tô',N'Còn hàng','Món chính'),
						 ('15','5',N'Nấm thập cẩm xào tỏi','60000',N'Đĩa',N'Còn hàng','Món chính'),
						 ('16','5',N'Rau càng cua xào thịt bò','1100000',N'Đĩa',N'Còn hàng','Món chính')


SELECT *  FROM dbo.MONAN
GO
CREATE PROC USP_getListBan
	AS SELECT * FROM DBO.BAN
EXEC dbo.USP_getListBan
GO
SELECT a.MAMA ,a.TENMA as 'Name' , B.TENNMA as 'TENNMA', A.DONGIA as 'Gia' FROM DBO.MONAN a, DBO.NHOMMONAN B where a.TENMA like  N'%a%' and a.MAMA=b.MANMA


CREATE PROC USP_InsertBill
 (	
	@MABAN int
 )
 AS 
 BEGIN
	insert dbo.HOADONXUAT(THOIGIANVAO, THOIGIANRA,MABAN,TRANGTHAI,GIAMGIA)
	values(GETDATE(),NULL,@MABAN,0,0)
END
GO


ALTER PROC USP_InsertBillInfor
@MAHDX INT, @MAMA INT, @SOLUONG FLOAT
AS
BEGIN
	DECLARE @isExitBillInfo INT;
	DECLARE @foodCount INT=1;
	SELECT @isExitBillInfo = MACTHDX,@foodCount = SOLUONG FROM DBO.CHITIETHOADONXUAT WHERE MAHDX = @MAHDX AND MAMA = @MAMA
	IF(@isExitBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @SOLUONG
		IF(@newCount > 0)
			UPDATE DBO.CHITIETHOADONXUAT SET SOLUONG = @foodCount + @SOLUONG WHERE MAMA = @MAMA
		ELSE	
			DELETE 	DBO.CHITIETHOADONXUAT WHERE MAHDX = @MAHDX AND MAMA = @MAMA
	END	
	ELSE
	INSERT DBO.CHITIETHOADONXUAT
		(MAHDX, MAMA, SOLUONG)
VALUES(	@MAHDX,@MAMA,@SOLUONG)
END


CREATE DATABASE QuanLyKhachSan
GO

USE QuanLyKhachSan
GO

-- Client
-- Account
-- Room
-- TableTable
-- Service
-- Food
-- FoodCategory
-- Bill
-- BillInfo

CREATE TABLE Client
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100)
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Tai Khoan',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)
GO

CREATE TABLE Room
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'	
)
GO

CREATE TABLE TableTable
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'	
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE xService
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	price FLOAT NOT NULL DEFAULT 0
)	
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idRoom INT ,
	idTable INT,
	status INT NOT NULL DEFAULT 0 -- 1: đã thanh toán && 0: chưa thanh toán
	
	FOREIGN KEY (idRoom) REFERENCES dbo.Room(id),
	FOREIGN KEY (idTable) REFERENCES dbo.TableTable(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idService INT ,
	idFood INT ,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idService) REFERENCES dbo.xService(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
	
)
GO

INSERT INTO dbo.Account
        ( UserName ,
          DisplayName ,
          PassWord ,
          Type
        )
VALUES  ( N'admin' , -- UserName - nvarchar(100)
          N'Admin' , -- DisplayName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(1000)
          1  -- Type - int
        )
INSERT INTO dbo.Account
        ( UserName,
          DisplayName,
          PassWord,
          Type
        )
VALUES  ( N'staff' , -- UserName - nvarchar(100)
          N'staff' , -- DisplayName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(1000)
          0  -- Type - int
        )
GO

CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS 
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName
END
GO

CREATE PROC USP_fLogin
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO

EXEC dbo.USP_GetAccountByUserName @userName = N'admin' -- nvarchar(100)

GO

DECLARE @i INT = 0

WHILE @i <= 10
BEGIN
	INSERT dbo.TableTable ( name)VALUES  ( N'Bàn ' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1
END

GO

CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.TableTable

GO



EXEC dbo.USP_GetTableList

GO

DECLARE @i INT = 0

WHILE @i <= 10
BEGIN
	INSERT dbo.Room ( name)VALUES  ( N'Phòng ' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1
END

GO

CREATE PROC USP_GetRoomList
AS SELECT * FROM dbo.Room

GO



EXEC dbo.USP_GetRoomList

GO
       



-- thêm dịch vụ

INSERT dbo.xService
        ( name, price )
VALUES  ( N'Giá phòng theo ngày', 300000)
INSERT dbo.xService
        ( name, price )
VALUES  ( N'Nhận sớm mỗi giờ', 30000)
INSERT dbo.xService
        ( name, price )
VALUES  ( N'Nhận muộn mỗi giờ', 30000)


-- thêm bill

INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idRoom ,
          status
        )
VALUES  ( GETDATE() , -- DateCheckIn - date
          NULL , -- DateCheckOut - date
          3 , -- idRoom - int
          0  -- status - int
        )
        
INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idRoom ,
          status
        )
VALUES  ( GETDATE() , 
          NULL , 
          4, 
          0  
        )
INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idRoom ,
          status
        )
VALUES  ( GETDATE() , 
          GETDATE() , 
          5 , 
          1  
        )
       
-- thêm bill info     
 
INSERT	dbo.BillInfo
        ( idBill, idService, count )
VALUES  ( 1, -- idBill - int
          2, -- idService - int
          2  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idService, count )
VALUES  ( 2, 
          3, 
          4  
          )

INSERT	dbo.BillInfo
        ( idBill, idService, count )
VALUES  ( 3,
          1,
          2  
          )
 
          
GO      

   
-- Ban an
-- thêm category
INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Đồ ăn'  -- name - nvarchar(100)
          )
INSERT dbo.FoodCategory
        ( name )
VALUES  ( N'Nước uống' )

-- thêm món ăn
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Thịt lợn luộc', -- name - nvarchar(100)
          1, -- idCategory - int
          85000)
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Cá chép luộc', 1, 120000)
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Rau muống luộc', 1, 999999)
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Fanta', 2, 12000)
INSERT dbo.Food
        ( name, idCategory, price )
VALUES  ( N'Pepsi', 2, 15000)


-- thêm bill
INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idTable ,
          status
        )
VALUES  ( GETDATE() , -- DateCheckIn - date
          NULL , -- DateCheckOut - date
          3 , -- idTable - int
          0  -- status - int
        )
        
INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idTable ,
          status
        )
VALUES  ( GETDATE() , -- DateCheckIn - date
          NULL , -- DateCheckOut - date
          4, -- idTable - int
          0  -- status - int
        )
INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idTable ,
          status
        )
VALUES  ( GETDATE() , -- DateCheckIn - date
          GETDATE() , -- DateCheckOut - date
          5 , -- idTable - int
          1  -- status - int
        )

-- thêm bill info
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 5, -- idBill - int
          1, -- idFood - int
          2  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 5, -- idBill - int
          3, -- idFood - int
          4  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 5, -- idBill - int
          5, -- idFood - int
          1  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 6, -- idBill - int
          1, -- idFood - int
          2  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 6, -- idBill - int
          3, -- idFood - int
          2  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 3, -- idBill - int
          5, -- idFood - int
          2  -- count - int
          )         
          
GO

CREATE PROC USP_InsertBill
@idTable INT
AS
BEGIN
	INSERT dbo.Bill
	        ( DateCheckIn ,
	          DateCheckOut ,
	          idTable ,
	          status
	          	     
	        )
	VALUES  ( GETDATE() , -- DateCheckIn - date
	          NULL , -- DateCheckOut - date
	          @idTable , -- idTable - int
	          0   -- status - int
	          
	        )
END
GO

CREATE PROC USP_InsertBillRoom
@idRoom INT
AS
BEGIN
	INSERT dbo.Bill 
	        ( DateCheckIn ,
	          DateCheckOut ,
	          idRoom ,
	          status 
	          
	        )
	VALUES  ( GETDATE() , -- DateCheckIn - date
	          NULL , -- DateCheckOut - date
	          @idRoom , -- idTable - int
	          0  -- status - int	          
	        )
END
GO

CREATE PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN

	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1
	
	SELECT @isExitsBillInfo = id, @foodCount = b.count 
	FROM dbo.BillInfo AS b 
	WHERE idBill = @idBill AND idFood = @idFood

	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0)
			UPDATE dbo.BillInfo	SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		INSERT	dbo.BillInfo
        ( idBill, idFood, count )
		VALUES  ( @idBill, -- idBill - int
          @idFood, -- idFood - int
          @count  -- count - int
          )
	END
END
GO

-- room

CREATE PROC USP_InsertBillInfoRoom
@idBill INT, @idService INT, @count INT
AS
BEGIN

	DECLARE @isExitsBillInfo INT
	DECLARE @serviceCount INT = 1
	
	SELECT @isExitsBillInfo = id, @serviceCount = b.count 
	FROM dbo.BillInfo AS b 
	WHERE idBill = @idBill AND idService = @idService

	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @serviceCount + @count
		IF (@newCount > 0)
			UPDATE dbo.BillInfo	SET count = @serviceCount + @count WHERE idService = @idService
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idService = @idService
	END
	ELSE
	BEGIN
		INSERT	dbo.BillInfo
        ( idBill, idService, count )
		VALUES  ( @idBill, -- idBill - int
          @idService, -- idFood - int
          @count  -- count - int
          )
	END
END
GO

DELETE dbo.BillInfo

DELETE dbo.Bill
GO
---- thanh toan ban an

CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = idBill FROM Inserted
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0
	
	UPDATE dbo.TableTable SET status = N'Có người' WHERE id = @idTable
END
GO

CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = id FROM Inserted	
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	
	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0
	
	IF (@count = 0)
		UPDATE dbo.TableTable SET status = N'Trống' WHERE id = @idTable
END
GO

---- thanh toan phong

CREATE TRIGGER UTG_UpdateBillInfoRoom

ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = idBill FROM Inserted
	
	DECLARE @idRoom INT
	
	SELECT @idRoom = idRoom FROM dbo.Bill WHERE id = @idBill AND status = 0
	
	UPDATE dbo.Room SET status = N'Có người' WHERE id = @idRoom
END
GO

CREATE TRIGGER UTG_UpdateBillRoom
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = id FROM Inserted	
	
	DECLARE @idRoom INT
	
	SELECT @idRoom = idRoom FROM dbo.Bill WHERE id = @idBill
	
	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idRoom = @idRoom AND status = 0
	
	IF (@count = 0)
		UPDATE dbo.Room SET status = N'Trống' WHERE id = @idRoom
END
GO

-- thong ke hoa don

ALTER TABLE dbo.Bill ADD totalPrice FLOAT

DELETE dbo.BillInfo
DELETE dbo.Bill

GO

CREATE PROC USP_GetListBillByDate
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT t.name AS [Tên], b.totalPrice AS [Tổng tiền], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra] 
	FROM dbo.Bill AS b,dbo.Room AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idRoom
END
GO





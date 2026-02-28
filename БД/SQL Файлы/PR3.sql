
CREATE DATABASE [Практическая_3]
GO
USE [Практическая_3]
GO
CREATE TABLE [Customer]
(
IdCust int IDENTITY(1, 1) PRIMARY KEY,
FName nvarchar(50) NOT NULL,
LName nvarchar(50) NOT NULL,
IdCity int NOT NULL,
[Address] nvarchar(100),
Zip nchar(6) NOT NULL CHECK (Zip LIKE '[0-9][0-9][0-9][0-9][0-9][0-9]'),
Phone nchar(12) NULL UNIQUE
);
GO

CREATE TABLE [Order]
(
IdOrd int IDENTITY PRIMARY KEY,
IdCust int,
OrdDate datetime DEFAULT GETDATE()
);
GO

ALTER TABLE [Order]
ADD CONSTRAINT FK_Order_Customer
FOREIGN KEY (IdCust) REFERENCES Customer (IdCust)
GO

CREATE TABLE City 
(
IdCity int IDENTITY PRIMARY KEY,
CityName nvarchar(20) UNIQUE NOT NULL,
);
GO
CREATE TABLE OrdItem 
(
IdOrd int,
IdProduct int,
Qty int NOT NULL CHECK (Qty >= 0),
Price decimal(10, 2) NOT NULL CHECK (Price >= 0),
PRIMARY KEY (IdOrd, IdProduct)
);
GO
CREATE TABLE [Product] 
(
IdProduct int IDENTITY PRIMARY KEY,
[Description] nvarchar(100) UNIQUE NOT NULL,
InStock int NOT NULL DEFAULT 0 CHECK (InStock >= 0),
);
GO
ALTER TABLE OrdItem
ADD CONSTRAINT FK_OrdItem_Order
FOREIGN KEY(IdOrd) REFERENCES [Order](IdOrd) ON DELETE CASCADE
GO
ALTER TABLE Customer
ADD CONSTRAINT FK_Customer_City 
FOREIGN KEY(IdCity) REFERENCES City(IdCity)
GO
ALTER TABLE OrdItem
ADD CONSTRAINT FK_OrdItem_Product 
FOREIGN KEY(IdProduct) REFERENCES [Product](IdProduct)
GO



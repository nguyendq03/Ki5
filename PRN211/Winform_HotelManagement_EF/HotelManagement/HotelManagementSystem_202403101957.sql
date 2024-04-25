CREATE DATABASE HotelManagementSystem;

USE HotelManagementSystem
GO

IF DB_NAME() <> N'HotelManagementSystem' SET NOEXEC ON
GO

--
-- Create table [dbo].[Rooms]
--
PRINT (N'Create table [dbo].[Rooms]')
GO
CREATE TABLE dbo.Rooms (
  RoomID int IDENTITY,
  RoomType varchar(50) NULL,
  Status varchar(50) NULL,
  Price float NULL,
  CONSTRAINT PK_Rooms_RoomID PRIMARY KEY CLUSTERED (RoomID)
)
ON [PRIMARY]
GO

--
-- Create table [dbo].[Customers]
--
PRINT (N'Create table [dbo].[Customers]')
GO
CREATE TABLE dbo.Customers (
  CustomerID int IDENTITY,
  Name varchar(100) NULL,
  PhoneNumber varchar(20) NULL,
  Email varchar(100) NULL,
  Address varchar(200) NULL,
  CONSTRAINT PK_Customers_CustomerID PRIMARY KEY CLUSTERED (CustomerID)
)
ON [PRIMARY]
GO

--
-- Create table [dbo].[Bookings]
--
PRINT (N'Create table [dbo].[Bookings]')
GO
CREATE TABLE dbo.Bookings (
  BookingID int IDENTITY,
  CustomerID int NULL,
  RoomID int NULL,
  CheckInDate datetime NULL,
  CheckOutDate datetime NULL,
  TotalPrice float NULL,
  CONSTRAINT PK_Bookings_BookingID PRIMARY KEY CLUSTERED (BookingID)
)
ON [PRIMARY]
GO

-- 
-- Dumping data for table Rooms
--
PRINT (N'Dumping data for table Rooms')
SET IDENTITY_INSERT dbo.Rooms ON
GO
INSERT dbo.Rooms(RoomID, RoomType, Status, Price) VALUES (1, 'Director of Manufacturing', 'Pallet', 156.86)
INSERT dbo.Rooms(RoomID, RoomType, Status, Price) VALUES (2, 'Technical Specialist', 'Bag', 57.68)
INSERT dbo.Rooms(RoomID, RoomType, Status, Price) VALUES (3, 'Lead Engineer', 'Carton', 69.47)
INSERT dbo.Rooms(RoomID, RoomType, Status, Price) VALUES (4, 'Director of Customer Support', 'Packet', 46.18)
INSERT dbo.Rooms(RoomID, RoomType, Status, Price) VALUES (5, 'Communication Engineer', 'Tube', 148.69)
INSERT dbo.Rooms(RoomID, RoomType, Status, Price) VALUES (6, 'Director of Information Technology', 'Pallet', 131.9)
INSERT dbo.Rooms(RoomID, RoomType, Status, Price) VALUES (7, 'Product Manager', 'Can', 70)
INSERT dbo.Rooms(RoomID, RoomType, Status, Price) VALUES (8, 'Developer/Programmer', 'Bag', 143.48)
INSERT dbo.Rooms(RoomID, RoomType, Status, Price) VALUES (9, 'Development Manager', 'Pair', 138.34)
INSERT dbo.Rooms(RoomID, RoomType, Status, Price) VALUES (10, 'Product Manager', 'Packet', 13.35)
GO
SET IDENTITY_INSERT dbo.Rooms OFF
GO

-- 
-- Dumping data for table Customers
--
PRINT (N'Dumping data for table Customers')
SET IDENTITY_INSERT dbo.Customers ON
GO
INSERT dbo.Customers(CustomerID, Name, PhoneNumber, Email, Address) VALUES (1, 'Conrad1997', '(951) 501-9191', 'Conrad_Frizzell61@example.com', '1388 Parkwood Loop, STE 31, Lansing, Michigan, 24438')
INSERT dbo.Customers(CustomerID, Name, PhoneNumber, Email, Address) VALUES (2, 'Drew10', '(873) 033-1497', 'Schuler@example.com', '2083 SE Bayview Hwy, Diamond Bldg, Austin, Texas, 35512')
INSERT dbo.Customers(CustomerID, Name, PhoneNumber, Email, Address) VALUES (3, 'Kim1953', '(286) 206-7080', 'ZapataF@example.com', '3782 Hidden Meadowview Avenue, Comcast Bldg, Phoenix, AZ, 14366')
INSERT dbo.Customers(CustomerID, Name, PhoneNumber, Email, Address) VALUES (4, 'Latonya2022', '(826) 193-9372', 'Sanford549@nowhere.com', '56 Front Way, 7th Floor, Salem, Oregon, 66021')
INSERT dbo.Customers(CustomerID, Name, PhoneNumber, Email, Address) VALUES (5, 'Stamm465', '(967) 582-3086', 'Barr@nowhere.com', '646 SE Ironwood Avenue, Little Rock, Arkansas, 83249')
INSERT dbo.Customers(CustomerID, Name, PhoneNumber, Email, Address) VALUES (6, 'Winkler2019', '(812) 301-5300', 'Almanza@example.com', '1086 Brentwood Blvd, Dover, DE, 59369')
INSERT dbo.Customers(CustomerID, Name, PhoneNumber, Email, Address) VALUES (7, 'Brendan547', '(537) 222-1190', 'Ron.Irish@example.com', '94 North Chapel Hill Pkwy, APT 436, Frankfort, Kentucky, 94314')
INSERT dbo.Customers(CustomerID, Name, PhoneNumber, Email, Address) VALUES (8, 'Gino2022', '(236) 929-0143', 'ktercnnp_okcisx@example.com', '3543 Rockwood Way, Bartlett Building, Santa Fe, NM, 74100')
INSERT dbo.Customers(CustomerID, Name, PhoneNumber, Email, Address) VALUES (9, 'Abby664', '(748) 666-0948', 'mnksgeiq8021@example.com', '296 SW Rockwood Blvd, Comcast Building, Saint Paul, Minnesota, 63918')
INSERT dbo.Customers(CustomerID, Name, PhoneNumber, Email, Address) VALUES (10, 'Jolene437', '(173) 265-2255', 'Atwood@nowhere.com', '291 E Market Pkwy, Helena, MT, 32277')
GO
SET IDENTITY_INSERT dbo.Customers OFF
GO

-- 
-- Dumping data for table Bookings
--
PRINT (N'Dumping data for table Bookings')
SET IDENTITY_INSERT dbo.Bookings ON
GO
INSERT dbo.Bookings(BookingID, CustomerID, RoomID, CheckInDate, CheckOutDate, TotalPrice) VALUES (1, 9, 2, '1987-12-11 04:43:58.190', '2022-04-18 01:21:46.120', 57.68)
INSERT dbo.Bookings(BookingID, CustomerID, RoomID, CheckInDate, CheckOutDate, TotalPrice) VALUES (2, 4, 3, '2018-06-02 18:29:20.590', '1980-11-09 02:39:03.060', 69.47)
INSERT dbo.Bookings(BookingID, CustomerID, RoomID, CheckInDate, CheckOutDate, TotalPrice) VALUES (3, 6, 1, '1987-06-08 07:48:22.700', '2016-10-01 11:33:26.000', 156.86)
INSERT dbo.Bookings(BookingID, CustomerID, RoomID, CheckInDate, CheckOutDate, TotalPrice) VALUES (4, 2, 1, '1986-08-02 23:33:07.920', '2008-02-08 08:32:41.950', 156.86)
INSERT dbo.Bookings(BookingID, CustomerID, RoomID, CheckInDate, CheckOutDate, TotalPrice) VALUES (5, 3, 2, '2010-12-18 21:37:55.490', '2015-05-14 20:49:45.580', 57.68)
INSERT dbo.Bookings(BookingID, CustomerID, RoomID, CheckInDate, CheckOutDate, TotalPrice) VALUES (6, 9, 9, '2014-12-10 10:37:31.350', '1993-07-07 13:20:27.300', 138.34)
INSERT dbo.Bookings(BookingID, CustomerID, RoomID, CheckInDate, CheckOutDate, TotalPrice) VALUES (7, 1, 8, '2011-01-11 01:52:42.770', '2013-07-19 05:58:58.760', 143.48)
INSERT dbo.Bookings(BookingID, CustomerID, RoomID, CheckInDate, CheckOutDate, TotalPrice) VALUES (8, 10, 10, '2005-12-13 09:36:06.110', '2024-03-06 16:01:14.700', 13.35)
INSERT dbo.Bookings(BookingID, CustomerID, RoomID, CheckInDate, CheckOutDate, TotalPrice) VALUES (9, 6, 3, '2021-06-21 20:26:39.470', '2023-02-02 13:21:23.000', 69.47)
INSERT dbo.Bookings(BookingID, CustomerID, RoomID, CheckInDate, CheckOutDate, TotalPrice) VALUES (10, 6, 2, '2001-02-05 02:18:33.330', '1997-12-07 02:14:23.690', 57.68)
GO
SET IDENTITY_INSERT dbo.Bookings OFF
GO

USE HotelManagementSystem
GO

IF DB_NAME() <> N'HotelManagementSystem' SET NOEXEC ON
GO

--
-- Create foreign key [FK_Bookings_CustomerID] on table [dbo].[Bookings]
--
PRINT (N'Create foreign key [FK_Bookings_CustomerID] on table [dbo].[Bookings]')
GO
ALTER TABLE dbo.Bookings WITH NOCHECK
  ADD CONSTRAINT FK_Bookings_CustomerID FOREIGN KEY (CustomerID) REFERENCES dbo.Customers (CustomerID)
GO

--
-- Create foreign key [FK_Bookings_RoomID] on table [dbo].[Bookings]
--
PRINT (N'Create foreign key [FK_Bookings_RoomID] on table [dbo].[Bookings]')
GO
ALTER TABLE dbo.Bookings WITH NOCHECK
  ADD CONSTRAINT FK_Bookings_RoomID FOREIGN KEY (RoomID) REFERENCES dbo.Rooms (RoomID)
GO
SET NOEXEC OFF
GO
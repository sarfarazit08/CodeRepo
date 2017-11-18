USE DemoDB;
GO

CREATE TABLE Employees
(
	EmployeeID int NOT NULL,
	FirstName nvarchar(50) NOT NULL,
	MiddleName nvarchar(50) NULL,
	LastName nvarchar(50) NOT NULL,
	Title  nvarchar(100) NULL,
	HireDate datetime NOT NULL,
	VacationHours smallint NOT NULL,
	Salary decimal(19,4) NOT NULL
);
GO

CREATE TABLE Products
(
	ProductsID int NOT NULL,
	Name nvarchar(255) NOT NULL,
	Price decimal(19,4) NOT NULL
);
GO


CREATE TABLE Sales 
(
	SalesID uniqueidentifier NOT NULL,
	ProductsID int NOT NULL,
	EmployeeID int NOT NULL,
	Quantity smallint NOT NULL
);
GO
use DemoDB
Go

ALTER TABLE Employees
ADD
	ActiveFlag bit NOT NULL,
	ModifiedDate datetime NOT NULL
	
GO

ALTER TABLE Products
	ALTER COLUMN Price Money
	

ALTER TABLE Sales
ADD	
	SalesDate datetime NOT NULL
	
GO


EXEC sp_rename 'Sales', 'SalesOrder'
use DemoDB
go

ALTER TABLE Products
	DROP COLUMN Price 
go
	
DROP TABLE Products;
go

DROP TABLE Employees;
go

DROP TABLE SalesOrder;
go
USE DemoDB;
GO

CREATE VIEW vEmployeesWithSales
AS
	Select Distinct Employees.*
	From Employees Join Sales 
	on Employees.EmployeeID = Sales.EmployeeID;

GO

--Querying on a view
Select * from vEmployeesWithSales;

CREATE VIEW vTopTenProductSalesByQuantity
AS
	Select TOP (10) Products.Name as ProductName, SUM(Sales.Quantity) as TotalQuantity
	From Products Join Sales 
	on Products.ProductsID = Sales.ProductsID
	group by Products.Name
	order by SUM(Sales.Quantity) DESC
GO 

--Querying on a view
Select * from vTopTenProductSalesByQuantity;
use DemoDB
Go

--Altering View
ALTER VIEW vEmployeesWithSales
AS
	Select Distinct 
		Employees.EmployeeID,
		Employees.FirstName,
		Employees.LastName		
	From Employees Join Sales 
	on Employees.EmployeeID = Sales.EmployeeID;
	
GO

--renaming views
--exec sp_rename 'vEmployeeView', 'vEmployeesWithSales'
--Go

--Qerying View
select * from vEmployees;
Go


/*

--Inserting data into View
Insert vEmployees SELECT 3,'Julie','Robert'
Insert vEmployees SELECT 5,'Julie','Robert'

Error:
Msg 4403, Level 16, State 1, Line 1
Cannot update the view or function 'vEmployees' because it contains aggregates, or a DISTINCT or GROUP BY clause, or PIVOT or UNPIVOT operator.

*/use DemoDB
go

DROP VIEW vEmployees, vEmployeesWithSales, vTopTenProductSalesByQuantity;
go
USE AdventureWorks2008
GO

/****** Object:  Table [dbo].[Employees]    Script Date: 06/27/2015 11:10:35 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employees]') AND type in (N'U'))
DROP TABLE [dbo].[Employees]
GO

USE AdventureWorks2008
GO

/****** Object:  Table [dbo].[Employees]    Script Date: 06/27/2015 11:10:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

--Create Employees table with NULL, NOT NULL, DEFAULT, CHECK Constraints
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] NOT NULL IDENTITY (1,1) PRIMARY KEY,
	[FirstName] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](100) NULL DEFAULT ('NEW HIRE'),
	[HireDate] [datetime] NOT NULL CONSTRAINT DF_HireDate DEFAULT (GETDATE()) CHECK (DATEDIFF(d,GETDATE(),HireDate) <=0),
	[VacationHours] [smallint] NOT NULL DEFAULT (0),
	[Salary] [decimal](19, 4) NOT NULL,
	[ActiveFlag] [bit] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	CONSTRAINT U_Employee UNIQUE NONCLUSTERED (FirstName, LastName, HireDate)
) ON [PRIMARY]

GO


USE AdventureWorks2008
GO

/****** Object:  Table [dbo].[Products]    Script Date: 06/27/2015 11:12:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Products]') AND type in (N'U'))
DROP TABLE [dbo].[Products]
GO

USE AdventureWorks2008
GO

/****** Object:  Table [dbo].[Products]    Script Date: 06/27/2015 11:12:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products](
	[ProductsID] [int] NOT NULL IDENTITY (1,1),
	[Name] [nvarchar](255) NOT NULL UNIQUE NONCLUSTERED,
	[Price] [decimal] (19,4) NOT NULL CONSTRAINT CHK_Price CHECK (Price > 0),
	[DiscontinuedFlag] [bit] NOT NULL CONSTRAINT DF_DiscontinuedFlag DEFAULT (0),
	CONSTRAINT PK_ProductID PRIMARY KEY CLUSTERED (ProductsID ASC)
) ON [PRIMARY]

GO


USE AdventureWorks2008
GO

/****** Object:  Table [dbo].[Sales]    Script Date: 06/27/2015 11:13:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Sales]') AND type in (N'U'))
DROP TABLE [dbo].[Sales]
GO

USE AdventureWorks2008
GO

/****** Object:  Table [dbo].[Sales]    Script Date: 06/27/2015 11:13:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sales](
	[SalesID] [uniqueidentifier] NOT NULL DEFAULT NEWID(),
	[ProductsID] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[Quantity] [smallint] NOT NULL ,
	[SalesDate] [datetime] NOT NULL CONSTRAINT DF_SalesDate DEFAULT (GETDATE()),
	CONSTRAINT CHK_QuantitySaleDate CHECK ( Quantity > 0 AND DATEDIFF(d,GETDATE(),SalesDate) <=0),
	CONSTRAINT PK_SalesID PRIMARY KEY CLUSTERED (SalesID ASC)
		WITH (IGNORE_DUP_KEY = OFF),
	CONSTRAINT FK_ProductsSales FOREIGN KEY (ProductsID) REFERENCES Products (ProductsID),
	CONSTRAINT FK_EmployeesSales FOREIGN KEY (EmployeeID) REFERENCES Employees (EmployeeID)
) ON [PRIMARY]

GO



ALTER TABLE dbo.Sales
	DROP CONSTRAINT FK_EmployeesSales
GO

ALTER TABLE dbo.Sales
	ADD CONSTRAINT FK_EmployeesSales FOREIGN KEY (EmployeeID) REFERENCES Employees (EmployeeID)
GO
USE AdventureWorks2008
GO

/****** Object:  Table [dbo].[Employees]    Script Date: 06/27/2015 11:10:35 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employees]') AND type in (N'U'))
DROP TABLE [dbo].[Employees]
GO

USE AdventureWorks2008
GO

/****** Object:  Table [dbo].[Employees]    Script Date: 06/27/2015 11:10:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](100) NULL,
	[HireDate] [datetime] NOT NULL,
	[VacationHours] [smallint] NOT NULL,
	[Salary] [decimal](19, 4) NOT NULL,
	[ActiveFlag] [bit] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL
) ON [PRIMARY]

GO


use DemoDB;
--inner join
Select pc.*
From Production.ProductCategory AS pc
INNER JOIN Production.ProductSubcategory AS ps
on pc.ProductCategoryID = ps.ProductCategoryID;

Select 
	pc.ProductCategoryID, 
	pc.Name, 
	count(pc.ProductCategoryID) AS 'Product count'
From Production.ProductCategory AS pc
INNER JOIN Production.ProductSubcategory AS ps
on pc.ProductCategoryID = ps.ProductCategoryID
group by pc.ProductCategoryID, pc.Name;

Select 
	pc.ProductCategoryID, 
	pc.Name, 
	count(pc.ProductCategoryID) AS 'Product count'
From Production.ProductCategory AS pc
INNER JOIN Production.ProductSubcategory AS ps
on pc.ProductCategoryID = ps.ProductCategoryID
group by pc.ProductCategoryID, pc.Name
having count(pc.ProductCategoryID)> 5
order by pc.ProductCategoryID;


--outer join : left join
Select 
	pc.ProductCategoryID, 
	pc.Name
From Production.ProductCategory pc 
left join Production.ProductSubcategory ps 
on pc.ProductCategoryID = ps.ProductCategoryID;

--outer join : right join
Select 
	pc.ProductCategoryID, 
	pc.Name
From Production.ProductCategory pc 
right join Production.ProductSubcategory ps 
on pc.ProductCategoryID = ps.ProductCategoryID;


INSERT INTO [dbo].[Expenses]
           ([Sl No]
           ,[ItemPurchased]
           ,[DateOfPurchase]
           ,[Price]
           ,[Buyer]
           ,[AccountType]
           ,[IndividualSettlement])
     VALUES
           (28,'Bread','18-May-2015','25','Sarfaraz','Combined',null);
GO

SELECT SUM(price) FROM [dbo].[Expenses];


select AVG(listprice) 
from Production.Product;


select	name, 
		listprice - (select AVG(listprice) 
from Production.Product)
from Production.Product;


select	name, 
		listprice 'List Price'
from Production.Product p
inner join  (select  ProductSubcategoryID , AVG(listprice) 'AverageListPrice'
from Production.Product group by ProductSubcategoryID) ap
on p.ProductSubcategoryID = ap.ProductSubcategoryID
order by listprice;

--sub queries, selecting nth highest value, first sorting and then taking top values 
 Select TOP 1 
		listprice '3rd Highest List Price'
from 
	(SELECT DISTINCT TOP 3 listprice 
		from Production.Product 
		ORDER BY listprice DESC) lp
ORDER BY listprice ASC ;

--sub queries, selecting nth lowest value, a
-- sorting and then taking top values
 Select TOP 1 
		listprice '3rd lowest List Price'
from 
	(SELECT DISTINCT TOP 3 listprice 
		from Production.Product 
		ORDER BY listprice asc) lp
ORDER BY listprice desc ;

--sub queries, selecting nth highest value, a
-- sorting and then taking top values
Select TOP 1 
		listprice '3rd lowest List Price'
from 
	(SELECT DISTINCT TOP 3 listprice 
		from Production.Product 
		ORDER BY listprice asc) lp
ORDER BY listprice desc ;

select	name, 
		listprice 'List Price'
from Production.Product p
inner join  (select  ProductSubcategoryID , AVG(listprice) 'AverageListPrice'
from Production.Product group by ProductSubcategoryID) ap
on p.ProductSubcategoryID = ap.ProductSubcategoryID
order by listprice;-- ctrl k, ctrl c
-- ctrl k, ctrl u

use DemoDB;

--Execution order
------select FirstName 
------from person.Person
--1----where EmailPromotion = 0
------group by LastName
------having Person.LastName = 'Adams'
------order by FirstName;

select FirstName, MiddleName, LastName
from person.Person;

--example of concatenation & Alias
select FirstName+''+MiddleName+''+LastName AS 'Full Name' --alias name
from person.Person;


--concatenating NULL with NOT NULL results NULL
--so use 
select FirstName+''+MiddleName+''+LastName AS 'Full Name' --alias name
from person.Person;

--working with null
select FirstName,LastName
from person.Person
where MiddleName  is NULL 
order by FirstName; --8499

--distinct on single column
select distinct(FirstName),LastName
from person.Person;--19516

--distinct on multiple column is not applicable
select distinct(FirstName +' '+LastName) AS 'Name'
from person.Person order by (FirstName +' '+LastName);--19516

--using LIKE operator WITH %%
select distinct(FirstName +' '+LastName) AS 'Name'
from person.Person 
where (FirstName +' '+LastName) like '%Aaron%' 
order by (FirstName +' '+LastName);--55

--using LIKE operator WITH _%
select distinct(FirstName +' '+LastName) AS 'Name'
from person.Person 
where (FirstName +' '+LastName) like '_aron%' 
order by (FirstName +' '+LastName);--55

--using LIKE operator WITH []
select distinct(FirstName +' '+LastName) AS 'Name'
from person.Person 
where (FirstName +' '+LastName) like '%[A-C]%' 
order by (FirstName +' '+LastName);--17977

--using LIKE operator WITH [^] : checks for charachter other than mentioned
select distinct(FirstName +' '+LastName) AS 'Name'
from person.Person 
where (FirstName +' '+LastName) like '[^AC]%' 
order by (FirstName +' '+LastName);--15871

--range based: names from A to C will be ignored
select distinct(FirstName +' '+LastName) AS 'Name'
from person.Person 
where (FirstName +' '+LastName) like '[^A-C]%' 
order by (FirstName +' '+LastName);--14889


use DemoDB
go

create table EmployeeInfo (
	EmpId int not null,
	EmpFirstName nvarchar(50) not null,
	EmpMiddleName nvarchar(50) not null,
	EmpLastName nvarchar(50) not null,
	HireDate datetime not null,
	VacationHours smallint not null,
	Salary decimal (19,4) not null
);


create table Product
(
	ProductId int not null,
	ProductName nvarchar(50) not null,
	Price decimal (19,4) not null
);


create table Sales (
	ProductId int not null,
	ProductName nvarchar(50) not null,
	Price decimal (19,4) not null
);

create table Name 	(	
	Id	int identity(1,1),
	Name varchar(50),
	DateOfBirth Date,
	[Address] varchar(300),
	Contact varchar(15)
);

insert into Name (
	Name,
	DateOfBirth,
	[Address],
	Contact
	)
	values(
	'Md Sarfaraz',
	'3-Oct-1989',
	'Venkat Pg',
	'8187030388'
);

insert into Name (
	Id,
	Name,
	DateOfBirth,
	[Address],
	Contact
	) 
	values(
	1,
	'Mohit',
	'12-Sep-1985',
	'Venkat Pg 2',
	'9885670624'
);

select * from Name order by ID;
select distinct Name from Name;

delete from Name where Name like '%Sarfaraz';
update Name set name = 'sarfaraz', Contact = 8187030388 where name like 'Mohit';

set identity_insert Name off;

USE AdventureWorks2008
GO

/****** Object:  Table [dbo].[Products]    Script Date: 06/27/2015 11:12:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Products]') AND type in (N'U'))
DROP TABLE [dbo].[Products]
GO

USE AdventureWorks2008
GO

/****** Object:  Table [dbo].[Products]    Script Date: 06/27/2015 11:12:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products](
	[ProductsID] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Price] [money] NULL
) ON [PRIMARY]

GO


USE AdventureWorks2008
GO

/****** Object:  Table [dbo].[Sales]    Script Date: 06/27/2015 11:13:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Sales]') AND type in (N'U'))
DROP TABLE [dbo].[Sales]
GO

USE AdventureWorks2008
GO

/****** Object:  Table [dbo].[Sales]    Script Date: 06/27/2015 11:13:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sales](
	[SalesID] [uniqueidentifier] NOT NULL,
	[ProductsID] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[Quantity] [smallint] NOT NULL,
	[SalesDate] [datetime] NOT NULL
) ON [PRIMARY]

GO


use DemoDB
Go

Truncate table Employees;
GO
--Create sample employee records
Insert Employees SELECT 1,'John',NUll,'Shepard','Sales Person','1/1/2014',10,30000,1,'1/6/2015'
Insert Employees SELECT 2,'Maria',NUll,'Stefan','Sales Person','1/3/2014',5,25000,1,'1/6/2015'


Truncate table Products;
GO
--Create sample Products Records
INSERT Products Select 1,'Shirt', 12.99
INSERT Products Select 2,'Shorts', 14.99
INSERT Products Select 3,'Pants', 15.99
INSERT Products Select 4,'Caps', 6.99
INSERT Products Select 5,'Bras', 16.99

Truncate table Sales;
GO
--Create sample Sales records
INSERT Sales Select NEWID(),1,1,4 , '4/1/2014'
INSERT Sales Select NEWID(),2,1,1 , '1/2/2014'
INSERT Sales Select NEWID(),3,2,4 , '11/3/2014'
INSERT Sales Select NEWID(),2,1,4 , '5/2/2014'
INSERT Sales Select NEWID(),3,2,4 , '2/5/2014'
INSERT Sales Select NEWID(),4,1,3 , '3/10/2014'


--Create 50,000 random saale records!
Declare @counter int
set @counter = 1

while @counter <= 50000
	Begin 
		Insert Sales
			Select 
				NEWID(),
				(ABS(CHECKSUM(NEWID())) % 4) + 1,
				(ABS(CHECKSUM(NEWID())) % 2) + 1,
				(ABS(CHECKSUM(NEWID())) % 9) + 1,
				DATEADD(DAY, (ABS(CHECKSUM(NEWID())) % 365), '2012-01-01')
				
		set @counter +=1
	EndUSE [NuggetDemoDB]
GO

/****** Object:  Table [dbo].[Employees]    Script Date: 06/27/2015 11:10:35 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employees]') AND type in (N'U'))
DROP TABLE [dbo].[Employees]
GO

USE [NuggetDemoDB]
GO

/****** Object:  Table [dbo].[Employees]    Script Date: 06/27/2015 11:10:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](100) NULL,
	[HireDate] [datetime] NOT NULL,
	[VacationHours] [smallint] NOT NULL,
	[Salary] [decimal](19, 4) NOT NULL,
	[ActiveFlag] [bit] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL
) ON [PRIMARY]

GO


USE [NuggetDemoDB]
GO

/****** Object:  Table [dbo].[Products]    Script Date: 06/27/2015 11:12:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Products]') AND type in (N'U'))
DROP TABLE [dbo].[Products]
GO

USE [NuggetDemoDB]
GO

/****** Object:  Table [dbo].[Products]    Script Date: 06/27/2015 11:12:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products](
	[ProductsID] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Price] [money] NULL
) ON [PRIMARY]

GO


USE [NuggetDemoDB]
GO

/****** Object:  Table [dbo].[Sales]    Script Date: 06/27/2015 11:13:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Sales]') AND type in (N'U'))
DROP TABLE [dbo].[Sales]
GO

USE [NuggetDemoDB]
GO

/****** Object:  Table [dbo].[Sales]    Script Date: 06/27/2015 11:13:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sales](
	[SalesID] [uniqueidentifier] NOT NULL,
	[ProductsID] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[Quantity] [smallint] NOT NULL,
	[SalesDate] [datetime] NOT NULL
) ON [PRIMARY]

GO


USE [NuggetDemoDB]
GO

/****** Object:  View [dbo].[vEmployeesWithSales]    Script Date: 06/27/2015 11:13:49 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vEmployeesWithSales]'))
DROP VIEW [dbo].[vEmployeesWithSales]
GO

USE [NuggetDemoDB]
GO

/****** Object:  View [dbo].[vEmployeesWithSales]    Script Date: 06/27/2015 11:13:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[vEmployeesWithSales]
AS
	Select Distinct Employees.*
	From Employees Join Sales 
	on Employees.EmployeeID = Sales.EmployeeID;


GO


USE [NuggetDemoDB]
GO

/****** Object:  View [dbo].[vTopTenProductSalesByQuantity]    Script Date: 06/27/2015 11:14:43 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vTopTenProductSalesByQuantity]'))
DROP VIEW [dbo].[vTopTenProductSalesByQuantity]
GO

USE [NuggetDemoDB]
GO

/****** Object:  View [dbo].[vTopTenProductSalesByQuantity]    Script Date: 06/27/2015 11:14:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vTopTenProductSalesByQuantity]
AS
	Select TOP (10) Products.Name as ProductName, SUM(Sales.Quantity) as TotalQuantity
	From Products Join Sales 
	on Products.ProductsID = Sales.ProductsID
	group by Products.Name
	order by SUM(Sales.Quantity) DESC

GO




/* ERROR HANDLING */
BEGIN TRY

	--SELECT 1/0 -- ERROR
	--SELECT 1 + '3' --NO ERROR
	SELECT 1 + 'THREE' -- ERROR
	
	
END TRY
BEGIN CATCH
	SELECT	ERROR_NUMBER()AS ERROR_NUMBER,
			ERROR_MESSAGE() AS ERROR_MESSAGE,
			ERROR_LINE() ERROR_LINE,
			ERROR_PROCEDURE() ERROR_PROCEDURE,
			ERROR_SEVERITY() ERROR_SEVERITY,
			ERROR_STATE() ERROR_STATE;			

END CATCH


CREATE TABLE DBErrors 
(
ErrorID int IDENTITY(1,1),
Username varchar(100),
ErrorNumber int, 
ErrorState int, 
ErrorSeverity int, 
ErrorLine int, 
ErrorProcedure varchar(MAX) , 
ErrorMessage varchar(MAX), 
ErrorDateTime datetime 
)
go

CREATE PROCEDURE Addsale 
	 
	@ProductID uniqueidentifier OUTPUT, 
	@ProductName varchar(100), 
	@Price money
	 
AS
	SET @ProductID = NEWID() 

BEGIN TRY 
	INSERT INTO sales SELECT @ProductID, @ProductName, @Price
END TRY 
BEGIN CATCH 
	INSERT DBErrors VALUES(SUSER_NAME(), 
							ERROR_NUMBER(), 
							ERROR_STATE(), 
							ERROR_SEVERITY(),
							ERROR_LINE(), 
							ERROR_PROCEDURE(), 
							ERROR_MESSAGE(),
							GETDATE());
END CATCH  

select * from Sales;
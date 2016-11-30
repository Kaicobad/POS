use master
go
create database dbPharmacyPOS
go
use dbPharmacyPOS
go

create table [Group]
(
Id int identity(1,1) primary key not null,
Name varchar(200) not null,
Description varchar(500)
)

create table Power
(
Id int identity(1,1) primary key not null,
Name varchar(100)
)

create table Company
(
Id int identity(1,1) primary key not null,
Name varchar(200) not null,
ContactPerson varchar(200) not null,
Contact varchar(100) not null,
Email varchar(100) not null,
Address varchar(200) not null,
CreateDateTime datetime
)


create table Category
(
Id int identity(1,1) primary key not null,
Name varchar(100) not null,
GroupId int,
foreign key(GroupId) references [Group](Id),
)

create table Unit
(
Id int identity(1,1) primary key not null,
Name varchar(100) not null,
Description varchar(500) not null,
PrimaryQty int
)

create table Discount
(
Id int identity(1,1) primary key not null,
Status varchar(200) not null,
)
create table Product
(
Id int identity(1,1) primary key not null,
Name varchar(200) not null,
Code varchar(200) not null,
GroupId int not null,
PowerId int not null,
CompanyId int not null,
CategoryId int not null,
UnitId int not null,
DiscountId int not null,
ListPrice float not null,
Vat float not null, 
Remarks varchar(500),
foreign key(GroupId) references [Group](Id),
foreign key(PowerId) references Power(Id),
foreign key(CompanyId) references Company(Id),
foreign key(CategoryId) references Category(Id),
foreign key(UnitId) references Unit(Id),
foreign key(DiscountId) references Discount(Id)
)

create table Rack
(
ID int identity(1,1) primary key not null,
Name varchar (200) not null,
ProductId int,
foreign key(ProductId) references Product(Id)
)

create table SaleStatus
(
Id int identity(1,1) primary key not null,
Name varchar(200) not null,
Description varchar(500) not null
)


create table Employee
(
Id int identity(1,1) primary key not null,
Name varchar(200) not null,
Phone varchar(100) unique not null,
Email varchar(100) unique not null,
Password varchar(500) unique not null,
Type varchar(100)
)

create table SaleDetails
(
Id int identity(1,1) primary key not null,
ProductId int,
SerialNumber varchar(500) unique not null,
Qty int,
Rate float,
Vat float,
DiscountId int,
foreign key(ProductId) references Product(Id),
foreign key(DiscountId) references Discount(Id)
)

create table PaymentMethod
(
Id int identity(1,1) primary key not null,
Name varchar(100) not null,
Company varchar(1000)
)	
create table Sale
(
Id int identity(1,1) primary key not null,
Number varchar(100) not null,
DateTime datetime not null,
EmployeeId int,
SaleStatusId int,
SaleDetailsId int,
PaymentMethodId int
foreign key(EmployeeId) references Employee(Id),
foreign Key(SaleStatusId) references SaleStatus(Id),
foreign key(SaleDetailsId) references SaleDetails(Id),
foreign key(PaymentMethodId) references PaymentMethod(Id)
)

create table PurchaseDetails
(
Id int identity(1,1) primary key not null,
ProductId int,
Qty int,
Rate float,
Vat float,
DiscountID int,
foreign key(ProductId) references Product(Id),
foreign key(DiscountId) references Discount(Id)
)
create table Purchase
(
Id int identity(1,1) primary key not null,
Number varchar(500) unique not null,
DateTime datetime not null,
EmployeeId int,
PurchaseDetailsId int,
foreign key(EmployeeId) references Employee(Id),
foreign key(PurchaseDetailsId) references PurchaseDetails(Id)
)


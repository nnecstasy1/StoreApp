Create database StoreApp
use StoreApp

create table Category
(
	categoryId int primary key identity,
	categoryName varchar(255),
	description varchar(max)
)

create table ProductItem
(
	productId int primary key,
	categoryId int,
	productName varchar(255),
	description varchar(max),
	foreign key (categoryId) references category(categoryId)
)

create table Size
(
	sizeId int primary key identity,
	sizeNo int,
	sizeType varchar(255)
)

create table Supplier
(
	supplierId int primary key identity,
	supplierName varchar(255),
	email varchar(255),
	phone int,
	fax int,
	address varchar(max)
)

create table Item_Size_Supplier
(
	itemId int primary key identity,
	productId int,
	sizeId int,
	supplierId int,
	cost decimal(38,2),
	quantity int
	foreign key (productId) references productItem(productId),
	foreign key (sizeId) references size(sizeId),
	foreign key (supplierId) references supplier(supplierId)
)


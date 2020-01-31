create database IndianaTruckingCompanys;
go
use IndianaTruckingCompanys;
go
create table TruckingCompanies(--Trucking companies that are currently in oporation
	USDOT varchar(6) primary key not null,
	LegalNameDBAName varchar(200) not null,
	Address varchar(500) not null,
	OOSReason varchar(41) not null,
	OOSDate varchar(10) not null,
	Status varchar(7) not null,
	addminID nvarchar(450) not null --this is link going to be linked with the AspNetUsers dont 
									--add when you push data into this from the website this field say
									--update[today's date mm-dd-yyyy]
);
go
create table ChameleonCompanies(--Trucking companies that are oporational but are expected to be chameleon companies
	USDOT varchar(6) primary key not null,
	LegalNameDBAName varchar(200) not null,
	Address varchar(500) not null,
	OOSReason varchar(41) not null,
	OOSDate varchar(10) not null,
	Status varchar(7) not null,
	addminID nvarchar(450) not null --this is link going to be linked with the AspNetUsers dont 
									--add when you push data into this from the website this field say
									--update[today's date mm-dd-yyyy]
	FOREIGN KEY (USDOT) REFERENCES TruckingCompanies(USDOT)
);
go
create table LiquidatedCompanys(--No longer optorational companies
	USDOT varchar(6) primary key not null,
	LegalNameDBAName varchar(200) not null,
	Address varchar(500) not null,
	OOSReason varchar(41) not null,
	OOSDate varchar(10) not null,
	Status varchar(7) not null,
	addminID nvarchar(450) not null --this is link going to be linked with the AspNetUsers dont 
									--add when you push data into this from the website this field say
									--update[today's date mm-dd-yyyy]
);

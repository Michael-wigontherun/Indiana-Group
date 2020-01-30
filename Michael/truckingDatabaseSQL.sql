create database IndianaTruckingCompanys;
go
use IndianaTruckingCompanys;
go
create table LiquidatedCompanys(
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


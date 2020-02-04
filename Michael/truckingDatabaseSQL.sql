create database IndianaTruckingCompanys;
go
use IndianaTruckingCompanys;
go
drop table TruckingCompanies
create table TruckingCompanies(--Trucking companies that are currently in oporation
	USDOT varchar(6) primary key not null,
	LegalName varchar(200) not null,
	DBAName varchar(200),
	CARRIER_OPERATION_ varchar(1) not null,
	HM_FLAG_ varchar(1) not null,
	PC_FLAG_ varchar(1) not null,
	PHY_STREET_ varchar(500) not null,
	PHY_CITY_ varchar(50) not null,
	PHY_STATE_ varchar(2) not null,
	PHY_ZIP_ varchar(10) not null,
	PHY_COUNTRY_ varchar(2) not null,
	MAILING_STREET_ varchar(500) not null,
	MAILING_CITY_ varchar(50) not null,
	MAILING_STATE_ varchar(2) not null,
	MAILING_ZIP_ varchar(10) not null,
	MAILING_COUNTRY_ varchar(2) not null,
	TELEPHONE_ varchar(10) not null,
	FAX_ varchar(10),
	EMAIL_ADDRESS_ varchar(200),
	MCS150_DATE_ varchar(10) not null,
	MCS150_MILEAGE_ bigint not null,
	MCS150_MILEAGE_YEAR_ int not null,
	ADD_DATE_ varchar(10) not null,
	OIC_STATE_ varchar(2) not null,
	NBR_POWER_UNIT_ int not null,
	DRIVER_TOTAL_ int not null,
	GeoLocation varchar(500) not null,
	addminID nvarchar(450) not null --this is link going to be linked with the AspNetUsers dont 
									--add when you push data into this from the website this field say
									--update[today's date mm-dd-yyyy]
);
go
drop table ChameleonCompanies
create table ChameleonCompanies(--Trucking companies that are oporational but are expected to be chameleon companies
	USDOT varchar(6) primary key not null,
	LegalName varchar(200) not null,
	PHY_STREET_ varchar(500) not null,
	PHY_CITY_ varchar(50) not null,
	PHY_STATE_ varchar(2) not null,
	PHY_ZIP_ varchar(10) not null,
	PHY_COUNTRY_ varchar(2) not null,
	MAILING_STREET_ varchar(500) not null,
	MAILING_CITY_ varchar(50) not null,
	MAILING_STATE_ varchar(2) not null,
	MAILING_ZIP_ varchar(10) not null,
	MAILING_COUNTRY_ varchar(2) not null,
	TELEPHONE_ varchar(10) not null,
	GeoLocation varchar(500) not null,
	addminID nvarchar(450) not null --this is link going to be linked with the AspNetUsers dont 
									--add when you push data into this from the website this field say
									--update[today's date mm-dd-yyyy]
);
go
drop table LiquidatedCompanys
create table LiquidatedCompanys(--No longer optorational companies
	USDOT varchar(6) primary key not null,
	LegalNameDBAName varchar(200) not null,
	Address varchar(500) not null,
	OOSReason varchar(41) not null,
	OOSDate varchar(10) not null,
	Status varchar(7) not null,
	GeoLocation varchar(500) not null,
	addminID nvarchar(450) not null --this is link going to be linked with the AspNetUsers dont 
									--add when you push data into this from the website this field say
									--update[today's date mm-dd-yyyy]
);

create database IndianaTruckingCompanys;
go
use IndianaTruckingCompanys;
go
create table TruckingCompanies(--Trucking companies that are currently in oporation
	USDOT varchar(6) primary key not null,
	LegalName varchar(200) not null,
	DBAName varchar(200),
	_CARRIER_OPERATION_ varchar(1) not null,
	_HM_FLAG_ varchar(1) not null,
	_PC_FLAG_ varchar(1) not null,
	_PHY_STREET_ varchar(500) not null,
	_PHY_CITY_ varchar(50) not null,
	_PHY_STATE_ varchar(2) not null,
	_PHY_ZIP_ varchar(10) not null,
	_PHY_COUNTRY_ varchar(2) not null,
	_MAILING_STREET_ varchar(500) not null,
	_MAILING_CITY_ varchar(50) not null,
	_MAILING_STATE_ varchar(2) not null,
	_MAILING_ZIP_ varchar(10) not null,
	_MAILING_COUNTRY_ varchar(2) not null,
	_TELEPHONE_ varchar(10) not null,
	_FAX_ varchar(10),
	_EMAIL_ADDRESS_ varchar(200),
	_MCS150_DATE_ varchar(10) not null,
	_MCS150_MILEAGE_ bigint not null,
	_MCS150_MILEAGE_YEAR_ int not null,
	_ADD_DATE_ varchar(10) not null,
	_OIC_STATE_ varchar(2) not null,
	_NBR_POWER_UNIT_ int not null,
	_DRIVER_TOTAL_ int not null,
	addminID nvarchar(450) not null --this is link going to be linked with the AspNetUsers dont 
									--add when you push data into this from the website this field say
									--update[today's date mm-dd-yyyy]
);
go
create table ChameleonCompanies(--Trucking companies that are oporational but are expected to be chameleon companies
	--I would like to disscus with everyone about what we should and should not have in here
	--Unsure if i should use this as a roster or a secondary table that copys over the companies from TruckingCompanies table
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

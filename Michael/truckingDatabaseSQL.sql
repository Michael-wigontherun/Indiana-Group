create database IndianaTruckingCompanys;
go
use IndianaTruckingCompanys;
go
drop table TruckingCompanies
-- if anyone drops this table they are the ones paying for the geoscraping
create table TruckingCompanies(--Trucking companies that are currently in oporation
	USDOT varchar(10) primary key not null,
	LegalName varchar(200) not null,
	DBAName varchar(200),
	CARRIER_OPERATION_ varchar(5) not null,
	HM_FLAG_ varchar(5) not null,
	PC_FLAG_ varchar(5) not null,
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
	TELEPHONE_ varchar(14),
	FAX_ varchar(14),
	EMAIL_ADDRESS_ varchar(200),
	MCS150_DATE_ varchar(10),
	MCS150_MILEAGE_ bigint,
	MCS150_MILEAGE_YEAR_ varchar(4),
	ADD_DATE_ varchar(10),
	OIC_STATE_ varchar(2) not null,
	NBR_POWER_UNIT_ int,
	DRIVER_TOTAL_ int,
	GeoLocation varchar(500) not null,
	addminID nvarchar(450) not null --this is link going to be linked with the AspNetUsers dont 
									--add when you push data into this from the website this field say
									--update[today's date mm-dd-yyyy]
);
go
drop table ChameleonCompanies
create table ChameleonCompanies(--Trucking companies that are oporational but are expected to be chameleon companies
	USDOT varchar(10) primary key not null,
	percentOCham varchar(10) not null,
	addminID nvarchar(450) not null --this is link going to be linked with the AspNetUsers dont 
									--add when you push data into this from the website this field say
									--update[today's date mm-dd-yyyy]
);
go
drop table LiquidatedCompanys
create table LiquidatedCompanys(--No longer optorational companies
	USDOT varchar(10) primary key not null,
	LegalName varchar(200) not null,
	DBAName varchar(200) not null,
	Address varchar(500) not null,
	OOSReason varchar(100) not null,
	OOSDate varchar(10) not null,
	Status varchar(10) not null,
	GeoLocation varchar(500) not null,
	addminID nvarchar(450) not null --this is link going to be linked with the AspNetUsers dont 
									--add when you push data into this from the website this field say
									--update[today's date mm-dd-yyyy]
);

--insert into TruckingCompanies values('1000283','CORNERSTONE CONCRETE CONSTRUCTION INC','','C','N','N','25 MANCHESTER DR','TRAFALGAR','IN','46181','US','25 MANCHESTER DR','TRAFALGAR','IN','46181','US','(317) 878-9954','','','01/23/2002',0,'','01/23/2002','IN', 1,1,'39.40675170000001:-86.15590019999999','update02/12/2020')

-- Classefie as a Chameleon company


-- OOSReason is bad
-- if geolocation is same or address is similar
-- else if mcs 150 and oosdate is similar
-- else not chameleon

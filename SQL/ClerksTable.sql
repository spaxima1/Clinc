create database ClinicDB;

use ClinicDB;

CREATE TABLE Clerks(
	ClerkID INT IDENTITY(1,1) PRIMARY KEY,
	ClerkUserName varchar(50) not null ,
	ClerkName nvarchar(70) not null,
	ClerkFamily nvarchar(70) not null,
	ClerkPassword varchar(128) not null,
	ClerkStartDate DATE DEFAULT  GETDATE(),
	ClerkEndDate DATE,
	CONSTRAINT UC_Clerk UNIQUE (ClerkUserName)
)
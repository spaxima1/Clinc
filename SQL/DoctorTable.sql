use ClinicDB;
CREATE TABLE Doctors(
	DoctorID INT IDENTITY(1,1) PRIMARY KEY,
	DoctorUserName varchar(50) not null ,
	DoctorName nvarchar(70) not null,
	DoctorFamily nvarchar(70) not null,
	DoctorPassword varchar(128) not null,
	DoctorStartDate DATE DEFAULT  GETDATE(),
	DoctorEndDate DATE,
	CONSTRAINT UC_Doctor UNIQUE (DoctorUserName)
)

ALTER TABLE Doctors
ADD DoctorSpecialty  nvarchar(100);
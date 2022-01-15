use ClinicDB;
CREATE TABLE Patients(
	PatientID INT IDENTITY(1,1) PRIMARY KEY,	
	PatientName nvarchar(70) not null,
	PatientFamily nvarchar(70) not null,
	PatientDateBirth DATE DEFAULT  GETDATE(),
	PatientAddress nvarchar(300),
	PatientPhoneNumber varchar(12),
	ClerkID int ,
	CONSTRAINT FK_ClerkID FOREIGN KEY (ClerkID)
	REFERENCES Clerks(ClerkID)
)

alter TABLE Patients ADD CONSTRAINT
chk_phone CHECK (PatientPhoneNumber not like '%[^0-9]%')

ALTER TABLE Patients
ADD  PatientGender tinyint not null	;
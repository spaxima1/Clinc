use ClinicDB;
--ثبت بیماری 
create table DiseaseRegistration(
	DiseaseID INT IDENTITY(1,1) PRIMARY KEY,
	DiseaseName nvarchar(100) not null ,

	--علائم بیماری
	DiseaseSigns nvarchar(250) not null,
	--آیدی بیمار
	PatientID INT,
	--آیدی پزشک
	DoctorID INT,

)

alter table DiseaseRegistration add
	CONSTRAINT FK_DiseasePatientID FOREIGN KEY (PatientID)
	REFERENCES Patients(PatientID)



alter table DiseaseRegistration add
	CONSTRAINT FK_DiseaseDoctorID FOREIGN KEY (DoctorID)
	REFERENCES Doctors(DoctorID)
	
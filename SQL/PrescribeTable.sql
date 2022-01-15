
use ClinicDB;
--تجویز دارو
create table Prescribes(
	PrescribeID INT IDENTITY(1,1) PRIMARY KEY,

	MedicineCount int not null,

	PrescribeDate  DATE DEFAULT  GETDATE(),
	--آیدی دارو
	MedicineID INT,
	--آیدی بیمار
	PatientID INT,
	--آیدی پزشک
	DoctorID INT,
	CHECK (MedicineCount>=1)

)

alter table Prescribes add
	CONSTRAINT FK_PrescribePatientID FOREIGN KEY (PatientID)
	REFERENCES Patients(PatientID)



alter table Prescribes add
	CONSTRAINT FK_PrescribeDoctorID FOREIGN KEY (DoctorID)
	REFERENCES Doctors(DoctorID)

alter table Prescribes add
	CONSTRAINT FK_PrescribeMedicineID FOREIGN KEY (MedicineID)
	REFERENCES Medicines(MedicineID)
		
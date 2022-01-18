CREATE TABLE TurnRatings(
	TurnRatingsid int identity(1,1) primary key,
	PatientID int not null,
	DoctorID int not null,
	TurnRatingDate smalldatetime DEFAULT GETUTCDATE() ,
	Acctive bit not null
)

alter table TurnRatings add
	CONSTRAINT FK_TurnRatingsPatientID FOREIGN KEY (PatientID)
	REFERENCES Patients(PatientID)

alter table TurnRatings add
	CONSTRAINT FK_TurnRatingsDoctorID FOREIGN KEY (DoctorID)
	REFERENCES Doctors(DoctorID)

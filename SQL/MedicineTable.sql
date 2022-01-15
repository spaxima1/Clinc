use ClinicDB;
create table Medicines(
	MedicineID INT IDENTITY(1,1) PRIMARY KEY,
	MedicineName nvarchar(60) not null,
	MedicineCount int not null,
	ExpirationDate DATE not null,
	MedicinePurchasePrice bigint not null,
	MedicineSaleePrice bigint not null,
)
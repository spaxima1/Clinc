use ClinicDB;
create View Vw_TurnRatings as SELECT dbo.TurnRatings.Acctive, dbo.TurnRatings.TurnRatingDate, dbo.TurnRatings.DoctorID, dbo.TurnRatings.PatientID, dbo.Patients.PatientName, dbo.Patients.PatientFamily, dbo.Doctors.DoctorName, dbo.Doctors.DoctorFamily
FROM     dbo.Doctors INNER JOIN
                  dbo.TurnRatings ON dbo.Doctors.DoctorID = dbo.TurnRatings.DoctorID INNER JOIN
                  dbo.Patients ON dbo.TurnRatings.PatientID = dbo.Patients.PatientID


create View Vw_TuVw_prescibes as  SELECT dbo.Patients.PatientName, dbo.Patients.PatientFamily, dbo.Medicines.MedicineName, dbo.Prescribes.MedicineCount, dbo.Prescribes.PrescribeDate,
                      (SELECT CASE WHEN PatientGender = 1 THEN 'مرد' WHEN PatientGender = 2 THEN 'زن' END AS Expr1) AS Gender, dbo.Doctors.DoctorFamily, dbo.Doctors.DoctorName, dbo.Medicines.MedicineSaleePrice, 
                  dbo.Patients.PatientPhoneNumber
FROM     dbo.Doctors INNER JOIN
                  dbo.Prescribes ON dbo.Doctors.DoctorID = dbo.Prescribes.DoctorID INNER JOIN
                  dbo.Medicines ON dbo.Prescribes.MedicineID = dbo.Medicines.MedicineID INNER JOIN
                  dbo.Patients ON dbo.Prescribes.PatientID = dbo.Patients.PatientID


create View Vw_TuVw_prescibes as SELECT PatientName, PatientFamily, PatientDateBirth, PatientAddress, PatientPhoneNumber, PatientGender, PatientID,
                      (SELECT CASE WHEN PatientGender = 1 THEN 'مرد' WHEN PatientGender = 2 THEN 'زن' END AS Expr1) AS Gender
FROM     dbo.Patients
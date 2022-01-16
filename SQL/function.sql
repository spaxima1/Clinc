use ClinicDB;
select * from  Vw_prescibes

create function fn_prescibes( @phone varchar(12))
returns table 
as 
return (select * from Vw_prescibes where PatientPhoneNumber=@phone)

create function fn_dr( @ss varchar(50))
returns table 
as 
return (select * from Doctors where DoctorUserName=@ss)

select * from fn_dr('Dralipor')





create function find_prescibes_By_phonenumber( @phone varchar(12))
returns table 
as 
return (select * from Vw_prescibes where PatientPhoneNumber=@phone)


create function sum_medicineSaleePrice( @phone varchar(12),@date_time date)
returns table 
as 
return ( select sum (MedicineCount * MedicineSaleePrice ) as total from  find_prescibes_By_phonenumber(@phone) where PrescribeDate=@date_time)

select * from sum_medicineSaleePrice('09123216541','2022-01-16')
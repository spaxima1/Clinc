use ClinicDB;
create function find_TurnRatings_Patinent_acctive( @DoctorID int)
returns table 
as 
return (select * from vw_TurnRatings where DoctorID=@DoctorID and Acctive=1)

create function find_TurnRatings_Patinent_all_active()
returns table 
as 
return (select * from vw_TurnRatings where  Acctive=1)



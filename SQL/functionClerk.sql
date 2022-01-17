use ClinicDB;


create function find_Clerk( @username varchar(50),@password varchar(128))
returns table 
as 
return (select * from Clerks where ClerkPassword=@password and ClerkUserName=@username)
select * from find_Clerk('a','1')

create function find_Clerk_byID( @clrckid int)
returns table 
as 
return (select * from Clerks where ClerkID=@clrckid)
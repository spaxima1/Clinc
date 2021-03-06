//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModelLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ClinicDBEntities : DbContext
    {
        public ClinicDBEntities()
            : base("name=ClinicDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Clerk> Clerks { get; set; }
        public virtual DbSet<DiseaseRegistration> DiseaseRegistrations { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Prescribe> Prescribes { get; set; }
        public virtual DbSet<Vw_prescibes> Vw_prescibes { get; set; }
        public virtual DbSet<Vw_Patients> Vw_Patients { get; set; }
        public virtual DbSet<TurnRating> TurnRatings { get; set; }
        public virtual DbSet<Vw_TurnRatings> Vw_TurnRatings { get; set; }
    
        [DbFunction("ClinicDBEntities", "fn_dr")]
        public virtual IQueryable<fn_dr_Result> fn_dr(string ss)
        {
            var ssParameter = ss != null ?
                new ObjectParameter("ss", ss) :
                new ObjectParameter("ss", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_dr_Result>("[ClinicDBEntities].[fn_dr](@ss)", ssParameter);
        }
    
        [DbFunction("ClinicDBEntities", "find_prescibes_By_phonenumber")]
        public virtual IQueryable<find_prescibes_By_phonenumber_Result> find_prescibes_By_phonenumber(string phone)
        {
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<find_prescibes_By_phonenumber_Result>("[ClinicDBEntities].[find_prescibes_By_phonenumber](@phone)", phoneParameter);
        }
    
        [DbFunction("ClinicDBEntities", "sum_medicineSaleePrice")]
        public virtual IQueryable<Nullable<long>> sum_medicineSaleePrice(string phone, Nullable<System.DateTime> date_time)
        {
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var date_timeParameter = date_time.HasValue ?
                new ObjectParameter("date_time", date_time) :
                new ObjectParameter("date_time", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Nullable<long>>("[ClinicDBEntities].[sum_medicineSaleePrice](@phone, @date_time)", phoneParameter, date_timeParameter);
        }
    
        [DbFunction("ClinicDBEntities", "find_Clerk")]
        public virtual IQueryable<find_Clerk_Result> find_Clerk(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<find_Clerk_Result>("[ClinicDBEntities].[find_Clerk](@username, @password)", usernameParameter, passwordParameter);
        }
    
        [DbFunction("ClinicDBEntities", "find_Clerk_byID")]
        public virtual IQueryable<find_Clerk_byID_Result> find_Clerk_byID(Nullable<int> clrckid)
        {
            var clrckidParameter = clrckid.HasValue ?
                new ObjectParameter("clrckid", clrckid) :
                new ObjectParameter("clrckid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<find_Clerk_byID_Result>("[ClinicDBEntities].[find_Clerk_byID](@clrckid)", clrckidParameter);
        }
    
        [DbFunction("ClinicDBEntities", "find_TurnRatings_Patinent_acctive")]
        public virtual IQueryable<find_TurnRatings_Patinent_acctive_Result> find_TurnRatings_Patinent_acctive(Nullable<int> doctorID)
        {
            var doctorIDParameter = doctorID.HasValue ?
                new ObjectParameter("DoctorID", doctorID) :
                new ObjectParameter("DoctorID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<find_TurnRatings_Patinent_acctive_Result>("[ClinicDBEntities].[find_TurnRatings_Patinent_acctive](@DoctorID)", doctorIDParameter);
        }
    
        [DbFunction("ClinicDBEntities", "find_TurnRatings_Patinent_all_active")]
        public virtual IQueryable<find_TurnRatings_Patinent_all_active_Result> find_TurnRatings_Patinent_all_active()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<find_TurnRatings_Patinent_all_active_Result>("[ClinicDBEntities].[find_TurnRatings_Patinent_all_active]()");
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace database
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(@"Host=172.16.0.49;Username=postgres;Password=p@ssw0rd;Database=milk_practice");
        public DbSet<Profile> profile { get; set; }

    }
    [Keyless]
    public class Profile
    {
        public string pf_name { get; set; }
        public string pf_lastname { get; set; }
        public string pf_nickname { get; set; }
        public DateTime pf_birth { get; set; }
        public int pf_age { get; set; }
        public string pf_email { get; set; }
        public string pf_tel { get; set; }
        public string pf_lineid { get; set; }
        public string pf_university { get; set; }
        public string pf_faculty { get; set; }
        public string pf_department { get; set; }
        public double pf_gpa { get; set; }
        public string pf_motto { get; set; }
        public string pf_language_th { get; set; }
        public string pf_language_en { get; set; }
        public string pf_skill { get; set; }
        public string pf_hobby { get; set; }
        public string pf_workplace_st { get; set; }
        public string pf_workdate_st { get; set; }
        public string pf_position_st { get; set; }
        public string pf_work_st { get; set; }
        public string pf_workplace_nd { get; set; }
        public string pf_workdate_nd { get; set; }
        public string pf_position_nd { get; set; }
        public string pf_work_nd { get; set; }
    }
    
}

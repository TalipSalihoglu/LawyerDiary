using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete
{
    class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server =.\\SQLEXPRESS; database = LawyerDiary; integrated security = true;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Lawyer> Lawyers{ get; set; }
        public DbSet<Client> Clients{ get; set; }
        public DbSet<Case> Cases{ get; set; }
        public DbSet<Court> Courts{ get; set; }
        public DbSet<Appointment> Appointments{ get; set; }
        public DbSet<Bill> Bills{ get; set; }
    }
}

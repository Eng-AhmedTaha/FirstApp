using System;
using Microsoft.EntityFrameworkCore;
namespace FirstApp.Models
{
    public class HrContext :DbContext
    {
        public HrContext() 
        {
            
        }
        public DbSet<EmployeeModel> TbEmployees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

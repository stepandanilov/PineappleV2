using PineappleV2.Models;
using PineappleV2.Models.ComputerSettings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PineappleV2
{
    public class PineappleContext : DbContext
    {
        
        ///public DbSet<CompSetting> CompSettings { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Periphery> Peripheries { get; set; }
        //public DbSet<PerSetting> PerSettings { get; set; }
        public DbSet<Position> Positions { get; set; }

        //periphery
        public DbSet<CPU> Cpus { get; set; }
        public DbSet<HDD> Hdds { get; set; }
        public DbSet<Monitor> Monitors { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<Mouse> Mouses { get; set; }
        public DbSet<Printer> Printers { get; set; }
    }
}

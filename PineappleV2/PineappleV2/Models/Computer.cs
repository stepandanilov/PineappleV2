using PineappleV2.Models.ComputerSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PineappleV2.Models
{
    public class Computer
    {
        [Key]

        public int Id { get; set; }
        public string Condition { get; set; }
        public CPU cpu { get; set; }
        public HDD hdd { get; set; }
        public Monitor monitor { get; set; }
        public Motherboard motherboard { get; set; }
        public Mouse mouse { get; set; }
        public Printer printer { get; set; }

        //public virtual ICollection<CompSetting> settings { get; set; } 

        //public  Computer()
        //{
        //    settings = new List<CompSetting>();
        //}
        //public int EmployeeID { get; set; }
        //[ForeignKey("EmployeeID")]
        //public Employee employee { get; set; }

    }
}

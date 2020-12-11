using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace PineappleV2.Models.ComputerSettings
{
    public class Monitor
    {
        [Key]
        public string name { get; set; }
        public string manufacturer { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PineappleV2.Models.ComputerSettings
{
    public class HDD
    {
        [Key]
        public string name { get; set; }
        public string manufacturer { get; set; }
        public string space { get; set; }

    }
}

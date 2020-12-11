using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PineappleV2.Models.ComputerSettings
{
    public class Mouse
    {
        [Key]
        public string name { get; set; }
        public string manufacturer { get; set; }
    }
}

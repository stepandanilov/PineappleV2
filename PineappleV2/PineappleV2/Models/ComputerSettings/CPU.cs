using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PineappleV2.Models.ComputerSettings
{
    public class CPU
    {
        [Key]
        public int Id { get; set; }
        public string frequency { get; set; }
        public string name { get; set; }
        public string manufacturer { get; set; }

    }
}

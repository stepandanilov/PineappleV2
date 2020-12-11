using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PineappleV2.Models
{
    public class Periphery
    {
        [Key]

        public int Id { get; set; }
        public string Condition { get; set; }

        //public string SettingID { get; set; }
        //[ForeignKey("SettingID")]
        //public PerSetting Setting { get; set; }

        //public int CompID { get; set; }
        //[ForeignKey("CompID")]
        //public Computer computer { get; set; }
    }
}

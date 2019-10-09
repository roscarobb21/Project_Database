using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace program_depozit.tabele
{

    public class User
    {
        [Key]
        public int id { get; set; }
        public String Nume { get; set; }
        public String Pass { get; set; }
       

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace program_depozit.tabele
{

    public class Furnizor
    {
        [Key]
        public int id { get; set; }
       
        public String NumeFurnizor { get; set; }
        public String CodFurnizor { get; set; }
        public String AdresaSediuSocial { get; set; }
        public String AdresaDeLivrare { get; set; }
        public String PersoanaDeContact { get; set; }
        public String Email { get; set; }
        public String AlteDetalii { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace program_depozit.tabele
{

    public class Client
    {
        [Key]
        public int id { get; set; }
        public String Filiala { get; set; }
        public String NumeClient { get; set; }
        public String CodClient { get; set; }
        public String CodTvaClient { get; set; }
        public String NrReg { get; set; }
        public String AdresaSediu { get; set; }
        public String AdresaDeLivrare { get; set; }
        public String PersoanaDeContact { get; set; }
        public String Email { get; set; }
        public String Telefon { get; set; }
        public String ZonaClient { get; set; }
        public String Judet { get; set; }

    }
}
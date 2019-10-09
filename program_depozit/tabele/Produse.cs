using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace program_depozit.tabele
{

    public class Produse
    {
        [Key]
        public int id { get; set; }
        public String NumeProdus { get; set; }
        public String CodProdus { get; set; }
        public String CodBare { get; set; }
        public String Furnizor { get; set; }
        public String CodProdusFurnizor { get; set; }
        public String UM { get; set; }
        public String BucatiInBax { get; set; }
        public String NrBaxuriInLayer { get; set; }
        public String NrStraturiPePalet { get; set; }
        public String GreutateProdusKg { get; set; }
        public String GreutateNetaProdusKg { get; set; }
        public String LungimeCm { get; set; }
        public String LatimeCm { get; set; }
        public String InaltimeCm { get; set; }
        public String TipProdus { get; set; }

    }
}

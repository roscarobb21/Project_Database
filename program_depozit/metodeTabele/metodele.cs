using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using program_depozit.tabele;
using System.Data.Entity.Migrations.Design;
//using program_depozit.Clase_pentru_cautare;

namespace program_depozit.metodeTabele
{
    public class metodele
    {
        private bazaDeDateContext db = new bazaDeDateContext();
        private static metodele instance;

        public metodele() { }

        public static metodele Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new metodele();
                }

                return instance;
            }
        }
        public User addOne(User model)
        {
            db = new bazaDeDateContext();
            model.Nume = "admin";
            model.Pass = "admin";
            db.tabel_User.Add(model);
            db.SaveChanges();
            return model;
        }

        public Furnizor adaugaFurnizor(Furnizor model)
        {
            //model.NumeFurnizor = NumeFurnizorTxt.Text.ToString();
            //model.CodFurnizor = CodFurnizorTxt.Text.ToString();
            //model.AdresaSediuSocial = AdresaSediuSocialTxt.Text.ToString();
            //model.AdresaDeLivrare = AdresaDeLivrareTxt.Text.ToString();
            //model.PersoanaDeContact = PersoanaDeContactTxt.Text.ToString();
            //model.Email = EmailTxtFurnizor.Text.ToString();
            db = new bazaDeDateContext();
            db.tabel_Furnizor.Add(model);
            db.SaveChanges();
            return model;
        }
        public Produse adaugaProduse(Produse model)
        {
            //model.NumeProdus = NumeProdusTxt.Text.ToString();
            //model.CodProdus = CodProdusTxt.Text.ToString();
            //model.CodBare = CodBareTxt.Text.ToString();
            //model.Furnizor = FurnizorProdusTxt.Text.ToString();
            //model.UM = UMTxt.Text.ToString();
            //model.BucatiInBax = BucatiInBaxTxt.Text.ToString();
            //model.NrBaxuriInLayer = NrBaxuriInLayerTxt.Text.ToString();
            //model.NrStraturiPePalet = NrStraturiPePalet.Text.ToString();
            //model.GreutateProdusKg = GreutateProdusKgTxt.Text.ToString();
            //model.GreutateNetaProdusKg = GreutateNetaProdusKgTxt.Text.ToString();
            //model.LungimeCm = LungimeCmTxt.Text.ToString();
            //model.LatimeCm = LatimeCmTxt.Text.toString();
            //model.InaltimeCm = InaltimeCmTxt.Text.ToString();
            //model.TipProdus = TipProdusTxt.Text.ToString();
            db = new bazaDeDateContext();
            db.tabel_Produse.Add(model);
            db.SaveChanges();
            return model;
        }
        public Client adaugaClient(Client model)
        {
            //model.Filiala = FilialaTxt.Text.ToString();
            //model.NumeClient = NumeClientTxt.Text.ToString();
            //model.CodClient = CodClientTxt.Text.ToString();
            //model.CodTvaClient = CodTvaClientTxt.Text.ToString();
            //model.NrReg = NrRegTxt.Text.ToString();
            //model.AdresaSediu = AdresaSediuTxt.Text.ToString();
            //model.AdresaDeLivrare = AdresaDeLivrareTxt.Text.ToString();
            //model.PersoanaDeContact = PersoanaDeContactTxt.Text.ToString();
            //model.Email = EmailClientTxt.Text.ToString();
            //model.Telefon = TelefonTxt.Text.ToString();
            //model.ZonaClient = ZonaClientTxt.Text.ToString();
            //model.Judet = JudetTxt.Text.toString();
            db = new bazaDeDateContext();
            db.tabel_Client.Add(model);
            db.SaveChanges();
            return model;
        }

     
        public Furnizor modificaFurnizor(Furnizor model)
        {
            db = new bazaDeDateContext();
            //String o = model.NumeFurnizor.ToString();
            var fur = db.tabel_Furnizor.FirstOrDefault(x=> x.NumeFurnizor == model.NumeFurnizor);
            
            fur.CodFurnizor = model.CodFurnizor;
            fur.AdresaSediuSocial = model.AdresaSediuSocial;
            fur.AdresaDeLivrare = model.AdresaDeLivrare;
            fur.PersoanaDeContact = model.PersoanaDeContact;
            fur.Email = model.Email;
            fur.AlteDetalii = model.AlteDetalii;

            //fur.NumeFurnizor = model.NumeFurnizor;
            //fur.CodFurnizor = model.CodFurnizor;
            db.SaveChanges();
            model = null;
            return model;

        }
        public Client modificaClient(Client model)
        {
            db = new bazaDeDateContext();
            // db.Entry(model).State = System.Data.Entity.EntityState.Modified;
            var cli = db.tabel_Client.FirstOrDefault(x => x.NumeClient == model.NumeClient);
            
            cli.Filiala = model.Filiala.ToString();
            cli.CodClient = model.CodClient.ToString();
            cli.CodTvaClient = model.CodTvaClient.ToString();
            cli.PersoanaDeContact = model.PersoanaDeContact.ToString();
            cli.NrReg = model.NrReg.ToString();
            cli.AdresaSediu = model.AdresaSediu.ToString();
            cli.AdresaDeLivrare = model.AdresaDeLivrare.ToString();
            cli.Email = model.Email.ToString();
            cli.Telefon = model.Telefon.ToString();
            cli.ZonaClient = model.ZonaClient.ToString();
            cli.Judet = model.Judet.ToString();
            model = null;
            db.SaveChanges();
            return cli;
        }
    public Produse modificaProdus(Produse model)
        {
          
            db = new bazaDeDateContext();
            Produse re = new Produse();
            var produs = db.tabel_Produse.FirstOrDefault(x => x.NumeProdus == model.NumeProdus);
            if (produs == null)
                return re;

            produs.NumeProdus = model.NumeProdus;
            produs.CodProdus = model.CodProdus;
            produs.CodBare = model.CodBare;
            produs.Furnizor = model.Furnizor;
            produs.CodProdusFurnizor = model.CodProdusFurnizor;
            produs.UM = model.UM;
            produs.BucatiInBax = model.BucatiInBax;
            produs.NrBaxuriInLayer = model.NrBaxuriInLayer;
            produs.NrStraturiPePalet = model.NrStraturiPePalet;
            produs.GreutateProdusKg = model.GreutateProdusKg;
            produs.GreutateNetaProdusKg = model.GreutateNetaProdusKg;
            produs.LungimeCm = model.LungimeCm;
            produs.LatimeCm = model.LatimeCm;
            produs.InaltimeCm = model.InaltimeCm;
            produs.TipProdus = model.TipProdus;
            db.SaveChanges();
            return produs;
        }
        public Furnizor readFurnizor(String NumeFurnizor)
        {
            db = new bazaDeDateContext();
            var model = (from m in db.tabel_Furnizor
                         where m.NumeFurnizor == NumeFurnizor
                        // orderby m.IdPersoanaDeReferinta descending
                         select m).FirstOrDefault();
            return model;
        }
        public Client readClient(String NumeClient)
        {
            db = new bazaDeDateContext();
            var model = (from m in db.tabel_Client
                         where m.NumeClient == NumeClient
                         // orderby m.IdPersoanaDeReferinta descending
                         select m).FirstOrDefault();
            return model;
        }
        public Produse readProdus(String NumeProdus)
        {
            db = new bazaDeDateContext();
            var model = (from m in db.tabel_Produse
                         where m.NumeProdus == NumeProdus
                         // orderby m.IdPersoanaDeReferinta descending
                         select m).FirstOrDefault();
            return model;
        }
        public List<string> readallFurnizor(bool activ)
        {
            db = new bazaDeDateContext();
            var listaNume = (from m in db.tabel_Furnizor
                            // where m.Stare == activ
                             orderby m.NumeFurnizor ascending
                             select m.NumeFurnizor).Distinct().ToList();
            return listaNume;
        }
        public List<string> readallClient(bool activ)
        {
            db = new bazaDeDateContext();
            var listaNume = (from m in db.tabel_Client
                                 // where m.Stare == activ
                             orderby m.NumeClient ascending
                             select m.NumeClient).Distinct().ToList();
            return listaNume;
        }
        public List<string> readallProduse(bool activ)
        {
            db = new bazaDeDateContext();
            var listaNume = (from m in db.tabel_Produse
                                 // where m.Stare == activ
                             orderby m.NumeProdus ascending
                             select m.NumeProdus).Distinct().ToList();
            return listaNume;
        }


    }
}

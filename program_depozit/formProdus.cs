using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace program_depozit
{
    public partial class formProdus : DevExpress.XtraEditors.XtraUserControl
    {
        public formProdus()
        {
            InitializeComponent();
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        private void salveazaBtt_Click(object sender, EventArgs e)
        {
            tabele.Produse model = new tabele.Produse();
            try
            {
                model.NumeProdus = NumeProdusTxt.Text.ToString();
                model.CodProdus = CodProdusTxt.Text.ToString();
                model.CodBare = CodBareTxt.Text.ToString();
                model.Furnizor = FurnizorProdusTxt.Text.ToString();
                model.UM = UMTxt.Text.ToString();
                model.BucatiInBax = BucatiInBaxTxt.Text.ToString();
                model.NrBaxuriInLayer = NrBaxuriInLayerTxt.Text.ToString();
                model.NrStraturiPePalet = NrStraturiPePalet.Text.ToString();
                model.GreutateProdusKg = GreutateProdusKgTxt.Text.ToString();
                model.GreutateNetaProdusKg = GreutateNetaProdusKgTxt.Text.ToString();
                model.LungimeCm = LungimeCmTxt.Text.ToString();
                model.LatimeCm = LatimeCmTxt.Text.ToString();
                model.InaltimeCm = InaltimeCmTxt.Text.ToString();
                model.TipProdus = TipProdusTxt.Text.ToString();
                if(model.NumeProdus.Length * model.CodProdus.Length * model.CodBare.Length * model.Furnizor.Length *
                   model.UM.Length * model.BucatiInBax.Length * model.NrBaxuriInLayer.Length * model.NrStraturiPePalet.Length *
                   model.GreutateProdusKg.Length * model.GreutateNetaProdusKg.Length * model.LungimeCm.Length *
                   model.LatimeCm.Length * model.InaltimeCm.Length * model.TipProdus.Length == 0) throw new ArgumentException("Camp necompletat!");
                else
                {
                    metodeTabele.metodele add = new metodeTabele.metodele();
                    add.adaugaProduse(model);
                    MessageBox.Show("Operatiune efectuata cu succes.");
                }
            } catch (Exception err) { MessageBox.Show(err.Message);  }
        }

        private void NumeProdusTxt_EditValueChanged(object sender, EventArgs e, String s)
        {
           
        }
        public void AutoPopulate(tabele.Produse model)
        {
            NumeProdusTxt.Text = model.NumeProdus.ToString();
          //  MessageBox.Show("AM TrECUT DE PRIMA");
            CodProdusTxt.Text = model.CodProdus.ToString();
           // MessageBox.Show("AM TRECUT DE A 2");
            CodBareTxt.Text = model.CodBare.ToString();
            FurnizorProdusTxt.Text = model.Furnizor.ToString();
            CodProdusFurnizorTextEdit.Text = model.UM.ToString();
            BucatiInBaxTxt.Text = model.BucatiInBax.ToString();
            NrBaxuriInLayerTxt.Text = model.NrBaxuriInLayer.ToString();
            NrStraturiPePalet.Text = model.NrStraturiPePalet.ToString();
            GreutateProdusKgTxt.Text = model.GreutateProdusKg.ToString();
            GreutateNetaProdusKgTxt.Text = model.GreutateNetaProdusKg.ToString();
            LungimeCmTxt.Text = model.LungimeCm.ToString();
            LatimeCmTxt.Text = model.LatimeCm.ToString();
            InaltimeCmTxt.Text = model.InaltimeCm.ToString();
            TipProdusTxt.Text = model.TipProdus.ToString();
           
            return;

        }

        private void NumeProdusTxt_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void modificaBtt_Click(object sender, EventArgs e)
        {
            
            tabele.Produse model = new tabele.Produse();
            tabele.Produse of = new tabele.Produse();
            metodeTabele.metodele update = new metodeTabele.metodele();

            model.NumeProdus = NumeProdusTxt.Text.ToString();
            model.CodProdus = CodProdusTxt.Text.ToString();
            model.CodBare = CodBareTxt.Text.ToString();
            model.Furnizor = FurnizorProdusTxt.Text.ToString();
            model.UM = UMTxt.Text.ToString();
            model.BucatiInBax = BucatiInBaxTxt.Text.ToString();
            model.NrBaxuriInLayer = NrBaxuriInLayerTxt.Text.ToString();
            model.NrStraturiPePalet = NrStraturiPePalet.Text.ToString();
            model.GreutateProdusKg = GreutateProdusKgTxt.Text.ToString();
            model.GreutateNetaProdusKg = GreutateNetaProdusKgTxt.Text.ToString();
            model.LungimeCm = LungimeCmTxt.Text.ToString();
            model.LatimeCm = LatimeCmTxt.Text.ToString();
            model.InaltimeCm = InaltimeCmTxt.Text.ToString();
            model.TipProdus = TipProdusTxt.Text.ToString();
            MessageBox.Show(" NUME PRODUS DIN MODIFICA" + model.CodProdus.ToString());
          update.modificaProdus(model);
          //  MessageBox.Show("DE LA RETURN  COD PRODUS   " + of.CodProdus.ToString());
            model = null;
            return;
        }
    }
}

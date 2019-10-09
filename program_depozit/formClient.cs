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
    public partial class formClient : DevExpress.XtraEditors.XtraUserControl
    {
        public formClient()
        {
            InitializeComponent();
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void salveazaBtt_Click(object sender, EventArgs e)
        {
            tabele.Client model = new tabele.Client();
            try
            {
                model.Filiala = FilialaTxt.Text.ToString();
                model.NumeClient = NumeClientTxt.Text.ToString();
                model.CodClient = CodClientTxt.Text.ToString();
                model.CodTvaClient = CodTvaClientTxt.Text.ToString();
                model.NrReg = NrRegTxt.Text.ToString();
                model.AdresaSediu = AdresaSediuTxt.Text.ToString();
                model.AdresaDeLivrare = AdresaDeLivrareTxt.Text.ToString();
                model.PersoanaDeContact = PersoanaDeContactTxt.Text.ToString();
                model.Email = EmailClientTxt.Text.ToString();
                model.Telefon = TelefonTxt.Text.ToString();
                model.ZonaClient = ZonaClientTxt.Text.ToString();
                model.Judet = JudetTxt.Text.ToString();
                if (!IsValidEmail(model.Email)) throw new ArgumentException("Email invalid.");
                else if (model.Filiala.Length * model.NumeClient.Length * model.CodClient.Length *
                        model.CodTvaClient.Length * model.NrReg.Length * model.AdresaSediu.Length *
                        model.AdresaDeLivrare.Length * model.PersoanaDeContact.Length * model.Email.Length *
                        model.Telefon.Length * model.ZonaClient.Length * model.Judet.Length == 0) throw new ArgumentException("Camp necompletat.");
                else
                {
                    metodeTabele.metodele add = new metodeTabele.metodele();
                    add.adaugaClient(model);
                    MessageBox.Show("Operatiune efectuata cu succes.");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void modificaBtt_Click(object sender, EventArgs e)
        {
            tabele.Client model = new tabele.Client();
            metodeTabele.metodele update = new metodeTabele.metodele();
            model.NumeClient = NumeClientTxt.Text.ToString();
            model.Filiala = FilialaTxt.Text.ToString();
            model.CodClient = CodClientTxt.Text.ToString();
            model.CodTvaClient = CodTvaClientTxt.Text.ToString();
            model.PersoanaDeContact = PersoanaDeContactTxt.Text.ToString();
            model.NrReg = NrRegTxt.Text.ToString();
            model.AdresaSediu   = AdresaSediuTxt.Text.ToString();
            model.AdresaDeLivrare = AdresaDeLivrareTxt.Text.ToString();
            model.Email = EmailClientTxt.Text.ToString();
            model.Telefon = TelefonTxt.Text.ToString();
            model.ZonaClient = ZonaClientTxt.Text.ToString();
            model.Judet = JudetTxt.Text.ToString();
            update.modificaClient(model);
            return;
        }
        public void AutoPopulate(tabele.Client model)
        {
            NumeClientTxt.Text = model.NumeClient.ToString();
            FilialaTxt.Text = model.Filiala.ToString();
            CodClientTxt.Text = model.CodClient.ToString();
            CodTvaClientTxt.Text = model.CodTvaClient.ToString();
            PersoanaDeContactTxt.Text = model.PersoanaDeContact.ToString();
            
            NrRegTxt.Text = model.NrReg.ToString();
            AdresaDeLivrareTxt.Text = model.AdresaDeLivrare.ToString();
            AdresaSediuTxt.Text = model.AdresaSediu.ToString();
            EmailClientTxt.Text = model.Email.ToString();
            TelefonTxt.Text = model.Telefon.ToString();
            ZonaClientTxt.Text = model.ZonaClient.ToString();
            JudetTxt.Text = model.Judet.ToString();
            return;

        }
       
    }
}

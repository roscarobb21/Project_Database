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
    public partial class formFurnizor : DevExpress.XtraEditors.XtraUserControl
    {
        public formFurnizor()
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
            tabele.Furnizor req = new tabele.Furnizor();
            try
            {
                req.NumeFurnizor = NumeFurnizorTxt.Text.ToString();
                req.CodFurnizor = CodFurnizorTxt.Text.ToString();
                req.AdresaSediuSocial = AdresaSediuSocialTxt.Text.ToString();
                req.AdresaDeLivrare = AdresaDeLivrareTxt.Text.ToString();
                req.PersoanaDeContact = PersoanaDeContactTxt.Text.ToString();
                req.Email = EmailTxtFurnizor.Text.ToString();
                if (req.NumeFurnizor.Length * req.CodFurnizor.Length *
                    req.AdresaSediuSocial.Length * req.AdresaDeLivrare.Length *
                    req.PersoanaDeContact.Length * req.Email.Length == 0) throw new ArgumentException("Camp necompletat!");
                else if (!IsValidEmail(req.Email)) throw new ArgumentException("Email invalid!");
                else
                {
                    metodeTabele.metodele add = new metodeTabele.metodele();
                    add.adaugaFurnizor(req);
                    MessageBox.Show("Operatiune efectuata cu succes.");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        
        private void listFurnizor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumeFurnizorTxt_EditValueChanged(object sender, EventArgs e, String s)
        {
            

        }
        public void AutoPopulate(tabele.Furnizor furnizor)
        {
            NumeFurnizorTxt.Text = furnizor.NumeFurnizor.ToString();
            CodFurnizorTxt.Text = furnizor.CodFurnizor.ToString();
            AdresaSediuSocialTxt.Text = furnizor.AdresaSediuSocial.ToString();
            AdresaDeLivrareTxt.Text = furnizor.AdresaDeLivrare.ToString();
            PersoanaDeContactTxt.Text = furnizor.PersoanaDeContact.ToString();
                EmailTxtFurnizor.Text = furnizor.Email.ToString();
           // AlteDetaliiTextEdit.Text = furnizor.AlteDetalii.ToString();
            return;
    }

        private void modificaBtt_Click(object sender, EventArgs e)
        {
            tabele.Furnizor model = new tabele.Furnizor();
            metodeTabele.metodele update = new metodeTabele.metodele();
            model.NumeFurnizor = NumeFurnizorTxt.Text.ToString();
            model.CodFurnizor = CodFurnizorTxt.Text.ToString();
            model.AdresaSediuSocial = AdresaSediuSocialTxt.Text.ToString();
            model.AdresaDeLivrare = AdresaDeLivrareTxt.Text.ToString();
            model.PersoanaDeContact = PersoanaDeContactTxt.Text.ToString();
            model.Email = EmailTxtFurnizor.Text.ToString();
           
            update.modificaFurnizor(model);
            model = null;
            return;
        }

       
    }
}

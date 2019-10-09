using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace program_depozit
{
    public partial class main : DevExpress.XtraEditors.XtraForm
    {
        public main()
        {
            InitializeComponent();
        }
        
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Control ctrl in mainContainer.Controls)
            {
                ctrl.Dispose();
            }
            mainContainer.Controls.Add(new formFurnizor());
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Control ctrl in mainContainer.Controls)
            {
                ctrl.Dispose();
            }
            mainContainer.Controls.Add(new formProdus());
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Control ctrl in mainContainer.Controls)
            {
                ctrl.Dispose();
            }
            mainContainer.Controls.Add(new formClient());
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Control ctrl in mainContainer.Controls)
            {
                ctrl.Dispose();
            }
            mainContainer.Controls.Add(new formUser());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dbSearch_Click(object sender, EventArgs e)
        {

        }
            
        public void searcF()
        {
            foreach (Control ctrl in mainContainer.Controls)
            {
                ctrl.Dispose();
            }
            mainContainer.Controls.Add(new formFurnizor());
            tabele.Furnizor x = new tabele.Furnizor();
            metodeTabele.metodele str = new metodeTabele.metodele();
            x = str.readFurnizor(cautaToken.Text.ToString());
            MessageBox.Show(x.CodFurnizor.ToString());
        }

        public void searcP()
        {
            foreach (Control ctrl in mainContainer.Controls)
            {
                ctrl.Dispose();
            }
            mainContainer.Controls.Add(new formProdus());
            tabele.Produse x = new tabele.Produse();
            metodeTabele.metodele str = new metodeTabele.metodele();
            //x = str.readFurnizor(cautaToken.Text.ToString());
        }

        public void searcC()
        {
            foreach (Control ctrl in mainContainer.Controls)
            {
                ctrl.Dispose();
            }
            mainContainer.Controls.Add(new formClient());
            tabele.Client x = new tabele.Client();
            metodeTabele.metodele str = new metodeTabele.metodele();
            //x = str.readFurnizor(cautaToken.Text.ToString());
        }
        public void searcU()
        {
            foreach (Control ctrl in mainContainer.Controls)
            {
                ctrl.Dispose();
            }
            mainContainer.Controls.Add(new formUser());
            tabele.User x = new tabele.User();
            metodeTabele.metodele str = new metodeTabele.metodele();
            //x = str.readFurnizor(cautaToken.Text.ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {

            switch(dbToken.Text.ToString())
            {
                case "Furnizor":
                   
                    String NumeFurnizor = cautaToken.Text.ToString();
                    tabele.Furnizor fur = new tabele.Furnizor();
                    metodeTabele.metodele metF = new metodeTabele.metodele();
                    fur = metF.readFurnizor(NumeFurnizor);
                   // MessageBox.Show(fur.CodFurnizor.ToString());
                    foreach (Control ctrl in mainContainer.Controls)
                    {
                        ctrl.Dispose();
                    }
                    formFurnizor k = new formFurnizor();
                    mainContainer.Controls.Add(k);
                    k.AutoPopulate(fur);
                    metF = null;
                   
                    break;
                    //end Furnizor
                case "Produs":
                    String NumeProdus = cautaToken.Text.ToString();
                    if (NumeProdus == null) break;
                    tabele.Produse pro = new tabele.Produse();
                    metodeTabele.metodele metP = new metodeTabele.metodele();
                    pro = metP.readProdus(NumeProdus);
                    MessageBox.Show(pro.CodProdus.ToString());
                    foreach (Control ctrl in mainContainer.Controls)
                    {
                        ctrl.Dispose();
                    }
                    formProdus p = new formProdus();
                    mainContainer.Controls.Add(p);
                    p.AutoPopulate(pro);
                    pro = null;
                    break;
                    //end produs
                case "Client":
                    String NumeClient = cautaToken.Text.ToString();
                    if (NumeClient == null) break;
                    tabele.Client cli = new tabele.Client();
                    metodeTabele.metodele metC = new metodeTabele.metodele();
                    cli = metC.readClient(NumeClient);
                    MessageBox.Show(cli.PersoanaDeContact.ToString());
                    foreach (Control ctrl in mainContainer.Controls)
                    {
                        ctrl.Dispose();
                    }
                    formClient c = new formClient();
                    mainContainer.Controls.Add(c);
                    c.AutoPopulate(cli);
                    cli = null;

                   // searcC();
                    break;

                case "Utilizator":
                    searcU();
                    break;
            }
        }

        private void mainContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
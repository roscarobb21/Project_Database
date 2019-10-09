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
                   
                    String Nume = cautaToken.Text.ToString();
                    tabele.Furnizor fur = new tabele.Furnizor();
                    metodeTabele.metodele met = new metodeTabele.metodele();
                    fur = met.readFurnizor(Nume);
                    MessageBox.Show(fur.CodFurnizor.ToString());
                    foreach (Control ctrl in mainContainer.Controls)
                    {
                        ctrl.Dispose();
                    }
                    formFurnizor k = new formFurnizor();
                    mainContainer.Controls.Add(k);
                    k.AutoPopulate(fur);
                   
                   



                    break;

                case "Produs":
                    searcP();
                    break;

                case "Client":
                    searcC();
                    break;

                case "Utilizator":
                    searcU();
                    break;
            }
        }
    }
}
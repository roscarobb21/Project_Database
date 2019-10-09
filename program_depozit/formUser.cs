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
    public partial class formUser : DevExpress.XtraEditors.XtraUserControl
    {
        public formUser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabele.User req = new tabele.User();
            try
            {
                req.Nume = NumeTextEdit.Text.ToString();
                req.Pass = PassTextEdit.Text.ToString();
                
                if (req.Nume.Length * req.Pass.Length  == 0) throw new ArgumentException("Camp necompletat!");
                else
                {
                    metodeTabele.metodele add = new metodeTabele.metodele();
                    add.addOne(req);
                    MessageBox.Show("Operatiune efectuata cu succes.");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}

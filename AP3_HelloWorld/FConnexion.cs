using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP3_HelloWorld
{
    public partial class FConnexion : Form
    {
        public FConnexion()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(Modele.utilVerif(txtIdentifiant.Text))
            {
                if (Modele.mdpVerif(txtMdp.Text))
                {
                    MessageBox.Show("Identification réussi");
                    System.Threading.Thread x = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                    x.Start();
                    this.Close();
                }
            }
        }

        private void FConnexion_Load(object sender, EventArgs e)
        {

        }
    }
}

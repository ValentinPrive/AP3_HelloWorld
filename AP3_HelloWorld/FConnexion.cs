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
        //TEST : id : lvillachane mdp : jux7g
        //Vérification d'identifiant et mot de passe
        private void btnOK_Click(object sender, EventArgs e)
        {
            if(Modele.utilVerif(txtIdentifiant.Text))
            {
                if (Modele.mdpVerif(txtMdp.Text))
                {
                    MessageBox.Show("Identification réussie");
                    System.Threading.Thread x = new System.Threading.Thread(new System.Threading.ThreadStart(threadProc));
                    x.Start();
                    this.Close();
                }else
                {
                    MessageBox.Show("Identification refusée");
                }
            }
            else
            {
                MessageBox.Show("Identification refusée");
            }
        }
        //------------------------------

        public static void threadProc()
        {
            Application.Run(new FMenu());
        }
        

        //Passage du mot de passe en *
        private void FConnexion_Load(object sender, EventArgs e)
        {
            txtMdp.PasswordChar = '*';
        }
        //-------------------------
    }
}

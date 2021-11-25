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
    public partial class FM1RLab : Form
    {
        public FM1RLab()
        {
            InitializeComponent();
            Nom.Visible = false;
            TBNom.Visible = false;
            Prenom.Visible = false;
            TBPrenom.Visible = false;
            Rue.Visible = false;
            TBRue.Visible = false;
            CP.Visible = false;
            TBCP.Visible = false;
            Ville.Visible = false;
            TBVille.Visible = false;

            ancMDP.Visible = false;
            nouvMDP.Visible = false;
            textAncMDP.Visible = false;
            ancMDP.PasswordChar = '*';
            textNouvMDP.Visible = false;
            nouvMDP.PasswordChar = '*';
            BValider.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nom.Visible = true;
            TBNom.Visible = true;
            Prenom.Visible = true;
            TBPrenom.Visible = true;
            Rue.Visible = true;
            TBRue.Visible = true;
            CP.Visible = true;
            TBCP.Visible = true;
            Ville.Visible = true;
            TBVille.Visible = true;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void DGVInfPers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModMDP_Click(object sender, EventArgs e)
        {
            ancMDP.Visible = true;
            nouvMDP.Visible = true;
            textAncMDP.Visible = true;
            textNouvMDP.Visible = true;
            BValider.Visible = true;
        }

        private void FM1RLab_Load(object sender, EventArgs e)
        {
            /*txtMDP.PasswordChar = '*';*/
        }

        private void BValider_Click(object sender, EventArgs e)
        {
            if (Modele.mdpVerif(ancMDP.Text))
            {
                MessageBox.Show("Modification réussi");
                Modele.changepass(nouvMDP.Text);
                //Modele.changeNom(Nom.Text);
                //Modele.changepass(nouvMDP.Text);
                //Modele.changepass(nouvMDP.Text);
                //Modele.changepass(nouvMDP.Text);
                //Modele.changepass(nouvMDP.Text);
            }

            else
            {
                MessageBox.Show("Modification refusée, vérifiez l'ancien mot de passe");
            }
        }
    }
}

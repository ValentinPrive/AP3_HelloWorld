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
                    if (nouvMDP.TextLength > 0)
                    {
                        Modele.changepass(nouvMDP.Text);
                    }
                    if (TBNom.TextLength > 0)
                    {
                        Modele.changeNom(TBNom.Text);
                    }
                    if (TBPrenom.TextLength > 0)
                    {
                        Modele.changePrenom(TBPrenom.Text);
                    }
                    if (TBCP.TextLength > 4)
                    {
                        Modele.changeCP(TBCP.Text);
                    }
                    if (TBVille.TextLength > 0)
                    {
                        Modele.changeVille(TBVille.Text);
                    }
                    if (TBRue.TextLength > 0)
                    {
                        Modele.changeRue(TBRue.Text);
                    }

                else
                {
                    MessageBox.Show("Modification refusée");
                }
            }
        }
        /*private bool  verif()
        {
            bool vretour=true;
            if(TBNom.TextLength<2)
            {
                errorProvider1.SetError(TBNom, "Le nom doit avoir au moins 2 car");
                vretour = false;

            }
            return vretour;
        }*/

    }
}

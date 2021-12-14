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
        private static Visiteur RespLabo;
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

        }
        //Modification informations nominatives
        private void BValider_Click(object sender, EventArgs e)
        {
            if (Modele.mdpVerif(ancMDP.Text))
            {
                if (nouvMDP.TextLength > 0 || TBNom.TextLength > 0 || TBPrenom.TextLength > 0 || TBCP.TextLength > 4 || TBVille.TextLength > 0 || TBRue.TextLength > 0)
                {
                    if (nouvMDP.TextLength > 0)
                    {
                        Modele.changepass(nouvMDP.Text);
                        MessageBox.Show("Le mot de passe à été modifié");
                    }
                    if (TBNom.TextLength > 0)
                    {
                        Modele.changeNom(TBNom.Text);
                        MessageBox.Show("Le nom à été modifié");
                    }
                    if (TBPrenom.TextLength > 0)
                    {
                        Modele.changePrenom(TBPrenom.Text);
                        MessageBox.Show("Le prénom à été modifié");
                    }
                    if (TBCP.TextLength > 4)
                    {
                        Modele.changeCP(TBCP.Text);
                        MessageBox.Show("Le code postal à été modifié");
                    }
                    if (TBVille.TextLength > 0)
                    {
                        Modele.changeVille(TBVille.Text);
                        MessageBox.Show("La ville à été modifiée");
                    }
                    if (TBRue.TextLength > 0)
                    {
                        Modele.changeRue(TBRue.Text);
                        MessageBox.Show("L'adresse à été modifiée");
                    }
                }
                else
                {
                    MessageBox.Show("Modification refusée");
                }
            }
        }

        private void secteursToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static Visiteur RespLabo { get => RespLabo; set => RespLabo = value; }

        
        RespLabo = maConnexion.Visiteur.Where(x => x.identifiant == id).ToList()[0];




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

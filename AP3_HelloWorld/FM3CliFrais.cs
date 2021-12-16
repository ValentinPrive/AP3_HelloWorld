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
    public partial class FM3CliFrais : Form
    {
        int nbj;

        public FM3CliFrais()
        {
            InitializeComponent();
        }

        private void FM3CliFrais_SizeChanged(object sender, EventArgs e)
        {
            int largeur = panel1.Width;
            lblFicheFrais.Left = largeur / 2 - lblFicheFrais.Width / 2;

            pictureBox1.Left = largeur / 2 - pictureBox1.Width / 2;
        }

        private void FM3CliFrais_Load(object sender, EventArgs e)
        {
            Visiteur V;
            Modele.UtilisateurConnecte = Modele3.UtilisateurConnecte;
            V = Modele3.UtilisateurConnecte;
            nbj = 0;
            //Dit quel utilisateur se connecte
            lblIdVisiteur.Text = V.idVisiteur;
            lblNomVisiteur.Text = V.prenom + " " + V.nom;
            txtMNuitée.Text = Convert.ToString(Modele3.listeFF()[0].montant);
            txtRepas.Text = Convert.ToString(Modele3.listeFF()[8].montant);
            
            //Mise des valeurs dans la liste killométrage
            cbokilométrage.ValueMember = "id";
            cbokilométrage.DisplayMember = "libelle";
            bsFrais.DataSource = Modele3.listeFFA();
            cbokilométrage.DataSource = bsFrais;
            //Mise a zéro des quantités
            txtQKilo.Text = (0).ToString();
            txtQNuitee.Text = (0).ToString();
            txtQRPM.Text = (0).ToString();

        }

        private bool test()
        {
            bool vr = false;
            return vr;
        }

        private void bsFrais_CurrentChanged(object sender, EventArgs e)
        {
            txtKillometrage.Text = ((FraisForfait)bsFrais.Current).montant.ToString();
            try
            {
                txtTKilo.Text = (double.Parse(txtQKilo.Text) * double.Parse(txtKillometrage.Text)).ToString();
            }
            catch
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                txtTN.Text = (double.Parse(txtQNuitee.Text) * double.Parse(txtMNuitée.Text)).ToString();
            }
            catch
            {

            }
        }

        private void txtQRPM_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                txtTRPM.Text = (double.Parse(txtQRPM.Text) * double.Parse(txtRepas.Text)).ToString(); 
            }
            catch
            {

            }
        }

        private void txtQKilo_TextChanged(object sender, EventArgs e)
        {
            try 
            {  
                txtTKilo.Text = (double.Parse(txtQKilo.Text) * double.Parse(txtKillometrage.Text)).ToString(); 
            }
            catch
            {

            }
        }

        private void txtTN_TextChanged(object sender, EventArgs e)
        {
            double s1, s2, s3;
            double.TryParse(txtTKilo.Text,out s1);
            double.TryParse(txtTRPM.Text, out s2);
            double.TryParse(txtTN.Text, out s3);
            textBox4.Text = (s1 + s2 + s3).ToString();


        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string mois;
            double s1, s2, s3, m1;
            mois = txtMois.Text + txtAnnées.Text;
            nbj = 3;
            double.TryParse(txtTKilo.Text, out s1);
            double.TryParse(txtTRPM.Text, out s2);
            double.TryParse(txtTN.Text, out s3);
            m1 = s1 + s2 + s3;
            Modele3.AjoutficheFrais(mois, nbj, m1 );
            Close();
        }
    }
}

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
            List<>
            Modele.UtilisateurConnecte = Modele3.UtilisateurConnecte;
            V = Modele3.UtilisateurConnecte;
            //Dit quel utilisateur se connecte
            lblIdVisiteur.Text = V.idVisiteur;
            lblNomVisiteur.Text = V.prenom + " " + V.nom;
            txtMNuitée.Text = Convert.ToString(Modele3.listeFF()[0].montant);
            txtRepas.Text = Convert.ToString(Modele3.listeFF()[8].montant);
            
            //Mise des valeurs dans la liste killométrage
            cbokilométrage.ValueMember = "id";
            cbokilométrage.DisplayMember = "libelle";
            bsFrais.DataSource = Modele3.listeFF();
            cbokilométrage.DataSource = bsFrais;

        }

        private bool test()
        {
            bool vr = false;
            return vr;
        }

        private void bsFrais_CurrentChanged(object sender, EventArgs e)
        {
            txtKilometrage
        }
    }
}

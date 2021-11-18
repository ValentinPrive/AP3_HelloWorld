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
            V = Modele.UtilisateurConnecte;
            //Dit quel utilisateur se connecte 
            lblIdVisiteur.Text = V.idVisiteur;
            lblNomVisiteur.Text = V.nom+" "+V.prenom;
        }
    }
}

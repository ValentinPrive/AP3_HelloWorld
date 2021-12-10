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
    public partial class FM3MenuClient : Form
    {
        public FM3MenuClient()
        {
            InitializeComponent();
        }

        private void FM3MenuClient_Load(object sender, EventArgs e)
        {
            //Chargement de l'utilisateur courant du Modele principal a mon modele
            Visiteur V;
            Modele3.UtilisateurConnecte = Modele.UtilisateurConnecte;
            V = Modele3.UtilisateurConnecte;


            bsFicheFrais.DataSource = Modele3.listefrais().Select (x=>new { x.idVisiteur, x.idEtat, x.mois, x.montantValide } );
            dgvFrais.DataSource = bsFicheFrais;
        }

        private void btnAjoutF_Click(object sender, EventArgs e)
        {
            Form f = new FM3CliFrais();
            f.Show();
        }
    }
}

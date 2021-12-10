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
            //Chargement de l'utilisateur courant du Modele principal à mon modele
            Modele3.UtilisateurConnecte = Modele.UtilisateurConnecte;
            //Dire a la binding source l'utilisateur présent
            bsVisiteur.DataSource = Modele3.UtilisateurConnecte;
           
        }

        private void btnAjoutF_Click(object sender, EventArgs e)
        {
            Form f = new FM3CliFrais();
            f.Show();
        }

        private void bsVisiteur_CurrentChanged(object sender, EventArgs e)
        {
            bsFicheFrais.DataSource = ((Visiteur)bsVisiteur.Current).fichefrais.Select(x => new {x.Etat.libelle, x.idVisiteur, x.montantValide, x.mois, x.nbJustificatifs });
            dgvFrais.DataSource = bsFicheFrais;
            dgvFrais.Columns[0].HeaderText = "ETAT";
            dgvFrais.Columns[1].HeaderText = "IDVISITEUR";
            dgvFrais.Columns[2].HeaderText = "MONTANT VALIDE";
            dgvFrais.Columns[3].HeaderText = "MOIS / ANNEES";
            dgvFrais.Columns[4].HeaderText = "N°Justification";
        }
    }
}

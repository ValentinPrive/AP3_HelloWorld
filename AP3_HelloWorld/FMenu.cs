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
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();            
        }

        private void FMenu_Load(object sender, EventArgs e)
        {
            lblUtilConnecte.Text = "Utilisateur connecté : " + Modele.UtilisateurConnecte.nom + " " + Modele.UtilisateurConnecte.prenom;
        }

        private void FMenu_Shown(object sender, EventArgs e)
        {
            //Form f = new FConnexion();
            //f.Show();
        }

        private void btnMission1_Click(object sender, EventArgs e)
        {
            Form f = new FM1RLab();
            f.Show();
        }

        private void btnMission2_Click(object sender, EventArgs e)
        {
            Form f = new FMission2();
            f.Show();
        }

        private void btnMission3_Click(object sender, EventArgs e)
        {
            Form f = new FM3MenuClient();
            f.Show();
        }

    }
}

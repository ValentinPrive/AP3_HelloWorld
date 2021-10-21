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
            Visiteur V;
            bsFicheFrais.DataSource = Modele3.listefrais().Select(x=>new { x.idVisiteur,x.idEtat, x.mois, x.montantValide } );
            dgvFrais.DataSource = bsFicheFrais;
        }
    }
}

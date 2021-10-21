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
    public partial class FMission2 : Form
    {
        public FMission2()
        {
            InitializeComponent();
        }

        private void FMission2_Load(object sender, EventArgs e)
        {
            Modele.init();
            cboMedecin.ValueMember = "idMedecin";
            cboMedecin.DisplayMember = "nom" + " " + "prenom";
            bsMedecin.DataSource = Modele2.listemedecin();
            cboMedecin.DataSource = bsMedecin;
        }
    }
}

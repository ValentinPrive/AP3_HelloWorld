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
    public partial class FAjoutModifRapport : Form
    {
        public FAjoutModifRapport()
        {
            InitializeComponent();
        }

        private void idDateVisite_Click(object sender, EventArgs e)
        {

        }

        private void FAjoutModifRapport_Load(object sender, EventArgs e)
        {
            bsMedecin.DataSource = Modele2.listemedecin();
            bsMotif.DataSource = Modele2.listemotif();
            cboMedecin.DataSource = bsMedecin;
            cboMotif.DataSource = bsMotif;
            cboMedecin.ValueMember = "idMedecin";
            cboMedecin.DisplayMember = "nom";
            cboMotif.ValueMember = "idMotif";
            cboMotif.DisplayMember = "libMotif";
            foreach(MEDICAMENT m in Modele2.listemedicament())
            {
                clbMedicamentsPresentes.Items.Add(m.nomCommercial);
            }
            foreach (MEDICAMENT m in Modele2.listemedicament())
            {
                clbMedicamentsOfferts.Items.Add(m.nomCommercial);
            }
            if (Modele2.ActionGestionRapport == 1)
            {
                this.Text = "Ajout d'un rapport de visite";
            }
            if (Modele2.ActionGestionRapport == 2)
            {
                this.Text = "Modification du rapport de visite";
            }
        }

        private void cboMedecin_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((MEDECIN)e.ListItem).nom.Trim() + " " + ((MEDECIN)e.ListItem).prenom.Trim();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

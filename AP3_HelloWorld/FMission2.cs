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
            Modele2.init();
            cboMedecin.ValueMember = "idMedecin";
            cboMedecin.DisplayMember = "nom";
            bsMedecin.DataSource = Modele2.listemedecin();
            cboMedecin.DataSource = bsMedecin;
        }

        private void cboMedecin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bsMedecin_CurrentChanged(object sender, EventArgs e)
        {
            bsRapports.DataSource = ((MEDECIN)bsMedecin.Current).RAPPORT.Where(x => x.idVisiteur == Modele.UtilisateurConnecte.idVisiteur).Select(x => new { x.idRapport, x.dateRapport, nomMedecin=x.MEDECIN.nom, x.MEDECIN.prenom, x.MOTIF.libMotif, x.bilan }).OrderBy(x => x.dateRapport).ToList();
            dgvRapports.DataSource = bsRapports;
            dgvRapports.Columns[0].HeaderText = "Numéro du rapport";
            dgvRapports.Columns[1].HeaderText = "Date du rapport";
            dgvRapports.Columns[2].HeaderText = "Nom du médecin";
            dgvRapports.Columns[3].HeaderText = "Prénom du médecin";
            dgvRapports.Columns[4].HeaderText = "Motif de la visite";
            dgvRapports.Columns[5].HeaderText = "Bilan";
        }

        private void btnTousMedecins_Click(object sender, EventArgs e)
        {
            bsRapports.DataSource = Modele2.listerapport();
            dgvRapports.DataSource = bsRapports;
            dgvRapports.Columns[0].HeaderText = "Numéro du rapport";
            dgvRapports.Columns[1].HeaderText = "Date du rapport";
            dgvRapports.Columns[2].HeaderText = "Nom du médecin";
            dgvRapports.Columns[3].HeaderText = "Prénom du médecin";
            dgvRapports.Columns[4].HeaderText = "Motif de la visite";
            dgvRapports.Columns[5].HeaderText = "Bilan";
        }

        private void cboMedecin_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((MEDECIN)e.ListItem).nom.Trim() + " " + ((MEDECIN)e.ListItem).prenom.Trim();
        }

        private void btnAjoutRapport_Click(object sender, EventArgs e)
        {
            Modele2.actionGestionRapport = 1;
            Form f = new FAjoutModifRapport();
            f.Show();
        }

        private void btnModifRapport_Click(object sender, EventArgs e)
        {
            Modele2.actionGestionRapport = 2;
            System.Type type = bsRapports.Current.GetType();
            int id = (int)type.GetProperty("idRapport").GetValue(bsRapports.Current, null);
            Modele2.rapportChoisi = Modele2.RapportDepuisId(id);
            Form f = new FAjoutModifRapport();
            f.Show();
        }
    }
}

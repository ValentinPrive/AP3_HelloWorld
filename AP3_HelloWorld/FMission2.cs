﻿using System;
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
            bsRapports.DataSource = ((MEDECIN)bsMedecin.Current).RAPPORT.Where(x => x.idVisiteur == Modele.UtilisateurConnecte.idVisiteur).Select(x => new { x.idRapport, x.dateRapport, nomMedecin=x.MEDECIN.nom, x.MOTIF.libMotif, x.bilan }).OrderBy(x => x.dateRapport).ToList();
            dgvRapports.DataSource = bsRapports;
            dgvRapports.Columns[0].HeaderText = "Numéro du rapport";
            dgvRapports.Columns[1].HeaderText = "Date du rapport";
            dgvRapports.Columns[2].HeaderText = "Médecin";
            dgvRapports.Columns[3].HeaderText = "Motif de la visite";
            dgvRapports.Columns[4].HeaderText = "Bilan";
        }

        private void btnTousMedecins_Click(object sender, EventArgs e)
        {
            bsRapports.DataSource = Modele2.listerapport();
            dgvRapports.DataSource = bsRapports;
            dgvRapports.Columns[0].HeaderText = "Numéro du rapport";
            dgvRapports.Columns[1].HeaderText = "Date du rapport";
            dgvRapports.Columns[2].HeaderText = "Médecin";
            dgvRapports.Columns[3].HeaderText = "Motif de la visite";
            dgvRapports.Columns[4].HeaderText = "Bilan";
        }

        private void cboMedecin_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((MEDECIN)e.ListItem).nom.Trim() + " " + ((MEDECIN)e.ListItem).prenom.Trim();
        }
    }
}

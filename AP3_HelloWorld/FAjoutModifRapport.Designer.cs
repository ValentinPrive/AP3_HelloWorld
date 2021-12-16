
namespace AP3_HelloWorld
{
    partial class FAjoutModifRapport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.idDateVisite = new System.Windows.Forms.Label();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.lblBilan = new System.Windows.Forms.Label();
            this.cboMedecin = new System.Windows.Forms.ComboBox();
            this.lblMedecin = new System.Windows.Forms.Label();
            this.clbMedicamentsPresentes = new System.Windows.Forms.CheckedListBox();
            this.dtpDateVisite = new System.Windows.Forms.DateTimePicker();
            this.lblMedicamentsPresentes = new System.Windows.Forms.Label();
            this.clbMedicamentsOfferts = new System.Windows.Forms.CheckedListBox();
            this.lblMedicamentsOfferts = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.bsMedecin = new System.Windows.Forms.BindingSource(this.components);
            this.bsMotif = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotif)).BeginInit();
            this.SuspendLayout();
            // 
            // idDateVisite
            // 
            this.idDateVisite.AutoSize = true;
            this.idDateVisite.Location = new System.Drawing.Point(12, 42);
            this.idDateVisite.Name = "idDateVisite";
            this.idDateVisite.Size = new System.Drawing.Size(89, 13);
            this.idDateVisite.TabIndex = 0;
            this.idDateVisite.Text = "Date de la visite :";
            this.idDateVisite.Click += new System.EventHandler(this.idDateVisite_Click);
            // 
            // cboMotif
            // 
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Location = new System.Drawing.Point(144, 65);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(200, 21);
            this.cboMotif.TabIndex = 2;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(12, 68);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(36, 13);
            this.lblMotif.TabIndex = 3;
            this.lblMotif.Text = "Motif :";
            // 
            // txtBilan
            // 
            this.txtBilan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBilan.Location = new System.Drawing.Point(144, 92);
            this.txtBilan.Multiline = true;
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(644, 86);
            this.txtBilan.TabIndex = 4;
            // 
            // lblBilan
            // 
            this.lblBilan.AutoSize = true;
            this.lblBilan.Location = new System.Drawing.Point(12, 95);
            this.lblBilan.Name = "lblBilan";
            this.lblBilan.Size = new System.Drawing.Size(36, 13);
            this.lblBilan.TabIndex = 5;
            this.lblBilan.Text = "Bilan :";
            // 
            // cboMedecin
            // 
            this.cboMedecin.FormattingEnabled = true;
            this.cboMedecin.Location = new System.Drawing.Point(144, 12);
            this.cboMedecin.Name = "cboMedecin";
            this.cboMedecin.Size = new System.Drawing.Size(200, 21);
            this.cboMedecin.TabIndex = 6;
            this.cboMedecin.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cboMedecin_Format);
            // 
            // lblMedecin
            // 
            this.lblMedecin.AutoSize = true;
            this.lblMedecin.Location = new System.Drawing.Point(12, 15);
            this.lblMedecin.Name = "lblMedecin";
            this.lblMedecin.Size = new System.Drawing.Size(54, 13);
            this.lblMedecin.TabIndex = 7;
            this.lblMedecin.Text = "Médecin :";
            // 
            // clbMedicamentsPresentes
            // 
            this.clbMedicamentsPresentes.FormattingEnabled = true;
            this.clbMedicamentsPresentes.Location = new System.Drawing.Point(144, 184);
            this.clbMedicamentsPresentes.Name = "clbMedicamentsPresentes";
            this.clbMedicamentsPresentes.Size = new System.Drawing.Size(200, 184);
            this.clbMedicamentsPresentes.TabIndex = 8;
            // 
            // dtpDateVisite
            // 
            this.dtpDateVisite.Checked = false;
            this.dtpDateVisite.Location = new System.Drawing.Point(144, 39);
            this.dtpDateVisite.Name = "dtpDateVisite";
            this.dtpDateVisite.Size = new System.Drawing.Size(200, 20);
            this.dtpDateVisite.TabIndex = 9;
            // 
            // lblMedicamentsPresentes
            // 
            this.lblMedicamentsPresentes.AutoSize = true;
            this.lblMedicamentsPresentes.Location = new System.Drawing.Point(13, 186);
            this.lblMedicamentsPresentes.Name = "lblMedicamentsPresentes";
            this.lblMedicamentsPresentes.Size = new System.Drawing.Size(125, 13);
            this.lblMedicamentsPresentes.TabIndex = 10;
            this.lblMedicamentsPresentes.Text = "Médicaments présentés :";
            // 
            // clbMedicamentsOfferts
            // 
            this.clbMedicamentsOfferts.FormattingEnabled = true;
            this.clbMedicamentsOfferts.Location = new System.Drawing.Point(464, 184);
            this.clbMedicamentsOfferts.Name = "clbMedicamentsOfferts";
            this.clbMedicamentsOfferts.Size = new System.Drawing.Size(200, 184);
            this.clbMedicamentsOfferts.TabIndex = 11;
            // 
            // lblMedicamentsOfferts
            // 
            this.lblMedicamentsOfferts.AutoSize = true;
            this.lblMedicamentsOfferts.Location = new System.Drawing.Point(350, 186);
            this.lblMedicamentsOfferts.Name = "lblMedicamentsOfferts";
            this.lblMedicamentsOfferts.Size = new System.Drawing.Size(108, 13);
            this.lblMedicamentsOfferts.TabIndex = 12;
            this.lblMedicamentsOfferts.Text = "Médicaments offerts :";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(225, 385);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(144, 385);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 14;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // FAjoutModifRapport
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblMedicamentsOfferts);
            this.Controls.Add(this.clbMedicamentsOfferts);
            this.Controls.Add(this.lblMedicamentsPresentes);
            this.Controls.Add(this.dtpDateVisite);
            this.Controls.Add(this.clbMedicamentsPresentes);
            this.Controls.Add(this.lblMedecin);
            this.Controls.Add(this.cboMedecin);
            this.Controls.Add(this.lblBilan);
            this.Controls.Add(this.txtBilan);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.cboMotif);
            this.Controls.Add(this.idDateVisite);
            this.Name = "FAjoutModifRapport";
            this.Load += new System.EventHandler(this.FAjoutModifRapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idDateVisite;
        private System.Windows.Forms.ComboBox cboMotif;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.TextBox txtBilan;
        private System.Windows.Forms.Label lblBilan;
        private System.Windows.Forms.ComboBox cboMedecin;
        private System.Windows.Forms.Label lblMedecin;
        private System.Windows.Forms.CheckedListBox clbMedicamentsPresentes;
        private System.Windows.Forms.DateTimePicker dtpDateVisite;
        private System.Windows.Forms.Label lblMedicamentsPresentes;
        private System.Windows.Forms.CheckedListBox clbMedicamentsOfferts;
        private System.Windows.Forms.Label lblMedicamentsOfferts;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.BindingSource bsMedecin;
        private System.Windows.Forms.BindingSource bsMotif;
    }
}
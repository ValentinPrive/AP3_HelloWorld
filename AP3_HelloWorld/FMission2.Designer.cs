
namespace AP3_HelloWorld
{
    partial class FMission2
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pnlTitre = new System.Windows.Forms.Panel();
            this.lblMedecin = new System.Windows.Forms.Label();
            this.bsMedecin = new System.Windows.Forms.BindingSource(this.components);
            this.cboMedecin = new System.Windows.Forms.ComboBox();
            this.bsRapports = new System.Windows.Forms.BindingSource(this.components);
            this.dgvRapports = new System.Windows.Forms.DataGridView();
            this.btnTousMedecins = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapports)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.Image = global::AP3_HelloWorld.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(334, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(135, 91);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // lblTitre
            // 
            this.lblTitre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblTitre.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTitre.Location = new System.Drawing.Point(309, 18);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(185, 25);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Rapports de visite";
            // 
            // pnlTitre
            // 
            this.pnlTitre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTitre.AutoSize = true;
            this.pnlTitre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTitre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitre.Controls.Add(this.lblTitre);
            this.pnlTitre.Location = new System.Drawing.Point(0, 109);
            this.pnlTitre.Name = "pnlTitre";
            this.pnlTitre.Size = new System.Drawing.Size(800, 61);
            this.pnlTitre.TabIndex = 2;
            // 
            // lblMedecin
            // 
            this.lblMedecin.AutoSize = true;
            this.lblMedecin.Location = new System.Drawing.Point(12, 183);
            this.lblMedecin.Name = "lblMedecin";
            this.lblMedecin.Size = new System.Drawing.Size(54, 13);
            this.lblMedecin.TabIndex = 4;
            this.lblMedecin.Text = "Médecin :";
            // 
            // bsMedecin
            // 
            this.bsMedecin.CurrentChanged += new System.EventHandler(this.bsMedecin_CurrentChanged);
            // 
            // cboMedecin
            // 
            this.cboMedecin.FormattingEnabled = true;
            this.cboMedecin.Location = new System.Drawing.Point(72, 180);
            this.cboMedecin.Name = "cboMedecin";
            this.cboMedecin.Size = new System.Drawing.Size(121, 21);
            this.cboMedecin.TabIndex = 5;
            this.cboMedecin.SelectedIndexChanged += new System.EventHandler(this.cboMedecin_SelectedIndexChanged);
            // 
            // dgvRapports
            // 
            this.dgvRapports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRapports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRapports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapports.Location = new System.Drawing.Point(15, 207);
            this.dgvRapports.Name = "dgvRapports";
            this.dgvRapports.Size = new System.Drawing.Size(773, 231);
            this.dgvRapports.TabIndex = 6;
            // 
            // btnTousMedecins
            // 
            this.btnTousMedecins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTousMedecins.Location = new System.Drawing.Point(685, 178);
            this.btnTousMedecins.Name = "btnTousMedecins";
            this.btnTousMedecins.Size = new System.Drawing.Size(103, 23);
            this.btnTousMedecins.TabIndex = 7;
            this.btnTousMedecins.Text = "Tous les médecins";
            this.btnTousMedecins.UseVisualStyleBackColor = true;
            this.btnTousMedecins.Click += new System.EventHandler(this.btnTousMedecins_Click);
            // 
            // FMission2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTousMedecins);
            this.Controls.Add(this.dgvRapports);
            this.Controls.Add(this.cboMedecin);
            this.Controls.Add(this.lblMedecin);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pnlTitre);
            this.Name = "FMission2";
            this.Text = "Rapports de visite";
            this.Load += new System.EventHandler(this.FMission2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlTitre.ResumeLayout(false);
            this.pnlTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel pnlTitre;
        private System.Windows.Forms.Label lblMedecin;
        private System.Windows.Forms.BindingSource bsMedecin;
        private System.Windows.Forms.ComboBox cboMedecin;
        private System.Windows.Forms.BindingSource bsRapports;
        private System.Windows.Forms.DataGridView dgvRapports;
        private System.Windows.Forms.Button btnTousMedecins;
    }
}
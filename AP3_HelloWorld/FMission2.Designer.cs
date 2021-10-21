
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
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecin)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::AP3_HelloWorld.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(352, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(117, 91);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblTitre.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTitre.Location = new System.Drawing.Point(315, 18);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(185, 25);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Rapports de visite";
            // 
            // pnlTitre
            // 
            this.pnlTitre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            // cboMedecin
            // 
            this.cboMedecin.FormattingEnabled = true;
            this.cboMedecin.Location = new System.Drawing.Point(72, 180);
            this.cboMedecin.Name = "cboMedecin";
            this.cboMedecin.Size = new System.Drawing.Size(121, 21);
            this.cboMedecin.TabIndex = 5;
            // 
            // FMission2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboMedecin);
            this.Controls.Add(this.lblMedecin);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pnlTitre);
            this.Name = "FMission2";
            this.Text = "Mission 2";
            this.Load += new System.EventHandler(this.FMission2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlTitre.ResumeLayout(false);
            this.pnlTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecin)).EndInit();
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
    }
}
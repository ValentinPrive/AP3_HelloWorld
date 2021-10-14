
namespace AP3_HelloWorld
{
    partial class FM3CliFrais
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFicheFrais = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVisiteur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblNomVisiteur = new System.Windows.Forms.Label();
            this.lblIdVisiteur = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblFicheFrais);
            this.panel1.Location = new System.Drawing.Point(-10, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 61);
            this.panel1.TabIndex = 0;
            // 
            // lblFicheFrais
            // 
            this.lblFicheFrais.AutoSize = true;
            this.lblFicheFrais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblFicheFrais.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblFicheFrais.Location = new System.Drawing.Point(353, 15);
            this.lblFicheFrais.Name = "lblFicheFrais";
            this.lblFicheFrais.Size = new System.Drawing.Size(119, 25);
            this.lblFicheFrais.TabIndex = 0;
            this.lblFicheFrais.Text = "Fiche Frais";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AP3_HelloWorld.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(340, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.AutoSize = true;
            this.lblVisiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblVisiteur.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblVisiteur.Location = new System.Drawing.Point(24, 193);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(75, 20);
            this.lblVisiteur.TabIndex = 2;
            this.lblVisiteur.Text = "Visiteur:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(24, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mois:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 264);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // lblNomVisiteur
            // 
            this.lblNomVisiteur.AutoSize = true;
            this.lblNomVisiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNomVisiteur.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblNomVisiteur.Location = new System.Drawing.Point(96, 223);
            this.lblNomVisiteur.Name = "lblNomVisiteur";
            this.lblNomVisiteur.Size = new System.Drawing.Size(132, 20);
            this.lblNomVisiteur.TabIndex = 5;
            this.lblNomVisiteur.Text = "NOMVISITEUR";
            // 
            // lblIdVisiteur
            // 
            this.lblIdVisiteur.AutoSize = true;
            this.lblIdVisiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblIdVisiteur.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblIdVisiteur.Location = new System.Drawing.Point(96, 193);
            this.lblIdVisiteur.Name = "lblIdVisiteur";
            this.lblIdVisiteur.Size = new System.Drawing.Size(112, 20);
            this.lblIdVisiteur.TabIndex = 6;
            this.lblIdVisiteur.Text = "IDVISITEUR";
            // 
            // FM3CliFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIdVisiteur);
            this.Controls.Add(this.lblNomVisiteur);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVisiteur);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FM3CliFrais";
            this.Text = "FM3CliFrais";
            this.SizeChanged += new System.EventHandler(this.FM3CliFrais_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFicheFrais;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVisiteur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblNomVisiteur;
        private System.Windows.Forms.Label lblIdVisiteur;
    }
}
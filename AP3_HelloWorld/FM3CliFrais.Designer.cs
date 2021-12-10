
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFicheFrais = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVisiteur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomVisiteur = new System.Windows.Forms.Label();
            this.lblFrais = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMois = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnnées = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblIdVisiteur = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtMNuitée = new System.Windows.Forms.TextBox();
            this.txtRepas = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtKilometrage = new System.Windows.Forms.TextBox();
            this.bsFrais = new System.Windows.Forms.BindingSource(this.components);
            this.cbokilométrage = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFrais)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblFicheFrais);
            this.panel1.Location = new System.Drawing.Point(-12, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 61);
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
            this.lblVisiteur.Location = new System.Drawing.Point(23, 214);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(141, 20);
            this.lblVisiteur.TabIndex = 2;
            this.lblVisiteur.Text = "Nom du Visiteur:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(23, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mois:";
            // 
            // lblNomVisiteur
            // 
            this.lblNomVisiteur.AutoSize = true;
            this.lblNomVisiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNomVisiteur.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblNomVisiteur.Location = new System.Drawing.Point(170, 214);
            this.lblNomVisiteur.Name = "lblNomVisiteur";
            this.lblNomVisiteur.Size = new System.Drawing.Size(132, 20);
            this.lblNomVisiteur.TabIndex = 6;
            this.lblNomVisiteur.Text = "NOMVISITEUR";
            // 
            // lblFrais
            // 
            this.lblFrais.AutoSize = true;
            this.lblFrais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrais.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblFrais.Location = new System.Drawing.Point(24, 278);
            this.lblFrais.Name = "lblFrais";
            this.lblFrais.Size = new System.Drawing.Size(150, 20);
            this.lblFrais.TabIndex = 7;
            this.lblFrais.Text = "Fiche Forfaitaires";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(194, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quantité";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(312, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Montant unitaire";
            // 
            // txtMois
            // 
            this.txtMois.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMois.Location = new System.Drawing.Point(90, 243);
            this.txtMois.Name = "txtMois";
            this.txtMois.Size = new System.Drawing.Size(36, 26);
            this.txtMois.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(503, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total";
            // 
            // txtAnnées
            // 
            this.txtAnnées.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAnnées.Location = new System.Drawing.Point(154, 243);
            this.txtAnnées.Name = "txtAnnées";
            this.txtAnnées.Size = new System.Drawing.Size(117, 26);
            this.txtAnnées.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(132, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "-";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(661, 536);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(23, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID du Visiteur:";
            // 
            // lblIdVisiteur
            // 
            this.lblIdVisiteur.AutoSize = true;
            this.lblIdVisiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblIdVisiteur.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblIdVisiteur.Location = new System.Drawing.Point(170, 182);
            this.lblIdVisiteur.Name = "lblIdVisiteur";
            this.lblIdVisiteur.Size = new System.Drawing.Size(112, 20);
            this.lblIdVisiteur.TabIndex = 17;
            this.lblIdVisiteur.Text = "IDVISITEUR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(65, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nuitée";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(49, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Repas Midi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Location = new System.Drawing.Point(49, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Kilométrage";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(193, 307);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 26);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.Location = new System.Drawing.Point(193, 339);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(84, 26);
            this.textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox3.Location = new System.Drawing.Point(193, 401);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(84, 26);
            this.textBox3.TabIndex = 23;
            // 
            // txtMNuitée
            // 
            this.txtMNuitée.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMNuitée.Location = new System.Drawing.Point(316, 306);
            this.txtMNuitée.Name = "txtMNuitée";
            this.txtMNuitée.ReadOnly = true;
            this.txtMNuitée.Size = new System.Drawing.Size(136, 26);
            this.txtMNuitée.TabIndex = 24;
            this.txtMNuitée.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRepas
            // 
            this.txtRepas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRepas.Location = new System.Drawing.Point(316, 339);
            this.txtRepas.Name = "txtRepas";
            this.txtRepas.ReadOnly = true;
            this.txtRepas.Size = new System.Drawing.Size(136, 26);
            this.txtRepas.TabIndex = 25;
            this.txtRepas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox6.Location = new System.Drawing.Point(316, 401);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(136, 26);
            this.textBox6.TabIndex = 26;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox7.Location = new System.Drawing.Point(482, 304);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(97, 26);
            this.textBox7.TabIndex = 27;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox8.Location = new System.Drawing.Point(482, 340);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(97, 26);
            this.textBox8.TabIndex = 28;
            // 
            // txtKilometrage
            // 
            this.txtKilometrage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtKilometrage.Location = new System.Drawing.Point(482, 401);
            this.txtKilometrage.Name = "txtKilometrage";
            this.txtKilometrage.ReadOnly = true;
            this.txtKilometrage.Size = new System.Drawing.Size(97, 26);
            this.txtKilometrage.TabIndex = 29;
            // 
            // bsFrais
            // 
            this.bsFrais.CurrentChanged += new System.EventHandler(this.bsFrais_CurrentChanged);
            // 
            // cbokilométrage
            // 
            this.cbokilométrage.FormattingEnabled = true;
            this.cbokilométrage.Location = new System.Drawing.Point(53, 403);
            this.cbokilométrage.Name = "cbokilométrage";
            this.cbokilométrage.Size = new System.Drawing.Size(94, 21);
            this.cbokilométrage.TabIndex = 30;
            // 
            // FM3CliFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.cbokilométrage);
            this.Controls.Add(this.txtKilometrage);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtRepas);
            this.Controls.Add(this.txtMNuitée);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblIdVisiteur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAnnées);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMois);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFrais);
            this.Controls.Add(this.lblNomVisiteur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVisiteur);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FM3CliFrais";
            this.Text = "FM3CliFrais";
            this.Load += new System.EventHandler(this.FM3CliFrais_Load);
            this.SizeChanged += new System.EventHandler(this.FM3CliFrais_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFrais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFicheFrais;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVisiteur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomVisiteur;
        private System.Windows.Forms.Label lblFrais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMois;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAnnées;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblIdVisiteur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtMNuitée;
        private System.Windows.Forms.TextBox txtRepas;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox txtKilometrage;
        private System.Windows.Forms.BindingSource bsFrais;
        private System.Windows.Forms.ComboBox cbokilométrage;
    }
}
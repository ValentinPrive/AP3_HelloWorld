
namespace AP3_HelloWorld
{
    partial class FM1RLab
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
            this.DGVInfPers = new System.Windows.Forms.DataGridView();
            this.InfoPers = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ModMDP = new System.Windows.Forms.Button();
            this.Nom = new System.Windows.Forms.Label();
            this.Prenom = new System.Windows.Forms.Label();
            this.Rue = new System.Windows.Forms.Label();
            this.CP = new System.Windows.Forms.Label();
            this.Ville = new System.Windows.Forms.Label();
            this.TBNom = new System.Windows.Forms.TextBox();
            this.TBPrenom = new System.Windows.Forms.TextBox();
            this.TBRue = new System.Windows.Forms.TextBox();
            this.TBCP = new System.Windows.Forms.TextBox();
            this.TBVille = new System.Windows.Forms.TextBox();
            this.ancMDP = new System.Windows.Forms.TextBox();
            this.nouvMDP = new System.Windows.Forms.TextBox();
            this.textAncMDP = new System.Windows.Forms.Label();
            this.textNouvMDP = new System.Windows.Forms.Label();
            this.BValider = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BT = new System.Windows.Forms.ToolStripMenuItem();
            this.Resp = new System.Windows.Forms.Label();
            this.Labo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInfPers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVInfPers
            // 
            this.DGVInfPers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVInfPers.Location = new System.Drawing.Point(12, 56);
            this.DGVInfPers.Name = "DGVInfPers";
            this.DGVInfPers.Size = new System.Drawing.Size(591, 368);
            this.DGVInfPers.TabIndex = 0;
            // 
            // InfoPers
            // 
            this.InfoPers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoPers.Location = new System.Drawing.Point(612, 12);
            this.InfoPers.Name = "InfoPers";
            this.InfoPers.Size = new System.Drawing.Size(176, 23);
            this.InfoPers.TabIndex = 1;
            this.InfoPers.Text = "Informations personnelles";
            this.InfoPers.UseVisualStyleBackColor = true;
            this.InfoPers.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModMDP
            // 
            this.ModMDP.Location = new System.Drawing.Point(624, 256);
            this.ModMDP.Name = "ModMDP";
            this.ModMDP.Size = new System.Drawing.Size(150, 23);
            this.ModMDP.TabIndex = 2;
            this.ModMDP.Text = "Modifier mot de passe";
            this.ModMDP.UseVisualStyleBackColor = true;
            this.ModMDP.Click += new System.EventHandler(this.ModMDP_Click);
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(609, 50);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(35, 13);
            this.Nom.TabIndex = 3;
            this.Nom.Text = "Nom :";
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Location = new System.Drawing.Point(691, 50);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(49, 13);
            this.Prenom.TabIndex = 4;
            this.Prenom.Text = "Prénom :";
            // 
            // Rue
            // 
            this.Rue.AutoSize = true;
            this.Rue.Location = new System.Drawing.Point(609, 124);
            this.Rue.Name = "Rue";
            this.Rue.Size = new System.Drawing.Size(33, 13);
            this.Rue.TabIndex = 5;
            this.Rue.Text = "Rue :";
            // 
            // CP
            // 
            this.CP.AutoSize = true;
            this.CP.Location = new System.Drawing.Point(609, 192);
            this.CP.Name = "CP";
            this.CP.Size = new System.Drawing.Size(27, 13);
            this.CP.TabIndex = 6;
            this.CP.Text = "CP :";
            // 
            // Ville
            // 
            this.Ville.AutoSize = true;
            this.Ville.Location = new System.Drawing.Point(691, 192);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(32, 13);
            this.Ville.TabIndex = 7;
            this.Ville.Text = "Ville :";
            // 
            // TBNom
            // 
            this.TBNom.Location = new System.Drawing.Point(612, 75);
            this.TBNom.Name = "TBNom";
            this.TBNom.Size = new System.Drawing.Size(75, 20);
            this.TBNom.TabIndex = 8;
            // 
            // TBPrenom
            // 
            this.TBPrenom.Location = new System.Drawing.Point(694, 75);
            this.TBPrenom.Name = "TBPrenom";
            this.TBPrenom.Size = new System.Drawing.Size(94, 20);
            this.TBPrenom.TabIndex = 9;
            // 
            // TBRue
            // 
            this.TBRue.Location = new System.Drawing.Point(612, 150);
            this.TBRue.Name = "TBRue";
            this.TBRue.Size = new System.Drawing.Size(176, 20);
            this.TBRue.TabIndex = 10;
            // 
            // TBCP
            // 
            this.TBCP.Location = new System.Drawing.Point(612, 217);
            this.TBCP.Name = "TBCP";
            this.TBCP.Size = new System.Drawing.Size(50, 20);
            this.TBCP.TabIndex = 11;
            // 
            // TBVille
            // 
            this.TBVille.Location = new System.Drawing.Point(694, 217);
            this.TBVille.Name = "TBVille";
            this.TBVille.Size = new System.Drawing.Size(94, 20);
            this.TBVille.TabIndex = 12;
            // 
            // ancMDP
            // 
            this.ancMDP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ancMDP.Location = new System.Drawing.Point(642, 307);
            this.ancMDP.Name = "ancMDP";
            this.ancMDP.Size = new System.Drawing.Size(118, 20);
            this.ancMDP.TabIndex = 13;
            // 
            // nouvMDP
            // 
            this.nouvMDP.Location = new System.Drawing.Point(642, 361);
            this.nouvMDP.Name = "nouvMDP";
            this.nouvMDP.Size = new System.Drawing.Size(118, 20);
            this.nouvMDP.TabIndex = 14;
            // 
            // textAncMDP
            // 
            this.textAncMDP.AutoSize = true;
            this.textAncMDP.Location = new System.Drawing.Point(642, 288);
            this.textAncMDP.Name = "textAncMDP";
            this.textAncMDP.Size = new System.Drawing.Size(112, 13);
            this.textAncMDP.TabIndex = 15;
            this.textAncMDP.Text = "Ancien mot de passe :";
            // 
            // textNouvMDP
            // 
            this.textNouvMDP.AutoSize = true;
            this.textNouvMDP.Location = new System.Drawing.Point(642, 342);
            this.textNouvMDP.Name = "textNouvMDP";
            this.textNouvMDP.Size = new System.Drawing.Size(123, 13);
            this.textNouvMDP.TabIndex = 16;
            this.textNouvMDP.Text = "Nouveau mot de passe :";
            // 
            // BValider
            // 
            this.BValider.Location = new System.Drawing.Point(665, 401);
            this.BValider.Name = "BValider";
            this.BValider.Size = new System.Drawing.Size(75, 23);
            this.BValider.TabIndex = 17;
            this.BValider.Text = "Valider";
            this.BValider.UseVisualStyleBackColor = true;
            this.BValider.Click += new System.EventHandler(this.BValider_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BT});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BT
            // 
            this.BT.Name = "BT";
            this.BT.Size = new System.Drawing.Size(61, 20);
            this.BT.Text = "Régions";
            this.BT.Click += new System.EventHandler(this.secteursToolStripMenuItem_Click);
            // 
            // Resp
            // 
            this.Resp.AutoSize = true;
            this.Resp.Location = new System.Drawing.Point(13, 28);
            this.Resp.Name = "Resp";
            this.Resp.Size = new System.Drawing.Size(82, 13);
            this.Resp.TabIndex = 19;
            this.Resp.Text = "Responsabilité :";
            // 
            // Labo
            // 
            this.Labo.AutoSize = true;
            this.Labo.Location = new System.Drawing.Point(241, 28);
            this.Labo.Name = "Labo";
            this.Labo.Size = new System.Drawing.Size(66, 13);
            this.Labo.TabIndex = 20;
            this.Labo.Text = "Laboratoire :";
            this.Labo.Click += new System.EventHandler(this.label1_Click);
            // 
            // FM1RLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Labo);
            this.Controls.Add(this.Resp);
            this.Controls.Add(this.BValider);
            this.Controls.Add(this.textNouvMDP);
            this.Controls.Add(this.textAncMDP);
            this.Controls.Add(this.nouvMDP);
            this.Controls.Add(this.ancMDP);
            this.Controls.Add(this.TBVille);
            this.Controls.Add(this.TBCP);
            this.Controls.Add(this.TBRue);
            this.Controls.Add(this.TBPrenom);
            this.Controls.Add(this.TBNom);
            this.Controls.Add(this.Ville);
            this.Controls.Add(this.CP);
            this.Controls.Add(this.Rue);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.ModMDP);
            this.Controls.Add(this.InfoPers);
            this.Controls.Add(this.DGVInfPers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FM1RLab";
            this.Text = "Mission 1";
            this.Load += new System.EventHandler(this.FM1RLab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVInfPers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVInfPers;
        private System.Windows.Forms.Button InfoPers;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button ModMDP;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.Label Rue;
        private System.Windows.Forms.Label CP;
        private System.Windows.Forms.Label Ville;
        private System.Windows.Forms.TextBox TBNom;
        private System.Windows.Forms.TextBox TBPrenom;
        private System.Windows.Forms.TextBox TBRue;
        private System.Windows.Forms.TextBox TBCP;
        private System.Windows.Forms.TextBox TBVille;
        private System.Windows.Forms.TextBox ancMDP;
        private System.Windows.Forms.TextBox nouvMDP;
        private System.Windows.Forms.Label textAncMDP;
        private System.Windows.Forms.Label textNouvMDP;
        private System.Windows.Forms.Button BValider;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BT;
        private System.Windows.Forms.Label Labo;
        private System.Windows.Forms.Label Resp;
    }
}

namespace AP3_HelloWorld
{
    partial class FConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FConnexion));
            this.btnOK = new System.Windows.Forms.Button();
            this.lblConnexion = new System.Windows.Forms.Label();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(350, 280);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 17;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblConnexion
            // 
            this.lblConnexion.AutoSize = true;
            this.lblConnexion.BackColor = System.Drawing.Color.Transparent;
            this.lblConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnexion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblConnexion.Location = new System.Drawing.Point(255, 116);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(115, 25);
            this.lblConnexion.TabIndex = 16;
            this.lblConnexion.Text = "Connexion";
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(221, 229);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(204, 20);
            this.txtMdp.TabIndex = 15;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.BackColor = System.Drawing.Color.Transparent;
            this.lblMdp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMdp.Location = new System.Drawing.Point(138, 232);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(77, 13);
            this.lblMdp.TabIndex = 14;
            this.lblMdp.Text = "Mot de passe :";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(221, 178);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(204, 20);
            this.txtIdentifiant.TabIndex = 13;
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.BackColor = System.Drawing.Color.Transparent;
            this.lblIdentifiant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIdentifiant.Location = new System.Drawing.Point(138, 181);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(59, 13);
            this.lblIdentifiant.TabIndex = 12;
            this.lblIdentifiant.Text = "Identifiant :";
            // 
            // FConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(626, 419);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblConnexion);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.lblIdentifiant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FConnexion";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.FConnexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblConnexion;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label lblIdentifiant;
    }
}
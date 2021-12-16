
namespace AP3_HelloWorld
{
    partial class FMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.lblUtilConnecte = new System.Windows.Forms.Label();
            this.btnMission1 = new System.Windows.Forms.Button();
            this.btnMission2 = new System.Windows.Forms.Button();
            this.btnMission3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUtilConnecte
            // 
            this.lblUtilConnecte.AutoSize = true;
            this.lblUtilConnecte.Location = new System.Drawing.Point(13, 13);
            this.lblUtilConnecte.Name = "lblUtilConnecte";
            this.lblUtilConnecte.Size = new System.Drawing.Size(133, 13);
            this.lblUtilConnecte.TabIndex = 0;
            this.lblUtilConnecte.Text = "Aucun utilisateur connecté";
            this.lblUtilConnecte.Click += new System.EventHandler(this.lblUtilConnecte_Click);
            // 
            // btnMission1
            // 
            this.btnMission1.Location = new System.Drawing.Point(277, 119);
            this.btnMission1.Name = "btnMission1";
            this.btnMission1.Size = new System.Drawing.Size(212, 23);
            this.btnMission1.TabIndex = 1;
            this.btnMission1.Text = "Gestion des visiteurs, secteurs et régions";
            this.btnMission1.UseVisualStyleBackColor = true;
            this.btnMission1.Click += new System.EventHandler(this.btnMission1_Click);
            // 
            // btnMission2
            // 
            this.btnMission2.Location = new System.Drawing.Point(303, 230);
            this.btnMission2.Name = "btnMission2";
            this.btnMission2.Size = new System.Drawing.Size(163, 23);
            this.btnMission2.TabIndex = 2;
            this.btnMission2.Text = "Gestion des rapports de visite";
            this.btnMission2.UseVisualStyleBackColor = true;
            this.btnMission2.Click += new System.EventHandler(this.btnMission2_Click);
            // 
            // btnMission3
            // 
            this.btnMission3.Location = new System.Drawing.Point(303, 337);
            this.btnMission3.Name = "btnMission3";
            this.btnMission3.Size = new System.Drawing.Size(163, 23);
            this.btnMission3.TabIndex = 3;
            this.btnMission3.Text = "Gestion des remboursements";
            this.btnMission3.UseVisualStyleBackColor = true;
            this.btnMission3.Click += new System.EventHandler(this.btnMission3_Click);
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMission3);
            this.Controls.Add(this.btnMission2);
            this.Controls.Add(this.btnMission1);
            this.Controls.Add(this.lblUtilConnecte);
            this.Name = "FMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FMenu_Load);
            this.Shown += new System.EventHandler(this.FMenu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.Label lblUtilConnecte;
        private System.Windows.Forms.Button btnMission1;
        private System.Windows.Forms.Button btnMission2;
        private System.Windows.Forms.Button btnMission3;
    }
}


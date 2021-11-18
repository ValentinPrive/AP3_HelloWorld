
namespace AP3_HelloWorld
{
    partial class FM3MenuClient
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
            this.btnAjoutF = new System.Windows.Forms.Button();
            this.btnModifF = new System.Windows.Forms.Button();
            this.dgvFrais = new System.Windows.Forms.DataGridView();
            this.bsFicheFrais = new System.Windows.Forms.BindingSource(this.components);
            this.lblFicheFrais = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.CbDate = new System.Windows.Forms.ComboBox();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFicheFrais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjoutF
            // 
            this.btnAjoutF.Location = new System.Drawing.Point(399, 455);
            this.btnAjoutF.Name = "btnAjoutF";
            this.btnAjoutF.Size = new System.Drawing.Size(169, 23);
            this.btnAjoutF.TabIndex = 0;
            this.btnAjoutF.Text = "Ajouter une fiche de Frais";
            this.btnAjoutF.UseVisualStyleBackColor = true;
            this.btnAjoutF.Click += new System.EventHandler(this.btnAjoutF_Click);
            // 
            // btnModifF
            // 
            this.btnModifF.Location = new System.Drawing.Point(574, 455);
            this.btnModifF.Name = "btnModifF";
            this.btnModifF.Size = new System.Drawing.Size(147, 23);
            this.btnModifF.TabIndex = 1;
            this.btnModifF.Text = "Modifier une fiche de frais";
            this.btnModifF.UseVisualStyleBackColor = true;
            // 
            // dgvFrais
            // 
            this.dgvFrais.AllowUserToDeleteRows = false;
            this.dgvFrais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrais.Location = new System.Drawing.Point(12, 84);
            this.dgvFrais.Name = "dgvFrais";
            this.dgvFrais.Size = new System.Drawing.Size(776, 357);
            this.dgvFrais.TabIndex = 2;
            // 
            // lblFicheFrais
            // 
            this.lblFicheFrais.AutoSize = true;
            this.lblFicheFrais.Location = new System.Drawing.Point(12, 18);
            this.lblFicheFrais.Name = "lblFicheFrais";
            this.lblFicheFrais.Size = new System.Drawing.Size(61, 13);
            this.lblFicheFrais.TabIndex = 3;
            this.lblFicheFrais.Text = "Fiche Frais:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 46);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date :";
            // 
            // CbDate
            // 
            this.CbDate.FormattingEnabled = true;
            this.CbDate.Location = new System.Drawing.Point(54, 43);
            this.CbDate.Name = "CbDate";
            this.CbDate.Size = new System.Drawing.Size(121, 21);
            this.CbDate.TabIndex = 5;
            // 
            // FM3MenuClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.CbDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblFicheFrais);
            this.Controls.Add(this.dgvFrais);
            this.Controls.Add(this.btnModifF);
            this.Controls.Add(this.btnAjoutF);
            this.Name = "FM3MenuClient";
            this.Text = "FM3MenuClient";
            this.Load += new System.EventHandler(this.FM3MenuClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFicheFrais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjoutF;
        private System.Windows.Forms.Button btnModifF;
        private System.Windows.Forms.DataGridView dgvFrais;
        private System.Windows.Forms.Label lblFicheFrais;
        private System.Windows.Forms.BindingSource bsFicheFrais;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox CbDate;
        private System.Windows.Forms.BindingSource bsVisiteur;
    }
}
﻿
namespace AP3_HelloWorld
{
    partial class FMission3
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
            this.btnFrais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFrais
            // 
            this.btnFrais.Location = new System.Drawing.Point(12, 12);
            this.btnFrais.Name = "btnFrais";
            this.btnFrais.Size = new System.Drawing.Size(75, 23);
            this.btnFrais.TabIndex = 0;
            this.btnFrais.Text = "Fiche Frais";
            this.btnFrais.UseVisualStyleBackColor = true;
            this.btnFrais.Click += new System.EventHandler(this.btnFrais_Click);
            // 
            // FMission3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFrais);
            this.Name = "FMission3";
            this.Text = "Mission 3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFrais;
    }
}
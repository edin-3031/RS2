﻿namespace StudentskiServis.WinUI.Raspored
{
    partial class frmMojRasporedIzmjena
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
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.cbVazno = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDatum = new System.Windows.Forms.DateTimePicker();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbOpis
            // 
            this.rtbOpis.Location = new System.Drawing.Point(12, 132);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.Size = new System.Drawing.Size(679, 306);
            this.rtbOpis.TabIndex = 11;
            this.rtbOpis.Text = "";
            // 
            // cbVazno
            // 
            this.cbVazno.AutoSize = true;
            this.cbVazno.Location = new System.Drawing.Point(546, 67);
            this.cbVazno.Name = "cbVazno";
            this.cbVazno.Size = new System.Drawing.Size(56, 17);
            this.cbVazno.TabIndex = 10;
            this.cbVazno.Text = "Važno";
            this.cbVazno.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Datum";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(87, 64);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(177, 20);
            this.txtNaslov.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naslov";
            // 
            // dateDatum
            // 
            this.dateDatum.Location = new System.Drawing.Point(298, 63);
            this.dateDatum.Name = "dateDatum";
            this.dateDatum.Size = new System.Drawing.Size(200, 20);
            this.dateDatum.TabIndex = 12;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(714, 264);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(103, 37);
            this.btnSacuvaj.TabIndex = 8;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // frmMojRasporedIzmjena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.dateDatum);
            this.Controls.Add(this.rtbOpis);
            this.Controls.Add(this.cbVazno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.label1);
            this.Name = "frmMojRasporedIzmjena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMojRasporedIzmjena";
            this.Load += new System.EventHandler(this.frmMojRasporedIzmjena_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOpis;
        private System.Windows.Forms.CheckBox cbVazno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateDatum;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}
﻿namespace StudentskiServis.WinUI.Student
{
    partial class frmPromijeniSifru
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
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPotvrda = new System.Windows.Forms.TextBox();
            this.txtNovaSifra = new System.Windows.Forms.TextBox();
            this.errPassword = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(121, 213);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(92, 33);
            this.btnSacuvaj.TabIndex = 140;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(51, 71);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.PasswordChar = '*';
            this.txtSifra.Size = new System.Drawing.Size(232, 20);
            this.txtSifra.TabIndex = 136;
            this.txtSifra.Validating += new System.ComponentModel.CancelEventHandler(this.txtSifra_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 134;
            this.label5.Text = "Nova šifra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 135;
            this.label7.Text = "Trenutna šifra";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 137;
            this.label8.Text = "Potvrda nove šifre";
            // 
            // txtPotvrda
            // 
            this.txtPotvrda.Location = new System.Drawing.Point(51, 162);
            this.txtPotvrda.Name = "txtPotvrda";
            this.txtPotvrda.PasswordChar = '*';
            this.txtPotvrda.Size = new System.Drawing.Size(232, 20);
            this.txtPotvrda.TabIndex = 138;
            this.txtPotvrda.Validating += new System.ComponentModel.CancelEventHandler(this.txtPotvrda_Validating);
            // 
            // txtNovaSifra
            // 
            this.txtNovaSifra.Location = new System.Drawing.Point(51, 116);
            this.txtNovaSifra.Name = "txtNovaSifra";
            this.txtNovaSifra.PasswordChar = '*';
            this.txtNovaSifra.Size = new System.Drawing.Size(232, 20);
            this.txtNovaSifra.TabIndex = 139;
            this.txtNovaSifra.Validating += new System.ComponentModel.CancelEventHandler(this.txtNovaSifra_Validating);
            // 
            // errPassword
            // 
            this.errPassword.ContainerControl = this;
            // 
            // frmPromijeniSifru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 311);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPotvrda);
            this.Controls.Add(this.txtNovaSifra);
            this.Name = "frmPromijeniSifru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPromijeniSifru";
            ((System.ComponentModel.ISupportInitialize)(this.errPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPotvrda;
        private System.Windows.Forms.TextBox txtNovaSifra;
        private System.Windows.Forms.ErrorProvider errPassword;
    }
}
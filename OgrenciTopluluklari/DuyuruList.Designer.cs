﻿namespace OgrenciTopluluklari
{
    partial class DuyuruList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ocak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nisan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mayıs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haziran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temmuz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agustos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eylul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aralik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ocak,
            this.subat,
            this.mart,
            this.nisan,
            this.mayıs,
            this.haziran,
            this.temmuz,
            this.agustos,
            this.eylul,
            this.ekim,
            this.kasim,
            this.aralik});
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(936, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // ocak
            // 
            this.ocak.HeaderText = "OCAK";
            this.ocak.Name = "ocak";
            // 
            // subat
            // 
            this.subat.HeaderText = "ŞUBAT";
            this.subat.Name = "subat";
            // 
            // mart
            // 
            this.mart.HeaderText = "MART";
            this.mart.Name = "mart";
            // 
            // nisan
            // 
            this.nisan.HeaderText = "NİSAN";
            this.nisan.Name = "nisan";
            // 
            // mayıs
            // 
            this.mayıs.HeaderText = "MAYIS";
            this.mayıs.Name = "mayıs";
            // 
            // haziran
            // 
            this.haziran.HeaderText = "HAZİRAN";
            this.haziran.Name = "haziran";
            // 
            // temmuz
            // 
            this.temmuz.HeaderText = "TEMMUZ";
            this.temmuz.Name = "temmuz";
            // 
            // agustos
            // 
            this.agustos.HeaderText = "AĞUSTOS";
            this.agustos.Name = "agustos";
            // 
            // eylul
            // 
            this.eylul.HeaderText = "EYLÜL";
            this.eylul.Name = "eylul";
            // 
            // ekim
            // 
            this.ekim.HeaderText = "EKİM";
            this.ekim.Name = "ekim";
            // 
            // kasim
            // 
            this.kasim.HeaderText = "KASİM";
            this.kasim.Name = "kasim";
            // 
            // aralik
            // 
            this.aralik.HeaderText = "ARALIK";
            this.aralik.Name = "aralik";
            // 
            // buttonGeri
            // 
            this.buttonGeri.Location = new System.Drawing.Point(138, 351);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(75, 23);
            this.buttonGeri.TabIndex = 1;
            this.buttonGeri.Text = "GERİ";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // DuyuruList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.buttonGeri);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DuyuruList";
            this.Text = "DuyuruList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocak;
        private System.Windows.Forms.DataGridViewTextBoxColumn subat;
        private System.Windows.Forms.DataGridViewTextBoxColumn mart;
        private System.Windows.Forms.DataGridViewTextBoxColumn nisan;
        private System.Windows.Forms.DataGridViewTextBoxColumn mayıs;
        private System.Windows.Forms.DataGridViewTextBoxColumn haziran;
        private System.Windows.Forms.DataGridViewTextBoxColumn temmuz;
        private System.Windows.Forms.DataGridViewTextBoxColumn agustos;
        private System.Windows.Forms.DataGridViewTextBoxColumn eylul;
        private System.Windows.Forms.DataGridViewTextBoxColumn ekim;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasim;
        private System.Windows.Forms.DataGridViewTextBoxColumn aralik;
        private System.Windows.Forms.Button buttonGeri;
    }
}
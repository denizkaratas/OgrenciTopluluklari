namespace OgrenciTopluluklari
{
    partial class UserList
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
            this.kadi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yetk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kadi1,
            this.yetk});
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(241, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // kadi1
            // 
            this.kadi1.HeaderText = "KULLANICI ADI";
            this.kadi1.Name = "kadi1";
            // 
            // yetk
            // 
            this.yetk.HeaderText = "YETKİ";
            this.yetk.Name = "yetk";
            // 
            // UserList
            // 
            this.ClientSize = new System.Drawing.Size(570, 359);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.DataGridViewTextBoxColumn st2;
        private System.Windows.Forms.DataGridViewTextBoxColumn duyuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn top1;
        private System.Windows.Forms.DataGridViewTextBoxColumn etkinlik;
        
        
       
        private System.Windows.Forms.Button buttonGerii;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kadi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yetk;
    }
}
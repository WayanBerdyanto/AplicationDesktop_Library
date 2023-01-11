namespace TugasAkhir
{
    partial class FormCariPetugas
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtidpetugas = new System.Windows.Forms.TextBox();
            this.dgvCariPetugas = new System.Windows.Forms.DataGridView();
            this.id_ptgs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_ptgs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_hp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariPetugas)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 113;
            this.label6.Text = "Cari Petugas";
            // 
            // txtidpetugas
            // 
            this.txtidpetugas.Location = new System.Drawing.Point(197, 86);
            this.txtidpetugas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtidpetugas.Name = "txtidpetugas";
            this.txtidpetugas.Size = new System.Drawing.Size(253, 26);
            this.txtidpetugas.TabIndex = 112;
            this.txtidpetugas.TextChanged += new System.EventHandler(this.txtidpetugas_TextChanged);
            this.txtidpetugas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtidpetugas_KeyDown);
            this.txtidpetugas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtidpetugas_KeyUp);
            // 
            // dgvCariPetugas
            // 
            this.dgvCariPetugas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCariPetugas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_ptgs,
            this.nama_ptgs,
            this.gender,
            this.alamat,
            this.no_hp});
            this.dgvCariPetugas.Location = new System.Drawing.Point(66, 144);
            this.dgvCariPetugas.Name = "dgvCariPetugas";
            this.dgvCariPetugas.RowHeadersWidth = 62;
            this.dgvCariPetugas.RowTemplate.Height = 28;
            this.dgvCariPetugas.Size = new System.Drawing.Size(990, 453);
            this.dgvCariPetugas.TabIndex = 111;
            this.dgvCariPetugas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCariPetugas_KeyDown);
            // 
            // id_ptgs
            // 
            this.id_ptgs.DataPropertyName = "id_ptgs";
            this.id_ptgs.HeaderText = "id_ptgs";
            this.id_ptgs.MinimumWidth = 8;
            this.id_ptgs.Name = "id_ptgs";
            this.id_ptgs.Width = 150;
            // 
            // nama_ptgs
            // 
            this.nama_ptgs.DataPropertyName = "nama_ptgs";
            this.nama_ptgs.HeaderText = "nama_ptgs";
            this.nama_ptgs.MinimumWidth = 8;
            this.nama_ptgs.Name = "nama_ptgs";
            this.nama_ptgs.Width = 150;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "gender";
            this.gender.MinimumWidth = 8;
            this.gender.Name = "gender";
            this.gender.Width = 150;
            // 
            // alamat
            // 
            this.alamat.DataPropertyName = "alamat";
            this.alamat.HeaderText = "alamat";
            this.alamat.MinimumWidth = 8;
            this.alamat.Name = "alamat";
            this.alamat.Width = 150;
            // 
            // no_hp
            // 
            this.no_hp.DataPropertyName = "no_hp";
            this.no_hp.HeaderText = "no_hp";
            this.no_hp.MinimumWidth = 8;
            this.no_hp.Name = "no_hp";
            this.no_hp.Width = 150;
            // 
            // FormCariPetugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 680);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtidpetugas);
            this.Controls.Add(this.dgvCariPetugas);
            this.Name = "FormCariPetugas";
            this.Text = "FormCariPetugas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCariPetugas_FormClosed);
            this.Load += new System.EventHandler(this.FormCariPetugas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariPetugas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtidpetugas;
        private System.Windows.Forms.DataGridView dgvCariPetugas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ptgs;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_ptgs;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_hp;
    }
}
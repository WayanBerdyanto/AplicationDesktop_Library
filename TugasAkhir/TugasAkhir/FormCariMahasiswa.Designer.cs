namespace TugasAkhir
{
    partial class FormCariMahasiswa
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCariMhs = new System.Windows.Forms.TextBox();
            this.dgvMhs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMhs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Nama";
            // 
            // txtCariMhs
            // 
            this.txtCariMhs.Location = new System.Drawing.Point(190, 49);
            this.txtCariMhs.Name = "txtCariMhs";
            this.txtCariMhs.Size = new System.Drawing.Size(763, 26);
            this.txtCariMhs.TabIndex = 1;
            this.txtCariMhs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCariMhs_KeyDown);
            this.txtCariMhs.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCariMhs_KeyUp);
            // 
            // dgvMhs
            // 
            this.dgvMhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMhs.Location = new System.Drawing.Point(96, 113);
            this.dgvMhs.Name = "dgvMhs";
            this.dgvMhs.RowHeadersWidth = 62;
            this.dgvMhs.RowTemplate.Height = 28;
            this.dgvMhs.Size = new System.Drawing.Size(857, 369);
            this.dgvMhs.TabIndex = 2;
            this.dgvMhs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMhs_KeyDown);
            // 
            // FormCariMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 672);
            this.Controls.Add(this.dgvMhs);
            this.Controls.Add(this.txtCariMhs);
            this.Controls.Add(this.label1);
            this.Name = "FormCariMahasiswa";
            this.Text = "FormCariMahasiswa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCariMahasiswa_FormClosed);
            this.Load += new System.EventHandler(this.FormCariMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMhs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCariMhs;
        private System.Windows.Forms.DataGridView dgvMhs;
    }
}
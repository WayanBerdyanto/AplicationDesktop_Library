namespace TugasAkhir
{
    partial class FormFilterPinjam
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
            this.btnCari1 = new System.Windows.Forms.Button();
            this.txtDatePinjam = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCari1
            // 
            this.btnCari1.Location = new System.Drawing.Point(603, 205);
            this.btnCari1.Name = "btnCari1";
            this.btnCari1.Size = new System.Drawing.Size(123, 40);
            this.btnCari1.TabIndex = 12;
            this.btnCari1.Text = "Cari";
            this.btnCari1.UseVisualStyleBackColor = true;
            this.btnCari1.Click += new System.EventHandler(this.btnCari1_Click);
            // 
            // txtDatePinjam
            // 
            this.txtDatePinjam.Location = new System.Drawing.Point(206, 210);
            this.txtDatePinjam.Name = "txtDatePinjam";
            this.txtDatePinjam.Size = new System.Drawing.Size(391, 26);
            this.txtDatePinjam.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tanggal Pinjam";
            // 
            // FormFilterPinjam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCari1);
            this.Controls.Add(this.txtDatePinjam);
            this.Controls.Add(this.label1);
            this.Name = "FormFilterPinjam";
            this.Text = "FormFilterPinjam";
            this.Load += new System.EventHandler(this.FormFilterPinjam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCari1;
        private System.Windows.Forms.DateTimePicker txtDatePinjam;
        private System.Windows.Forms.Label label1;
    }
}
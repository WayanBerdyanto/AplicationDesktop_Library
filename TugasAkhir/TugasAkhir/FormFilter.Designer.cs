namespace TugasAkhir
{
    partial class FormFilter
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnCari2 = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tanggal Kembali";
            // 
            // btnCari2
            // 
            this.btnCari2.Location = new System.Drawing.Point(671, 211);
            this.btnCari2.Name = "btnCari2";
            this.btnCari2.Size = new System.Drawing.Size(123, 40);
            this.btnCari2.TabIndex = 6;
            this.btnCari2.Text = "Cari";
            this.btnCari2.UseVisualStyleBackColor = true;
            this.btnCari2.Click += new System.EventHandler(this.btnCari2_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(274, 216);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(391, 26);
            this.txtDate.TabIndex = 7;
            // 
            // FormFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 631);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnCari2);
            this.Controls.Add(this.label2);
            this.Name = "FormFilter";
            this.Text = "FormFilter";
            this.Load += new System.EventHandler(this.FormFilter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCari2;
        private System.Windows.Forms.DateTimePicker txtDate;
    }
}
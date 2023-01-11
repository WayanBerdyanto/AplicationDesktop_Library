namespace TugasAkhir
{
    partial class FormFilterBuku
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
            this.btnCari3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCari3
            // 
            this.btnCari3.Location = new System.Drawing.Point(603, 205);
            this.btnCari3.Name = "btnCari3";
            this.btnCari3.Size = new System.Drawing.Size(123, 40);
            this.btnCari3.TabIndex = 13;
            this.btnCari3.Text = "Cari";
            this.btnCari3.UseVisualStyleBackColor = true;
            this.btnCari3.Click += new System.EventHandler(this.btnCari3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(207, 212);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(390, 26);
            this.textBox3.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cari Judul Buku";
            // 
            // FormFilterBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCari3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Name = "FormFilterBuku";
            this.Text = "FormFilterBuku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCari3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}
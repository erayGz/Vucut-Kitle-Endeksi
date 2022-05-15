namespace BoyKiloEndeksi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbBoy = new System.Windows.Forms.TextBox();
            this.tbKilo = new System.Windows.Forms.TextBox();
            this.lblBoy = new System.Windows.Forms.Label();
            this.lblKilo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBoy
            // 
            this.tbBoy.Location = new System.Drawing.Point(271, 91);
            this.tbBoy.Multiline = true;
            this.tbBoy.Name = "tbBoy";
            this.tbBoy.Size = new System.Drawing.Size(196, 34);
            this.tbBoy.TabIndex = 0;
            this.tbBoy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sadeceSayiGirme);
            // 
            // tbKilo
            // 
            this.tbKilo.Location = new System.Drawing.Point(271, 135);
            this.tbKilo.Multiline = true;
            this.tbKilo.Name = "tbKilo";
            this.tbKilo.Size = new System.Drawing.Size(196, 34);
            this.tbKilo.TabIndex = 1;
            this.tbKilo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sadeceSayiGirme);
            // 
            // lblBoy
            // 
            this.lblBoy.AutoSize = true;
            this.lblBoy.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBoy.Location = new System.Drawing.Point(92, 94);
            this.lblBoy.Name = "lblBoy";
            this.lblBoy.Size = new System.Drawing.Size(159, 31);
            this.lblBoy.TabIndex = 2;
            this.lblBoy.Text = "BOYUNUZ (M)";
            // 
            // lblKilo
            // 
            this.lblKilo.AutoSize = true;
            this.lblKilo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKilo.Location = new System.Drawing.Point(92, 138);
            this.lblKilo.Name = "lblKilo";
            this.lblKilo.Size = new System.Drawing.Size(154, 31);
            this.lblKilo.TabIndex = 3;
            this.lblKilo.Text = "KİLONUZ (KG)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(152, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 45);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vücut Kitle Endeksi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(439, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 38);
            this.label4.TabIndex = 5;
            this.label4.Text = "ERAY GÜRBÜZ";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSonuc.Location = new System.Drawing.Point(45, 241);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(110, 38);
            this.lblSonuc.TabIndex = 6;
            this.lblSonuc.Text = "SONUÇ";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHesapla.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHesapla.Location = new System.Drawing.Point(346, 188);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(121, 50);
            this.btnHesapla.TabIndex = 7;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(651, 339);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKilo);
            this.Controls.Add(this.lblBoy);
            this.Controls.Add(this.tbKilo);
            this.Controls.Add(this.tbBoy);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbBoy;
        private TextBox tbKilo;
        private Label lblBoy;
        private Label lblKilo;
        private Label label3;
        private Label label4;
        private Label lblSonuc;
        private Button btnHesapla;
    }
}
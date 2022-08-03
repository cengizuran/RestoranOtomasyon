namespace RestoranOtomasyon
{
    partial class Form1
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
            this.cmbAnaYemek = new System.Windows.Forms.ComboBox();
            this.cmbAraSicak = new System.Windows.Forms.ComboBox();
            this.cmbIcecek = new System.Windows.Forms.ComboBox();
            this.cmbTatli = new System.Windows.Forms.ComboBox();
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.lblMasa = new System.Windows.Forms.Label();
            this.lblAnaYemek = new System.Windows.Forms.Label();
            this.lblArasSicak = new System.Windows.Forms.Label();
            this.lbl_Icecek = new System.Windows.Forms.Label();
            this.lblTatli = new System.Windows.Forms.Label();
            this.lstSiparis = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCiro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbAnaYemek
            // 
            this.cmbAnaYemek.FormattingEnabled = true;
            this.cmbAnaYemek.Location = new System.Drawing.Point(98, 42);
            this.cmbAnaYemek.Name = "cmbAnaYemek";
            this.cmbAnaYemek.Size = new System.Drawing.Size(273, 24);
            this.cmbAnaYemek.TabIndex = 0;
            // 
            // cmbAraSicak
            // 
            this.cmbAraSicak.FormattingEnabled = true;
            this.cmbAraSicak.Location = new System.Drawing.Point(98, 72);
            this.cmbAraSicak.Name = "cmbAraSicak";
            this.cmbAraSicak.Size = new System.Drawing.Size(273, 24);
            this.cmbAraSicak.TabIndex = 0;
            // 
            // cmbIcecek
            // 
            this.cmbIcecek.FormattingEnabled = true;
            this.cmbIcecek.Location = new System.Drawing.Point(98, 102);
            this.cmbIcecek.Name = "cmbIcecek";
            this.cmbIcecek.Size = new System.Drawing.Size(273, 24);
            this.cmbIcecek.TabIndex = 0;
            // 
            // cmbTatli
            // 
            this.cmbTatli.FormattingEnabled = true;
            this.cmbTatli.Location = new System.Drawing.Point(98, 132);
            this.cmbTatli.Name = "cmbTatli";
            this.cmbTatli.Size = new System.Drawing.Size(273, 24);
            this.cmbTatli.TabIndex = 0;
            // 
            // txtMasa
            // 
            this.txtMasa.Location = new System.Drawing.Point(99, 14);
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.Size = new System.Drawing.Size(272, 22);
            this.txtMasa.TabIndex = 1;
            // 
            // lblMasa
            // 
            this.lblMasa.AutoSize = true;
            this.lblMasa.Location = new System.Drawing.Point(49, 20);
            this.lblMasa.Name = "lblMasa";
            this.lblMasa.Size = new System.Drawing.Size(41, 16);
            this.lblMasa.TabIndex = 2;
            this.lblMasa.Text = "Masa";
            // 
            // lblAnaYemek
            // 
            this.lblAnaYemek.AutoSize = true;
            this.lblAnaYemek.Location = new System.Drawing.Point(13, 50);
            this.lblAnaYemek.Name = "lblAnaYemek";
            this.lblAnaYemek.Size = new System.Drawing.Size(77, 16);
            this.lblAnaYemek.TabIndex = 3;
            this.lblAnaYemek.Text = "Ana Yemek";
            // 
            // lblArasSicak
            // 
            this.lblArasSicak.AutoSize = true;
            this.lblArasSicak.Location = new System.Drawing.Point(25, 80);
            this.lblArasSicak.Name = "lblArasSicak";
            this.lblArasSicak.Size = new System.Drawing.Size(65, 16);
            this.lblArasSicak.TabIndex = 3;
            this.lblArasSicak.Text = "Ara Sıcak";
            // 
            // lbl_Icecek
            // 
            this.lbl_Icecek.AutoSize = true;
            this.lbl_Icecek.Location = new System.Drawing.Point(43, 110);
            this.lbl_Icecek.Name = "lbl_Icecek";
            this.lbl_Icecek.Size = new System.Drawing.Size(47, 16);
            this.lbl_Icecek.TabIndex = 3;
            this.lbl_Icecek.Text = "İçecek";
            // 
            // lblTatli
            // 
            this.lblTatli.AutoSize = true;
            this.lblTatli.Location = new System.Drawing.Point(57, 140);
            this.lblTatli.Name = "lblTatli";
            this.lblTatli.Size = new System.Drawing.Size(33, 16);
            this.lblTatli.TabIndex = 3;
            this.lblTatli.Text = "Tatlı";
            // 
            // lstSiparis
            // 
            this.lstSiparis.FormattingEnabled = true;
            this.lstSiparis.ItemHeight = 16;
            this.lstSiparis.Location = new System.Drawing.Point(377, 14);
            this.lstSiparis.Name = "lstSiparis";
            this.lstSiparis.Size = new System.Drawing.Size(797, 372);
            this.lstSiparis.TabIndex = 6;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(99, 162);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(272, 101);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Sipariş Gir";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCiro
            // 
            this.btnCiro.Location = new System.Drawing.Point(99, 281);
            this.btnCiro.Name = "btnCiro";
            this.btnCiro.Size = new System.Drawing.Size(272, 105);
            this.btnCiro.TabIndex = 7;
            this.btnCiro.Text = "Ciro Hesapla";
            this.btnCiro.UseVisualStyleBackColor = true;
            this.btnCiro.Click += new System.EventHandler(this.btnCiro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 450);
            this.Controls.Add(this.btnCiro);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstSiparis);
            this.Controls.Add(this.lblTatli);
            this.Controls.Add(this.lbl_Icecek);
            this.Controls.Add(this.lblArasSicak);
            this.Controls.Add(this.lblAnaYemek);
            this.Controls.Add(this.lblMasa);
            this.Controls.Add(this.txtMasa);
            this.Controls.Add(this.cmbTatli);
            this.Controls.Add(this.cmbIcecek);
            this.Controls.Add(this.cmbAraSicak);
            this.Controls.Add(this.cmbAnaYemek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAnaYemek;
        private System.Windows.Forms.ComboBox cmbAraSicak;
        private System.Windows.Forms.ComboBox cmbIcecek;
        private System.Windows.Forms.ComboBox cmbTatli;
        private System.Windows.Forms.TextBox txtMasa;
        private System.Windows.Forms.Label lblMasa;
        private System.Windows.Forms.Label lblAnaYemek;
        private System.Windows.Forms.Label lblArasSicak;
        private System.Windows.Forms.Label lbl_Icecek;
        private System.Windows.Forms.Label lblTatli;
        private System.Windows.Forms.ListBox lstSiparis;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCiro;
    }
}


namespace SifreUretici
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
            this.gbParametreler = new System.Windows.Forms.GroupBox();
            this.gbSifreler = new System.Windows.Forms.GroupBox();
            this.cbKucukHarf = new System.Windows.Forms.CheckBox();
            this.cbBuyukHarf = new System.Windows.Forms.CheckBox();
            this.cbRakam = new System.Windows.Forms.CheckBox();
            this.cbOzelKarakter = new System.Windows.Forms.CheckBox();
            this.tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblSifreSayisi = new System.Windows.Forms.Label();
            this.lblSifreUzunlugu = new System.Windows.Forms.Label();
            this.nudSifreSayisi = new System.Windows.Forms.NumericUpDown();
            this.nudSifreUzunlugu = new System.Windows.Forms.NumericUpDown();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.txtUretilenSifreler = new System.Windows.Forms.RichTextBox();
            this.btnUret = new System.Windows.Forms.Button();
            this.gbParametreler.SuspendLayout();
            this.gbSifreler.SuspendLayout();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreUzunlugu)).BeginInit();
            this.SuspendLayout();
            // 
            // gbParametreler
            // 
            this.gbParametreler.Controls.Add(this.tablePanel);
            this.gbParametreler.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbParametreler.Location = new System.Drawing.Point(0, 0);
            this.gbParametreler.Name = "gbParametreler";
            this.gbParametreler.Size = new System.Drawing.Size(333, 486);
            this.gbParametreler.TabIndex = 0;
            this.gbParametreler.TabStop = false;
            this.gbParametreler.Text = "Parametreler";
            // 
            // gbSifreler
            // 
            this.gbSifreler.Controls.Add(this.txtUretilenSifreler);
            this.gbSifreler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSifreler.Location = new System.Drawing.Point(333, 0);
            this.gbSifreler.Name = "gbSifreler";
            this.gbSifreler.Size = new System.Drawing.Size(647, 486);
            this.gbSifreler.TabIndex = 0;
            this.gbSifreler.TabStop = false;
            this.gbSifreler.Text = "Üretilen Şifreler";
            // 
            // cbKucukHarf
            // 
            this.cbKucukHarf.AutoSize = true;
            this.cbKucukHarf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbKucukHarf.Location = new System.Drawing.Point(3, 3);
            this.cbKucukHarf.Name = "cbKucukHarf";
            this.cbKucukHarf.Size = new System.Drawing.Size(147, 25);
            this.cbKucukHarf.TabIndex = 0;
            this.cbKucukHarf.Text = "Küçük Harf";
            this.cbKucukHarf.UseVisualStyleBackColor = true;
            // 
            // cbBuyukHarf
            // 
            this.cbBuyukHarf.AutoSize = true;
            this.cbBuyukHarf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBuyukHarf.Location = new System.Drawing.Point(3, 34);
            this.cbBuyukHarf.Name = "cbBuyukHarf";
            this.cbBuyukHarf.Size = new System.Drawing.Size(147, 25);
            this.cbBuyukHarf.TabIndex = 1;
            this.cbBuyukHarf.Text = "Büyük Harf";
            this.cbBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // cbRakam
            // 
            this.cbRakam.AutoSize = true;
            this.cbRakam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbRakam.Location = new System.Drawing.Point(3, 65);
            this.cbRakam.Name = "cbRakam";
            this.cbRakam.Size = new System.Drawing.Size(147, 25);
            this.cbRakam.TabIndex = 2;
            this.cbRakam.Text = "Rakam";
            this.cbRakam.UseVisualStyleBackColor = true;
            // 
            // cbOzelKarakter
            // 
            this.cbOzelKarakter.AutoSize = true;
            this.cbOzelKarakter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbOzelKarakter.Location = new System.Drawing.Point(3, 96);
            this.cbOzelKarakter.Name = "cbOzelKarakter";
            this.cbOzelKarakter.Size = new System.Drawing.Size(147, 25);
            this.cbOzelKarakter.TabIndex = 3;
            this.cbOzelKarakter.Text = "Özel Karakter";
            this.cbOzelKarakter.UseVisualStyleBackColor = true;
            // 
            // tablePanel
            // 
            this.tablePanel.ColumnCount = 2;
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanel.Controls.Add(this.cbKucukHarf, 0, 0);
            this.tablePanel.Controls.Add(this.cbOzelKarakter, 0, 3);
            this.tablePanel.Controls.Add(this.cbBuyukHarf, 0, 1);
            this.tablePanel.Controls.Add(this.cbRakam, 0, 2);
            this.tablePanel.Controls.Add(this.lblSifreSayisi, 0, 5);
            this.tablePanel.Controls.Add(this.lblSifreUzunlugu, 0, 6);
            this.tablePanel.Controls.Add(this.nudSifreSayisi, 1, 5);
            this.tablePanel.Controls.Add(this.nudSifreUzunlugu, 1, 6);
            this.tablePanel.Controls.Add(this.btnUret, 1, 7);
            this.tablePanel.Controls.Add(this.btnSifirla, 0, 7);
            this.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel.Location = new System.Drawing.Point(3, 25);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.RowCount = 8;
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanel.Size = new System.Drawing.Size(327, 458);
            this.tablePanel.TabIndex = 4;
            // 
            // lblSifreSayisi
            // 
            this.lblSifreSayisi.AutoSize = true;
            this.lblSifreSayisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSifreSayisi.Location = new System.Drawing.Point(3, 124);
            this.lblSifreSayisi.Name = "lblSifreSayisi";
            this.lblSifreSayisi.Size = new System.Drawing.Size(147, 26);
            this.lblSifreSayisi.TabIndex = 4;
            this.lblSifreSayisi.Text = "Şifre Sayısı: ";
            // 
            // lblSifreUzunlugu
            // 
            this.lblSifreUzunlugu.AutoSize = true;
            this.lblSifreUzunlugu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSifreUzunlugu.Location = new System.Drawing.Point(3, 150);
            this.lblSifreUzunlugu.Name = "lblSifreUzunlugu";
            this.lblSifreUzunlugu.Size = new System.Drawing.Size(147, 35);
            this.lblSifreUzunlugu.TabIndex = 5;
            this.lblSifreUzunlugu.Text = "Şifre Uzunluğu:";
            // 
            // nudSifreSayisi
            // 
            this.nudSifreSayisi.Location = new System.Drawing.Point(156, 127);
            this.nudSifreSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSifreSayisi.Name = "nudSifreSayisi";
            this.nudSifreSayisi.Size = new System.Drawing.Size(120, 29);
            this.nudSifreSayisi.TabIndex = 6;
            this.nudSifreSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudSifreUzunlugu
            // 
            this.nudSifreUzunlugu.Location = new System.Drawing.Point(156, 153);
            this.nudSifreUzunlugu.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudSifreUzunlugu.Name = "nudSifreUzunlugu";
            this.nudSifreUzunlugu.Size = new System.Drawing.Size(120, 29);
            this.nudSifreUzunlugu.TabIndex = 7;
            this.nudSifreUzunlugu.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // btnSifirla
            // 
            this.btnSifirla.Location = new System.Drawing.Point(3, 188);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(147, 60);
            this.btnSifirla.TabIndex = 8;
            this.btnSifirla.Text = "SIFIRLA";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // txtUretilenSifreler
            // 
            this.txtUretilenSifreler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUretilenSifreler.Location = new System.Drawing.Point(3, 25);
            this.txtUretilenSifreler.Name = "txtUretilenSifreler";
            this.txtUretilenSifreler.ReadOnly = true;
            this.txtUretilenSifreler.Size = new System.Drawing.Size(641, 458);
            this.txtUretilenSifreler.TabIndex = 0;
            this.txtUretilenSifreler.Text = "";
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(156, 188);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(147, 60);
            this.btnUret.TabIndex = 9;
            this.btnUret.Text = "ÜRET";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 486);
            this.Controls.Add(this.gbSifreler);
            this.Controls.Add(this.gbParametreler);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Üretici";
            this.gbParametreler.ResumeLayout(false);
            this.gbSifreler.ResumeLayout(false);
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreUzunlugu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbParametreler;
        private System.Windows.Forms.GroupBox gbSifreler;
        private System.Windows.Forms.TableLayoutPanel tablePanel;
        private System.Windows.Forms.CheckBox cbKucukHarf;
        private System.Windows.Forms.CheckBox cbOzelKarakter;
        private System.Windows.Forms.CheckBox cbBuyukHarf;
        private System.Windows.Forms.CheckBox cbRakam;
        private System.Windows.Forms.Label lblSifreSayisi;
        private System.Windows.Forms.Label lblSifreUzunlugu;
        private System.Windows.Forms.NumericUpDown nudSifreSayisi;
        private System.Windows.Forms.NumericUpDown nudSifreUzunlugu;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.RichTextBox txtUretilenSifreler;
        private System.Windows.Forms.Button btnUret;
    }
}


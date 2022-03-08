namespace Domenik_Milohanic_PPZ02
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
            this.RTBispis = new System.Windows.Forms.RichTextBox();
            this.BTNunos = new System.Windows.Forms.Button();
            this.RDBgazirana = new System.Windows.Forms.RadioButton();
            this.TXTnaziv = new System.Windows.Forms.TextBox();
            this.LBLnaziv = new System.Windows.Forms.Label();
            this.LBLkolicina = new System.Windows.Forms.Label();
            this.CMBkolicina = new System.Windows.Forms.ComboBox();
            this.LBLpakiranje = new System.Windows.Forms.Label();
            this.CMBpakiranje = new System.Windows.Forms.ComboBox();
            this.TRBalkohol = new System.Windows.Forms.TrackBar();
            this.LBLalkohol = new System.Windows.Forms.Label();
            this.LBLcijena = new System.Windows.Forms.Label();
            this.TXTcijena = new System.Windows.Forms.TextBox();
            this.BTNispis = new System.Windows.Forms.Button();
            this.RDBnegazirana = new System.Windows.Forms.RadioButton();
            this.RDBalkoholna = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.TRBalkohol)).BeginInit();
            this.SuspendLayout();
            // 
            // RTBispis
            // 
            this.RTBispis.Location = new System.Drawing.Point(224, 61);
            this.RTBispis.Name = "RTBispis";
            this.RTBispis.Size = new System.Drawing.Size(419, 317);
            this.RTBispis.TabIndex = 0;
            this.RTBispis.Text = "";
            // 
            // BTNunos
            // 
            this.BTNunos.Location = new System.Drawing.Point(708, 123);
            this.BTNunos.Name = "BTNunos";
            this.BTNunos.Size = new System.Drawing.Size(129, 51);
            this.BTNunos.TabIndex = 1;
            this.BTNunos.Text = "Unos";
            this.BTNunos.UseVisualStyleBackColor = true;
            this.BTNunos.Click += new System.EventHandler(this.BTNunos_Click);
            // 
            // RDBgazirana
            // 
            this.RDBgazirana.AutoSize = true;
            this.RDBgazirana.Location = new System.Drawing.Point(27, 61);
            this.RDBgazirana.Name = "RDBgazirana";
            this.RDBgazirana.Size = new System.Drawing.Size(67, 17);
            this.RDBgazirana.TabIndex = 2;
            this.RDBgazirana.TabStop = true;
            this.RDBgazirana.Text = "Gazirana";
            this.RDBgazirana.UseVisualStyleBackColor = true;
            // 
            // TXTnaziv
            // 
            this.TXTnaziv.Location = new System.Drawing.Point(27, 203);
            this.TXTnaziv.Name = "TXTnaziv";
            this.TXTnaziv.Size = new System.Drawing.Size(130, 20);
            this.TXTnaziv.TabIndex = 3;
            // 
            // LBLnaziv
            // 
            this.LBLnaziv.AutoSize = true;
            this.LBLnaziv.Location = new System.Drawing.Point(27, 187);
            this.LBLnaziv.Name = "LBLnaziv";
            this.LBLnaziv.Size = new System.Drawing.Size(37, 13);
            this.LBLnaziv.TabIndex = 4;
            this.LBLnaziv.Text = "Naziv:";
            // 
            // LBLkolicina
            // 
            this.LBLkolicina.AutoSize = true;
            this.LBLkolicina.Location = new System.Drawing.Point(27, 263);
            this.LBLkolicina.Name = "LBLkolicina";
            this.LBLkolicina.Size = new System.Drawing.Size(47, 13);
            this.LBLkolicina.TabIndex = 5;
            this.LBLkolicina.Text = "Količina:";
            // 
            // CMBkolicina
            // 
            this.CMBkolicina.FormattingEnabled = true;
            this.CMBkolicina.Items.AddRange(new object[] {
            "0.5L",
            "1L",
            "1.5L",
            "2L"});
            this.CMBkolicina.Location = new System.Drawing.Point(27, 279);
            this.CMBkolicina.Name = "CMBkolicina";
            this.CMBkolicina.Size = new System.Drawing.Size(130, 21);
            this.CMBkolicina.TabIndex = 6;
            // 
            // LBLpakiranje
            // 
            this.LBLpakiranje.AutoSize = true;
            this.LBLpakiranje.Location = new System.Drawing.Point(27, 341);
            this.LBLpakiranje.Name = "LBLpakiranje";
            this.LBLpakiranje.Size = new System.Drawing.Size(54, 13);
            this.LBLpakiranje.TabIndex = 7;
            this.LBLpakiranje.Text = "Pakiranje:";
            // 
            // CMBpakiranje
            // 
            this.CMBpakiranje.FormattingEnabled = true;
            this.CMBpakiranje.Items.AddRange(new object[] {
            "Staklo",
            "PET",
            "Tetrapak"});
            this.CMBpakiranje.Location = new System.Drawing.Point(27, 357);
            this.CMBpakiranje.Name = "CMBpakiranje";
            this.CMBpakiranje.Size = new System.Drawing.Size(130, 21);
            this.CMBpakiranje.TabIndex = 8;
            // 
            // TRBalkohol
            // 
            this.TRBalkohol.Location = new System.Drawing.Point(325, 438);
            this.TRBalkohol.Maximum = 50;
            this.TRBalkohol.Name = "TRBalkohol";
            this.TRBalkohol.Size = new System.Drawing.Size(220, 45);
            this.TRBalkohol.TabIndex = 9;
            // 
            // LBLalkohol
            // 
            this.LBLalkohol.AutoSize = true;
            this.LBLalkohol.Location = new System.Drawing.Point(415, 422);
            this.LBLalkohol.Name = "LBLalkohol";
            this.LBLalkohol.Size = new System.Drawing.Size(45, 13);
            this.LBLalkohol.TabIndex = 10;
            this.LBLalkohol.Text = "Alkohol:";
            // 
            // LBLcijena
            // 
            this.LBLcijena.AutoSize = true;
            this.LBLcijena.Location = new System.Drawing.Point(27, 406);
            this.LBLcijena.Name = "LBLcijena";
            this.LBLcijena.Size = new System.Drawing.Size(39, 13);
            this.LBLcijena.TabIndex = 11;
            this.LBLcijena.Text = "Cijena:";
            // 
            // TXTcijena
            // 
            this.TXTcijena.Location = new System.Drawing.Point(27, 422);
            this.TXTcijena.Name = "TXTcijena";
            this.TXTcijena.Size = new System.Drawing.Size(130, 20);
            this.TXTcijena.TabIndex = 12;
            // 
            // BTNispis
            // 
            this.BTNispis.Location = new System.Drawing.Point(708, 242);
            this.BTNispis.Name = "BTNispis";
            this.BTNispis.Size = new System.Drawing.Size(129, 58);
            this.BTNispis.TabIndex = 13;
            this.BTNispis.Text = "Ispis:";
            this.BTNispis.UseVisualStyleBackColor = true;
            this.BTNispis.Click += new System.EventHandler(this.BTNispis_Click);
            // 
            // RDBnegazirana
            // 
            this.RDBnegazirana.AutoSize = true;
            this.RDBnegazirana.Location = new System.Drawing.Point(27, 100);
            this.RDBnegazirana.Name = "RDBnegazirana";
            this.RDBnegazirana.Size = new System.Drawing.Size(79, 17);
            this.RDBnegazirana.TabIndex = 14;
            this.RDBnegazirana.TabStop = true;
            this.RDBnegazirana.Text = "Negazirana";
            this.RDBnegazirana.UseVisualStyleBackColor = true;
            // 
            // RDBalkoholna
            // 
            this.RDBalkoholna.AutoSize = true;
            this.RDBalkoholna.Location = new System.Drawing.Point(27, 140);
            this.RDBalkoholna.Name = "RDBalkoholna";
            this.RDBalkoholna.Size = new System.Drawing.Size(72, 17);
            this.RDBalkoholna.TabIndex = 15;
            this.RDBalkoholna.TabStop = true;
            this.RDBalkoholna.Text = "Alkoholna";
            this.RDBalkoholna.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 519);
            this.Controls.Add(this.RDBalkoholna);
            this.Controls.Add(this.RDBnegazirana);
            this.Controls.Add(this.BTNispis);
            this.Controls.Add(this.TXTcijena);
            this.Controls.Add(this.LBLcijena);
            this.Controls.Add(this.LBLalkohol);
            this.Controls.Add(this.TRBalkohol);
            this.Controls.Add(this.CMBpakiranje);
            this.Controls.Add(this.LBLpakiranje);
            this.Controls.Add(this.CMBkolicina);
            this.Controls.Add(this.LBLkolicina);
            this.Controls.Add(this.LBLnaziv);
            this.Controls.Add(this.TXTnaziv);
            this.Controls.Add(this.RDBgazirana);
            this.Controls.Add(this.BTNunos);
            this.Controls.Add(this.RTBispis);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TRBalkohol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBispis;
        private System.Windows.Forms.Button BTNunos;
        private System.Windows.Forms.RadioButton RDBgazirana;
        private System.Windows.Forms.TextBox TXTnaziv;
        private System.Windows.Forms.Label LBLnaziv;
        private System.Windows.Forms.Label LBLkolicina;
        private System.Windows.Forms.ComboBox CMBkolicina;
        private System.Windows.Forms.Label LBLpakiranje;
        private System.Windows.Forms.ComboBox CMBpakiranje;
        private System.Windows.Forms.TrackBar TRBalkohol;
        private System.Windows.Forms.Label LBLalkohol;
        private System.Windows.Forms.Label LBLcijena;
        private System.Windows.Forms.TextBox TXTcijena;
        private System.Windows.Forms.Button BTNispis;
        private System.Windows.Forms.RadioButton RDBnegazirana;
        private System.Windows.Forms.RadioButton RDBalkoholna;
    }
}


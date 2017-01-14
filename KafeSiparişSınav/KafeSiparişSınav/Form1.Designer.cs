namespace KafeSiparişSınav
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
            this.masalarGbox = new System.Windows.Forms.GroupBox();
            this.siparisGbox = new System.Windows.Forms.GroupBox();
            this.iceceknumdown = new System.Windows.Forms.NumericUpDown();
            this.yemeknumupdown = new System.Windows.Forms.NumericUpDown();
            this.icecekCbox = new System.Windows.Forms.ComboBox();
            this.yemekCbox = new System.Windows.Forms.ComboBox();
            this.siparisBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelmasa = new System.Windows.Forms.Label();
            this.masanonumber = new System.Windows.Forms.Label();
            this.tlRBtn = new System.Windows.Forms.RadioButton();
            this.dolarRBtn = new System.Windows.Forms.RadioButton();
            this.euroRBtn = new System.Windows.Forms.RadioButton();
            this.odeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.siparisGbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iceceknumdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemeknumupdown)).BeginInit();
            this.SuspendLayout();
            // 
            // masalarGbox
            // 
            this.masalarGbox.Location = new System.Drawing.Point(13, 28);
            this.masalarGbox.Name = "masalarGbox";
            this.masalarGbox.Size = new System.Drawing.Size(361, 200);
            this.masalarGbox.TabIndex = 0;
            this.masalarGbox.TabStop = false;
            this.masalarGbox.Text = "Masalar";
            // 
            // siparisGbox
            // 
            this.siparisGbox.Controls.Add(this.iceceknumdown);
            this.siparisGbox.Controls.Add(this.yemeknumupdown);
            this.siparisGbox.Controls.Add(this.icecekCbox);
            this.siparisGbox.Controls.Add(this.yemekCbox);
            this.siparisGbox.Controls.Add(this.siparisBtn);
            this.siparisGbox.Location = new System.Drawing.Point(13, 252);
            this.siparisGbox.Name = "siparisGbox";
            this.siparisGbox.Size = new System.Drawing.Size(295, 163);
            this.siparisGbox.TabIndex = 1;
            this.siparisGbox.TabStop = false;
            this.siparisGbox.Text = "Sipariş";
            // 
            // iceceknumdown
            // 
            this.iceceknumdown.Location = new System.Drawing.Point(144, 48);
            this.iceceknumdown.Name = "iceceknumdown";
            this.iceceknumdown.Size = new System.Drawing.Size(120, 20);
            this.iceceknumdown.TabIndex = 4;
            // 
            // yemeknumupdown
            // 
            this.yemeknumupdown.Location = new System.Drawing.Point(144, 19);
            this.yemeknumupdown.Name = "yemeknumupdown";
            this.yemeknumupdown.Size = new System.Drawing.Size(120, 20);
            this.yemeknumupdown.TabIndex = 3;
            // 
            // icecekCbox
            // 
            this.icecekCbox.FormattingEnabled = true;
            this.icecekCbox.Items.AddRange(new object[] {
            "Cola ",
            "Fanta ",
            "Çay ",
            "Su "});
            this.icecekCbox.Location = new System.Drawing.Point(7, 47);
            this.icecekCbox.Name = "icecekCbox";
            this.icecekCbox.Size = new System.Drawing.Size(121, 21);
            this.icecekCbox.TabIndex = 2;
            this.icecekCbox.Text = "İçecek";
            // 
            // yemekCbox
            // 
            this.yemekCbox.FormattingEnabled = true;
            this.yemekCbox.Items.AddRange(new object[] {
            "Kuru Fasulye ",
            "Tavuklu Pilav ",
            "Pizza",
            "Hamburger",
            "Tost"});
            this.yemekCbox.Location = new System.Drawing.Point(6, 19);
            this.yemekCbox.Name = "yemekCbox";
            this.yemekCbox.Size = new System.Drawing.Size(121, 21);
            this.yemekCbox.TabIndex = 1;
            this.yemekCbox.Text = "Yemek";
            // 
            // siparisBtn
            // 
            this.siparisBtn.Location = new System.Drawing.Point(7, 88);
            this.siparisBtn.Name = "siparisBtn";
            this.siparisBtn.Size = new System.Drawing.Size(257, 45);
            this.siparisBtn.TabIndex = 0;
            this.siparisBtn.Text = "Sipariş Ver";
            this.siparisBtn.UseVisualStyleBackColor = true;
            this.siparisBtn.Click += new System.EventHandler(this.siparisBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(447, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(297, 446);
            this.listBox1.TabIndex = 2;
            // 
            // labelmasa
            // 
            this.labelmasa.AutoSize = true;
            this.labelmasa.Location = new System.Drawing.Point(444, 13);
            this.labelmasa.Name = "labelmasa";
            this.labelmasa.Size = new System.Drawing.Size(50, 13);
            this.labelmasa.TabIndex = 3;
            this.labelmasa.Text = "Masa No";
            // 
            // masanonumber
            // 
            this.masanonumber.AutoSize = true;
            this.masanonumber.Location = new System.Drawing.Point(501, 12);
            this.masanonumber.Name = "masanonumber";
            this.masanonumber.Size = new System.Drawing.Size(79, 13);
            this.masanonumber.TabIndex = 4;
            this.masanonumber.Text = "masanonumber";
            // 
            // tlRBtn
            // 
            this.tlRBtn.AutoSize = true;
            this.tlRBtn.Location = new System.Drawing.Point(479, 502);
            this.tlRBtn.Name = "tlRBtn";
            this.tlRBtn.Size = new System.Drawing.Size(31, 17);
            this.tlRBtn.TabIndex = 5;
            this.tlRBtn.TabStop = true;
            this.tlRBtn.Text = "₺";
            this.tlRBtn.UseVisualStyleBackColor = true;
            // 
            // dolarRBtn
            // 
            this.dolarRBtn.AutoSize = true;
            this.dolarRBtn.Location = new System.Drawing.Point(580, 502);
            this.dolarRBtn.Name = "dolarRBtn";
            this.dolarRBtn.Size = new System.Drawing.Size(31, 17);
            this.dolarRBtn.TabIndex = 6;
            this.dolarRBtn.TabStop = true;
            this.dolarRBtn.Text = "$";
            this.dolarRBtn.UseVisualStyleBackColor = true;
            // 
            // euroRBtn
            // 
            this.euroRBtn.AutoSize = true;
            this.euroRBtn.Location = new System.Drawing.Point(671, 502);
            this.euroRBtn.Name = "euroRBtn";
            this.euroRBtn.Size = new System.Drawing.Size(31, 17);
            this.euroRBtn.TabIndex = 7;
            this.euroRBtn.TabStop = true;
            this.euroRBtn.Text = "£";
            this.euroRBtn.UseVisualStyleBackColor = true;
            // 
            // odeBtn
            // 
            this.odeBtn.Location = new System.Drawing.Point(479, 525);
            this.odeBtn.Name = "odeBtn";
            this.odeBtn.Size = new System.Drawing.Size(248, 23);
            this.odeBtn.TabIndex = 8;
            this.odeBtn.Text = "ÖDE";
            this.odeBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(780, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(783, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dolar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(783, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Euro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(834, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(834, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(834, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 631);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odeBtn);
            this.Controls.Add(this.euroRBtn);
            this.Controls.Add(this.dolarRBtn);
            this.Controls.Add(this.tlRBtn);
            this.Controls.Add(this.masanonumber);
            this.Controls.Add(this.labelmasa);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.siparisGbox);
            this.Controls.Add(this.masalarGbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.siparisGbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iceceknumdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemeknumupdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox masalarGbox;
        private System.Windows.Forms.GroupBox siparisGbox;
        private System.Windows.Forms.NumericUpDown iceceknumdown;
        private System.Windows.Forms.NumericUpDown yemeknumupdown;
        private System.Windows.Forms.ComboBox icecekCbox;
        private System.Windows.Forms.ComboBox yemekCbox;
        private System.Windows.Forms.Button siparisBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelmasa;
        private System.Windows.Forms.Label masanonumber;
        private System.Windows.Forms.RadioButton tlRBtn;
        private System.Windows.Forms.RadioButton dolarRBtn;
        private System.Windows.Forms.RadioButton euroRBtn;
        private System.Windows.Forms.Button odeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


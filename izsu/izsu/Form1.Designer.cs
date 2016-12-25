namespace izsu
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
            this.AboneNoTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdSoyadTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EvRBtn = new System.Windows.Forms.RadioButton();
            this.KurumRBtn = new System.Windows.Forms.RadioButton();
            this.BSayacTxt = new System.Windows.Forms.TextBox();
            this.ASayacTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AboneNoTxt
            // 
            this.AboneNoTxt.Location = new System.Drawing.Point(16, 32);
            this.AboneNoTxt.Name = "AboneNoTxt";
            this.AboneNoTxt.Size = new System.Drawing.Size(134, 20);
            this.AboneNoTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Abone No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad Soyad";
            // 
            // AdSoyadTxt
            // 
            this.AdSoyadTxt.Location = new System.Drawing.Point(17, 80);
            this.AdSoyadTxt.Name = "AdSoyadTxt";
            this.AdSoyadTxt.Size = new System.Drawing.Size(133, 20);
            this.AdSoyadTxt.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KurumRBtn);
            this.groupBox1.Controls.Add(this.EvRBtn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(17, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ev / Kurum";
            // 
            // EvRBtn
            // 
            this.EvRBtn.AutoSize = true;
            this.EvRBtn.Location = new System.Drawing.Point(6, 19);
            this.EvRBtn.Name = "EvRBtn";
            this.EvRBtn.Size = new System.Drawing.Size(38, 17);
            this.EvRBtn.TabIndex = 0;
            this.EvRBtn.TabStop = true;
            this.EvRBtn.Text = "Ev";
            this.EvRBtn.UseVisualStyleBackColor = true;
            // 
            // KurumRBtn
            // 
            this.KurumRBtn.AutoSize = true;
            this.KurumRBtn.Location = new System.Drawing.Point(7, 43);
            this.KurumRBtn.Name = "KurumRBtn";
            this.KurumRBtn.Size = new System.Drawing.Size(55, 17);
            this.KurumRBtn.TabIndex = 1;
            this.KurumRBtn.TabStop = true;
            this.KurumRBtn.Text = "Kurum";
            this.KurumRBtn.UseVisualStyleBackColor = true;
            // 
            // BSayacTxt
            // 
            this.BSayacTxt.Location = new System.Drawing.Point(17, 245);
            this.BSayacTxt.Name = "BSayacTxt";
            this.BSayacTxt.Size = new System.Drawing.Size(100, 20);
            this.BSayacTxt.TabIndex = 5;
            // 
            // ASayacTxt
            // 
            this.ASayacTxt.Location = new System.Drawing.Point(15, 292);
            this.ASayacTxt.Name = "ASayacTxt";
            this.ASayacTxt.Size = new System.Drawing.Size(100, 20);
            this.ASayacTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Önceki Sayaç";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Son Sayaç";
            // 
            // EkleBtn
            // 
            this.EkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EkleBtn.Location = new System.Drawing.Point(17, 335);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(200, 46);
            this.EkleBtn.TabIndex = 9;
            this.EkleBtn.Text = "EKLE";
            this.EkleBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 624);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ASayacTxt);
            this.Controls.Add(this.BSayacTxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AdSoyadTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AboneNoTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AboneNoTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdSoyadTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton KurumRBtn;
        private System.Windows.Forms.RadioButton EvRBtn;
        private System.Windows.Forms.TextBox BSayacTxt;
        private System.Windows.Forms.TextBox ASayacTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EkleBtn;
    }
}


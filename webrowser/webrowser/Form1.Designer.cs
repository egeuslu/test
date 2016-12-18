namespace webrowser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tarayici = new System.Windows.Forms.WebBrowser();
            this.URLTxt = new System.Windows.Forms.TextBox();
            this.GitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Takvim = new System.Windows.Forms.DateTimePicker();
            this.YasTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.YasTxt);
            this.groupBox1.Controls.Add(this.Takvim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.GitBtn);
            this.groupBox1.Controls.Add(this.URLTxt);
            this.groupBox1.Controls.Add(this.Tarayici);
            this.groupBox1.Location = new System.Drawing.Point(30, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 443);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Kontrolleri";
            // 
            // Tarayici
            // 
            this.Tarayici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tarayici.Location = new System.Drawing.Point(6, 72);
            this.Tarayici.MinimumSize = new System.Drawing.Size(20, 20);
            this.Tarayici.Name = "Tarayici";
            this.Tarayici.Size = new System.Drawing.Size(778, 371);
            this.Tarayici.TabIndex = 0;
            // 
            // URLTxt
            // 
            this.URLTxt.Location = new System.Drawing.Point(7, 20);
            this.URLTxt.Name = "URLTxt";
            this.URLTxt.Size = new System.Drawing.Size(289, 20);
            this.URLTxt.TabIndex = 1;
            // 
            // GitBtn
            // 
            this.GitBtn.Location = new System.Drawing.Point(302, 17);
            this.GitBtn.Name = "GitBtn";
            this.GitBtn.Size = new System.Drawing.Size(75, 23);
            this.GitBtn.TabIndex = 2;
            this.GitBtn.Text = "Git";
            this.GitBtn.UseVisualStyleBackColor = true;
            this.GitBtn.Click += new System.EventHandler(this.GitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Doğum Tarihi";
            // 
            // Takvim
            // 
            this.Takvim.Location = new System.Drawing.Point(494, 16);
            this.Takvim.Name = "Takvim";
            this.Takvim.Size = new System.Drawing.Size(200, 20);
            this.Takvim.TabIndex = 4;
            this.Takvim.ValueChanged += new System.EventHandler(this.Takvim_ValueChanged);
            // 
            // YasTxt
            // 
            this.YasTxt.Location = new System.Drawing.Point(494, 46);
            this.YasTxt.Name = "YasTxt";
            this.YasTxt.ReadOnly = true;
            this.YasTxt.Size = new System.Drawing.Size(200, 20);
            this.YasTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yaş";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 486);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button GitBtn;
        private System.Windows.Forms.TextBox URLTxt;
        private System.Windows.Forms.WebBrowser Tarayici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox YasTxt;
        private System.Windows.Forms.DateTimePicker Takvim;
        private System.Windows.Forms.Label label1;
    }
}


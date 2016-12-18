namespace hesapömür
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
            this.isTxtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saaatTxtB = new System.Windows.Forms.TextBox();
            this.HesaplaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // isTxtB
            // 
            this.isTxtB.Location = new System.Drawing.Point(28, 25);
            this.isTxtB.Name = "isTxtB";
            this.isTxtB.Size = new System.Drawing.Size(100, 20);
            this.isTxtB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hangi İşi Yapıcaksın?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kaç Saat Yapıcaksın?";
            // 
            // saaatTxtB
            // 
            this.saaatTxtB.Location = new System.Drawing.Point(31, 69);
            this.saaatTxtB.Name = "saaatTxtB";
            this.saaatTxtB.Size = new System.Drawing.Size(100, 20);
            this.saaatTxtB.TabIndex = 3;
            // 
            // HesaplaBtn
            // 
            this.HesaplaBtn.Location = new System.Drawing.Point(156, 42);
            this.HesaplaBtn.Name = "HesaplaBtn";
            this.HesaplaBtn.Size = new System.Drawing.Size(75, 23);
            this.HesaplaBtn.TabIndex = 4;
            this.HesaplaBtn.Text = "Hesapla";
            this.HesaplaBtn.UseVisualStyleBackColor = true;
            this.HesaplaBtn.Click += new System.EventHandler(this.HesaplaBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 109);
            this.Controls.Add(this.HesaplaBtn);
            this.Controls.Add(this.saaatTxtB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isTxtB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox isTxtB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox saaatTxtB;
        private System.Windows.Forms.Button HesaplaBtn;
    }
}


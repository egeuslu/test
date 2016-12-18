namespace Zar
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
            this.components = new System.ComponentModel.Container();
            this.AtBtn = new System.Windows.Forms.Button();
            this.zar1 = new System.Windows.Forms.Label();
            this.zar2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // AtBtn
            // 
            this.AtBtn.Location = new System.Drawing.Point(149, 77);
            this.AtBtn.Name = "AtBtn";
            this.AtBtn.Size = new System.Drawing.Size(75, 23);
            this.AtBtn.TabIndex = 0;
            this.AtBtn.Text = "At";
            this.AtBtn.UseVisualStyleBackColor = true;
            this.AtBtn.Click += new System.EventHandler(this.AtBtn_Click);
            // 
            // zar1
            // 
            this.zar1.AutoSize = true;
            this.zar1.Location = new System.Drawing.Point(115, 40);
            this.zar1.Name = "zar1";
            this.zar1.Size = new System.Drawing.Size(35, 13);
            this.zar1.TabIndex = 1;
            this.zar1.Text = "label1";
            // 
            // zar2
            // 
            this.zar2.AutoSize = true;
            this.zar2.Location = new System.Drawing.Point(223, 40);
            this.zar2.Name = "zar2";
            this.zar2.Size = new System.Drawing.Size(35, 13);
            this.zar2.TabIndex = 2;
            this.zar2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 317);
            this.Controls.Add(this.zar2);
            this.Controls.Add(this.zar1);
            this.Controls.Add(this.AtBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AtBtn;
        private System.Windows.Forms.Label zar1;
        private System.Windows.Forms.Label zar2;
        private System.Windows.Forms.Timer timer1;
    }
}


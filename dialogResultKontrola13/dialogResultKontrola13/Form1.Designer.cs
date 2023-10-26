namespace dialogResultKontrola13
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
            this.btnMB = new System.Windows.Forms.Button();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMB
            // 
            this.btnMB.Location = new System.Drawing.Point(279, 140);
            this.btnMB.Name = "btnMB";
            this.btnMB.Size = new System.Drawing.Size(191, 24);
            this.btnMB.TabIndex = 0;
            this.btnMB.Text = "Otvorite MessageBox";
            this.btnMB.UseVisualStyleBackColor = true;
            this.btnMB.Click += new System.EventHandler(this.btnMB_Click);
            // 
            // txtB1
            // 
            this.txtB1.Location = new System.Drawing.Point(207, 196);
            this.txtB1.Multiline = true;
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(340, 131);
            this.txtB1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtB1);
            this.Controls.Add(this.btnMB);
            this.Name = "Form1";
            this.Text = "Upotreba DialogResult Kontrole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMB;
        private System.Windows.Forms.TextBox txtB1;
    }
}


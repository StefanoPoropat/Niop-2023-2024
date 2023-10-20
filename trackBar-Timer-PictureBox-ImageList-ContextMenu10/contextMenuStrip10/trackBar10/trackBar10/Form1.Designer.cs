namespace trackBar10
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
            this.bar1 = new System.Windows.Forms.TrackBar();
            this.lbl1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.Location = new System.Drawing.Point(150, 86);
            this.bar1.Maximum = 100;
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(476, 56);
            this.bar1.TabIndex = 0;
            this.bar1.TickFrequency = 2;
            this.bar1.Scroll += new System.EventHandler(this.bar1_Scroll);
            // 
            // lbl1
            // 
            this.lbl1.Location = new System.Drawing.Point(150, 172);
            this.lbl1.Multiline = true;
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(476, 54);
            this.lbl1.TabIndex = 1;
            this.lbl1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.bar1);
            this.Name = "Form1";
            this.Text = "Upotreba TrackBar Kontrole";
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar bar1;
        private System.Windows.Forms.TextBox lbl1;
    }
}


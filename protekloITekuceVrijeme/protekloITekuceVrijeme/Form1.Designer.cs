namespace protekloITekuceVrijeme
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCurrent = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPased = new System.Windows.Forms.ToolStripStatusLabel();
            this.T = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCurrent,
            this.lblPased});
            this.statusStrip1.Location = new System.Drawing.Point(0, 202);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(382, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = false;
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(150, 17);
            this.lblCurrent.Text = "toolStripStatusLabel1";
            // 
            // lblPased
            // 
            this.lblPased.AutoSize = false;
            this.lblPased.Name = "lblPased";
            this.lblPased.Size = new System.Drawing.Size(150, 17);
            this.lblPased.Text = "toolStripStatusLabel2";
            // 
            // T
            // 
            this.T.Enabled = true;
            this.T.Interval = 1000;
            this.T.Tick += new System.EventHandler(this.T_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 224);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Proteklo i tekuce vrijeme";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrent;
        private System.Windows.Forms.ToolStripStatusLabel lblPased;
        private System.Windows.Forms.Timer T;
    }
}


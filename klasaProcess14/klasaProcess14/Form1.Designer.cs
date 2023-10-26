namespace klasaProcess14
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
            this.btnIE = new System.Windows.Forms.Button();
            this.btnExc = new System.Windows.Forms.Button();
            this.btnWo = new System.Windows.Forms.Button();
            this.btnSI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIE
            // 
            this.btnIE.Location = new System.Drawing.Point(102, 109);
            this.btnIE.Name = "btnIE";
            this.btnIE.Size = new System.Drawing.Size(205, 37);
            this.btnIE.TabIndex = 0;
            this.btnIE.Text = "Pokrenite Internet Explorer";
            this.btnIE.UseVisualStyleBackColor = true;
            this.btnIE.Click += new System.EventHandler(this.btnIE_Click);
            // 
            // btnExc
            // 
            this.btnExc.Location = new System.Drawing.Point(527, 109);
            this.btnExc.Name = "btnExc";
            this.btnExc.Size = new System.Drawing.Size(205, 37);
            this.btnExc.TabIndex = 1;
            this.btnExc.Text = "Pokrenite Excel";
            this.btnExc.UseVisualStyleBackColor = true;
            this.btnExc.Click += new System.EventHandler(this.btnExc_Click);
            // 
            // btnWo
            // 
            this.btnWo.Location = new System.Drawing.Point(102, 333);
            this.btnWo.Name = "btnWo";
            this.btnWo.Size = new System.Drawing.Size(205, 37);
            this.btnWo.TabIndex = 2;
            this.btnWo.Text = "Pokrenite Word";
            this.btnWo.UseVisualStyleBackColor = true;
            this.btnWo.Click += new System.EventHandler(this.btnWo_Click);
            // 
            // btnSI
            // 
            this.btnSI.Location = new System.Drawing.Point(527, 333);
            this.btnSI.Name = "btnSI";
            this.btnSI.Size = new System.Drawing.Size(205, 37);
            this.btnSI.TabIndex = 3;
            this.btnSI.Text = "Start Info";
            this.btnSI.UseVisualStyleBackColor = true;
            this.btnSI.Click += new System.EventHandler(this.btnSI_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSI);
            this.Controls.Add(this.btnWo);
            this.Controls.Add(this.btnExc);
            this.Controls.Add(this.btnIE);
            this.Name = "Form1";
            this.Text = "Upotreba Klase Process";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIE;
        private System.Windows.Forms.Button btnExc;
        private System.Windows.Forms.Button btnWo;
        private System.Windows.Forms.Button btnSI;
    }
}


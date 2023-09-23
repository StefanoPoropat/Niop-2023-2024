namespace UvodnaVjezba02
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
            this.varA = new System.Windows.Forms.TextBox();
            this.varC = new System.Windows.Forms.TextBox();
            this.varD = new System.Windows.Forms.TextBox();
            this.varB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // varA
            // 
            this.varA.Location = new System.Drawing.Point(50, 140);
            this.varA.Name = "varA";
            this.varA.Size = new System.Drawing.Size(123, 22);
            this.varA.TabIndex = 0;
            this.varA.Text = "10";
            this.varA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // varC
            // 
            this.varC.Location = new System.Drawing.Point(50, 242);
            this.varC.Name = "varC";
            this.varC.Size = new System.Drawing.Size(123, 22);
            this.varC.TabIndex = 1;
            this.varC.Text = "12.5";
            this.varC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // varD
            // 
            this.varD.Location = new System.Drawing.Point(232, 242);
            this.varD.Name = "varD";
            this.varD.Size = new System.Drawing.Size(123, 22);
            this.varD.TabIndex = 3;
            this.varD.Text = "16.7";
            this.varD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // varB
            // 
            this.varB.Location = new System.Drawing.Point(232, 140);
            this.varB.Name = "varB";
            this.varB.Size = new System.Drawing.Size(123, 22);
            this.varB.TabIndex = 2;
            this.varB.Text = "7";
            this.varB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Variabla A: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Variabla B: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Variabla D: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Variabla C: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prosječna vrijednost:";
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResult.Location = new System.Drawing.Point(509, 209);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(117, 55);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "                             ";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(374, 321);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(118, 43);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.Text = "Press me!";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Clicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.varD);
            this.Controls.Add(this.varB);
            this.Controls.Add(this.varC);
            this.Controls.Add(this.varA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox varA;
        private System.Windows.Forms.TextBox varC;
        private System.Windows.Forms.TextBox varD;
        private System.Windows.Forms.TextBox varB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalc;
    }
}


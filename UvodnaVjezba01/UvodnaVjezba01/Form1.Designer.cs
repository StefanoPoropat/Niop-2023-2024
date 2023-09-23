namespace UvodnaVjezba01
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
            this.varB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRez = new System.Windows.Forms.Label();
            this.lblOstatak = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // varA
            // 
            this.varA.Location = new System.Drawing.Point(39, 154);
            this.varA.Name = "varA";
            this.varA.Size = new System.Drawing.Size(135, 22);
            this.varA.TabIndex = 0;
            this.varA.Text = "100";
            this.varA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // varB
            // 
            this.varB.Location = new System.Drawing.Point(39, 320);
            this.varB.Name = "varB";
            this.varB.Size = new System.Drawing.Size(135, 22);
            this.varB.TabIndex = 1;
            this.varB.Text = "3";
            this.varB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rezultat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ostatak";
            // 
            // lblRez
            // 
            this.lblRez.AutoSize = true;
            this.lblRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRez.Location = new System.Drawing.Point(618, 180);
            this.lblRez.Name = "lblRez";
            this.lblRez.Size = new System.Drawing.Size(108, 26);
            this.lblRez.TabIndex = 4;
            this.lblRez.Text = "                ";
            this.lblRez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOstatak
            // 
            this.lblOstatak.AutoSize = true;
            this.lblOstatak.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOstatak.Location = new System.Drawing.Point(618, 302);
            this.lblOstatak.Name = "lblOstatak";
            this.lblOstatak.Size = new System.Drawing.Size(108, 26);
            this.lblOstatak.TabIndex = 5;
            this.lblOstatak.Text = "                ";
            this.lblOstatak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(308, 351);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(116, 45);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Press me!";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(67, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Broj A:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(67, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Broj B:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(34, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Djeljeno sa";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblText.Location = new System.Drawing.Point(208, 45);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(321, 29);
            this.lblText.TabIndex = 10;
            this.lblText.Text = "A dijeljeno s B je x i ostatak y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblOstatak);
            this.Controls.Add(this.lblRez);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.varB);
            this.Controls.Add(this.varA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox varA;
        private System.Windows.Forms.TextBox varB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRez;
        private System.Windows.Forms.Label lblOstatak;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblText;
    }
}


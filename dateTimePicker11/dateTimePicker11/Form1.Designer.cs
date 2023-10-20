namespace dateTimePicker11
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
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.time1 = new System.Windows.Forms.DateTimePicker();
            this.btnRez = new System.Windows.Forms.Button();
            this.rTxt = new System.Windows.Forms.RichTextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // date1
            // 
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.date1.Location = new System.Drawing.Point(419, 33);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(200, 23);
            this.date1.TabIndex = 0;
            // 
            // time1
            // 
            this.time1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.time1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time1.Location = new System.Drawing.Point(419, 88);
            this.time1.Name = "time1";
            this.time1.ShowUpDown = true;
            this.time1.Size = new System.Drawing.Size(200, 23);
            this.time1.TabIndex = 1;
            // 
            // btnRez
            // 
            this.btnRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRez.Location = new System.Drawing.Point(255, 389);
            this.btnRez.Name = "btnRez";
            this.btnRez.Size = new System.Drawing.Size(255, 39);
            this.btnRez.TabIndex = 2;
            this.btnRez.Text = "Rezervacija";
            this.btnRez.UseVisualStyleBackColor = true;
            this.btnRez.Click += new System.EventHandler(this.btnRez_Click);
            // 
            // rTxt
            // 
            this.rTxt.Location = new System.Drawing.Point(37, 123);
            this.rTxt.Name = "rTxt";
            this.rTxt.Size = new System.Drawing.Size(714, 254);
            this.rTxt.TabIndex = 3;
            this.rTxt.Text = "";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl1.Location = new System.Drawing.Point(209, 38);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(125, 17);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Upišite datum leta:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl2.Location = new System.Drawing.Point(209, 93);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(157, 17);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Upišite vrijeme polaska:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.rTxt);
            this.Controls.Add(this.btnRez);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.date1);
            this.Name = "Form1";
            this.Text = "Upotreba DateTimePicker Kontrole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.DateTimePicker time1;
        private System.Windows.Forms.Button btnRez;
        private System.Windows.Forms.RichTextBox rTxt;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
    }
}


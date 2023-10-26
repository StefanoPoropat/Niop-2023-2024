namespace monthCalendarKontrola12
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
            this.mC1 = new System.Windows.Forms.MonthCalendar();
            this.btnMore = new System.Windows.Forms.Button();
            this.btn1Day = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mC1
            // 
            this.mC1.Location = new System.Drawing.Point(274, 61);
            this.mC1.MaxSelectionCount = 999999999;
            this.mC1.Name = "mC1";
            this.mC1.TabIndex = 0;
            // 
            // btnMore
            // 
            this.btnMore.Location = new System.Drawing.Point(274, 303);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(234, 30);
            this.btnMore.TabIndex = 1;
            this.btnMore.Text = "Odaberite termin";
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // btn1Day
            // 
            this.btn1Day.Location = new System.Drawing.Point(274, 362);
            this.btn1Day.Name = "btn1Day";
            this.btn1Day.Size = new System.Drawing.Size(234, 30);
            this.btn1Day.TabIndex = 2;
            this.btn1Day.Text = "Odaberite jednodevni termin";
            this.btn1Day.UseVisualStyleBackColor = true;
            this.btn1Day.Click += new System.EventHandler(this.btn1Day_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn1Day);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.mC1);
            this.Name = "Form1";
            this.Text = "Upotreba MonthCalendar Kontrole";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mC1;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Button btn1Day;
    }
}


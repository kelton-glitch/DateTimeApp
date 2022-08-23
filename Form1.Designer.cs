namespace DateTimeApp
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
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lbl3DateDay = new System.Windows.Forms.Label();
            this.lbl4TimeAMPM = new System.Windows.Forms.Label();
            this.lbl5TimeSeconds = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtPicker
            // 
            this.dtPicker.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.Location = new System.Drawing.Point(220, 45);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(343, 34);
            this.dtPicker.TabIndex = 0;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Red;
            this.lblDateTime.Location = new System.Drawing.Point(217, 139);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(85, 29);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Red;
            this.lblDate.Location = new System.Drawing.Point(217, 196);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(85, 29);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "label2";
            // 
            // lbl3DateDay
            // 
            this.lbl3DateDay.AutoSize = true;
            this.lbl3DateDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3DateDay.ForeColor = System.Drawing.Color.Red;
            this.lbl3DateDay.Location = new System.Drawing.Point(217, 252);
            this.lbl3DateDay.Name = "lbl3DateDay";
            this.lbl3DateDay.Size = new System.Drawing.Size(85, 29);
            this.lbl3DateDay.TabIndex = 3;
            this.lbl3DateDay.Text = "label3";
            // 
            // lbl4TimeAMPM
            // 
            this.lbl4TimeAMPM.AutoSize = true;
            this.lbl4TimeAMPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4TimeAMPM.ForeColor = System.Drawing.Color.Red;
            this.lbl4TimeAMPM.Location = new System.Drawing.Point(217, 319);
            this.lbl4TimeAMPM.Name = "lbl4TimeAMPM";
            this.lbl4TimeAMPM.Size = new System.Drawing.Size(85, 29);
            this.lbl4TimeAMPM.TabIndex = 4;
            this.lbl4TimeAMPM.Text = "label4";
            // 
            // lbl5TimeSeconds
            // 
            this.lbl5TimeSeconds.AutoSize = true;
            this.lbl5TimeSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5TimeSeconds.ForeColor = System.Drawing.Color.Red;
            this.lbl5TimeSeconds.Location = new System.Drawing.Point(217, 388);
            this.lbl5TimeSeconds.Name = "lbl5TimeSeconds";
            this.lbl5TimeSeconds.Size = new System.Drawing.Size(85, 29);
            this.lbl5TimeSeconds.TabIndex = 5;
            this.lbl5TimeSeconds.Text = "label5";
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(646, 419);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(142, 57);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lbl5TimeSeconds);
            this.Controls.Add(this.lbl4TimeAMPM);
            this.Controls.Add(this.lbl3DateDay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.dtPicker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lbl3DateDay;
        private System.Windows.Forms.Label lbl4TimeAMPM;
        private System.Windows.Forms.Label lbl5TimeSeconds;
        private System.Windows.Forms.Button btnShow;
    }
}


﻿namespace FullTime_PartTime
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.trkCredits = new System.Windows.Forms.TrackBar();
            this.lblCredits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of credits";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(77, 290);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(291, 60);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status shown here";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trkCredits
            // 
            this.trkCredits.Location = new System.Drawing.Point(107, 171);
            this.trkCredits.Maximum = 24;
            this.trkCredits.Name = "trkCredits";
            this.trkCredits.Size = new System.Drawing.Size(541, 90);
            this.trkCredits.TabIndex = 2;
            this.trkCredits.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(671, 171);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(24, 25);
            this.lblCredits.TabIndex = 3;
            this.lblCredits.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.trkCredits);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Full time, half time?";
            ((System.ComponentModel.ISupportInitialize)(this.trkCredits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TrackBar trkCredits;
        private System.Windows.Forms.Label lblCredits;
    }
}


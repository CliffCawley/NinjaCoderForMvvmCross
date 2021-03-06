﻿namespace NinjaCoder.MvvmCross.Views
{
    partial class AboutBoxForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.logo1 = new NinjaCoder.MvvmCross.UserControls.Logo();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logo1
            // 
            this.logo1.BackColor = System.Drawing.Color.White;
            this.logo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logo1.Location = new System.Drawing.Point(1, -1);
            this.logo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(198, 399);
            this.logo1.TabIndex = 95;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOK.Location = new System.Drawing.Point(52, 412);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(88, 29);
            this.buttonOK.TabIndex = 96;
            this.buttonOK.Text = "&OK";
            this.buttonOK.Click += new System.EventHandler(this.ButtonOKClick);
            // 
            // AboutBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 457);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.logo1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBoxForm";
            this.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ninja - About";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Logo logo1;
        private System.Windows.Forms.Button buttonOK;

    }
}

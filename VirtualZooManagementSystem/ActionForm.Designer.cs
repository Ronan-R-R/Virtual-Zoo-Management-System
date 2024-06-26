﻿using System.Windows.Forms;

namespace VirtualZooManagementSystem
{
    partial class ActionForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.btnFeed = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFeed
            // 
            this.btnFeed.Location = new System.Drawing.Point(52, 12);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(145, 23);
            this.btnFeed.TabIndex = 1;
            this.btnFeed.Text = "Feed";
            this.btnFeed.UseVisualStyleBackColor = true;
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(52, 41);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 76);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFeed);
            this.Name = "ActionForm";
            this.Text = "Interactions";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnFeed;
        private System.Windows.Forms.Button btnClose;
    }
}

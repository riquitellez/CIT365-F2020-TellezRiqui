﻿namespace MegaDesk_Tellez
{
    partial class Home
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
            this.AddQuoteBtn = new System.Windows.Forms.Button();
            this.ViewQuotesBtn = new System.Windows.Forms.Button();
            this.SearchQuotesBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddQuoteBtn
            // 
            this.AddQuoteBtn.Location = new System.Drawing.Point(167, 84);
            this.AddQuoteBtn.Name = "AddQuoteBtn";
            this.AddQuoteBtn.Size = new System.Drawing.Size(140, 113);
            this.AddQuoteBtn.TabIndex = 0;
            this.AddQuoteBtn.Text = "&Add New Quote";
            this.AddQuoteBtn.UseVisualStyleBackColor = true;
            this.AddQuoteBtn.Click += new System.EventHandler(this.AddQuoteBtn_Click);
            // 
            // ViewQuotesBtn
            // 
            this.ViewQuotesBtn.Location = new System.Drawing.Point(313, 84);
            this.ViewQuotesBtn.Name = "ViewQuotesBtn";
            this.ViewQuotesBtn.Size = new System.Drawing.Size(140, 113);
            this.ViewQuotesBtn.TabIndex = 1;
            this.ViewQuotesBtn.Text = "&View Quotes";
            this.ViewQuotesBtn.UseVisualStyleBackColor = true;
            this.ViewQuotesBtn.Click += new System.EventHandler(this.ViewQuotesBtn_Click);
            // 
            // SearchQuotesBtn
            // 
            this.SearchQuotesBtn.Location = new System.Drawing.Point(167, 203);
            this.SearchQuotesBtn.Name = "SearchQuotesBtn";
            this.SearchQuotesBtn.Size = new System.Drawing.Size(140, 113);
            this.SearchQuotesBtn.TabIndex = 2;
            this.SearchQuotesBtn.Text = "&Search Quotes";
            this.SearchQuotesBtn.UseVisualStyleBackColor = true;
            this.SearchQuotesBtn.Click += new System.EventHandler(this.SearchQuotesBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(314, 204);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(139, 112);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "&Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 380);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SearchQuotesBtn);
            this.Controls.Add(this.ViewQuotesBtn);
            this.Controls.Add(this.AddQuoteBtn);
            this.Name = "Home";
            this.Text = "MegaDesk";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddQuoteBtn;
        private System.Windows.Forms.Button ViewQuotesBtn;
        private System.Windows.Forms.Button SearchQuotesBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}


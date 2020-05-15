namespace HomeWork_Week9
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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnCrawl = new System.Windows.Forms.Button();
            this.txtResultURL = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblLimitTimes = new System.Windows.Forms.Label();
            this.txtLimitTimes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(98, 19);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(522, 28);
            this.txtURL.TabIndex = 0;
            // 
            // btnCrawl
            // 
            this.btnCrawl.Location = new System.Drawing.Point(632, 22);
            this.btnCrawl.Name = "btnCrawl";
            this.btnCrawl.Size = new System.Drawing.Size(156, 42);
            this.btnCrawl.TabIndex = 1;
            this.btnCrawl.Text = "Crawl";
            this.btnCrawl.UseVisualStyleBackColor = true;
            this.btnCrawl.Click += new System.EventHandler(this.btnCrawl_Click);
            // 
            // txtResultURL
            // 
            this.txtResultURL.Location = new System.Drawing.Point(67, 87);
            this.txtResultURL.Multiline = true;
            this.txtResultURL.Name = "txtResultURL";
            this.txtResultURL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultURL.Size = new System.Drawing.Size(670, 351);
            this.txtResultURL.TabIndex = 2;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(12, 22);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(80, 18);
            this.lblURL.TabIndex = 3;
            this.lblURL.Text = "起始网站";
            // 
            // lblLimitTimes
            // 
            this.lblLimitTimes.AutoSize = true;
            this.lblLimitTimes.Location = new System.Drawing.Point(12, 56);
            this.lblLimitTimes.Name = "lblLimitTimes";
            this.lblLimitTimes.Size = new System.Drawing.Size(80, 18);
            this.lblLimitTimes.TabIndex = 4;
            this.lblLimitTimes.Text = "爬取次数";
            // 
            // txtLimitTimes
            // 
            this.txtLimitTimes.Location = new System.Drawing.Point(98, 53);
            this.txtLimitTimes.Name = "txtLimitTimes";
            this.txtLimitTimes.Size = new System.Drawing.Size(100, 28);
            this.txtLimitTimes.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLimitTimes);
            this.Controls.Add(this.lblLimitTimes);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.txtResultURL);
            this.Controls.Add(this.btnCrawl);
            this.Controls.Add(this.txtURL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnCrawl;
        private System.Windows.Forms.TextBox txtResultURL;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblLimitTimes;
        private System.Windows.Forms.TextBox txtLimitTimes;
    }
}


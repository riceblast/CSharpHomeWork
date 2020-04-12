namespace WinFormOrderManagement
{
    partial class AppendForm
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
            this.panelAppend = new System.Windows.Forms.Panel();
            this.panelInnerAppend = new System.Windows.Forms.Panel();
            this.txtBuyerName = new System.Windows.Forms.TextBox();
            this.lblBuyerName = new System.Windows.Forms.Label();
            this.lblGoodsType = new System.Windows.Forms.Label();
            this.cmbGoodsType = new System.Windows.Forms.ComboBox();
            this.txtGoodsQutity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAppend = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.panelAppend.SuspendLayout();
            this.panelInnerAppend.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAppend
            // 
            this.panelAppend.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelAppend.Controls.Add(this.panelInnerAppend);
            this.panelAppend.Controls.Add(this.btnAppend);
            this.panelAppend.Location = new System.Drawing.Point(12, 13);
            this.panelAppend.Name = "panelAppend";
            this.panelAppend.Size = new System.Drawing.Size(775, 222);
            this.panelAppend.TabIndex = 0;
            // 
            // panelInnerAppend
            // 
            this.panelInnerAppend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelInnerAppend.Controls.Add(this.txtBuyerName);
            this.panelInnerAppend.Controls.Add(this.lblBuyerName);
            this.panelInnerAppend.Controls.Add(this.lblGoodsType);
            this.panelInnerAppend.Controls.Add(this.cmbGoodsType);
            this.panelInnerAppend.Controls.Add(this.txtGoodsQutity);
            this.panelInnerAppend.Controls.Add(this.lblQuantity);
            this.panelInnerAppend.Location = new System.Drawing.Point(3, 3);
            this.panelInnerAppend.Name = "panelInnerAppend";
            this.panelInnerAppend.Size = new System.Drawing.Size(444, 216);
            this.panelInnerAppend.TabIndex = 6;
            // 
            // txtBuyerName
            // 
            this.txtBuyerName.Location = new System.Drawing.Point(120, 18);
            this.txtBuyerName.Name = "txtBuyerName";
            this.txtBuyerName.Size = new System.Drawing.Size(100, 28);
            this.txtBuyerName.TabIndex = 8;
            // 
            // lblBuyerName
            // 
            this.lblBuyerName.AutoSize = true;
            this.lblBuyerName.Location = new System.Drawing.Point(23, 21);
            this.lblBuyerName.Name = "lblBuyerName";
            this.lblBuyerName.Size = new System.Drawing.Size(80, 18);
            this.lblBuyerName.TabIndex = 7;
            this.lblBuyerName.Text = "买家姓名";
            // 
            // lblGoodsType
            // 
            this.lblGoodsType.AutoSize = true;
            this.lblGoodsType.Location = new System.Drawing.Point(20, 74);
            this.lblGoodsType.Name = "lblGoodsType";
            this.lblGoodsType.Size = new System.Drawing.Size(80, 18);
            this.lblGoodsType.TabIndex = 6;
            this.lblGoodsType.Text = "商品种类";
            // 
            // cmbGoodsType
            // 
            this.cmbGoodsType.FormattingEnabled = true;
            this.cmbGoodsType.Location = new System.Drawing.Point(120, 66);
            this.cmbGoodsType.Name = "cmbGoodsType";
            this.cmbGoodsType.Size = new System.Drawing.Size(121, 26);
            this.cmbGoodsType.TabIndex = 0;
            this.cmbGoodsType.SelectedIndexChanged += new System.EventHandler(this.cmbGoodsType_SelectedIndexChanged);
            // 
            // txtGoodsQutity
            // 
            this.txtGoodsQutity.Location = new System.Drawing.Point(120, 115);
            this.txtGoodsQutity.Name = "txtGoodsQutity";
            this.txtGoodsQutity.Size = new System.Drawing.Size(206, 28);
            this.txtGoodsQutity.TabIndex = 3;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(20, 125);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(80, 18);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "商品数量";
            // 
            // btnAppend
            // 
            this.btnAppend.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAppend.Location = new System.Drawing.Point(525, 77);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(146, 54);
            this.btnAppend.TabIndex = 1;
            this.btnAppend.Text = "添加";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCommit.Location = new System.Drawing.Point(359, 390);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(110, 48);
            this.btnCommit.TabIndex = 1;
            this.btnCommit.Text = "完成";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // AppendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.panelAppend);
            this.Name = "AppendForm";
            this.Text = "AppendForm";
            this.panelAppend.ResumeLayout(false);
            this.panelInnerAppend.ResumeLayout(false);
            this.panelInnerAppend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAppend;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.ComboBox cmbGoodsType;
        private System.Windows.Forms.TextBox txtGoodsQutity;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Panel panelInnerAppend;
        private System.Windows.Forms.Label lblGoodsType;
        private System.Windows.Forms.TextBox txtBuyerName;
        private System.Windows.Forms.Label lblBuyerName;
    }
}
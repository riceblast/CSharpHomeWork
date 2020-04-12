namespace WinFormOrderManagement
{
    partial class UpdateForm
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
            this.tabUpdate = new System.Windows.Forms.TabControl();
            this.tabOrderItem = new System.Windows.Forms.TabPage();
            this.btnCommitOrderItem = new System.Windows.Forms.Button();
            this.panelOrderItemAdd = new System.Windows.Forms.Panel();
            this.btnAppend = new System.Windows.Forms.Button();
            this.panelInnerOrderItem = new System.Windows.Forms.Panel();
            this.txtQuatity = new System.Windows.Forms.TextBox();
            this.lblQuatity = new System.Windows.Forms.Label();
            this.lblGoodsType = new System.Windows.Forms.Label();
            this.cmbGoodsType = new System.Windows.Forms.ComboBox();
            this.tabBuyerName = new System.Windows.Forms.TabPage();
            this.btnCommitBuyerName = new System.Windows.Forms.Button();
            this.panelInnerBuyerName = new System.Windows.Forms.Panel();
            this.txtNewBuyerName = new System.Windows.Forms.TextBox();
            this.lblNewBuyerName = new System.Windows.Forms.Label();
            this.panelOrderId = new System.Windows.Forms.Panel();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.tabUpdate.SuspendLayout();
            this.tabOrderItem.SuspendLayout();
            this.panelOrderItemAdd.SuspendLayout();
            this.panelInnerOrderItem.SuspendLayout();
            this.tabBuyerName.SuspendLayout();
            this.panelInnerBuyerName.SuspendLayout();
            this.panelOrderId.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUpdate
            // 
            this.tabUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabUpdate.Controls.Add(this.tabOrderItem);
            this.tabUpdate.Controls.Add(this.tabBuyerName);
            this.tabUpdate.Location = new System.Drawing.Point(6, 75);
            this.tabUpdate.Name = "tabUpdate";
            this.tabUpdate.SelectedIndex = 0;
            this.tabUpdate.Size = new System.Drawing.Size(764, 363);
            this.tabUpdate.TabIndex = 0;
            // 
            // tabOrderItem
            // 
            this.tabOrderItem.Controls.Add(this.btnCommitOrderItem);
            this.tabOrderItem.Controls.Add(this.panelOrderItemAdd);
            this.tabOrderItem.Location = new System.Drawing.Point(4, 28);
            this.tabOrderItem.Name = "tabOrderItem";
            this.tabOrderItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrderItem.Size = new System.Drawing.Size(756, 331);
            this.tabOrderItem.TabIndex = 0;
            this.tabOrderItem.Text = "修改订单明细项";
            this.tabOrderItem.UseVisualStyleBackColor = true;
            // 
            // btnCommitOrderItem
            // 
            this.btnCommitOrderItem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCommitOrderItem.Location = new System.Drawing.Point(323, 264);
            this.btnCommitOrderItem.Name = "btnCommitOrderItem";
            this.btnCommitOrderItem.Size = new System.Drawing.Size(123, 60);
            this.btnCommitOrderItem.TabIndex = 1;
            this.btnCommitOrderItem.Text = "修改订单";
            this.btnCommitOrderItem.UseVisualStyleBackColor = true;
            this.btnCommitOrderItem.Click += new System.EventHandler(this.btnCommitOrderItem_Click);
            // 
            // panelOrderItemAdd
            // 
            this.panelOrderItemAdd.Controls.Add(this.btnAppend);
            this.panelOrderItemAdd.Controls.Add(this.panelInnerOrderItem);
            this.panelOrderItemAdd.Location = new System.Drawing.Point(7, 7);
            this.panelOrderItemAdd.Name = "panelOrderItemAdd";
            this.panelOrderItemAdd.Size = new System.Drawing.Size(743, 184);
            this.panelOrderItemAdd.TabIndex = 0;
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(568, 56);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(102, 44);
            this.btnAppend.TabIndex = 1;
            this.btnAppend.Text = "添加";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // panelInnerOrderItem
            // 
            this.panelInnerOrderItem.Controls.Add(this.txtQuatity);
            this.panelInnerOrderItem.Controls.Add(this.lblQuatity);
            this.panelInnerOrderItem.Controls.Add(this.lblGoodsType);
            this.panelInnerOrderItem.Controls.Add(this.cmbGoodsType);
            this.panelInnerOrderItem.Location = new System.Drawing.Point(4, 3);
            this.panelInnerOrderItem.Name = "panelInnerOrderItem";
            this.panelInnerOrderItem.Size = new System.Drawing.Size(467, 178);
            this.panelInnerOrderItem.TabIndex = 0;
            // 
            // txtQuatity
            // 
            this.txtQuatity.Location = new System.Drawing.Point(109, 101);
            this.txtQuatity.Name = "txtQuatity";
            this.txtQuatity.Size = new System.Drawing.Size(144, 28);
            this.txtQuatity.TabIndex = 5;
            // 
            // lblQuatity
            // 
            this.lblQuatity.AutoSize = true;
            this.lblQuatity.Location = new System.Drawing.Point(3, 101);
            this.lblQuatity.Name = "lblQuatity";
            this.lblQuatity.Size = new System.Drawing.Size(80, 18);
            this.lblQuatity.TabIndex = 4;
            this.lblQuatity.Text = "商品数量";
            // 
            // lblGoodsType
            // 
            this.lblGoodsType.AutoSize = true;
            this.lblGoodsType.Location = new System.Drawing.Point(3, 12);
            this.lblGoodsType.Name = "lblGoodsType";
            this.lblGoodsType.Size = new System.Drawing.Size(80, 18);
            this.lblGoodsType.TabIndex = 1;
            this.lblGoodsType.Text = "商品类型";
            // 
            // cmbGoodsType
            // 
            this.cmbGoodsType.FormattingEnabled = true;
            this.cmbGoodsType.Location = new System.Drawing.Point(106, 9);
            this.cmbGoodsType.Name = "cmbGoodsType";
            this.cmbGoodsType.Size = new System.Drawing.Size(121, 26);
            this.cmbGoodsType.TabIndex = 0;
            // 
            // tabBuyerName
            // 
            this.tabBuyerName.Controls.Add(this.btnCommitBuyerName);
            this.tabBuyerName.Controls.Add(this.panelInnerBuyerName);
            this.tabBuyerName.Location = new System.Drawing.Point(4, 28);
            this.tabBuyerName.Name = "tabBuyerName";
            this.tabBuyerName.Padding = new System.Windows.Forms.Padding(3);
            this.tabBuyerName.Size = new System.Drawing.Size(756, 331);
            this.tabBuyerName.TabIndex = 1;
            this.tabBuyerName.Text = "修改买家名字";
            this.tabBuyerName.UseVisualStyleBackColor = true;
            // 
            // btnCommitBuyerName
            // 
            this.btnCommitBuyerName.Location = new System.Drawing.Point(566, 127);
            this.btnCommitBuyerName.Name = "btnCommitBuyerName";
            this.btnCommitBuyerName.Size = new System.Drawing.Size(106, 44);
            this.btnCommitBuyerName.TabIndex = 1;
            this.btnCommitBuyerName.Text = "修改";
            this.btnCommitBuyerName.UseVisualStyleBackColor = true;
            this.btnCommitBuyerName.Click += new System.EventHandler(this.btnCommitBuyerName_Click);
            // 
            // panelInnerBuyerName
            // 
            this.panelInnerBuyerName.Controls.Add(this.txtNewBuyerName);
            this.panelInnerBuyerName.Controls.Add(this.lblNewBuyerName);
            this.panelInnerBuyerName.Location = new System.Drawing.Point(7, 6);
            this.panelInnerBuyerName.Name = "panelInnerBuyerName";
            this.panelInnerBuyerName.Size = new System.Drawing.Size(450, 319);
            this.panelInnerBuyerName.TabIndex = 0;
            // 
            // txtNewBuyerName
            // 
            this.txtNewBuyerName.Location = new System.Drawing.Point(177, 131);
            this.txtNewBuyerName.Name = "txtNewBuyerName";
            this.txtNewBuyerName.Size = new System.Drawing.Size(122, 28);
            this.txtNewBuyerName.TabIndex = 3;
            // 
            // lblNewBuyerName
            // 
            this.lblNewBuyerName.AutoSize = true;
            this.lblNewBuyerName.Location = new System.Drawing.Point(24, 134);
            this.lblNewBuyerName.Name = "lblNewBuyerName";
            this.lblNewBuyerName.Size = new System.Drawing.Size(116, 18);
            this.lblNewBuyerName.TabIndex = 1;
            this.lblNewBuyerName.Text = "买家姓名(新)";
            // 
            // panelOrderId
            // 
            this.panelOrderId.Controls.Add(this.txtOrderId);
            this.panelOrderId.Controls.Add(this.lblOrderId);
            this.panelOrderId.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrderId.Location = new System.Drawing.Point(0, 0);
            this.panelOrderId.Name = "panelOrderId";
            this.panelOrderId.Size = new System.Drawing.Size(779, 67);
            this.panelOrderId.TabIndex = 1;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtOrderId.Location = new System.Drawing.Point(128, 13);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(134, 28);
            this.txtOrderId.TabIndex = 1;
            // 
            // lblOrderId
            // 
            this.lblOrderId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(25, 16);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(62, 18);
            this.lblOrderId.TabIndex = 0;
            this.lblOrderId.Text = "订单号";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.panelOrderId);
            this.Controls.Add(this.tabUpdate);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.tabUpdate.ResumeLayout(false);
            this.tabOrderItem.ResumeLayout(false);
            this.panelOrderItemAdd.ResumeLayout(false);
            this.panelInnerOrderItem.ResumeLayout(false);
            this.panelInnerOrderItem.PerformLayout();
            this.tabBuyerName.ResumeLayout(false);
            this.panelInnerBuyerName.ResumeLayout(false);
            this.panelInnerBuyerName.PerformLayout();
            this.panelOrderId.ResumeLayout(false);
            this.panelOrderId.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUpdate;
        private System.Windows.Forms.TabPage tabOrderItem;
        private System.Windows.Forms.TabPage tabBuyerName;
        private System.Windows.Forms.Panel panelOrderItemAdd;
        private System.Windows.Forms.Panel panelInnerOrderItem;
        private System.Windows.Forms.Label lblGoodsType;
        private System.Windows.Forms.ComboBox cmbGoodsType;
        private System.Windows.Forms.Button btnCommitOrderItem;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.TextBox txtQuatity;
        private System.Windows.Forms.Label lblQuatity;
        private System.Windows.Forms.Panel panelOrderId;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Panel panelInnerBuyerName;
        private System.Windows.Forms.Button btnCommitBuyerName;
        private System.Windows.Forms.TextBox txtNewBuyerName;
        private System.Windows.Forms.Label lblNewBuyerName;
    }
}
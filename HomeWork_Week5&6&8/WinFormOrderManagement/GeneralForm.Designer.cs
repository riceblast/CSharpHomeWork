namespace WinFormOrderManagement
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelFunction = new System.Windows.Forms.Panel();
            this.lblIdBuyerName = new System.Windows.Forms.Label();
            this.lblQueryWay = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtQueryInfo = new System.Windows.Forms.TextBox();
            this.cmbQueryWays = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelInnerFunction = new System.Windows.Forms.Panel();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.naviOrder = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.buyerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelRight = new System.Windows.Forms.Panel();
            this.orderItemDataGridView = new System.Windows.Forms.DataGridView();
            this.goodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPirceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFunction.SuspendLayout();
            this.panelInnerFunction.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naviOrder)).BeginInit();
            this.naviOrder.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFunction
            // 
            this.panelFunction.Controls.Add(this.lblIdBuyerName);
            this.panelFunction.Controls.Add(this.lblQueryWay);
            this.panelFunction.Controls.Add(this.btnQuery);
            this.panelFunction.Controls.Add(this.txtQueryInfo);
            this.panelFunction.Controls.Add(this.cmbQueryWays);
            this.panelFunction.Controls.Add(this.btnDelete);
            this.panelFunction.Controls.Add(this.panelInnerFunction);
            this.panelFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFunction.Location = new System.Drawing.Point(0, 0);
            this.panelFunction.Name = "panelFunction";
            this.panelFunction.Size = new System.Drawing.Size(1240, 128);
            this.panelFunction.TabIndex = 0;
            // 
            // lblIdBuyerName
            // 
            this.lblIdBuyerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIdBuyerName.AutoSize = true;
            this.lblIdBuyerName.Location = new System.Drawing.Point(346, 27);
            this.lblIdBuyerName.Name = "lblIdBuyerName";
            this.lblIdBuyerName.Size = new System.Drawing.Size(80, 18);
            this.lblIdBuyerName.TabIndex = 7;
            this.lblIdBuyerName.Text = "查询信息";
            // 
            // lblQueryWay
            // 
            this.lblQueryWay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQueryWay.AutoSize = true;
            this.lblQueryWay.Location = new System.Drawing.Point(70, 27);
            this.lblQueryWay.Name = "lblQueryWay";
            this.lblQueryWay.Size = new System.Drawing.Size(80, 18);
            this.lblQueryWay.TabIndex = 4;
            this.lblQueryWay.Text = "查询方式";
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuery.Location = new System.Drawing.Point(696, 16);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(144, 41);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtQueryInfo
            // 
            this.txtQueryInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQueryInfo.Location = new System.Drawing.Point(432, 24);
            this.txtQueryInfo.Name = "txtQueryInfo";
            this.txtQueryInfo.Size = new System.Drawing.Size(193, 28);
            this.txtQueryInfo.TabIndex = 2;
            // 
            // cmbQueryWays
            // 
            this.cmbQueryWays.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbQueryWays.FormattingEnabled = true;
            this.cmbQueryWays.Location = new System.Drawing.Point(156, 24);
            this.cmbQueryWays.Name = "cmbQueryWays";
            this.cmbQueryWays.Size = new System.Drawing.Size(132, 26);
            this.cmbQueryWays.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Location = new System.Drawing.Point(866, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 41);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除选中订单";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelInnerFunction
            // 
            this.panelInnerFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInnerFunction.Controls.Add(this.btnImport);
            this.panelInnerFunction.Controls.Add(this.btnExport);
            this.panelInnerFunction.Controls.Add(this.btnUpdate);
            this.panelInnerFunction.Controls.Add(this.btnAppend);
            this.panelInnerFunction.Location = new System.Drawing.Point(12, 77);
            this.panelInnerFunction.Name = "panelInnerFunction";
            this.panelInnerFunction.Size = new System.Drawing.Size(1216, 48);
            this.panelInnerFunction.TabIndex = 0;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImport.Location = new System.Drawing.Point(719, 0);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(124, 45);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "导入订单";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExport.Location = new System.Drawing.Point(538, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(123, 41);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "导出订单";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.Location = new System.Drawing.Point(369, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 41);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "修改订单";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAppend
            // 
            this.btnAppend.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAppend.Location = new System.Drawing.Point(188, 4);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(120, 41);
            this.btnAppend.TabIndex = 0;
            this.btnAppend.Text = "添加订单";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.panelRight);
            this.panel1.Controls.Add(this.panelLeft);
            this.panel1.Location = new System.Drawing.Point(12, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 359);
            this.panel1.TabIndex = 1;
            // 
            // orderItemsBindingSource
            // 
            this.orderItemsBindingSource.DataMember = "OrderItems";
            this.orderItemsBindingSource.DataSource = this.OrderBindingSource;
            // 
            // OrderBindingSource
            // 
            this.OrderBindingSource.DataSource = typeof(OrderManagement.Entity.Order);
            // 
            // naviOrder
            // 
            this.naviOrder.AddNewItem = null;
            this.naviOrder.BindingSource = this.OrderBindingSource;
            this.naviOrder.CountItem = this.bindingNavigatorCountItem;
            this.naviOrder.DeleteItem = null;
            this.naviOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.naviOrder.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.naviOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.naviOrder.Location = new System.Drawing.Point(0, 564);
            this.naviOrder.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.naviOrder.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.naviOrder.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.naviOrder.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.naviOrder.Name = "naviOrder";
            this.naviOrder.PositionItem = this.bindingNavigatorPositionItem;
            this.naviOrder.Size = new System.Drawing.Size(1240, 38);
            this.naviOrder.TabIndex = 2;
            this.naviOrder.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 30);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.orderDataGridView);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(567, 359);
            this.panelLeft.TabIndex = 2;
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AutoGenerateColumns = false;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buyerNameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.dealTimeDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.orderDataGridView.DataSource = this.OrderBindingSource;
            this.orderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDataGridView.Location = new System.Drawing.Point(0, 0);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.RowHeadersWidth = 62;
            this.orderDataGridView.RowTemplate.Height = 30;
            this.orderDataGridView.Size = new System.Drawing.Size(567, 359);
            this.orderDataGridView.TabIndex = 1;
            // 
            // buyerNameDataGridViewTextBoxColumn
            // 
            this.buyerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.buyerNameDataGridViewTextBoxColumn.DataPropertyName = "BuyerName";
            this.buyerNameDataGridViewTextBoxColumn.HeaderText = "BuyerName";
            this.buyerNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.buyerNameDataGridViewTextBoxColumn.Name = "buyerNameDataGridViewTextBoxColumn";
            this.buyerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 62;
            // 
            // dealTimeDataGridViewTextBoxColumn
            // 
            this.dealTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dealTimeDataGridViewTextBoxColumn.DataPropertyName = "DealTime";
            this.dealTimeDataGridViewTextBoxColumn.HeaderText = "DealTime";
            this.dealTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dealTimeDataGridViewTextBoxColumn.Name = "dealTimeDataGridViewTextBoxColumn";
            this.dealTimeDataGridViewTextBoxColumn.Width = 116;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.Width = 134;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.orderItemDataGridView);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(584, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(611, 359);
            this.panelRight.TabIndex = 3;
            // 
            // orderItemDataGridView
            // 
            this.orderItemDataGridView.AutoGenerateColumns = false;
            this.orderItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsNameDataGridViewTextBoxColumn,
            this.unitPirceDataGridViewTextBoxColumn,
            this.goodsNumDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn1});
            this.orderItemDataGridView.DataSource = this.orderItemsBindingSource;
            this.orderItemDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderItemDataGridView.Location = new System.Drawing.Point(0, 0);
            this.orderItemDataGridView.Name = "orderItemDataGridView";
            this.orderItemDataGridView.RowHeadersWidth = 62;
            this.orderItemDataGridView.RowTemplate.Height = 30;
            this.orderItemDataGridView.Size = new System.Drawing.Size(611, 359);
            this.orderItemDataGridView.TabIndex = 2;
            // 
            // goodsNameDataGridViewTextBoxColumn
            // 
            this.goodsNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.goodsNameDataGridViewTextBoxColumn.DataPropertyName = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.HeaderText = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.goodsNameDataGridViewTextBoxColumn.Name = "goodsNameDataGridViewTextBoxColumn";
            this.goodsNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitPirceDataGridViewTextBoxColumn
            // 
            this.unitPirceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.unitPirceDataGridViewTextBoxColumn.DataPropertyName = "UnitPirce";
            this.unitPirceDataGridViewTextBoxColumn.HeaderText = "UnitPirce";
            this.unitPirceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.unitPirceDataGridViewTextBoxColumn.Name = "unitPirceDataGridViewTextBoxColumn";
            this.unitPirceDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodsNumDataGridViewTextBoxColumn
            // 
            this.goodsNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.goodsNumDataGridViewTextBoxColumn.DataPropertyName = "GoodsNum";
            this.goodsNumDataGridViewTextBoxColumn.HeaderText = "GoodsNum";
            this.goodsNumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.goodsNumDataGridViewTextBoxColumn.Name = "goodsNumDataGridViewTextBoxColumn";
            this.goodsNumDataGridViewTextBoxColumn.Width = 116;
            // 
            // totalPriceDataGridViewTextBoxColumn1
            // 
            this.totalPriceDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.totalPriceDataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.totalPriceDataGridViewTextBoxColumn1.Name = "totalPriceDataGridViewTextBoxColumn1";
            this.totalPriceDataGridViewTextBoxColumn1.Width = 134;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 602);
            this.Controls.Add(this.naviOrder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelFunction);
            this.Name = "Form1";
            this.Text = "订单管理";
            this.panelFunction.ResumeLayout(false);
            this.panelFunction.PerformLayout();
            this.panelInnerFunction.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naviOrder)).EndInit();
            this.naviOrder.ResumeLayout(false);
            this.naviOrder.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderItemDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFunction;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtQueryInfo;
        private System.Windows.Forms.ComboBox cmbQueryWays;
        private System.Windows.Forms.Panel panelInnerFunction;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource OrderBindingSource;
        private System.Windows.Forms.BindingSource orderItemsBindingSource;
        private System.Windows.Forms.Label lblIdBuyerName;
        private System.Windows.Forms.Label lblQueryWay;
        private System.Windows.Forms.BindingNavigator naviOrder;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DataGridView orderItemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPirceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
    }
}


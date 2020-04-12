using OrderManagement.ControlSystem;
using OrderManagement.Entity;
using OrderManagement.UserInteraction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormOrderManagement
{
    public partial class Form1 : Form
    {
        // 其他的附属表
        // 用于添加记录
        public AppendForm AppendForm { get; set; }

        // 用于更新记录
        public UpdateForm UpdateForm { get; set; }

        // 内部类，查询方式
        public enum QueryWay
        {
            ByGoodsName,
            ById,
            ByName,
        }

        // 用于查询的方式
        public QueryWay UserQueryWay { get; set; }

        // 需要查询的商品类型
        public GoodsType UserGoodsType 
        {
            get
            {
                GoodsType temp;
                TypeConvert.String2Enum(txtQueryInfo.Text, out temp);
                return temp;
            }
            set { }
        }

        public Form1()
        {
            InitializeComponent();

            // 添加查询类型comboBox选项
            object[] queryWay = new object[]
            {
                QueryWay.ByGoodsName,
                QueryWay.ById,
                QueryWay.ByName,
            };
            this.cmbQueryWays.DataSource = queryWay;
            this.cmbQueryWays.DataBindings.Add("SelectedItem", this, "UserQueryWay"); // 将选择的项和属性相结合

            // 添加订单以测试
            List<OrderItem> temp1 = new List<OrderItem>();
            temp1.Add(new OrderItem(GoodsType.Battery, 100));
            temp1.Add(new OrderItem(GoodsType.Cmos, 39));

            List<OrderItem> temp2 = new List<OrderItem>();
            temp2.Add(new OrderItem(GoodsType.Screen, 10));
            temp2.Add(new OrderItem(GoodsType.Cmos, 9));
            OrderService.AppendOrder("Andy", temp1);
            OrderService.AppendOrder("Andy", temp2);

            // 将添加和修改窗体初始化
            AppendForm = new AppendForm();
            UpdateForm = new UpdateForm();
        }

        // 执行查询操作
        private void btnQuery_Click(object sender, EventArgs e)
        {
            List<Order> resultOrder = new List<Order>(); // 用于接收查询的结果
            switch (this.UserQueryWay)
            {
                case QueryWay.ByGoodsName:
                    resultOrder = OrderService.QueryOrder(this.UserGoodsType);
                    break;
                case QueryWay.ById:
                    resultOrder = OrderService.QueryOrder(Convert.ToInt32(txtQueryInfo.Text));
                    break;
                case QueryWay.ByName:
                    resultOrder = OrderService.QueryOrder(txtQueryInfo.Text);
                    break;
            }

            if(resultOrder.Count == 0)
            {
                // 如果查询失败
                MessageBox.Show("查询失败，请重新输入");
                this.txtQueryInfo.Clear();
            }else
            {
                OrderBindingSource.DataSource = resultOrder;
                orderItemsBindingSource.DataSource = (this.orderDataGridView.CurrentRow.DataBoundItem as Order).OrderItems;
            }
        }

        // 执行删除操作
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 获取Id
            int deletingId = (this.orderDataGridView.CurrentRow.DataBoundItem as Order).Id;

            // 删除
            OrderService.DeleteOrder(deletingId);
            MessageBox.Show("删除成功"); // 提示用户

            // 刷新查询结果
            List<Order> resultOrder = new List<Order>(); // 用于接收查询的结果
            switch (this.UserQueryWay)
            {
                case QueryWay.ByGoodsName:
                    resultOrder = OrderService.QueryOrder(this.UserGoodsType);
                    break;
                case QueryWay.ById:
                    resultOrder = OrderService.QueryOrder(Convert.ToInt32(txtQueryInfo.Text));
                    break;
                case QueryWay.ByName:
                    resultOrder = OrderService.QueryOrder(txtQueryInfo.Text);
                    break;
            }

            if(resultOrder.Count != 0)
            {
                // 如果删除后还有查询结果
                OrderBindingSource.DataSource = resultOrder;
                orderItemsBindingSource.DataSource = (this.orderDataGridView.CurrentRow.DataBoundItem as Order).OrderItems;
            }
            else
            {
                // 如果删除后没有查询结果，则不显示
                OrderBindingSource.DataSource = null;
                orderItemsBindingSource.DataSource = null;
            }
        }

        // 更新orderItem
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            orderItemsBindingSource.DataSource = (this.orderDataGridView.CurrentRow.DataBoundItem as Order).OrderItems;
        }

        // 更新OrderItem
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            orderItemsBindingSource.DataSource = (this.orderDataGridView.CurrentRow.DataBoundItem as Order).OrderItems;

        }

        // 导出订单
        private void btnExport_Click(object sender, EventArgs e)
        {
            // 将现有订单导出
            OrderService.Export();
            MessageBox.Show("订单导出成功");
        }

        // 导入订单
        private void btnImport_Click(object sender, EventArgs e)
        {
            // 将现有订单导入
            OrderService.Import();
            MessageBox.Show("订单导入成功");
        }

        // 添加订单
        private void btnAppend_Click(object sender, EventArgs e)
        {
            this.AppendForm.Show();
        }

        // 修改订单
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.UpdateForm.Show();
        }
    }
}

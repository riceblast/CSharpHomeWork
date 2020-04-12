using OrderManagement.ControlSystem;
using OrderManagement.Entity;
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
    public partial class UpdateForm : Form
    {

        // 买家姓名
        public string BuyerName
        {
            get
            {
                return this.txtNewBuyerName.Text;
            }
        }

        // 待添加的OrderItem
        public List<OrderItem> OrderItems { get; set; }

        // 商品种类
        public GoodsType UserGoodsType { get; set; }

        // 商品单价
        public double UnitPrice
        {
            get
            {
                return PriceData.GetPrice(UserGoodsType);
            }
        }


        public UpdateForm()
        {
            InitializeComponent();

            OrderItems = new List<OrderItem>();
            // 将comboBox与枚举类型绑定
            GoodsType[] goodsType = new GoodsType[]
            {
                GoodsType.Battery,
                GoodsType.Cmos,
                GoodsType.Screen,
                GoodsType.Soc,
            };
            cmbGoodsType.DataSource = goodsType;
            cmbGoodsType.DataBindings.Add("SelectedItem", this, "UserGoodsType");

           
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            this.OrderItems.Add(new OrderItem(UserGoodsType, Convert.ToInt32(this.txtQuatity.Text)));

            // 提示用户
            string tips = "订单详细项添加成功\n" + "商品: " + this.UserGoodsType
                + "数量: " + Convert.ToInt32(txtQuatity.Text);
            MessageBox.Show(tips);
        }

        // 提交对订单的修改
        private void btnCommitOrderItem_Click(object sender, EventArgs e)
        {
            if(txtOrderId.Text == "")
            {
                MessageBox.Show("请输入需要修改的订单号");
                return;
            }

            try
            {
                OrderService.UpdateOrder(Convert.ToInt32(txtOrderId.Text), OrderItems);
            }
            catch (FormatException)
            {
                MessageBox.Show("请输入正确的订单号");
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            MessageBox.Show("订单" + Convert.ToInt32(txtOrderId.Text) + "修改成功");
            this.Hide();
        }

        private void btnCommitBuyerName_Click(object sender, EventArgs e)
        {
            if (txtOrderId.Text == "")
            {
                MessageBox.Show("请输入需要修改的订单号");
                return;
            }

            try
            {
                OrderService.UpdateOrder(Convert.ToInt32(txtOrderId.Text), BuyerName);
            }
            catch (FormatException)
            {
                MessageBox.Show("请输入正确的订单号");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            MessageBox.Show("订单" + Convert.ToInt32(txtOrderId.Text) + "修改成功");
            this.Hide();
        }
    }
}

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
    public partial class AppendForm : Form
    {
        // 买家姓名
        public string BuyerName 
        {
            get
            {
                return this.txtBuyerName.Text;
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

        public AppendForm()
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
            cmbGoodsType.DataBindings.Add("SelectedItem", this,"UserGoodsType");


        }

        // 添加商品详细项
        private void btnAppend_Click(object sender, EventArgs e)
        {
            this.OrderItems.Add(new OrderItem(UserGoodsType, Convert.ToInt32(this.txtGoodsQutity.Text)));

            // 提示用户
            string tips = "订单详细项添加成功\n" + "商品: " + this.UserGoodsType
                + "数量: " + Convert.ToInt32(txtGoodsQutity.Text);
            MessageBox.Show(tips);
        }

        // 将订单明细项添加到OrderService
        private void btnCommit_Click(object sender, EventArgs e)
        {
            OrderService.AppendOrder(this.BuyerName, this.OrderItems);
            MessageBox.Show("订单添加成功");

            // 隐藏当前窗口
            this.Hide();
        }

        private void cmbGoodsType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

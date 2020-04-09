using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCayleyTree
{
    public partial class Form1 : Form
    {
        // 用于画图的Graphics
        private Graphics graphics;

        // 用于存储画笔颜色的数组
        private Pen[] colors; 

        // 画笔颜色，更具所选的颜色进行设置
        public Pen penColor { get { return colors[this.cmbPenColor.SelectedIndex]; } } 

        // 递归深度
        public int DepthN
        {
            get { return trbDepthN.Value; }
        }

        // 主干长度
        public int Leng 
        {
            get { return trbLeng.Value; } 
        }

        // 右长度分支比
        public double RightPer { get { return trbRightPer1.Value / 10.0; } }

        // 左长度分支比
        public double LeftPer { get { return trbLeftPer2.Value / 10.0; } }

        // 右分支角度(以度为单位)
        public int RightThDegree { get { return trbRightTh1.Value; } }

        // 左分支角度(以度为单位)
        public int LeftThDegree { get { return trbLeftTh2.Value; } }

        // 右分支角度(以弧度为单位)
        public double RightThRadius { get { return RightThDegree * Math.PI / 180; } }

        // 左分支角度(以弧度为单位)
        public double LeftThRadius { get { return LeftThDegree * Math.PI / 180; } }

        public Form1()
        {
            InitializeComponent();

            // 显示滑动条数值
            this.lblDepthN.Text = this.lblDepthN.Text + ":" + DepthN;
            this.lblLeng.Text = this.lblLeng.Text + ":" + Leng;
            this.lblRightPer1.Text = this.lblRightPer1.Text + ":\n" + RightPer;
            this.lblLeftPer2.Text = this.lblLeftPer2.Text + ":\n" + LeftPer;
            this.lblRightTh1.Text = this.lblRightTh1.Text + ":\n" + RightThDegree;
            this.lblLeftTh2.Text = this.lblLeftTh2.Text + ":\n" + LeftThDegree;

            // 初始化颜色数组(按照七色表的顺序初始化)
            colors = new Pen[] {
                Pens.AliceBlue,
                Pens.Black,
                Pens.Blue,
                Pens.BlueViolet,
                Pens.DarkOliveGreen,
                Pens.DarkRed,
                Pens.DarkViolet,
                Pens.Gold,
                Pens.Green,
                Pens.LightGoldenrodYellow,
                Pens.LightYellow,
                Pens.MediumPurple,
                Pens.MediumVioletRed,
                Pens.Orange,
                Pens.OrangeRed,
                Pens.PaleVioletRed,
                Pens.Purple,
                Pens.Red,
                Pens.RoyalBlue,
                Pens.Silver,
                Pens.Violet,
                Pens.White, 
                Pens.Yellow,
                Pens.YellowGreen,
                };

            // 为多选框增加选项
            this.cmbPenColor.Items.AddRange(colors);
            this.cmbPenColor.DisplayMember = "Color"; // 展示的是Color这个属性的名字
            this.cmbPenColor.SelectedIndex = 3; // 默认为黑色
        }

        // 滑动条数值更新函数
        private void trbLeng_Scroll(object sender, EventArgs e)
        {
            this.lblLeng.Text = "主干长度:" + Leng;
        }

        private void trbDepthN_Scroll(object sender, EventArgs e)
        {
            this.lblDepthN.Text = "递归深度:" + DepthN;
        }

        private void trbLeftPer2_Scroll(object sender, EventArgs e)
        {
            this.lblLeftPer2.Text = "左长度分支比:\n" + LeftPer;
        }

        private void trbRightPer1_Scroll(object sender, EventArgs e)
        {
            this.lblRightPer1.Text = "右长度分支比:\n" + RightPer;
        }

        private void trbRightTh1_Scroll(object sender, EventArgs e)
        {
            this.lblRightTh1.Text = "右分支角度:\n" + RightThDegree;
        }

        private void trbLeftTh2_Scroll(object sender, EventArgs e)
        {
            this.lblLeftTh2.Text = "左分支角度:\n" + LeftThDegree;
        }

        // 画图函数
        private void DrawCayleyTree(int n, double x0, double y0, double leng, double th)
        {

            if (n == 0)
                return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            DrawLine(x0, y0, x1, y1);

            DrawCayleyTree(n - 1, x1, y1, RightPer * leng, th + RightThRadius);
            DrawCayleyTree(n - 1, x1, y1, LeftPer * leng, th - LeftThRadius);
        }

        private void DrawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(penColor, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        // 用于画Cayley的函数
        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (graphics == null)
                graphics = panelCayleyTree.CreateGraphics();

            // 先清除上一次绘画的记录
            graphics.Clear(BackColor);
            // 开始画图
            DrawCayleyTree(this.DepthN, panelCayleyTree.Width / 2, panelCayleyTree.Height + 40, this.Leng, -Math.PI / 2);
        }
    }
}

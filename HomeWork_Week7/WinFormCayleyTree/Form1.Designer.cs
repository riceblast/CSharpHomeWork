namespace WinFormCayleyTree
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
            this.panelCayleyTree = new System.Windows.Forms.Panel();
            this.btnDraw = new System.Windows.Forms.Button();
            this.cmbPenColor = new System.Windows.Forms.ComboBox();
            this.panelControl = new System.Windows.Forms.Panel();
            this.lblRightTh1 = new System.Windows.Forms.Label();
            this.lblLeftTh2 = new System.Windows.Forms.Label();
            this.lblLeftPer2 = new System.Windows.Forms.Label();
            this.lblLeng = new System.Windows.Forms.Label();
            this.lblRightPer1 = new System.Windows.Forms.Label();
            this.lblDepthN = new System.Windows.Forms.Label();
            this.trbLeftTh2 = new System.Windows.Forms.TrackBar();
            this.trbRightTh1 = new System.Windows.Forms.TrackBar();
            this.trbLeftPer2 = new System.Windows.Forms.TrackBar();
            this.trbRightPer1 = new System.Windows.Forms.TrackBar();
            this.trbLeng = new System.Windows.Forms.TrackBar();
            this.trbDepthN = new System.Windows.Forms.TrackBar();
            this.panelCayleyTree.SuspendLayout();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbLeftTh2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRightTh1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLeftPer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRightPer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLeng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbDepthN)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCayleyTree
            // 
            this.panelCayleyTree.AutoSize = true;
            this.panelCayleyTree.Controls.Add(this.btnDraw);
            this.panelCayleyTree.Controls.Add(this.cmbPenColor);
            this.panelCayleyTree.Location = new System.Drawing.Point(12, 3);
            this.panelCayleyTree.Name = "panelCayleyTree";
            this.panelCayleyTree.Size = new System.Drawing.Size(510, 445);
            this.panelCayleyTree.TabIndex = 0;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(225, 2);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(128, 38);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Cayley树！";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // cmbPenColor
            // 
            this.cmbPenColor.FormattingEnabled = true;
            this.cmbPenColor.Location = new System.Drawing.Point(4, 4);
            this.cmbPenColor.Name = "cmbPenColor";
            this.cmbPenColor.Size = new System.Drawing.Size(192, 26);
            this.cmbPenColor.TabIndex = 0;
            // 
            // panelControl
            // 
            this.panelControl.AutoSize = true;
            this.panelControl.Controls.Add(this.lblRightTh1);
            this.panelControl.Controls.Add(this.lblLeftTh2);
            this.panelControl.Controls.Add(this.lblLeftPer2);
            this.panelControl.Controls.Add(this.lblLeng);
            this.panelControl.Controls.Add(this.lblRightPer1);
            this.panelControl.Controls.Add(this.lblDepthN);
            this.panelControl.Controls.Add(this.trbLeftTh2);
            this.panelControl.Controls.Add(this.trbRightTh1);
            this.panelControl.Controls.Add(this.trbLeftPer2);
            this.panelControl.Controls.Add(this.trbRightPer1);
            this.panelControl.Controls.Add(this.trbLeng);
            this.panelControl.Controls.Add(this.trbDepthN);
            this.panelControl.Location = new System.Drawing.Point(528, 3);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(260, 445);
            this.panelControl.TabIndex = 1;
            // 
            // lblRightTh1
            // 
            this.lblRightTh1.AutoSize = true;
            this.lblRightTh1.Location = new System.Drawing.Point(5, 293);
            this.lblRightTh1.Name = "lblRightTh1";
            this.lblRightTh1.Size = new System.Drawing.Size(98, 18);
            this.lblRightTh1.TabIndex = 17;
            this.lblRightTh1.Text = "右分支角度";
            this.lblRightTh1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLeftTh2
            // 
            this.lblLeftTh2.AutoSize = true;
            this.lblLeftTh2.Location = new System.Drawing.Point(5, 368);
            this.lblLeftTh2.Name = "lblLeftTh2";
            this.lblLeftTh2.Size = new System.Drawing.Size(98, 18);
            this.lblLeftTh2.TabIndex = 16;
            this.lblLeftTh2.Text = "左分支角度";
            this.lblLeftTh2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLeftPer2
            // 
            this.lblLeftPer2.AutoSize = true;
            this.lblLeftPer2.Location = new System.Drawing.Point(5, 218);
            this.lblLeftPer2.Name = "lblLeftPer2";
            this.lblLeftPer2.Size = new System.Drawing.Size(116, 18);
            this.lblLeftPer2.TabIndex = 15;
            this.lblLeftPer2.Text = "左长度分支比";
            this.lblLeftPer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLeng
            // 
            this.lblLeng.AutoSize = true;
            this.lblLeng.Location = new System.Drawing.Point(5, 79);
            this.lblLeng.Name = "lblLeng";
            this.lblLeng.Size = new System.Drawing.Size(80, 18);
            this.lblLeng.TabIndex = 14;
            this.lblLeng.Text = "主干长度";
            // 
            // lblRightPer1
            // 
            this.lblRightPer1.AutoSize = true;
            this.lblRightPer1.Location = new System.Drawing.Point(5, 143);
            this.lblRightPer1.Name = "lblRightPer1";
            this.lblRightPer1.Size = new System.Drawing.Size(116, 18);
            this.lblRightPer1.TabIndex = 13;
            this.lblRightPer1.Text = "右长度分支比";
            this.lblRightPer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepthN
            // 
            this.lblDepthN.AutoSize = true;
            this.lblDepthN.Location = new System.Drawing.Point(5, 12);
            this.lblDepthN.Name = "lblDepthN";
            this.lblDepthN.Size = new System.Drawing.Size(80, 18);
            this.lblDepthN.TabIndex = 12;
            this.lblDepthN.Text = "递归深度";
            // 
            // trbLeftTh2
            // 
            this.trbLeftTh2.Location = new System.Drawing.Point(125, 370);
            this.trbLeftTh2.Maximum = 60;
            this.trbLeftTh2.Minimum = 10;
            this.trbLeftTh2.Name = "trbLeftTh2";
            this.trbLeftTh2.Size = new System.Drawing.Size(131, 69);
            this.trbLeftTh2.TabIndex = 11;
            this.trbLeftTh2.Value = 20;
            this.trbLeftTh2.Scroll += new System.EventHandler(this.trbLeftTh2_Scroll);
            // 
            // trbRightTh1
            // 
            this.trbRightTh1.Location = new System.Drawing.Point(125, 295);
            this.trbRightTh1.Maximum = 60;
            this.trbRightTh1.Minimum = 10;
            this.trbRightTh1.Name = "trbRightTh1";
            this.trbRightTh1.Size = new System.Drawing.Size(131, 69);
            this.trbRightTh1.TabIndex = 7;
            this.trbRightTh1.Value = 30;
            this.trbRightTh1.Scroll += new System.EventHandler(this.trbRightTh1_Scroll);
            // 
            // trbLeftPer2
            // 
            this.trbLeftPer2.LargeChange = 1;
            this.trbLeftPer2.Location = new System.Drawing.Point(125, 220);
            this.trbLeftPer2.Maximum = 7;
            this.trbLeftPer2.Minimum = 2;
            this.trbLeftPer2.Name = "trbLeftPer2";
            this.trbLeftPer2.Size = new System.Drawing.Size(131, 69);
            this.trbLeftPer2.TabIndex = 10;
            this.trbLeftPer2.Value = 5;
            this.trbLeftPer2.Scroll += new System.EventHandler(this.trbLeftPer2_Scroll);
            // 
            // trbRightPer1
            // 
            this.trbRightPer1.LargeChange = 1;
            this.trbRightPer1.Location = new System.Drawing.Point(125, 145);
            this.trbRightPer1.Maximum = 7;
            this.trbRightPer1.Minimum = 2;
            this.trbRightPer1.Name = "trbRightPer1";
            this.trbRightPer1.Size = new System.Drawing.Size(131, 69);
            this.trbRightPer1.TabIndex = 9;
            this.trbRightPer1.Value = 5;
            this.trbRightPer1.Scroll += new System.EventHandler(this.trbRightPer1_Scroll);
            // 
            // trbLeng
            // 
            this.trbLeng.Location = new System.Drawing.Point(125, 70);
            this.trbLeng.Maximum = 110;
            this.trbLeng.Minimum = 80;
            this.trbLeng.Name = "trbLeng";
            this.trbLeng.Size = new System.Drawing.Size(131, 69);
            this.trbLeng.TabIndex = 8;
            this.trbLeng.Value = 100;
            this.trbLeng.Scroll += new System.EventHandler(this.trbLeng_Scroll);
            // 
            // trbDepthN
            // 
            this.trbDepthN.LargeChange = 3;
            this.trbDepthN.Location = new System.Drawing.Point(125, 7);
            this.trbDepthN.Maximum = 15;
            this.trbDepthN.Minimum = 5;
            this.trbDepthN.Name = "trbDepthN";
            this.trbDepthN.Size = new System.Drawing.Size(131, 69);
            this.trbDepthN.TabIndex = 6;
            this.trbDepthN.Value = 10;
            this.trbDepthN.Scroll += new System.EventHandler(this.trbDepthN_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelCayleyTree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelCayleyTree.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbLeftTh2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRightTh1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLeftPer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRightPer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLeng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbDepthN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCayleyTree;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.ComboBox cmbPenColor;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.TrackBar trbLeftTh2;
        private System.Windows.Forms.TrackBar trbRightTh1;
        private System.Windows.Forms.TrackBar trbLeftPer2;
        private System.Windows.Forms.TrackBar trbRightPer1;
        private System.Windows.Forms.TrackBar trbLeng;
        private System.Windows.Forms.TrackBar trbDepthN;
        private System.Windows.Forms.Label lblDepthN;
        private System.Windows.Forms.Label lblRightTh1;
        private System.Windows.Forms.Label lblLeftTh2;
        private System.Windows.Forms.Label lblLeftPer2;
        private System.Windows.Forms.Label lblLeng;
        private System.Windows.Forms.Label lblRightPer1;
    }
}


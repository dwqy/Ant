using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_9switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //1雪碧2可乐3红牛4矿泉水
        private void btnBuy_Click(object sender, EventArgs e)
        {
            /*
             * 
             * switch使用场景，固定的值
             * 
             * if 用于范围值
             * 
             * 
             * 
             */
            int a = Convert.ToInt32(textBox1.Text);//这里不转也可以使用string类型
            switch (a)
            {
                case 1:
                    MessageBox.Show("购买雪碧成功");
                    break;
                case 2:
                    MessageBox.Show("购买可乐成功");
                    break;
                case 3:
                    MessageBox.Show("购买红牛成功");
                    break;
                case 4:
                    MessageBox.Show("购买矿泉水成功");
                    break;
                default:
                    MessageBox.Show("输入有误");
                    break;
            }
            textBox1.Text = "";



            #region MyRegion

            #endregion
        }
    }
}

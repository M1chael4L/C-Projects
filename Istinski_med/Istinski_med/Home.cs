using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Istinski_med
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>();
        double total_price = 0;
        int sum = 0;
        double wallet = 100;
        int c1,c2,c3,c4,c5,c6 = 1;
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            string items=string.Join("\n", list)+"\n"+"Обща сметка: "+$"{total_price:F2}"+"лв.";
            DialogResult dialogResult = MessageBox.Show(items,"Продукти");
            if (dialogResult == DialogResult.OK)
            {
                if (total_price > wallet)
                {
                    MessageBox.Show("Нямаш достатъчно пари!", "Грешка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    sum = 0;
                    list.Clear();
                    label1.Text = Convert.ToString(sum);
                    total_price = 0;
                }
                wallet -= total_price;
                label13.Text = $"Протфейл: "+$"{wallet:F2}" + "лв.";
                sum = 0;
                list.Clear();
                label1.Text = Convert.ToString(sum);
                total_price = 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            total_price += 12.7;
            sum++;
            label1.Text = Convert.ToString(sum);
            if (list.Contains("1xПлодомед с ягода"))
            {
                c1++;
                list.Remove("1xПлодомед с ягода");
                list.Add(Convert.ToString(c1) + "xПлодомед с ягода");
            }
            else
            {
                list.Add("1xПлодомед с ягода");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            total_price += 12.7;
            sum++;
            label1.Text = Convert.ToString(sum);
            if (list.Contains("1xПлодомед с малина"))
            {
                c2++;
                list.Remove("1xПлодомед с малина");
                list.Add(Convert.ToString(c2) + "xПлодомед с малина");
            }
            else
            {
                list.Add("1xПлодомед с малина");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            total_price += 16.5;
            sum++;
            label1.Text = Convert.ToString(sum);
            if (list.Contains("1xБио манов мед"))
            {
                c3++;
                list.Remove("1xБио манов мед");
                list.Add(Convert.ToString(c3) + "xБио манов мед");
            }
            else
            {
                list.Add("1xБио манов мед");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            total_price += 15.9;
            sum++;
            label1.Text = Convert.ToString(sum);
            if (list.Contains("1xШокомед"))
            {
                c4++;
                list.Remove("1xШокомед");
                list.Add(Convert.ToString(c4) + "xШокомед");
            }
            else
            {
                list.Add("1xШокомед");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            total_price += 10;
            sum++;
            label1.Text = Convert.ToString(sum);
            if (list.Contains("1x2 буркана мед на цената на 1"))
            {
                c5++;
                list.Remove("1x2 буркана мед на цената на 1");
                list.Add(Convert.ToString(c5) + "x2 буркана мед на цената на 1");
            }
            else
            {
                list.Add("1x2 буркана мед на цената на 1");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            total_price += 12.7;
            sum++;
            label1.Text = Convert.ToString(sum);
            if (list.Contains("1xБио мед с купина"))
            {
                c6++;
                list.Remove("1xБио мед с купина");
                list.Add(Convert.ToString(c6) + "xБио мед с купина");
            }
            else
            {
                list.Add("1xБио мед с купина");
            }
        }
    }
}

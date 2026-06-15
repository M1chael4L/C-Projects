using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Istinski_med
{
    public partial class Contacts : UserControl
    {
        public Contacts()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            if(comboBox1.SelectedItem.ToString()=="Кралицата")
            {
                pictureBox1.Image = Properties.Resources.images_removebg_preview;
                MessageBox.Show("НЕ НАМЕСВАЙ КРАЛИЦАТА!");
                label6.Text = "Тя е наша!";
            }
            else 
            {
                pictureBox1.Image = Properties.Resources.images_removebg_preview;
                label6.Text = "Аз не разбирам от тези неща.";
            }
            button1.Enabled = false;
        }
    }
}

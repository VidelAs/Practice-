using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anch_dock_pro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = DateTime.Now.ToString("HH:mm:ss");


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.textBox1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.time_label.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void first_num_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            Int64.TryParse(this.first_num.Text, out i);
            this.resultad.Text = i.ToString("#, #");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal i;
            Boolean b;
            b= decimal.TryParse(textBox2.Text, out i);
            if (b==true)
            {
                MessageBox.Show("This is Number");
            }
            else
            {
                MessageBox.Show("This is not Number");
            }
            
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are you sure?", "Alert", MessageBoxButtons.YesNo)==DialogResult.Yes) {
                this.Close();
            }
           
        }
    }
}

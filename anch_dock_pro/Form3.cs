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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.len_textBox.Text= this.String_textBox.Text.Length.ToString();
        }

        private void String_textBox_TextChanged(object sender, EventArgs e)
        {
            string t;
            t=this.String_textBox.Text;
            this.len_textBox.Text = t.Length.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.birth_date.Text = this.birth_date.Text.Substring(0, 2);
            this.birtT_month.Text=this.birth_date.Text.Substring(3,2);
            //this.birth_year.Text=this.birth_day.Text.Substring(6,4);
            Int64 i;
            i = this.birth_day.Text.Length;
            this.birth_year.Text = this.birth_date.Text.Substring(i-4, 4);

        }
    }
}

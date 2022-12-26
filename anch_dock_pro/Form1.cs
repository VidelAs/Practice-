namespace anch_dock_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 h;
            h = this.Size.Height;
            this.Size = new Size(750, 450);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(610, 390);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Size=new Size(this.pictureBox1.Width+10, this.pictureBox1.Height+ 10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Size = new Size(this.pictureBox1.Width - 10, this.pictureBox1.Height - 10);
        }
    }
}
namespace cs0530
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;
            if (label1.Left <= 0)
            {
                vx = -vx;
            }else if (label1.Top <= 0)
            {
                vy = -vy;
            }
            else if (label1.Left >= 763)
            {
                vx = -vx;
            }
            else if (label1.Top >= 435)
            {
                vy = -vy;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

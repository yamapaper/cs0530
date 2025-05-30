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
                vx = Math.Abs(vx);
            }
            else if (label1.Top <= 0)
            {
                vy = Math.Abs(vy); ;
            }
            else if (label1.Left >= ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }
            else if (label1.Top >= ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }

            if (vx >= 0 && vy >= 0)
            {
                label1.ForeColor = Color.Green;
            }
            else if (vx <= 0 && vy <= 0)
            {
                label1.ForeColor = Color.Red;
            }
            else
            {
                label1.ForeColor = Color.Blue;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

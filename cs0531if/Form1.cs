namespace cs0531if
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0)
            {
                vx = -vx;
            }

            if (label1.Top < 0)
            {
                vy = -vy;
            }

            if (label1.Left > 710)
            {
                vx = -vx;
            }

            if (label1.Top > 410)
            {
                vy = -vy;
            }
        }
    }
}
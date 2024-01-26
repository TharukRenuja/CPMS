namespace CPMS
{
    public partial class splashScr : Form
    {
        public splashScr()
        {
            InitializeComponent();
        }

        private void splashScr_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 3;

            if (panel1.Width >= 699)
            {
                SLoadTimer.Stop();
                this.Hide();
                Home home = new Home();
                home.Show();
            }
        }
    }
}

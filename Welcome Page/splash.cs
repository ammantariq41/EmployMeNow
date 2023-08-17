using System;
using System.Windows.Forms;

namespace Welcome_Page
{
    public partial class splash : Form
    {
        private Timer transitionTimer;
        public splash()
        {
            InitializeComponent();

            transitionTimer = new Timer();
            transitionTimer.Interval = 2000; 
            transitionTimer.Tick += new EventHandler(timer2_Tick);

            transitionTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(5);
            if (progressBar1.Value == 100 ) {

               timer1.Stop();
            
            }
       
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            transitionTimer.Stop();
            Welcome welcome = new Welcome();
            welcome.Show();

            this.Hide();


        }
    }
}

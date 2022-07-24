using System.Diagnostics;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        private Stopwatch stopWatch;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
        }
       

        private void startBTN_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        private void stopBTN_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        private void restartBTN_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label2.Text = String.Format("{0:hh\\:mm\\:ss\\:fff}", stopWatch.Elapsed);
        }
    }
}
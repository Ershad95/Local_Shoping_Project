using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Loading : Form
    {

        
        public Loading()
        {
            InitializeComponent();
        }

        private void circularProgress1_ValueChanged(object sender, EventArgs e)
        {
          

        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer_load.Enabled = true;
            timer_load.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loading_progress.Value += 2;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Loading_progress.Value += 10;
            if(Loading_progress.Value >30 && Loading_progress.Value<52)
            {
                Loading_progress.ProgressColor = Color.DarkOrange;
                Loading_progress.ProgressTextColor = Color.DarkOrange;
            }
            else if(Loading_progress.Value>50 && Loading_progress.Value < 80)
            {
                Loading_progress.ProgressColor = Color.LimeGreen;
                Loading_progress.ProgressTextColor = Color.LimeGreen;
            }
            else if (Loading_progress.Value > 90 && Loading_progress.Value <101)
            {
                Loading_progress.ProgressColor = Color.DarkGreen;
                Loading_progress.ProgressTextColor = Color.DarkGreen;
            }
            if(Loading_progress.Value==100)
            {

                timer_load.Enabled = false;
                timer_load.Stop();
                this.Close();
            }
        }
    }
}

using Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Globalization;


namespace shoping_project
{
    public partial class Splash : Form
    {
        Thread t;

        public Splash()
        {
            InitializeComponent();
            circularProgress1.IsRunning = true;
            circularProgress1.FocusCuesEnabled = false;
            t = new Thread(new ThreadStart(Speaking));
            t.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Step = 1;
            if (progressBar1.Value < 10)
            {
                progressBar1.Value += 20;
            }
            if (progressBar1.Value >= 20)
            {
                progressBar1.Value += 18;
            }

            if (progressBar1.Value > 80)
            {
                timer1.Enabled = false;

                progressBar1.Value = 0;
                progressBar1.Enabled = false;
                if (Presentation.Properties.Settings.Default.s == false)
                {
                    Splash.ActiveForm.Hide();
                    (new Specification()).ShowDialog();
                }
                else if (Presentation.Properties.Settings.Default.s == true)
                {
                    Splash.ActiveForm.Hide();
                    (new Authentication()).ShowDialog();
                }
            }
        }

        private void Speaking()
        {
            SpeechSynthesizer sp = new SpeechSynthesizer();
            sp.Speak("Hello , Welcome to Digital Store Application , Programmer : Ershad");
        }
    }
}

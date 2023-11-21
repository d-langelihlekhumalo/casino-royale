using CasinoRoyale.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasinoRoyale
{
    public partial class SplashScreen : Form
    {
        // Declare gloabl variables
        string title;
        int titleLength;
        int counter;

        public SplashScreen()
        {
            InitializeComponent();
            // Create round corners
            Region = Region.FromHrgn(CommonControls.CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            // Set form style
            CommonControls.FormStyle(this);
            // Initialize global variables
            title = lblTitle.Text;
            titleLength = title.Length;
            counter = 0;
            // Set progressbar value to 0
            cirProgressBar.Value = 0;
            // Enable timerHandleAnimations
            timerHandleAnimations.Enabled = true;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void timerHandleAnimations_Tick(object sender, EventArgs e)
        {
            if (Opacity < 90)
                CommonControls.FadeInEffect(this);

            // Animate title
            if (counter <= titleLength)
                AnimateTitle();
            // Set timer interval to 200, speed up process
            timerHandleAnimations.Interval = 200;
            if (cirProgressBar.Value < 100)
            {
                cirProgressBar.Value += 1;
                cirProgressBar.Text = cirProgressBar.Value.ToString() + "%";
            } else
            {
                // Fade out form, then change to main menu
                if (Opacity > 0)
                    CommonControls.FadeOutEffect(this);
                timerChangeForms.Enabled = true;
            }
        }

        private void AnimateTitle()
        {
            // Animate the application title
            lblTitle.Text = title.Substring(0, counter);
            ++counter;
        }

        private void timerChangeForms_Tick(object sender, EventArgs e)
        {
            timerHandleAnimations.Enabled = false;
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            timerChangeForms.Enabled = false;
        }

        private void timerFadeOut_Tick(object sender, EventArgs e)
        {
            // Fade out form, then change to main menu
            if (Opacity > 0)
                CommonControls.FadeOutEffect(this);
            timerExit.Enabled = true;
        }

        private void picBoxExit_Click(object sender, EventArgs e)
        {
            timerHandleAnimations.Enabled = false;
            timerChangeForms.Enabled = false;
            timerFadeOut.Enabled = true;
        }

        private void timerExit_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

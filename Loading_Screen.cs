using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeoulHacks2020Application
{
    public partial class Loading_Screen : Form
    {
        private static List<string> loadingStrings = new List<string>();

        public int Number { get; set; }

        private static int number = 0;

        int num = 0;
        public Loading_Screen()
        {
            InitializeComponent();
            timer1.Start();
            loadingStrings.Add("Importing Assets..");
            loadingStrings.Add("Cleaning up code..");
            loadingStrings.Add("Injecting Dependencies..");
            loadingStrings.Add("Tweaking Designs..");
            loadingStrings.Add("Polishing the application..");
            loadingStrings.Add("Generating terrain...");
            loadingStrings.Add("Entering cheat codes");
            loadingStrings.Add("l o a d i n g a e s t h e t i c s");
            loadingStrings.Add("PK Load Ω");
            loadingStrings.Add("Is this thing on..?");
            loadingStrings.Add("Insert Coin to Continue");

            loadingStrings.Add("Ready to go!");
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            loadingLabel.Width = loadingLabel.Width + 5;
            Random random = new Random();
            number = random.Next(0, 10);
            
            loadingText.Text = loadingStrings[number];

            if (loadingLabel.Width >= 675)
            {
                loadingText.Text = loadingStrings[11];
                timer1.Stop();
                LoadingScreenFunctionality();
            }
        }

        public void LoadingScreenFunctionality()
        {
            switch (Number)
            {

                case 1:
                    var loadingScreen = new Loading_Screen();
                    loadingScreen.ShowDialog();
                    loadingScreen.Close();
                    var signUpForm = new NewUserForm();
                    signUpForm.Show();
                    break;
                case 2:
                    this.Hide();
                    var logInForm = new Login_Form();
                    logInForm.Show();
                    break;
                case 3:
                    this.Hide();
                    var mainPage = new Dashboard();
                    mainPage.Show();
                    break;
                case 4:
                    this.Hide();
                    var musicPlayer = new MusicPlayer();
                    musicPlayer.Show();
                    break;
                case 5:
                    this.Hide();
                    var videoNotes = new VoiceNotes();
                    videoNotes.Show();
                    break;
            }
        }

    }
}

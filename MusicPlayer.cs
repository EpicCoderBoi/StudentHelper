using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpotifyAPI.Web;

namespace SeoulHacks2020Application
{
    public partial class MusicPlayer : Form
    {
        private Boolean mouseDown;

        private static int mousex;

        private static int mousey;

        private static string musicName = "";

        private static  OpenFileDialog fileDialog = new OpenFileDialog();

        private static Loading_Screen loadingManager = new Loading_Screen();
        public MusicPlayer()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            playButton.Visible = false;
            pauseButton.Visible = true;

            animatedCD.Visible = true;
            staticCD.Visible = false;

            axWindowsMediaPlayer1.URL = fileDialog.FileName;
            axWindowsMediaPlayer1.Ctlcontrols.play();

            musicName = fileDialog.FileName.ToString();

            musicInformation.Text = musicName;
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            playButton.Visible = true;
            pauseButton.Visible = false;

            animatedCD.Visible = false;
            staticCD.Visible = true;

            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                mousex = MousePosition.X - 333;

                mousey = MousePosition.Y - 8;

                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            mouseDown = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
        }

        private void musicLength_Scroll(object sender, EventArgs e)
        {
            musicLength.Maximum = (int)axWindowsMediaPlayer1.currentMedia.duration;
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = musicLength.Value;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Dashboard mainPage = new Dashboard();
            mainPage.Show();

            Visible = false;
        }

        private void informationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The main purpose of this tool is to let you play music from your local laptop");
            MessageBox.Show("Use this app to listen to podcasts/lectures that your teachers have sent you, or do listening comprehensions exercises from your desired foreign language");
        }
    }
}

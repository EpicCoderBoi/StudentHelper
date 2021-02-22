using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace SeoulHacks2020Application
{
    public partial class Dashboard : Form
    {
        private Boolean mouseDown;

        private int mousex;

        private int mousey;

        public Login_Form loginFormInformation;

        public Dashboard()
        {
            InitializeComponent();
            //SetText();
            loginFormInformation = new Login_Form();
            dashboardName.Text = "Hello " + loginFormInformation.Username;
        }

        public void SetText()
        {
            dashboardName.Text += loginFormInformation.Username;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                mousex = MousePosition.X - 333;

                mousey = MousePosition.Y - 8;

                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void enterMusicPlayer_Click(object sender, EventArgs e)
        {
            var musicPlayerForm = new MusicPlayer();
            musicPlayerForm.Show();
            Visible = false;
        }

        private void enterVoiceNotes_Click(object sender, EventArgs e)
        {
            var videoNotes = new VoiceNotes();
            videoNotes.Show();
            Visible = false;

        }

        private void enterVideoLearner_Click(object sender, EventArgs e)
        {
            var videoLearn = new VideoLearn();
            videoLearn.Show();
            Visible = false;
        }

        private void enterToDoApp_Click(object sender, EventArgs e)
        {
            Flashcard flashCard = new Flashcard();
            flashCard.Show();

            Visible = false;
        }
    }
}

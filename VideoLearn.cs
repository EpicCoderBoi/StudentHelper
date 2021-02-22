using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeoulHacks2020Application
{
    public partial class VideoLearn : Form
    {
        SQLHelper sqlHelper = new SQLHelper();

        private Boolean mouseDown;

        private int mousex;

        private int mousey;

        private static string url = "";
        public VideoLearn()
        {
            InitializeComponent();
            sqlHelper.ConnectToSQLDatabase();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            url = urlText.Text.ToString();
            Console.WriteLine(url);
            axVLCPlugin21.playlist.add(@url);
            Console.WriteLine(axVLCPlugin21.playlist); 
            axVLCPlugin21.playlist.play();
            if (!url.Contains("youtube.com"))
            {
                MessageBox.Show("Please check if your video is from youtube");
            }
            
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void resetVideo_Click(object sender, EventArgs e)
        {
            url = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.next();
            axVLCPlugin21.playlist.play();
        }

        private void InsertData()
        {
            sqlHelper.SqlConnection = new SqlConnection(sqlHelper.ConnectionSQLString);

            string insertNote = "INSERT into VideoNotesLearn (vidNotes) VALUES (@vidNotes)";

            sqlHelper.SqlConnection.Open();

            var insertData = new SqlCommand(insertNote, sqlHelper.SqlConnection);

            insertData.Parameters.AddWithValue("@vidNotes", notePadVideo.Text);

            insertData.ExecuteNonQuery();

            MessageBox.Show("Note stored successfully!");

            sqlHelper.SqlConnection.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void informationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The purpose of this application is to comfortably watch YouTube videos whilst taking notes");
            MessageBox.Show("When you first enter a video, then you can just enter the video link on the url search bar and then press the go button");
            MessageBox.Show("If you want to watch multiple videos at once. Then you should first paste your desired YouTube link, click reset, go and play in that order");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Dashboard mainPage = new Dashboard();
            mainPage.Show();
            Visible = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                mousex = MousePosition.X - 158;
                mousey = MousePosition.Y - 2;

                this.SetDesktopLocation(mousex, mousey);
            }

        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            mouseDown = false;
        }
    }
}

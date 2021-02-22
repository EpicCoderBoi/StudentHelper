using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Data.Sql;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace SeoulHacks2020Application
{
    public partial class VoiceNotes : Form
    {
        SpeechRecognitionEngine speechRecognition = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));

        SQLHelper sqlHelper = new SQLHelper();

        private Boolean mouseDown;

        private int mousex;

        private int mousey;

        public VoiceNotes()
        {
            InitializeComponent();
            sqlHelper.ConnectToSQLDatabase();
            outputtedText.ReadOnly = true;
        }

        
        private void InitializeMicrophone()
        {
            Choices reader = new Choices(File.ReadAllLines(@"C:\Users\Admin\Desktop\test2.txt"));
            GrammarBuilder grammarBuilder = new GrammarBuilder();
            grammarBuilder.Append(reader);
            Grammar grammar = new Grammar(grammarBuilder);
            speechRecognition.SetInputToDefaultAudioDevice();
            speechRecognition.LoadGrammarAsync(grammar);
            
            speechRecognition.RecognizeAsync(RecognizeMode.Multiple);
            speechRecognition.SpeechRecognized += speechRecognition_SpeechRecognized;
        }

        void speechRecognition_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            outputtedText.AppendText(e.Result.Text.ToString() + " ");

            string convertedString = e.Result.Text;

            string text = outputtedText.Text;

            switch (convertedString)
            {
                case ("clear"):
                    outputtedText.Text = "";
                    break;
            }
        }

        private void stillMicrophone_Click(object sender, EventArgs e)
        {
            stillMicrophone.Visible = false;
            animatedMicrophone.Visible = true;
            InitializeMicrophone();
        }

        private void animatedMicrophone_Click(object sender, EventArgs e)
        {
            stillMicrophone.Visible = true;
            animatedMicrophone.Visible = false;
        }

        private void InsertData()
        {
            sqlHelper.SqlConnection = new SqlConnection(sqlHelper.ConnectionSQLString);

            string insertNote = "INSERT into VoiceNotesData (notes) VALUES (@notes)";

            sqlHelper.SqlConnection.Open();

            var insertData = new SqlCommand(insertNote, sqlHelper.SqlConnection);

            insertData.Parameters.AddWithValue("@notes", outputtedText.Text);

            insertData.ExecuteNonQuery();

            MessageBox.Show("Note stored successfully!");

            sqlHelper.SqlConnection.Close();
        }
        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void saveNote_Click(object sender, EventArgs e)
        {
            InsertData();
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Dashboard mainPage = new Dashboard();

            mainPage.Show();

            Visible = false;
        }

        private void informationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The purpose of this tool is to utilize your voice to record notes which you can store in a database");
            MessageBox.Show("To record a note, simply click the microphone which will then play an animation to let you know that it's recording");
            MessageBox.Show("IMPORTANT! => This application is not stable. Speech Recognition is a technology which requires a lot of data to be trained and often strays away from the intended word/phrase you were trying to say");
        }
    }
}


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
    public partial class Flashcard : Form
    {
        SQLHelper sqlHelper = new SQLHelper();

        private Boolean mouseDown;

        private int mousex;

        private int mousey;
        public Flashcard()
        {
            InitializeComponent();
            sqlHelper.ConnectToSQLDatabase();
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void InsertData()
        {
            sqlHelper.SqlConnection = new SqlConnection(sqlHelper.ConnectionSQLString);

            string insertNote = "INSERT into FlashcardNotes (flashcardTerm, flashcardDefinition) VALUES (@flashcardTerm, @flashcardDefinition)";

            sqlHelper.SqlConnection.Open();

            var insertData = new SqlCommand(insertNote, sqlHelper.SqlConnection);

            insertData.Parameters.AddWithValue("@flashcardTerm", FlashcardTerm.Text);

            insertData.Parameters.AddWithValue("@flashcardDefinition", FlashcardDefinition.Text);

            insertData.ExecuteNonQuery();

            MessageBox.Show("Term and Definition stored successfully!");

            sqlHelper.SqlConnection.Close();
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

        private void informationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The purpose of this tool is to allow you to memorise key words faster.");
            MessageBox.Show("This tool closely mimicks the flashcards from Quizlet, however the main difference is that the key term and the definition are placed alongside each other");
            MessageBox.Show("Use this tool to take digitalized Cornell notes, or to write down words which need to be memorised");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

/* Sujash Barman 2020 
 * Used some help from the YouTube Video - https://www.youtube.com/watch?v=en_eqatpDEo&ab_channel=RJCodeAdvance
 * And also some help with - https://www.youtube.com/watch?v=_PCBTiXL884&ab_channel=SeeSharpCode
 * 30th of October
 */
namespace SeoulHacks2020Application
{
    public partial class NewUserForm : Form
    {
        SQLHelper sqlReference = new SQLHelper();

        public NewUserForm()
        {
            InitializeComponent();
            sqlReference.ConnectToSQLDatabase();
        }

        private Boolean mouseDown;

        private int mousex;

        private int mousey;

        private void userName_Enter_1(object sender, EventArgs e)
        {
            if (userName.Text == "Username/Email")
            {
                userName.Text = "";
                userName.ForeColor = Color.DarkGray;
            }
        }

        private void userName_Leave(object sender, EventArgs e)
        {
            if (userName.Text == "")
            {
                userName.Text = "Username/Email";
                userName.ForeColor = Color.DarkGray;
            }
        }

        private void passwordField_Enter(object sender, EventArgs e)
        {
            if (passwordField.Text == "Password")
            {
                passwordField.Text = "";
                passwordField.ForeColor = Color.DarkGray;
            }
        }

        private void passwordField_Leave(object sender, EventArgs e)
        {
            if (passwordField.Text == "")
            {
                passwordField.Text = "Password";
                passwordField.ForeColor = Color.DarkGray;
            }
        }

        private void StoreUsernameAndPassword()
        {
            string insertUsername = "INSERT INTO UserDetails (Username,Password) VALUES (@Username,@Password)";

            sqlReference.SqlConnection = new SqlConnection(sqlReference.ConnectionSQLString);

            var insertData = new SqlCommand(insertUsername, sqlReference.SqlConnection);
            
            sqlReference.SqlConnection.Open();

            insertData.Parameters.AddWithValue("@Username", userName.Text);
            insertData.Parameters.AddWithValue("@Password", passwordField.Text);
            insertData.ExecuteNonQuery();

            sqlReference.SqlConnection.Close();
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            StoreUsernameAndPassword();
            MessageBox.Show("User Added Successfully!");
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_Form loginForm = new Login_Form();
            loginForm.Visible = true;

            Visible = false;

        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            mouseDown = false;
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                mousex = MousePosition.X - 158;
                mousey = MousePosition.Y - 2;

                this.SetDesktopLocation(mousex, mousey);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SeoulHacks2020Application
{
    public partial class Login_Form : Form
    {
        SQLHelper sqlHelper = new SQLHelper();

        private Boolean mouseDown;

        private int mousex;

        private int mousey;

        public string Username { get; set; } = "";
           
        public Login_Form()
        {
            InitializeComponent();
            sqlHelper.ConnectToSQLDatabase();
        }

        private void linkToAddUser_Click(object sender, EventArgs e)
        {
            NewUserForm formAddNewUser = new NewUserForm();
            formAddNewUser.Visible = true;

            Visible = false;
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginMainForm_Click(object sender, EventArgs e)
        {
            sqlHelper.SqlConnection = new SqlConnection(sqlHelper.ConnectionSQLString);

            string query = "SELECT * FROM UserDetails WHERE Username = '" + usernameLogin.Text.Trim() + "' and Password = '" + passwordLogin.Text.Trim() + "'";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlHelper.SqlConnection);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            if(dataTable.Rows.Count == 1)
            {
                Dashboard dashboard = new Dashboard();
                Visible = false;
                dashboard.Show();
            } else
            {
                MessageBox.Show("Invalid username/password. Try again");
            }

            Username = usernameLogin.Text;

            Console.WriteLine(Username);

        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            mouseDown = false;
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                mousex = MousePosition.X - 177;
                mousey = MousePosition.Y - 1;

                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void usernameLogin_Enter(object sender, EventArgs e)
        {

        }

        private void usernameLogin_Leave(object sender, EventArgs e)
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeoulHacks2020Application
{
    public partial class WelcomeForm : Form
    {
        private Boolean mouseDown;

        private int mousex;

        private int mousey;

        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            NewUserForm newUserForm = new NewUserForm();
            newUserForm.Show();

            Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            NewUserForm newUserForm = new NewUserForm();
            newUserForm.Show();

            Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login_Form loginForm = new Login_Form();
            loginForm.Show();

            Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login_Form loginForm = new Login_Form();
            loginForm.Show();

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

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            mouseDown = false;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
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

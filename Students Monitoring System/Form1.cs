using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students_Monitoring_System
{
    public partial class LoginForm : Form
    {
        private int mov, movX, movY;
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.MinimumSize = new Size(650, 400);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.ControlBox = false;
            this.Text = String.Empty;
            DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            txtPassword.UseSystemPasswordChar = false;
            isValidCredentials.Text = "";
            forgotPassword.Location = new Point(85, 133);
        }

        // Code to Resize Borderless Form
        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;

        const int a = 10;

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, a); } }
        Rectangle Left { get { return new Rectangle(0, 0, a, this.ClientSize.Height); } }

        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - a, this.ClientSize.Width, a); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - a, 0, a, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, a, a); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - a, 0, a, a); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - a, a, a); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - a, this.ClientSize.Height - a, a, a); } }


        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        } // End of Resize Code

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email:";
            }
            if (txtPassword.Text == "")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Password:";
            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email:")
            {
                txtEmail.Text = "";
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email:")
            {
                txtEmail.Text = "";
            }
        }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtEmail.Text == "admin" && txtPassword.Text == "admin")
            {
                isValidCredentials.Location = new Point(51, 116);
                forgotPassword.Location = new Point(85, 143);
                isValidCredentials.Text = "Wrong Login Credentials !!!";
            }
            else
            {
                forgotPassword.Location = new Point(85, 133);
                isValidCredentials.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email:";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password:")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "";
            }
            else
            {
                if (showPassword.Checked == true)
                {
                    txtPassword.UseSystemPasswordChar = false;
                }
                else
                {
                    txtPassword.UseSystemPasswordChar = true;
                }
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtEmail.Text == "admin" && txtPassword.Text == "admin")
            {
                isValidCredentials.Location = new Point(51, 116);
                forgotPassword.Location = new Point(85, 143);
                isValidCredentials.Text = "Wrong Login Credentials !!!";
            }
            else
            {
                forgotPassword.Location = new Point(85, 133);
                isValidCredentials.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Password:";
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            if (showPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void forgotPassword_MouseEnter(object sender, EventArgs e)
        {
            forgotPassword.ForeColor = System.Drawing.Color.Silver;
        }

        private void forgotPassword_MouseLeave(object sender, EventArgs e)
        {
            forgotPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
    }
}

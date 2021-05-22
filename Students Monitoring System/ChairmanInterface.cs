using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Students_Monitoring_System
{
    public partial class ChairmanInterface : Form
    {
        private Form activeForm = null;
        public ChairmanInterface()
        {
            InitializeComponent();
            hideSubMenu();
            sessionSelectingPanel.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void hideSubMenu()
        {
            teachersSubMenuPanel.Visible = false;
            activitiesInchargeSubMenuPanel.Visible = false;
            medicalStaffSubMenuPanel.Visible = false;
            institutionAdvisorSubMenuPanel.Visible = false;
            studentsSubMenuPanel.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void teachersBtn_Click(object sender, EventArgs e)
        {
            teachersSubMenuPanel.AutoScroll = true;
            showSubMenu(teachersSubMenuPanel);
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            dashboardPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(sessionSelectingPanel.Visible == false)
            {
                if(activeForm != null)
                {
                    activeForm.Close();
                }
                sessionTeacherFileOkayBtn.Visible = false;
                sessionTeacherOkayBtn.Visible = true;
                sessionSelectingPanel.Visible = true;
            }
        }

        private void activitiesInachrgeBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(activitiesInchargeSubMenuPanel);
        }

        private void medicalStaffBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(medicalStaffSubMenuPanel);
        }

        private void institutionAdvisorBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(institutionAdvisorSubMenuPanel);
        }

        private void studentsBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(studentsSubMenuPanel);
        }

        private void sessionOkayBtn_Click(object sender, EventArgs e)
        {
            if(sessionCombobox.Text != "" || sessionSemesterCombobox.Text != "")
            {
                sessionSelectingPanel.Visible = false;
                openChildForm(new MembersCommonForm());
            }
        }

        private void uploadTeacherBtn_Click(object sender, EventArgs e)
        {
            sessionSelectingPanel.Visible = false;
            if (sessionSelectingPanel.Visible == false)
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                }
                sessionTeacherFileOkayBtn.Visible = true;
                sessionTeacherOkayBtn.Visible = false;
                sessionSelectingPanel.Visible = true;
            }
        }

        private void sessionTeacherFileOkayBtn_Click(object sender, EventArgs e)
        {
            if (sessionCombobox.Text != "" || sessionSemesterCombobox.Text != "")
            {
                sessionSelectingPanel.Visible = false;
                openChildForm(new UploadMembersFileForm());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MembersCommonForm f = new MembersCommonForm("Change Form");
            openChildForm(f);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UploadMembersFileForm f = new UploadMembersFileForm("Change Button");
            openChildForm(f);
        }

        private void manageMedicalStaffBtn_Click(object sender, EventArgs e)
        {
            MembersCommonForm f = new MembersCommonForm("Medical Form", 7);
            openChildForm(f);
        }

        private void uploadMedicalStaffBtn_Click(object sender, EventArgs e)
        {
            UploadMembersFileForm f = new UploadMembersFileForm("Medical Form", 9);
            openChildForm(f);
        }

        private void instititutionAdvisorBtn_Click(object sender, EventArgs e)
        {
            MembersCommonForm f = new MembersCommonForm("Institution Advisor Form", 7);
            openChildForm(f);
        }

        private void updateAdvisorsBtn_Click(object sender, EventArgs e)
        {
            UploadMembersFileForm f = new UploadMembersFileForm("Update Advisors", 8, 9);
            openChildForm(f);
        }

        private void viewStudentsBtn_Click(object sender, EventArgs e)
        {
            ViewStudentsForm f = new ViewStudentsForm();
            openChildForm(f);
        }

        private void studentProfileBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new StudentProfileForm());
        }

        private void studentsRecordBtn_Click(object sender, EventArgs e)
        {
            /*this.Visible = false;
            CommonForm f = new CommonForm();
            f.Show();*/
        }

        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {
            if(this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logoPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void dashboardPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}

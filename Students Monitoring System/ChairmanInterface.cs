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
    public partial class ChairmanInterface : Form
    {
        string session = "";
        public ChairmanInterface()
        {
            InitializeComponent();
            customizeDesign();
        }

        public ChairmanInterface(string str)
        {
            session = str;
        }

        private void customizeDesign()
        {
            teachersSubMenuPanel.Visible = false;
            activitiesInchargeSubMenuPanel.Visible = false;
            medicalStaffSubMenuPanel.Visible = false;
            institutionAdvisorSubMenuPanel.Visible = false;
            studentsSubMenuPanel.Visible = false;
        }

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

        private Form activeForm = null;
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
            openChildForm(new SessionSelectingForm());
            MessageBox.Show("I am Back");
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
    }
}

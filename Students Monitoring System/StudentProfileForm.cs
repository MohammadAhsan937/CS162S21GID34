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
    public partial class StudentProfileForm : Form
    {
        public StudentProfileForm()
        {
            InitializeComponent();
            studentProfilePanel.Visible = false;
        }

        private void studentSearchBtn_Click(object sender, EventArgs e)
        {
            if(studentSerachTextbox.Text == "2020-CS-125")
            {
                studentProfilePanel.Visible = true;
            }
        }
    }
}

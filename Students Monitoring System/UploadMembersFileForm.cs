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
    public partial class UploadMembersFileForm : Form
    {
        public UploadMembersFileForm()
        {
            InitializeComponent();
            browseFileLabel.Visible = false;
            TeacherFileOkayBtn.Visible = true;
            teachersFileOkay1Btn.Visible = false;
            teachersFileOkay2Btn.Visible = false;
            teachersFileOkay3Btn.Visible = false;
        }

        public UploadMembersFileForm(string str)
        {
            InitializeComponent();
            browseFileLabel.Visible = false;
            TeacherFileOkayBtn.Visible = false;
            teachersFileOkay1Btn.Visible = true;
            teachersFileOkay2Btn.Visible = false;
            teachersFileOkay3Btn.Visible = false;
        }

        public UploadMembersFileForm(string str, int num)
        {
            InitializeComponent();
            browseFileLabel.Visible = false;
            TeacherFileOkayBtn.Visible = false;
            teachersFileOkay1Btn.Visible = false;
            teachersFileOkay2Btn.Visible = true;
            teachersFileOkay3Btn.Visible = false;
        }

        public UploadMembersFileForm(string str, int num, int a)
        {
            InitializeComponent();
            browseFileLabel.Visible = false;
            TeacherFileOkayBtn.Visible = false;
            teachersFileOkay1Btn.Visible = false;
            teachersFileOkay2Btn.Visible = false;
            teachersFileOkay3Btn.Visible = true;
        }

        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            browseFileLabel.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            browseFileLabel.Visible = false;
        }

        private void teachersFileOkay1Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("teachersFileOkay1Btn_Click");
        }

        private void browseFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            fileNameTextbox.Enabled = false;
            ofd.Filter = "|*.csv";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileNameTextbox.Text = ofd.FileName;
            }
        }

        private void TeacherFileOkayBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TeacherFileOkayBtn_Click");
        }

        private void teachersFileOkay2Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("teachersFileOkay2Btn_Click");
        }

        private void teachersFileOkay3Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("teachersFileOkay3Btn_Click");
        }
    }
}

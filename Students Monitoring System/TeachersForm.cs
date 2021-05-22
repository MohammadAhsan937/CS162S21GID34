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
    public partial class MembersCommonForm : Form
    {
        public MembersCommonForm()
        {
            InitializeComponent();
        }

        public MembersCommonForm(string str)
        {
            InitializeComponent();
            customizeFormForIncharge();
        }

        public MembersCommonForm(string str, int num)
        {
            InitializeComponent();
            customizeFormForMedicalStaff();
        }

        private void customizeFormForIncharge()
        {
            // teachersIdLabel
            teacherIdLabel.Text = "Inchargs's ID:";
            
            // sectionsLabel
            sectionsLabel.Text = "Activities Status";
            
            // sectionsCombobox
            this.sectionsCombobox.Items.AddRange(new object[] {
            "Curricular Activities",
            "Co-Curricular Activities"});

            // subjectsLabel
            subjectsLabel.Text = "Email:";
            this.addMemberTableLayoutPanel.Controls.Add(this.emailTextbox, 3, 8);

            // subjectsCombobox
            subjectsCombobox.Visible = false;
            emailLabel.Text = "Password:";
            this.addMemberTableLayoutPanel.Controls.Add(this.passwordTextbox, 1, 10);
            passwordTextbox.UseSystemPasswordChar = true;

            // passwordLabel
            passwordLabel.Visible = false;

            // save1Btn
            saveBtn.Visible = false;
            save2Btn.Visible = false;
            this.save1Btn = new System.Windows.Forms.Button();
            this.dataSaveTableLayoutPanel.Controls.Add(this.save1Btn, 0, 0);

            // reset1Btn
            resetBtn.Visible = false;
            reset2Btn.Visible = false;
            this.reset1Btn = new System.Windows.Forms.Button();
            this.dataSaveTableLayoutPanel.Controls.Add(this.reset1Btn, 1, 0);

            // memberDataGridView
            this.ID.HeaderText = "Incharge's ID";
            this.sections.HeaderText = "Activities Status";
            this.subjects.Visible = false;

            // Function to Design Added Components
            designComponents();
        }

        private void designComponents()
        {
            //
            // save1Btn
            //
            this.save1Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.save1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save1Btn.Location = new System.Drawing.Point(276, 3);
            this.save1Btn.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.save1Btn.Name = "save1Btn";
            this.save1Btn.Size = new System.Drawing.Size(94, 36);
            this.save1Btn.TabIndex = 0;
            this.save1Btn.Text = "Save";
            this.save1Btn.UseVisualStyleBackColor = true;
            this.save1Btn.Click += new System.EventHandler(this.save1Btn_Click);
            //
            // reset1Btn
            //
            this.reset1Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.reset1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset1Btn.Location = new System.Drawing.Point(276, 3);
            this.reset1Btn.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.reset1Btn.Name = "reset1Btn";
            this.reset1Btn.Size = new System.Drawing.Size(94, 36);
            this.reset1Btn.TabIndex = 0;
            this.reset1Btn.Text = "Reset";
            this.reset1Btn.UseVisualStyleBackColor = true;
            this.reset1Btn.Click += new System.EventHandler(this.reset1Btn_Click);
        }

        private void customizeFormForMedicalStaff()
        {
            teacherIdLabel.Text = "PMDC No:";
            sectionsLabel.Text = "Email:";
            sectionsCombobox.Visible = false;
            this.addMemberTableLayoutPanel.Controls.Add(this.emailTextbox, 1, 8);
            subjectsLabel.Text = "Password:";
            subjectsCombobox.Visible = false;
            this.addMemberTableLayoutPanel.Controls.Add(this.passwordTextbox, 3, 8);
            emailLabel.Visible = false;
            passwordLabel.Visible = false;
            passwordTextbox.UseSystemPasswordChar = true;
            //addMemberTableLayoutPanel.RowStyles.RemoveAt(10);
            addMemberTableLayoutPanel.RowStyles.RemoveAt(9);
            addMemberTableLayoutPanel.RowStyles.RemoveAt(8);
            addMemberTableLayoutPanel.Size = new Size(838, 300);

            // dataGridView
            this.ID.HeaderText = "PMDC";
            this.sections.Visible = false;
            this.subjects.Visible = false;

            // save1Btn
            saveBtn.Visible = false;
            save1Btn.Visible = false;
            this.save2Btn = new System.Windows.Forms.Button();
            this.dataSaveTableLayoutPanel.Controls.Add(this.save2Btn, 0, 0);

            // reset1Btn
            resetBtn.Visible = false;
            reset1Btn.Visible = false;
            this.reset2Btn = new System.Windows.Forms.Button();
            this.dataSaveTableLayoutPanel.Controls.Add(this.reset2Btn, 1, 0);
        }

        private void designCompnentsForMedicalForm()
        {
            //
            // save2Btn
            //
            this.save2Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.save2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save2Btn.Location = new System.Drawing.Point(276, 3);
            this.save2Btn.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.save2Btn.Name = "save2Btn";
            this.save2Btn.Size = new System.Drawing.Size(94, 36);
            this.save2Btn.TabIndex = 0;
            this.save2Btn.Text = "Save";
            this.save2Btn.UseVisualStyleBackColor = true;
            this.save2Btn.Click += new System.EventHandler(this.save2Btn_Click);
            //
            // reset1Btn
            //
            this.reset1Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.reset2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset2Btn.Location = new System.Drawing.Point(276, 3);
            this.reset2Btn.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.reset2Btn.Name = "reset2Btn";
            this.reset2Btn.Size = new System.Drawing.Size(94, 36);
            this.reset2Btn.TabIndex = 0;
            this.reset2Btn.Text = "Reset";
            this.reset2Btn.UseVisualStyleBackColor = true;
            this.reset2Btn.Click += new System.EventHandler(this.reset2Btn_Click);
        }


        // Save and Reset Button Events
        private void saveBtn_Click(object sender, EventArgs e)
        {

        }

        private void save1Btn_Click(object sender, EventArgs e)
        {

        }

        private void save2Btn_Click(object sender, EventArgs e)
        {

        }

        private void reset1Btn_Click(object sender, EventArgs e)
        {

        }

        private void reset2Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
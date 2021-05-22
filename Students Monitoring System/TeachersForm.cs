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
            this.save1Btn = new System.Windows.Forms.Button();
            this.dataSaveTableLayoutPanel.Controls.Add(this.save1Btn, 0, 0);

            // reset1Btn
            resetBtn.Visible = false;
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
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void save1Btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
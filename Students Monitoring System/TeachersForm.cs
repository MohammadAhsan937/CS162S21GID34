using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Students_Monitoring_System
{
    public partial class MembersCommonForm : Form
    {
        string identifyForm = "";
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
            identifyForm = str;
            customizeFormForMedicalStaff();
        }

        private void customizeFormForIncharge()
        {
            // teachersIdLabel
            teacherIdLabel.Text = "Inchargs' ID:";
            
            // sectionsLabel
            sectionsLabel.Text = "Activities Status";
            
            // sectionsCombobox
            this.sectionsCombobox.Items.AddRange(new object[] {
            "Curricular Activities",
            "Co-Curricular Activities"});

            // subjectsLabel
            subjectsLabel.Text = "Email ";
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
            sectionsLabel.Text = "Email:";
            sectionsCombobox.Visible = false;
            this.addMemberTableLayoutPanel.Controls.Add(this.emailTextbox, 1, 8);
            subjectsLabel.Text = "Password:";
            subjectsCombobox.Visible = false;
            this.addMemberTableLayoutPanel.Controls.Add(this.passwordTextbox, 3, 8);
            emailLabel.Visible = false;
            passwordLabel.Visible = false;
            passwordTextbox.UseSystemPasswordChar = true;
            addMemberTableLayoutPanel.RowStyles.RemoveAt(8);
            addMemberTableLayoutPanel.RowStyles.RemoveAt(9);
            addMemberTableLayoutPanel.Size = new Size(838, 300);

            // dataGridView
            
            this.sections.Visible = false;
            this.subjects.Visible = false;

            // save1Btn
            saveBtn.Visible = false;
            save1Btn.Visible = false;

            // reset1Btn
            resetBtn.Visible = false;
            reset1Btn.Visible = false;
            
            if(identifyForm == "Institution Advisor Form")
            {
                this.ID.HeaderText = "Advisor's ID";
                teacherIdLabel.Text = "Advisor's ID:";
                reset2Btn.Visible = false;
                save2Btn.Visible = false;
                this.dataSaveTableLayoutPanel.Controls.Add(this.save3Btn, 0, 0);
                this.dataSaveTableLayoutPanel.Controls.Add(this.reset3Btn, 1, 0);
                designCompnentsForMedicalForm(save3Btn, reset3Btn);
                save3Btn.Click += new System.EventHandler(this.save3Btn_Click);
                reset3Btn.Click += new System.EventHandler(this.reset3Btn_Click);
                reset3Btn.Visible = true;
                save3Btn.Visible = true;
            }

            if(identifyForm == "Medical Form")
            {
                this.ID.HeaderText = "PMDC No";
                teacherIdLabel.Text = "PMDC No:";
                reset3Btn.Visible = false;
                save3Btn.Visible = false;
                this.dataSaveTableLayoutPanel.Controls.Add(this.save2Btn, 0, 0);
                this.dataSaveTableLayoutPanel.Controls.Add(this.reset2Btn, 1, 0);
                designCompnentsForMedicalForm(save2Btn, reset2Btn);
                reset2Btn.Click += new System.EventHandler(this.reset2Btn_Click);
                save2Btn.Click += new System.EventHandler(this.save2Btn_Click);
                save2Btn.Visible = true;
                reset2Btn.Visible = true;
            }
        }

        private void designCompnentsForMedicalForm(Button btn, Button btn1)
        {
            //
            // save2Btn
            //
            btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn.Location = new System.Drawing.Point(276, 3);
            btn.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            btn.Name = "save2Btn";
            btn.Size = new System.Drawing.Size(94, 36);
            btn.TabIndex = 0;
            btn.Text = "Save";
            btn.UseVisualStyleBackColor = true;
            //
            // reset1Btn
            //
            btn1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn1.Location = new System.Drawing.Point(276, 3);
            btn1.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            btn1.Name = "reset2Btn";
            btn1.Size = new System.Drawing.Size(94, 36);
            btn1.TabIndex = 0;
            btn1.Text = "Reset";
            btn1.UseVisualStyleBackColor = true;
        }


        // Save and Reset Button Events
        private void saveBtn_Click(object sender, EventArgs e)
        {
            isvalid_name(nameTextbox.Text);
            isvalid_name(fatherNameTextbox.Text);
            isvalid_email(emailTextbox.Text);
            isvalid_name(qualificationTextbox.Text);
            isvalid_contact(contactNumberTextbox.Text);
            isvalid_Salary(salaryTextbox.Text);
            
        }

        public bool isvalid_homeaddress(String H)
        //135-A2-Gulberg3-Lahore
        {
            Regex checks = new Regex(@"^ ^\(? ([0 - 9]{ 3 })\)?[-. ]? ([0 - 9-A-Z]{2})[-. ]? ([A - Z-a-z]{9})[-.]? ([A - Z-a-z]{9})$");
            bool valids = false;
            valids = checks.IsMatch(H);
            if (valids == true)
            {
                return valids;
            }
            else
            {
                MessageBox.Show("Contact Number is invalid");
                return valids;
            }
        }
        public bool isvalid_name(String n)
        {
            Regex check = new Regex(@"^[A-Z][a-z-A-z+)$");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid == true)
            {
                return valid;
            }
            else
            {
                MessageBox.Show("Name is invalid");
                return valid;
            }
        }

        public bool isvalid_email(String email)
        {
            Regex checke = new Regex(@"^\w+[\w-\.]+\@\w{5}\.[a-z]{2,3}$");
            bool valid = false;
            valid = checke.IsMatch(email);
            if (valid == true)
            {
                return true;
            }
            else
            {
                MessageBox.Show("E-mail is invalid");
                return valid;
            }

        }

        public bool isvalid_contact(String C)
        {
            Regex checks = new Regex(@"^ ^\(? ([0 - 9]{ 3 })\)?[-. ]? ([0 - 9]{3})[-. ]? ([0 - 9]{4})$");
            bool valids = false;
            valids = checks.IsMatch(C);
            if (valids == true)
            {
                return valids;
            }
            else
            {
                MessageBox.Show("Contact Number is invalid");
                return valids;
            }
        }
        public bool isvalid_Salary(String S)
        {
            Regex checks = new Regex(@"^ ^\(? ([0 - 9]{ 6 })$");
            bool valids = false;
            valids = checks.IsMatch(S);
            if (valids == true)
            {
                return valids;
            }
            else
            {
                MessageBox.Show("Salary Number is invalid");
                return valids;
            }
        }
        public bool isvalid_Session(String Ses)
        {
            Regex checks = new Regex(@"^ ^\(? ([0 - 9]{ 4 })$");
            bool valids = false;
            valids = checks.IsMatch(Ses);
            if (valids == true)
            {
                return valids;
            }
            else
            {
                MessageBox.Show("Session  is invalid");
                return valids;
            }
        }

        private void save1Btn_Click(object sender, EventArgs e)
        {

        }

        private void save2Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Medical Form Save");
        }

        private void save3Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Advisor Form Save");
        }


        private void resetBtn_Click(object sender, EventArgs e)
        {

        }

        private void reset1Btn_Click(object sender, EventArgs e)
        {

        }

        private void reset2Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Medical Form Reset");
        }

        private void reset3Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Advisor Form Reset");
        }
    }
}
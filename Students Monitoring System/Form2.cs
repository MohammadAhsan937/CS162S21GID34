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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            isvalid_name(studentname.Text);
            isvalid_name(fathername.Text);
            isvalid_contact(fcontact.Text);
            isvalid_contact(contact.Text);
            isvalid_email(Email.Text);
            ValidateDate(DOB.Text);
            isvalid_homeaddress(Address.Text);
            isvalid_semester(Semester.Text);
            validateRegistrationNumber(IDtextBox.Text);


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


        public bool isvalid_name(String n)
        {
            Regex check = new Regex(@"^[A-Z][a-z-A-z+)$");
            bool valid = false;
            valid = check.IsMatch(n);
            if(valid==true)
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

        private bool ValidateDate(string date)
        {  //DD/MM/YYYY
            try
            {
                
                string[] dateParts = date.Split('/');

               
                DateTime testDate = new
                    DateTime(Convert.ToInt32(dateParts[2]),
                    Convert.ToInt32(dateParts[0]),
                    Convert.ToInt32(dateParts[1]));

                return true;
            }
            catch
            {
               
                return false;
            }
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
        public bool isvalid_semester(String S)
        {
            Regex checks = new Regex(@"^ ^\(? ([0 - 4]{ 1 })$");
            bool valids = false;
            valids = checks.IsMatch(S);
            if (valids == true)
            {
                return valids;
            }
            else
            {
                MessageBox.Show("Semester Number is invalid");
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
        static bool validateRegistrationNumber(String regNo) //its validator
        {
            bool flag1 = false;
            int temp = 0;
            if (temp != 1)
            {
                if ((regNo[0] == '2') && (regNo[1] == '0') && (regNo[2] >= '0'
                                                                              && regNo[2] <= '2') && (regNo[3] >= '0' && regNo[3] <= '9')
                     && (regNo[4] == '-') && (regNo[5] >= 'A' && regNo[5] <= 'Z')
                     && (regNo[6] >= 'A' && regNo[6] <= 'Z') && (regNo[7] == '-')
                     && (regNo[8] >= '0' && regNo[8] <= '9') && (regNo[9] >= '0'
                                                                                && regNo[9] <= '9') && (regNo[10] >= '0' && regNo[10] <= '9'))
                {
                    flag1 = true;
                }
                else
                {
                    flag1 = false;
                    temp = 1;
                }
                temp = 1;
            }
            return flag1;
        }
        private void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Studentname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

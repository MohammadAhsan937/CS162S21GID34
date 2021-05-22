
namespace Students_Monitoring_System
{
    partial class ViewStudentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.srNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherContactNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.srNo,
            this.name,
            this.fatherName,
            this.fatherContactNum,
            this.studentID,
            this.dob,
            this.degree,
            this.session,
            this.semester,
            this.contactNum,
            this.adsress,
            this.email,
            this.password});
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1145, 472);
            this.dataGridView1.TabIndex = 0;
            // 
            // srNo
            // 
            this.srNo.HeaderText = "Sr.No.";
            this.srNo.Name = "srNo";
            this.srNo.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Student Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // fatherName
            // 
            this.fatherName.HeaderText = "Father Name";
            this.fatherName.Name = "fatherName";
            this.fatherName.ReadOnly = true;
            // 
            // fatherContactNum
            // 
            this.fatherContactNum.HeaderText = "Father\'s Contact Number";
            this.fatherContactNum.Name = "fatherContactNum";
            this.fatherContactNum.ReadOnly = true;
            // 
            // studentID
            // 
            this.studentID.HeaderText = "Student\'s ID";
            this.studentID.Name = "studentID";
            this.studentID.ReadOnly = true;
            // 
            // dob
            // 
            this.dob.HeaderText = "Date of Birth";
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            // 
            // degree
            // 
            this.degree.HeaderText = "Degree";
            this.degree.Name = "degree";
            this.degree.ReadOnly = true;
            // 
            // session
            // 
            this.session.HeaderText = "Session";
            this.session.Name = "session";
            this.session.ReadOnly = true;
            // 
            // semester
            // 
            this.semester.HeaderText = "Semester";
            this.semester.Name = "semester";
            this.semester.ReadOnly = true;
            // 
            // contactNum
            // 
            this.contactNum.HeaderText = "Contact Number";
            this.contactNum.Name = "contactNum";
            this.contactNum.ReadOnly = true;
            // 
            // adsress
            // 
            this.adsress.HeaderText = "Address";
            this.adsress.Name = "adsress";
            this.adsress.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email ID";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // ViewStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1141, 472);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewStudentsForm";
            this.Text = "ViewStudentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn srNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherContactNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn degree;
        private System.Windows.Forms.DataGridViewTextBoxColumn session;
        private System.Windows.Forms.DataGridViewTextBoxColumn semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsress;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
    }
}
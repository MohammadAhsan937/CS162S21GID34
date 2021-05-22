
namespace Students_Monitoring_System
{
    partial class UploadMembersFileForm
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
            this.uploadFileLabel = new System.Windows.Forms.Label();
            this.fileNameTextbox = new System.Windows.Forms.TextBox();
            this.browseFileLabel = new System.Windows.Forms.Label();
            this.selectFileLabel = new System.Windows.Forms.Label();
            this.TeacherFileOkayBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.browseFileBtn = new System.Windows.Forms.Button();
            this.teachersFileOkay1Btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uploadFileLabel
            // 
            this.uploadFileLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uploadFileLabel.AutoSize = true;
            this.uploadFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.uploadFileLabel.Location = new System.Drawing.Point(200, 105);
            this.uploadFileLabel.Name = "uploadFileLabel";
            this.uploadFileLabel.Size = new System.Drawing.Size(333, 46);
            this.uploadFileLabel.TabIndex = 0;
            this.uploadFileLabel.Text = "Upload Excel File";
            // 
            // fileNameTextbox
            // 
            this.fileNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameTextbox.BackColor = System.Drawing.Color.Gainsboro;
            this.fileNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameTextbox.Location = new System.Drawing.Point(217, 3);
            this.fileNameTextbox.Multiline = true;
            this.fileNameTextbox.Name = "fileNameTextbox";
            this.fileNameTextbox.ReadOnly = true;
            this.fileNameTextbox.Size = new System.Drawing.Size(379, 28);
            this.fileNameTextbox.TabIndex = 1;
            // 
            // browseFileLabel
            // 
            this.browseFileLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.browseFileLabel.AutoSize = true;
            this.browseFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.browseFileLabel.Location = new System.Drawing.Point(607, 36);
            this.browseFileLabel.Name = "browseFileLabel";
            this.browseFileLabel.Size = new System.Drawing.Size(48, 15);
            this.browseFileLabel.TabIndex = 3;
            this.browseFileLabel.Text = "Browse";
            // 
            // selectFileLabel
            // 
            this.selectFileLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.selectFileLabel.AutoSize = true;
            this.selectFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.selectFileLabel.Location = new System.Drawing.Point(115, 6);
            this.selectFileLabel.Name = "selectFileLabel";
            this.selectFileLabel.Size = new System.Drawing.Size(96, 22);
            this.selectFileLabel.TabIndex = 4;
            this.selectFileLabel.Text = "File Name:";
            // 
            // TeacherFileOkayBtn
            // 
            this.TeacherFileOkayBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TeacherFileOkayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherFileOkayBtn.Location = new System.Drawing.Point(336, 299);
            this.TeacherFileOkayBtn.Name = "TeacherFileOkayBtn";
            this.TeacherFileOkayBtn.Size = new System.Drawing.Size(68, 33);
            this.TeacherFileOkayBtn.TabIndex = 5;
            this.TeacherFileOkayBtn.Text = "Okay";
            this.TeacherFileOkayBtn.UseVisualStyleBackColor = true;
            this.TeacherFileOkayBtn.Click += new System.EventHandler(this.TeacherFileOkayBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Controls.Add(this.browseFileBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.selectFileLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fileNameTextbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.browseFileLabel, 2, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, 188);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(738, 54);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // browseFileBtn
            // 
            this.browseFileBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.browseFileBtn.Location = new System.Drawing.Point(611, 3);
            this.browseFileBtn.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.browseFileBtn.Name = "browseFileBtn";
            this.browseFileBtn.Size = new System.Drawing.Size(41, 28);
            this.browseFileBtn.TabIndex = 5;
            this.browseFileBtn.Text = "...";
            this.browseFileBtn.UseVisualStyleBackColor = true;
            this.browseFileBtn.Click += new System.EventHandler(this.browseFileBtn_Click);
            this.browseFileBtn.MouseEnter += new System.EventHandler(this.button1_MouseEnter_1);
            this.browseFileBtn.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // teachersFileOkay1Btn
            // 
            this.teachersFileOkay1Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.teachersFileOkay1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachersFileOkay1Btn.Location = new System.Drawing.Point(336, 299);
            this.teachersFileOkay1Btn.Name = "teachersFileOkay1Btn";
            this.teachersFileOkay1Btn.Size = new System.Drawing.Size(68, 33);
            this.teachersFileOkay1Btn.TabIndex = 7;
            this.teachersFileOkay1Btn.Text = "Okay";
            this.teachersFileOkay1Btn.UseVisualStyleBackColor = true;
            this.teachersFileOkay1Btn.Click += new System.EventHandler(this.teachersFileOkay1Btn_Click);
            this.teachersFileOkay1Btn.MouseEnter += new System.EventHandler(this.teachersFileOkay1Btn_MouseEnter);
            this.teachersFileOkay1Btn.MouseLeave += new System.EventHandler(this.teachersFileOkay1Btn_MouseLeave);
            // 
            // UploadMembersFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(732, 468);
            this.Controls.Add(this.teachersFileOkay1Btn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TeacherFileOkayBtn);
            this.Controls.Add(this.uploadFileLabel);
            this.Name = "UploadMembersFileForm";
            this.Text = "UploadTeachers";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uploadFileLabel;
        private System.Windows.Forms.TextBox fileNameTextbox;
        private System.Windows.Forms.Label browseFileLabel;
        private System.Windows.Forms.Label selectFileLabel;
        private System.Windows.Forms.Button TeacherFileOkayBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button browseFileBtn;
        private System.Windows.Forms.Button teachersFileOkay1Btn;
    }
}
namespace Grading_system
{
    partial class Teacher
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.userlb1 = new System.Windows.Forms.Label();
            this.logoutbutton1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TeacherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.lblerror3 = new System.Windows.Forms.Label();
            this.lblerror2 = new System.Windows.Forms.Label();
            this.lblerror1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gradetbx = new System.Windows.Forms.TextBox();
            this.studenttbx = new System.Windows.Forms.TextBox();
            this.Coursetbx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.CourseID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignmentGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.CourseID3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1199, 522);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.userlb1);
            this.tabPage1.Controls.Add(this.logoutbutton1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1191, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // userlb1
            // 
            this.userlb1.AutoSize = true;
            this.userlb1.Location = new System.Drawing.Point(24, 6);
            this.userlb1.Name = "userlb1";
            this.userlb1.Size = new System.Drawing.Size(39, 16);
            this.userlb1.TabIndex = 3;
            this.userlb1.Text = "User:";
            // 
            // logoutbutton1
            // 
            this.logoutbutton1.Location = new System.Drawing.Point(1086, 6);
            this.logoutbutton1.Name = "logoutbutton1";
            this.logoutbutton1.Size = new System.Drawing.Size(86, 43);
            this.logoutbutton1.TabIndex = 2;
            this.logoutbutton1.Text = "Logout";
            this.logoutbutton1.UseVisualStyleBackColor = true;
            this.logoutbutton1.Click += new System.EventHandler(this.logoutbutton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeacherID,
            this.UserID,
            this.TeacherName,
            this.TeacherEmail,
            this.TeacherDepartment});
            this.dataGridView1.Location = new System.Drawing.Point(18, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 281);
            this.dataGridView1.TabIndex = 0;
            // 
            // TeacherID
            // 
            this.TeacherID.DataPropertyName = "TeacherID";
            this.TeacherID.HeaderText = "Teacher ID";
            this.TeacherID.MinimumWidth = 6;
            this.TeacherID.Name = "TeacherID";
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "User ID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            // 
            // TeacherName
            // 
            this.TeacherName.DataPropertyName = "TeacherName";
            this.TeacherName.HeaderText = "Teacher Name";
            this.TeacherName.MinimumWidth = 6;
            this.TeacherName.Name = "TeacherName";
            // 
            // TeacherEmail
            // 
            this.TeacherEmail.DataPropertyName = "TeacherEmail";
            this.TeacherEmail.HeaderText = "Teacher Email";
            this.TeacherEmail.MinimumWidth = 6;
            this.TeacherEmail.Name = "TeacherEmail";
            // 
            // TeacherDepartment
            // 
            this.TeacherDepartment.DataPropertyName = "TeacherDepartment";
            this.TeacherDepartment.HeaderText = "Teacher Department";
            this.TeacherDepartment.MinimumWidth = 6;
            this.TeacherDepartment.Name = "TeacherDepartment";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1191, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseID,
            this.CourseName,
            this.CourseTitle,
            this.CourseDepartment});
            this.dataGridView2.Location = new System.Drawing.Point(6, 218);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1166, 259);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // CourseID
            // 
            this.CourseID.DataPropertyName = "CourseID";
            this.CourseID.HeaderText = "Course ID";
            this.CourseID.MinimumWidth = 6;
            this.CourseID.Name = "CourseID";
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.MinimumWidth = 6;
            this.CourseName.Name = "CourseName";
            // 
            // CourseTitle
            // 
            this.CourseTitle.DataPropertyName = "CourseTitle";
            this.CourseTitle.HeaderText = "Course Title";
            this.CourseTitle.MinimumWidth = 6;
            this.CourseTitle.Name = "CourseTitle";
            // 
            // CourseDepartment
            // 
            this.CourseDepartment.DataPropertyName = "CourseDepartment";
            this.CourseDepartment.HeaderText = "Course Department";
            this.CourseDepartment.MinimumWidth = 6;
            this.CourseDepartment.Name = "CourseDepartment";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.lblerror3);
            this.tabPage3.Controls.Add(this.lblerror2);
            this.tabPage3.Controls.Add(this.lblerror1);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.gradetbx);
            this.tabPage3.Controls.Add(this.studenttbx);
            this.tabPage3.Controls.Add(this.Coursetbx);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1191, 493);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(583, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 48);
            this.button2.TabIndex = 5;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblerror3
            // 
            this.lblerror3.AutoSize = true;
            this.lblerror3.Location = new System.Drawing.Point(851, 67);
            this.lblerror3.Name = "lblerror3";
            this.lblerror3.Size = new System.Drawing.Size(0, 16);
            this.lblerror3.TabIndex = 4;
            // 
            // lblerror2
            // 
            this.lblerror2.AutoSize = true;
            this.lblerror2.Location = new System.Drawing.Point(170, 151);
            this.lblerror2.Name = "lblerror2";
            this.lblerror2.Size = new System.Drawing.Size(0, 16);
            this.lblerror2.TabIndex = 4;
            this.lblerror2.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblerror1
            // 
            this.lblerror1.AutoSize = true;
            this.lblerror1.Location = new System.Drawing.Point(170, 67);
            this.lblerror1.Name = "lblerror1";
            this.lblerror1.Size = new System.Drawing.Size(0, 16);
            this.lblerror1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(691, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Assignment grade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Course ID";
            // 
            // gradetbx
            // 
            this.gradetbx.Location = new System.Drawing.Point(813, 20);
            this.gradetbx.Multiline = true;
            this.gradetbx.Name = "gradetbx";
            this.gradetbx.Size = new System.Drawing.Size(137, 31);
            this.gradetbx.TabIndex = 2;
            // 
            // studenttbx
            // 
            this.studenttbx.Location = new System.Drawing.Point(110, 100);
            this.studenttbx.Multiline = true;
            this.studenttbx.Name = "studenttbx";
            this.studenttbx.Size = new System.Drawing.Size(157, 33);
            this.studenttbx.TabIndex = 2;
            this.studenttbx.TextChanged += new System.EventHandler(this.studenttbx_TextChanged);
            // 
            // Coursetbx
            // 
            this.Coursetbx.HideSelection = false;
            this.Coursetbx.Location = new System.Drawing.Point(110, 20);
            this.Coursetbx.Multiline = true;
            this.Coursetbx.Name = "Coursetbx";
            this.Coursetbx.Size = new System.Drawing.Size(157, 31);
            this.Coursetbx.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseID2,
            this.StudentID,
            this.AssignmentGrade});
            this.dataGridView3.Location = new System.Drawing.Point(15, 211);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1151, 262);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // CourseID2
            // 
            this.CourseID2.DataPropertyName = "CourseID";
            this.CourseID2.HeaderText = "Course ID";
            this.CourseID2.MinimumWidth = 6;
            this.CourseID2.Name = "CourseID2";
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "StudentID";
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
            // 
            // AssignmentGrade
            // 
            this.AssignmentGrade.DataPropertyName = "AssignmentGrade";
            this.AssignmentGrade.HeaderText = "Assignment Grade";
            this.AssignmentGrade.MinimumWidth = 6;
            this.AssignmentGrade.Name = "AssignmentGrade";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1191, 493);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseID3,
            this.TeacherID2});
            this.dataGridView4.Location = new System.Drawing.Point(37, 196);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(1131, 291);
            this.dataGridView4.TabIndex = 0;
            // 
            // CourseID3
            // 
            this.CourseID3.DataPropertyName = "CourseID";
            this.CourseID3.HeaderText = "Course ID";
            this.CourseID3.MinimumWidth = 6;
            this.CourseID3.Name = "CourseID3";
            // 
            // TeacherID2
            // 
            this.TeacherID2.DataPropertyName = "TeacherID";
            this.TeacherID2.HeaderText = "Teacher ID";
            this.TeacherID2.MinimumWidth = 6;
            this.TeacherID2.Name = "TeacherID2";
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 537);
            this.Controls.Add(this.tabControl1);
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherDepartment;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseDepartment;
        private System.Windows.Forms.Button logoutbutton1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentGrade;
        private System.Windows.Forms.Label userlb1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherID2;
        private System.Windows.Forms.TextBox gradetbx;
        private System.Windows.Forms.TextBox studenttbx;
        private System.Windows.Forms.TextBox Coursetbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblerror3;
        private System.Windows.Forms.Label lblerror2;
        private System.Windows.Forms.Label lblerror1;
        private System.Windows.Forms.Button button2;
    }
}
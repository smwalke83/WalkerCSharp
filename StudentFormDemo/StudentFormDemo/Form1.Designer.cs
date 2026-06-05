namespace StudentFormDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStudentID = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            txbStudentID = new TextBox();
            txbFirstName = new TextBox();
            txbLastName = new TextBox();
            groupBox1 = new GroupBox();
            rbIT = new RadioButton();
            rbWebDesign = new RadioButton();
            rbProgramming = new RadioButton();
            lblCourses = new Label();
            lblScores = new Label();
            cbxCIS101 = new CheckBox();
            cbxCIS102 = new CheckBox();
            cbxCIS103 = new CheckBox();
            cbxCIS104 = new CheckBox();
            txbScore1 = new TextBox();
            txbScore2 = new TextBox();
            txbScore3 = new TextBox();
            txbScore4 = new TextBox();
            btnSubmit = new Button();
            txbResult = new TextBox();
            lblResults = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(12, 19);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(62, 15);
            lblStudentID.TabIndex = 0;
            lblStudentID.Text = "Student ID";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(186, 19);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(369, 19);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // txbStudentID
            // 
            txbStudentID.Location = new Point(80, 16);
            txbStudentID.Name = "txbStudentID";
            txbStudentID.Size = new Size(100, 23);
            txbStudentID.TabIndex = 3;
            // 
            // txbFirstName
            // 
            txbFirstName.Location = new Point(263, 16);
            txbFirstName.Name = "txbFirstName";
            txbFirstName.Size = new Size(100, 23);
            txbFirstName.TabIndex = 4;
            // 
            // txbLastName
            // 
            txbLastName.Location = new Point(438, 16);
            txbLastName.Name = "txbLastName";
            txbLastName.Size = new Size(100, 23);
            txbLastName.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbIT);
            groupBox1.Controls.Add(rbWebDesign);
            groupBox1.Controls.Add(rbProgramming);
            groupBox1.Location = new Point(159, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Major";
            // 
            // rbIT
            // 
            rbIT.AutoSize = true;
            rbIT.Location = new Point(13, 68);
            rbIT.Name = "rbIT";
            rbIT.Size = new Size(35, 19);
            rbIT.TabIndex = 2;
            rbIT.TabStop = true;
            rbIT.Text = "IT";
            rbIT.UseVisualStyleBackColor = true;
            // 
            // rbWebDesign
            // 
            rbWebDesign.AutoSize = true;
            rbWebDesign.Location = new Point(13, 43);
            rbWebDesign.Name = "rbWebDesign";
            rbWebDesign.Size = new Size(88, 19);
            rbWebDesign.TabIndex = 1;
            rbWebDesign.TabStop = true;
            rbWebDesign.Text = "Web Design";
            rbWebDesign.UseVisualStyleBackColor = true;
            // 
            // rbProgramming
            // 
            rbProgramming.AutoSize = true;
            rbProgramming.Location = new Point(13, 17);
            rbProgramming.Name = "rbProgramming";
            rbProgramming.Size = new Size(99, 19);
            rbProgramming.TabIndex = 0;
            rbProgramming.TabStop = true;
            rbProgramming.Text = "Programming";
            rbProgramming.UseVisualStyleBackColor = true;
            // 
            // lblCourses
            // 
            lblCourses.AutoSize = true;
            lblCourses.Location = new Point(95, 259);
            lblCourses.Name = "lblCourses";
            lblCourses.Size = new Size(49, 15);
            lblCourses.TabIndex = 7;
            lblCourses.Text = "Courses";
            // 
            // lblScores
            // 
            lblScores.AutoSize = true;
            lblScores.Location = new Point(238, 259);
            lblScores.Name = "lblScores";
            lblScores.Size = new Size(41, 15);
            lblScores.TabIndex = 8;
            lblScores.Text = "Scores";
            // 
            // cbxCIS101
            // 
            cbxCIS101.AutoSize = true;
            cbxCIS101.Location = new Point(159, 259);
            cbxCIS101.Name = "cbxCIS101";
            cbxCIS101.Size = new Size(64, 19);
            cbxCIS101.TabIndex = 9;
            cbxCIS101.Text = "CIS 101";
            cbxCIS101.UseVisualStyleBackColor = true;
            // 
            // cbxCIS102
            // 
            cbxCIS102.AutoSize = true;
            cbxCIS102.Location = new Point(159, 286);
            cbxCIS102.Name = "cbxCIS102";
            cbxCIS102.Size = new Size(64, 19);
            cbxCIS102.TabIndex = 10;
            cbxCIS102.Text = "CIS 102";
            cbxCIS102.UseVisualStyleBackColor = true;
            // 
            // cbxCIS103
            // 
            cbxCIS103.AutoSize = true;
            cbxCIS103.Location = new Point(159, 315);
            cbxCIS103.Name = "cbxCIS103";
            cbxCIS103.Size = new Size(64, 19);
            cbxCIS103.TabIndex = 11;
            cbxCIS103.Text = "CIS 103";
            cbxCIS103.UseVisualStyleBackColor = true;
            // 
            // cbxCIS104
            // 
            cbxCIS104.AutoSize = true;
            cbxCIS104.Location = new Point(159, 344);
            cbxCIS104.Name = "cbxCIS104";
            cbxCIS104.Size = new Size(64, 19);
            cbxCIS104.TabIndex = 12;
            cbxCIS104.Text = "CIS 104";
            cbxCIS104.UseVisualStyleBackColor = true;
            // 
            // txbScore1
            // 
            txbScore1.Location = new Point(297, 257);
            txbScore1.Name = "txbScore1";
            txbScore1.Size = new Size(100, 23);
            txbScore1.TabIndex = 13;
            // 
            // txbScore2
            // 
            txbScore2.Location = new Point(297, 286);
            txbScore2.Name = "txbScore2";
            txbScore2.Size = new Size(100, 23);
            txbScore2.TabIndex = 14;
            // 
            // txbScore3
            // 
            txbScore3.Location = new Point(297, 315);
            txbScore3.Name = "txbScore3";
            txbScore3.Size = new Size(100, 23);
            txbScore3.TabIndex = 15;
            // 
            // txbScore4
            // 
            txbScore4.Location = new Point(297, 344);
            txbScore4.Name = "txbScore4";
            txbScore4.Size = new Size(100, 23);
            txbScore4.TabIndex = 16;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(219, 400);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 17;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txbResult
            // 
            txbResult.Location = new Point(590, 102);
            txbResult.Multiline = true;
            txbResult.Name = "txbResult";
            txbResult.Size = new Size(198, 321);
            txbResult.TabIndex = 18;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(663, 59);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(44, 15);
            lblResults.TabIndex = 19;
            lblResults.Text = "Results";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResults);
            Controls.Add(txbResult);
            Controls.Add(btnSubmit);
            Controls.Add(txbScore4);
            Controls.Add(txbScore3);
            Controls.Add(txbScore2);
            Controls.Add(txbScore1);
            Controls.Add(cbxCIS104);
            Controls.Add(cbxCIS103);
            Controls.Add(cbxCIS102);
            Controls.Add(cbxCIS101);
            Controls.Add(lblScores);
            Controls.Add(lblCourses);
            Controls.Add(groupBox1);
            Controls.Add(txbLastName);
            Controls.Add(txbFirstName);
            Controls.Add(txbStudentID);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblStudentID);
            ForeColor = SystemColors.MenuText;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentID;
        private Label lblFirstName;
        private Label lblLastName;
        private TextBox txbStudentID;
        private TextBox txbFirstName;
        private TextBox txbLastName;
        private GroupBox groupBox1;
        private RadioButton rbIT;
        private RadioButton rbWebDesign;
        private RadioButton rbProgramming;
        private Label lblCourses;
        private Label lblScores;
        private CheckBox cbxCIS101;
        private CheckBox cbxCIS102;
        private CheckBox cbxCIS103;
        private CheckBox cbxCIS104;
        private TextBox txbScore1;
        private TextBox txbScore2;
        private TextBox txbScore3;
        private TextBox txbScore4;
        private Button btnSubmit;
        private TextBox txbResult;
        private Label lblResults;
    }
}

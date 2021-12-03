
namespace FinalProject
{
    partial class AdminForm
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
            this.welcomeL = new System.Windows.Forms.Label();
            this.studentRB = new System.Windows.Forms.RadioButton();
            this.teacherRB = new System.Windows.Forms.RadioButton();
            this.Course = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addB = new System.Windows.Forms.Button();
            this.teacherTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.teacherL = new System.Windows.Forms.Label();
            this.nameL = new System.Windows.Forms.Label();
            this.elementsL = new System.Windows.Forms.Label();
            this.displayL = new System.Windows.Forms.Label();
            this.displayB = new System.Windows.Forms.Button();
            this.errorL = new System.Windows.Forms.Label();
            this.closeB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeL
            // 
            this.welcomeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeL.ForeColor = System.Drawing.SystemColors.Highlight;
            this.welcomeL.Location = new System.Drawing.Point(28, 9);
            this.welcomeL.Name = "welcomeL";
            this.welcomeL.Size = new System.Drawing.Size(384, 32);
            this.welcomeL.TabIndex = 0;
            this.welcomeL.Text = "Welcome";
            this.welcomeL.Click += new System.EventHandler(this.label1_Click);
            // 
            // studentRB
            // 
            this.studentRB.AutoSize = true;
            this.studentRB.Checked = true;
            this.studentRB.Location = new System.Drawing.Point(13, 13);
            this.studentRB.Name = "studentRB";
            this.studentRB.Size = new System.Drawing.Size(78, 21);
            this.studentRB.TabIndex = 4;
            this.studentRB.TabStop = true;
            this.studentRB.Text = "Student";
            this.studentRB.UseVisualStyleBackColor = true;
            this.studentRB.CheckedChanged += new System.EventHandler(this.studentRB_CheckedChanged);
            // 
            // teacherRB
            // 
            this.teacherRB.AutoSize = true;
            this.teacherRB.Location = new System.Drawing.Point(13, 52);
            this.teacherRB.Name = "teacherRB";
            this.teacherRB.Size = new System.Drawing.Size(82, 21);
            this.teacherRB.TabIndex = 5;
            this.teacherRB.Text = "Teacher";
            this.teacherRB.UseVisualStyleBackColor = true;
            this.teacherRB.CheckedChanged += new System.EventHandler(this.teacherRB_CheckedChanged);
            // 
            // Course
            // 
            this.Course.AutoSize = true;
            this.Course.Location = new System.Drawing.Point(13, 92);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(74, 21);
            this.Course.TabIndex = 6;
            this.Course.Text = "Course";
            this.Course.UseVisualStyleBackColor = true;
            this.Course.CheckedChanged += new System.EventHandler(this.Course_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.addB);
            this.panel1.Controls.Add(this.teacherTB);
            this.panel1.Controls.Add(this.nameTB);
            this.panel1.Controls.Add(this.teacherL);
            this.panel1.Controls.Add(this.nameL);
            this.panel1.Controls.Add(this.studentRB);
            this.panel1.Controls.Add(this.Course);
            this.panel1.Controls.Add(this.teacherRB);
            this.panel1.Location = new System.Drawing.Point(12, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 179);
            this.panel1.TabIndex = 7;
            // 
            // addB
            // 
            this.addB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addB.Location = new System.Drawing.Point(300, 129);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(75, 36);
            this.addB.TabIndex = 11;
            this.addB.Text = "Add";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // teacherTB
            // 
            this.teacherTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherTB.Location = new System.Drawing.Point(197, 63);
            this.teacherTB.Multiline = true;
            this.teacherTB.Name = "teacherTB";
            this.teacherTB.Size = new System.Drawing.Size(178, 29);
            this.teacherTB.TabIndex = 10;
            this.teacherTB.Visible = false;
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.Location = new System.Drawing.Point(198, 28);
            this.nameTB.Multiline = true;
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(178, 29);
            this.nameTB.TabIndex = 9;
            // 
            // teacherL
            // 
            this.teacherL.AutoSize = true;
            this.teacherL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherL.Location = new System.Drawing.Point(108, 62);
            this.teacherL.Name = "teacherL";
            this.teacherL.Size = new System.Drawing.Size(83, 20);
            this.teacherL.TabIndex = 8;
            this.teacherL.Text = "Teacher:";
            this.teacherL.Visible = false;
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameL.Location = new System.Drawing.Point(128, 28);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(63, 20);
            this.nameL.TabIndex = 7;
            this.nameL.Text = "Name:";
            // 
            // elementsL
            // 
            this.elementsL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementsL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.elementsL.Location = new System.Drawing.Point(30, 68);
            this.elementsL.Name = "elementsL";
            this.elementsL.Size = new System.Drawing.Size(272, 21);
            this.elementsL.TabIndex = 8;
            this.elementsL.Text = "Add a Student, Teacher or Course";
            this.elementsL.Click += new System.EventHandler(this.elementsL_Click);
            // 
            // displayL
            // 
            this.displayL.BackColor = System.Drawing.SystemColors.ControlLight;
            this.displayL.Location = new System.Drawing.Point(418, 16);
            this.displayL.Name = "displayL";
            this.displayL.Size = new System.Drawing.Size(242, 386);
            this.displayL.TabIndex = 9;
            // 
            // displayB
            // 
            this.displayB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayB.Location = new System.Drawing.Point(523, 421);
            this.displayB.Name = "displayB";
            this.displayB.Size = new System.Drawing.Size(125, 36);
            this.displayB.TabIndex = 12;
            this.displayB.Text = "Display";
            this.displayB.UseVisualStyleBackColor = true;
            this.displayB.Click += new System.EventHandler(this.displayB_Click);
            // 
            // errorL
            // 
            this.errorL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorL.ForeColor = System.Drawing.Color.Red;
            this.errorL.Location = new System.Drawing.Point(58, 432);
            this.errorL.Name = "errorL";
            this.errorL.Size = new System.Drawing.Size(244, 23);
            this.errorL.TabIndex = 14;
            // 
            // closeB
            // 
            this.closeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeB.Location = new System.Drawing.Point(26, 328);
            this.closeB.Name = "closeB";
            this.closeB.Size = new System.Drawing.Size(157, 53);
            this.closeB.TabIndex = 13;
            this.closeB.Text = "<<Login ";
            this.closeB.UseVisualStyleBackColor = true;
            this.closeB.Click += new System.EventHandler(this.closeB_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 469);
            this.Controls.Add(this.errorL);
            this.Controls.Add(this.closeB);
            this.Controls.Add(this.displayB);
            this.Controls.Add(this.displayL);
            this.Controls.Add(this.elementsL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.welcomeL);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcomeL;
        private System.Windows.Forms.RadioButton studentRB;
        private System.Windows.Forms.RadioButton teacherRB;
        private System.Windows.Forms.RadioButton Course;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label elementsL;
        private System.Windows.Forms.TextBox teacherTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label teacherL;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Label displayL;
        private System.Windows.Forms.Button displayB;
        private System.Windows.Forms.Label errorL;
        private System.Windows.Forms.Button closeB;
    }
}
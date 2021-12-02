
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
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.studentRB);
            this.panel1.Controls.Add(this.Course);
            this.panel1.Controls.Add(this.teacherRB);
            this.panel1.Location = new System.Drawing.Point(33, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 179);
            this.panel1.TabIndex = 7;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 469);
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
    }
}
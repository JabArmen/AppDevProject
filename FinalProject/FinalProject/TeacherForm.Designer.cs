
namespace FinalProject
{
    partial class TeacherForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.StudentL = new System.Windows.Forms.Label();
            this.StudentTB = new System.Windows.Forms.TextBox();
            this.ScoreL = new System.Windows.Forms.Label();
            this.ScoreTB = new System.Windows.Forms.TextBox();
            this.closeB = new System.Windows.Forms.Button();
            this.AddB = new System.Windows.Forms.Button();
            this.CourseL = new System.Windows.Forms.Label();
            this.courseTB = new System.Windows.Forms.TextBox();
            this.displayL = new System.Windows.Forms.Label();
            this.displayB = new System.Windows.Forms.Button();
            this.errorL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeL
            // 
            this.welcomeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeL.ForeColor = System.Drawing.SystemColors.Highlight;
            this.welcomeL.Location = new System.Drawing.Point(11, 9);
            this.welcomeL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeL.Name = "welcomeL";
            this.welcomeL.Size = new System.Drawing.Size(288, 26);
            this.welcomeL.TabIndex = 2;
            this.welcomeL.Text = "Welcome";
            this.welcomeL.Click += new System.EventHandler(this.welcomeL_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.StudentL);
            this.panel1.Controls.Add(this.StudentTB);
            this.panel1.Controls.Add(this.ScoreL);
            this.panel1.Controls.Add(this.ScoreTB);
            this.panel1.Controls.Add(this.closeB);
            this.panel1.Controls.Add(this.AddB);
            this.panel1.Controls.Add(this.CourseL);
            this.panel1.Controls.Add(this.courseTB);
            this.panel1.Location = new System.Drawing.Point(14, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 240);
            this.panel1.TabIndex = 13;
            // 
            // StudentL
            // 
            this.StudentL.AutoSize = true;
            this.StudentL.Location = new System.Drawing.Point(3, 65);
            this.StudentL.Name = "StudentL";
            this.StudentL.Size = new System.Drawing.Size(52, 15);
            this.StudentL.TabIndex = 18;
            this.StudentL.Text = "Student:";
            // 
            // StudentTB
            // 
            this.StudentTB.Location = new System.Drawing.Point(58, 65);
            this.StudentTB.Name = "StudentTB";
            this.StudentTB.Size = new System.Drawing.Size(181, 20);
            this.StudentTB.TabIndex = 17;
            // 
            // ScoreL
            // 
            this.ScoreL.AutoSize = true;
            this.ScoreL.Location = new System.Drawing.Point(3, 91);
            this.ScoreL.Name = "ScoreL";
            this.ScoreL.Size = new System.Drawing.Size(42, 15);
            this.ScoreL.TabIndex = 16;
            this.ScoreL.Text = "Score:";
            // 
            // ScoreTB
            // 
            this.ScoreTB.Location = new System.Drawing.Point(58, 91);
            this.ScoreTB.Name = "ScoreTB";
            this.ScoreTB.Size = new System.Drawing.Size(181, 20);
            this.ScoreTB.TabIndex = 15;
            // 
            // closeB
            // 
            this.closeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeB.Location = new System.Drawing.Point(20, 193);
            this.closeB.Margin = new System.Windows.Forms.Padding(2);
            this.closeB.Name = "closeB";
            this.closeB.Size = new System.Drawing.Size(118, 43);
            this.closeB.TabIndex = 14;
            this.closeB.Text = "<<Login ";
            this.closeB.UseVisualStyleBackColor = true;
            this.closeB.Click += new System.EventHandler(this.closeB_Click);
            // 
            // AddB
            // 
            this.AddB.Location = new System.Drawing.Point(186, 155);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(75, 23);
            this.AddB.TabIndex = 3;
            this.AddB.Text = "Add";
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // CourseL
            // 
            this.CourseL.AutoSize = true;
            this.CourseL.Location = new System.Drawing.Point(3, 36);
            this.CourseL.Name = "CourseL";
            this.CourseL.Size = new System.Drawing.Size(49, 15);
            this.CourseL.TabIndex = 1;
            this.CourseL.Text = "Course:";
            // 
            // courseTB
            // 
            this.courseTB.Location = new System.Drawing.Point(58, 36);
            this.courseTB.Name = "courseTB";
            this.courseTB.Size = new System.Drawing.Size(181, 20);
            this.courseTB.TabIndex = 0;
            // 
            // displayL
            // 
            this.displayL.BackColor = System.Drawing.SystemColors.ControlLight;
            this.displayL.Location = new System.Drawing.Point(289, 65);
            this.displayL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.displayL.Name = "displayL";
            this.displayL.Size = new System.Drawing.Size(213, 240);
            this.displayL.TabIndex = 19;
            // 
            // displayB
            // 
            this.displayB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayB.Location = new System.Drawing.Point(408, 307);
            this.displayB.Margin = new System.Windows.Forms.Padding(2);
            this.displayB.Name = "displayB";
            this.displayB.Size = new System.Drawing.Size(94, 29);
            this.displayB.TabIndex = 20;
            this.displayB.Text = "Display";
            this.displayB.UseVisualStyleBackColor = true;
            this.displayB.Click += new System.EventHandler(this.displayB_Click);
            // 
            // errorL
            // 
            this.errorL.AutoSize = true;
            this.errorL.ForeColor = System.Drawing.Color.Red;
            this.errorL.Location = new System.Drawing.Point(12, 316);
            this.errorL.Name = "errorL";
            this.errorL.Size = new System.Drawing.Size(0, 15);
            this.errorL.TabIndex = 21;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 358);
            this.Controls.Add(this.errorL);
            this.Controls.Add(this.displayB);
            this.Controls.Add(this.displayL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.welcomeL);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeB;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Label CourseL;
        private System.Windows.Forms.TextBox courseTB;
        private System.Windows.Forms.Label StudentL;
        private System.Windows.Forms.TextBox StudentTB;
        private System.Windows.Forms.Label ScoreL;
        private System.Windows.Forms.TextBox ScoreTB;
        private System.Windows.Forms.Label displayL;
        private System.Windows.Forms.Button displayB;
        private System.Windows.Forms.Label errorL;
    }
}
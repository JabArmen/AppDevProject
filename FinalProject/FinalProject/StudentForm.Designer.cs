
namespace FinalProject
{
    partial class StudentForm
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
            this.displayL = new System.Windows.Forms.Label();
            this.DisplayScoresB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeB = new System.Windows.Forms.Button();
            this.CourseInfoB = new System.Windows.Forms.Button();
            this.RegesterB = new System.Windows.Forms.Button();
            this.CourseL = new System.Windows.Forms.Label();
            this.courseTB = new System.Windows.Forms.TextBox();
            this.errorL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeL
            // 
            this.welcomeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeL.ForeColor = System.Drawing.SystemColors.Highlight;
            this.welcomeL.Location = new System.Drawing.Point(35, 9);
            this.welcomeL.Name = "welcomeL";
            this.welcomeL.Size = new System.Drawing.Size(384, 32);
            this.welcomeL.TabIndex = 1;
            this.welcomeL.Text = "Welcome";
            // 
            // displayL
            // 
            this.displayL.BackColor = System.Drawing.SystemColors.ControlLight;
            this.displayL.Location = new System.Drawing.Point(447, 16);
            this.displayL.Name = "displayL";
            this.displayL.Size = new System.Drawing.Size(284, 370);
            this.displayL.TabIndex = 10;
            // 
            // DisplayScoresB
            // 
            this.DisplayScoresB.Location = new System.Drawing.Point(587, 409);
            this.DisplayScoresB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DisplayScoresB.Name = "DisplayScoresB";
            this.DisplayScoresB.Size = new System.Drawing.Size(131, 32);
            this.DisplayScoresB.TabIndex = 11;
            this.DisplayScoresB.Text = "Display Scores";
            this.DisplayScoresB.UseVisualStyleBackColor = true;
            this.DisplayScoresB.Click += new System.EventHandler(this.DisplayScoresB_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.closeB);
            this.panel1.Controls.Add(this.CourseInfoB);
            this.panel1.Controls.Add(this.RegesterB);
            this.panel1.Controls.Add(this.CourseL);
            this.panel1.Controls.Add(this.courseTB);
            this.panel1.Location = new System.Drawing.Point(40, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 295);
            this.panel1.TabIndex = 12;
            // 
            // closeB
            // 
            this.closeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeB.Location = new System.Drawing.Point(27, 238);
            this.closeB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeB.Name = "closeB";
            this.closeB.Size = new System.Drawing.Size(157, 53);
            this.closeB.TabIndex = 14;
            this.closeB.Text = "<<Login ";
            this.closeB.UseVisualStyleBackColor = true;
            this.closeB.Click += new System.EventHandler(this.closeB_Click);
            // 
            // CourseInfoB
            // 
            this.CourseInfoB.Location = new System.Drawing.Point(180, 84);
            this.CourseInfoB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CourseInfoB.Name = "CourseInfoB";
            this.CourseInfoB.Size = new System.Drawing.Size(137, 28);
            this.CourseInfoB.TabIndex = 4;
            this.CourseInfoB.Text = "Course Info";
            this.CourseInfoB.UseVisualStyleBackColor = true;
            this.CourseInfoB.Click += new System.EventHandler(this.CourseInfoB_Click);
            // 
            // RegesterB
            // 
            this.RegesterB.Location = new System.Drawing.Point(219, 112);
            this.RegesterB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegesterB.Name = "RegesterB";
            this.RegesterB.Size = new System.Drawing.Size(100, 28);
            this.RegesterB.TabIndex = 3;
            this.RegesterB.Text = "Register";
            this.RegesterB.UseVisualStyleBackColor = true;
            this.RegesterB.Click += new System.EventHandler(this.RegesterB_Click);
            // 
            // CourseL
            // 
            this.CourseL.AutoSize = true;
            this.CourseL.Location = new System.Drawing.Point(4, 44);
            this.CourseL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CourseL.Name = "CourseL";
            this.CourseL.Size = new System.Drawing.Size(53, 16);
            this.CourseL.TabIndex = 1;
            this.CourseL.Text = "Course:";
            // 
            // courseTB
            // 
            this.courseTB.Location = new System.Drawing.Point(77, 44);
            this.courseTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.courseTB.Name = "courseTB";
            this.courseTB.Size = new System.Drawing.Size(240, 22);
            this.courseTB.TabIndex = 0;
            // 
            // errorL
            // 
            this.errorL.AutoSize = true;
            this.errorL.ForeColor = System.Drawing.Color.Red;
            this.errorL.Location = new System.Drawing.Point(36, 368);
            this.errorL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorL.Name = "errorL";
            this.errorL.Size = new System.Drawing.Size(0, 16);
            this.errorL.TabIndex = 13;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 453);
            this.Controls.Add(this.errorL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DisplayScoresB);
            this.Controls.Add(this.displayL);
            this.Controls.Add(this.welcomeL);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeL;
        private System.Windows.Forms.Label displayL;
        private System.Windows.Forms.Button DisplayScoresB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CourseL;
        private System.Windows.Forms.TextBox courseTB;
        private System.Windows.Forms.Button RegesterB;
        private System.Windows.Forms.Button CourseInfoB;
        private System.Windows.Forms.Button closeB;
        private System.Windows.Forms.Label errorL;
    }
}
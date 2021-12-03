
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.displayL.Size = new System.Drawing.Size(284, 371);
            this.displayL.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Display Scores";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.displayL);
            this.Controls.Add(this.welcomeL);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcomeL;
        private System.Windows.Forms.Label displayL;
        private System.Windows.Forms.Button button1;
    }
}
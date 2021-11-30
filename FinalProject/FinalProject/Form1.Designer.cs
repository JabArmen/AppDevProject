
namespace FinalProject
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.SubmitB = new System.Windows.Forms.Button();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.IdL = new System.Windows.Forms.Label();
            this.PasswordL = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitB
            // 
            this.SubmitB.Location = new System.Drawing.Point(432, 242);
            this.SubmitB.Name = "SubmitB";
            this.SubmitB.Size = new System.Drawing.Size(96, 32);
            this.SubmitB.TabIndex = 0;
            this.SubmitB.Text = "Submit";
            this.SubmitB.UseVisualStyleBackColor = true;
            // 
            // IdTB
            // 
            this.IdTB.Location = new System.Drawing.Point(201, 173);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(158, 20);
            this.IdTB.TabIndex = 1;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(200, 199);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(158, 20);
            this.PasswordTB.TabIndex = 2;
            // 
            // IdL
            // 
            this.IdL.AutoSize = true;
            this.IdL.Location = new System.Drawing.Point(108, 173);
            this.IdL.Name = "IdL";
            this.IdL.Size = new System.Drawing.Size(20, 15);
            this.IdL.TabIndex = 3;
            this.IdL.Text = "Id:";
            // 
            // PasswordL
            // 
            this.PasswordL.AutoSize = true;
            this.PasswordL.Location = new System.Drawing.Point(108, 199);
            this.PasswordL.Name = "PasswordL";
            this.PasswordL.Size = new System.Drawing.Size(64, 15);
            this.PasswordL.TabIndex = 4;
            this.PasswordL.Text = "Password:";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(62, 110);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(466, 24);
            this.Title.TabIndex = 5;
            this.Title.Text = "Vanier College Database Managment Application";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.Vanier_Image;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 286);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.PasswordL);
            this.Controls.Add(this.IdL);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.SubmitB);
            this.Name = "Menu";
            this.Text = "Vanier College";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitB;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label IdL;
        private System.Windows.Forms.Label PasswordL;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


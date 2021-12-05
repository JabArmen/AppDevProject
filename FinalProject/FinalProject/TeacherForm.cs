using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class TeacherForm : Form
    {
        private Menu menu;
        Teacher teacher;
        public TeacherForm(Teacher teacher, Menu menu)
        {
            this.teacher = teacher;
            this.menu = menu;
            this.teacher = teacher;
            InitializeComponent();
            welcomeL.Text = "Welcome back, " + teacher.name;
        }

        private void welcomeL_Click(object sender, EventArgs e)
        {

        }



        private void closeB_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            menu.Visible = true;
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            foreach (Course course in teacher.teachingCourses)
            {
                if (course.Id == courseTB.Text)
                {
                    displayL.Text = course.students.Count + "";
                    for (int i = 0; i < course.students.Count; i++)
                    {
                        
                        Student student = (Student)(course.students[i]);
                        displayL.Text += student.name + ", ";
                        if (student.Id == StudentTB.Text)
                        {
                            course.finalScores[i] = Double.Parse(ScoreTB.Text);
                            displayL.Text += "Done1";
                        }
                    }
                }
            }
            FinalProject.Menu.SerializeAll();
        }
        private void displayB_Click(object sender, EventArgs e)
        {
            displayL.Text = "";
            
            foreach (Course course in teacher.teachingCourses)
            {
                displayL.Text += "Course: " + course.name + "\n";
                for (int i = 0; i < course.students.Count; i++)
                {
                    Student student = (Student)(course.students[i]);
                    displayL.Text += "  " + student.name + ": " + course.finalScores[i] + "\n";
                   
                }
            }
           
        }
    }
}

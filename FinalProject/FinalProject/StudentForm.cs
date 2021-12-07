using System;
using System.Collections;
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
    public partial class StudentForm : Form
    {
        private Student student;
        private Menu menu;
        public StudentForm(Student student, Menu menu)
        {
            this.student = student;
            this.menu = menu;
            InitializeComponent();
            welcomeL.Text = "Welcome back, " + student.name;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void DisplayScoresB_Click(object sender, EventArgs e)
        {
            displayL.Text = "";
            foreach (Course course in student.StudentCourses)
            {
                 Grade(course);
            }
        }

        private void Grade(Course course)
        {
            for(int i = 0; i < course.Studnets.Count; i++)
            {
                Student thisStudent = (Student)course.Studnets[i];
                if (student.Id == thisStudent.Id && course.FinalScores.Count > i)
                {
                    displayL.Text += course.Name + ": " + course.FinalScores[i] + "\n";
                }
            }
        }

        private void RegesterB_Click(object sender, EventArgs e)
        {
            errorL.Text = "";
            ArrayList courses = FinalProject.Menu.courses;
            if (pickCourse(courses) != null)
            {
                student.StudentCourses.Add(pickCourse(courses));
                pickCourse(courses).Studnets.Add(student);
                pickCourse(courses).FinalScores.Add((double)-1);
                FinalProject.Menu.SerializeAll();
                
                return;
            }
            errorL.Text = "Inserted course is not valid";
        }

        private void CourseInfoB_Click(object sender, EventArgs e)
        {
            displayL.Text = "";
            ArrayList courses = FinalProject.Menu.courses;
            if (pickCourse(courses) != null)
            {
                Course course = pickCourse(courses);
                displayL.Text += "Course: " + course.Name + "\n" + "Teacher: " + course.Teacher.name + "\n";
            }
        }
        
        private Course pickCourse(ArrayList courses)
        {
            foreach(Course course in courses)
            {
                if(course.Id == courseTB.Text)
                {
                    return course;
                }
            }
            return null;
        }

        private void closeB_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            menu.Visible = true;
        }
    }
}

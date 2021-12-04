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
            foreach (Course course in student.studentCourses)
            {
                displayL.Text += course.name + ": " + Grade(course) + "\n";
            }
        }

        private double Grade(Course course)
        {
            for(int i = 0; i < course.students.Count; i++)
            {
                displayL.Text = course.students.Count + "";
                Student thisStudent = (Student)course.students[i];
                displayL.Text += "After Studer";
                if (student.Id == thisStudent.Id && course.finalScores.Count > i)
                {
                    return (double)course.finalScores[i];
                }
            }
            return -1;
        }

        private void RegesterB_Click(object sender, EventArgs e)
        {
            ArrayList courses = FinalProject.Menu.courses;
            if (pickCourse(courses) != null)
            {
                student.studentCourses.Add(pickCourse(courses));
                pickCourse(courses).students.Add(student);
                FinalProject.Menu.SerializeAll();
            }
        }

        private void CourseInfoB_Click(object sender, EventArgs e)
        {
            displayL.Text = "";
            ArrayList courses = FinalProject.Menu.courses;
            if (pickCourse(courses) != null)
            {
                Course course = pickCourse(courses);
                displayL.Text += "Course: " + course.name + "\n" + "Teacher: " + course.teacher.name + "\n";
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

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
            errorL.Text = "";
            Course course1 = (Course)(FinalProject.Menu.courses[0]);
            foreach (Course course in teacher.TeachingCourses)
            {
                 
                if (course.Id == courseTB.Text)
                {
                    for (int i = 0; i < course.Studnets.Count; i++)
                    {
                        
                        Student student = (Student)(course.Studnets[i]);
                        if (student.Id == StudentTB.Text)
                        {
                            double grade;
                            if (Double.TryParse(ScoreTB.Text, out grade)) {
                                if (grade >= 0 && grade <= 100)
                                {
                                    course.FinalScores[i] = grade;
                                    FinalProject.Menu.SerializeAll();
                                    return;
                                }
                                errorL.Text = "the grade should be from 0 to 100";
                                return;
                            }
                            errorL.Text = "the grade should be a numeric value";
                            return;
                        }
                    }
                    errorL.Text = "student is not valid";
                    return;
                }
            }
            errorL.Text = "course is not valid";

        }
        public class StudentComparer : IComparer
        {
            int IComparer.Compare(Object xx, Object yy)
            {
                Student x = (Student)xx;
                Student y = (Student)yy;
                return x.name.CompareTo(y.name);
            }
        }
        private void displayB_Click(object sender, EventArgs e)
        {
            displayL.Text = "";
            
            foreach (Course course in teacher.TeachingCourses)
            {
                displayL.Text += "Course: " + course.Name + "\n";
                ArrayList students = new ArrayList(course.Studnets);
                students.Sort(new StudentComparer());
                for (int i = 0; i < students.Count; i++)
                {
                    Student student1 = (Student)(students[i]);
                    for (int j = 0; j < course.Studnets.Count; j++) 
                    {
                        Student student2 = (Student)course.Studnets[j];
                        if(student1.Id == student2.Id)
                        {
                            displayL.Text += "  " + student2.name + ": " + course.FinalScores[j] + "\n";
                        }
                    }
                }
            }
        }
    }
}

using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Menu : Form
    {
        public static ArrayList teachers = new ArrayList();
        public static ArrayList students = new ArrayList();
        public static ArrayList courses = new ArrayList();

        public static Admin mainAdmin = new Admin("1234", "Main Admin");

        public Menu()
        {
            InitializeComponent();
            if (File.Exists("teachers.ser"))
            {
                teachers = DeserializeTeacher();
                Teacher.newId = DeserializeTeacher().Count;
            }
            if (File.Exists("students.ser"))
            {
                students = DeserializeStudent();
                Student.newId = DeserializeStudent().Count;
            }
            if (File.Exists("courses.ser"))
            {
                courses = DeserializeCourse();
                Course.newId = DeserializeCourse().Count;
            }
            
        }

        private void SubmitB_Click(object sender, EventArgs e)
        {
            if (IdTB.Text != "" || PasswordTB.Text != "")
            {
                switch (IdTB.Text[0])
                {
                    case 'A':
                        if ("A001".Equals(IdTB.Text)
                                && mainAdmin.Password.Equals(PasswordTB.Text))
                        {
                            this.Visible = false;
                            new AdminForm(mainAdmin, this).Visible = true;
                            return;
                        }
                        break;
                    case 'S':
                        foreach (Student student in students)
                            if (student.Id.Equals(IdTB.Text)
                                    && student.Password.Equals(PasswordTB.Text))
                            {
                                this.Visible = false;
                                new StudentForm(student,this).Visible = true;
                                return;
                            }
                        break;
                    case 'T':
                        foreach (Teacher teacher in teachers)
                            if (teacher.Id.Equals(IdTB.Text)
                                    && teacher.Password.Equals(PasswordTB.Text))
                            {
                                this.Visible = false;
                                new TeacherForm(teacher, this).Visible = true; ;
                                return;
                            }
                        break;
                    default:
                        errorL.Text = "Wrong password or User ID!";
                        break;

                }
            }
            errorL.Text = "Wrong password or User ID!";
        }
        public class NameSorter : IComparer
        {
            // Call CaseInsensitiveComparer.Compare with the parameters reversed.
            int IComparer.Compare(Object x, Object y)
            {
                Student s1 = (Student)x;
                Student s2 = (Student)x;
                if (s1.name.Equals(s2.name))
                {
                    return 0;
                }

                for(int i = 0; i < Math.Min(s1.name.Length, s2.name.Length); i++)
                {
                    if( s1.name[i] > s2.name[i])
                    {
                        return 1;
                    } else if (s1.name[i] < s2.name[i])
                    {
                        return -1;
                    }
                }
                if (s1.name.Length > s2.name.Length)
                    return 1;
                return -1;
            }
        }
        
        public static void SerializeAll()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("courses.ser", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Stream stream1 = new FileStream("teachers.ser", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Stream stream2 = new FileStream("students.ser", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            formatter.Serialize(stream, courses);
            formatter.Serialize(stream1, teachers);
            formatter.Serialize(stream2, students);
            stream.Close();
            stream1.Close();
            stream2.Close();
        }

        public static ArrayList DeserializeCourse()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream("courses.ser", FileMode.Open, FileAccess.ReadWrite);
            ArrayList courses = (ArrayList)formatter.Deserialize(stream);
            stream.Close();
            return courses;
        }

        public static ArrayList DeserializeTeacher()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream("teachers.ser", FileMode.Open, FileAccess.ReadWrite);
            ArrayList teachers = (ArrayList)formatter.Deserialize(stream);
            stream.Close();
            return teachers;
        }

        public static ArrayList DeserializeStudent()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream("students.ser", FileMode.Open, FileAccess.Read);
            ArrayList students = (ArrayList)formatter.Deserialize(stream);
            stream.Close();
            return students;
        }

    }

}

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

        public static String pathStudent;
        public static String pathTeacher;
        public static String pathCourse;

        private Admin mainAdmin = new Admin("0000", "Main Admin");

        public Menu()
        {
            InitializeComponent();
            courses.Add(new Course("yassou",new ArrayList(),new Teacher("123","armen"),5));
            SerializeAll();
        }

        private void SubmitB_Click(object sender, EventArgs e)
        {
            switch (IdTB.Text[0])
            {
                case 'A':
                    if ("A001".Equals(IdTB.Text)
                            && mainAdmin.Password.Equals(PasswordTB.Text))
                    {
                        this.Visible = false;
                        new AdminForm(mainAdmin).Visible = true;
                        return;
                    }
                    break;
                case 'S':
                    foreach (Student student in students)
                        if (student.Id.Equals(IdTB.Text)
                                && student.Password.Equals(PasswordTB.Text))
                        {
                            this.Visible = false;
                            new StudentForm(student).Visible = true;
                            return;
                        }
                    break;
                case 'T':
                    foreach (Teacher teacher in teachers)
                        if (teacher.Id.Equals(IdTB.Text)
                                && teacher.Password.Equals(PasswordTB.Text))
                        {
                            this.Visible = false;
                            new TeacherForm(teacher).Visible = true; ;
                            return;
                        }
                    break;
            }
        }

        public static void SerializeAll()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("courses.ser", FileMode.Create, FileAccess.Write);
            Stream stream1 = new FileStream("teachers.ser", FileMode.Create, FileAccess.Write);
            Stream stream2 = new FileStream("students.ser", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, courses);
            formatter.Serialize(stream1, teachers);
            formatter.Serialize(stream2, students);
            stream.Close();
            stream1.Close();
            stream2.Close();

        }

        public static ArrayList DeserializeCourse() {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("courses.ser", FileMode.Open, FileAccess.Read);
            ArrayList courses = (ArrayList)formatter.Deserialize(stream);
            stream.Close();
            return courses;
        }

        public static ArrayList DeserializeTeacher()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("teachers.ser", FileMode.Open, FileAccess.Read);
            ArrayList teachers = (ArrayList)formatter.Deserialize(stream);
            stream.Close();
            return teachers;
        }

        public static ArrayList DeserializeStudent()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("students.ser", FileMode.Open, FileAccess.Read);
            ArrayList students = (ArrayList)formatter.Deserialize(stream);
            stream.Close();
            return students;
        }

    }

}

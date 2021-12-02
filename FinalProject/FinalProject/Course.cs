using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    [Serializable]
    public class Course 
    {
        public static int newId = 1;
        protected String Id { get; set; }

        protected String name { get; set; }

        protected ArrayList students = new ArrayList();
        protected Teacher teacher { get; set; }

        protected int maxStudents { get; set; }

        public Course(String name, ArrayList students, Teacher teacher, int maxStudents) 
        {
            this.name = name;
            this.students = students;
            this.teacher = teacher;
            this.maxStudents = maxStudents;
            generateId();
        }
        public void generateId()
        {
            this.Id = String.Format("C{0:000}", newId);
            newId++;
        }

        public override bool Equals(Object obj)
        {
            return this.Id == ((Course)obj).Id;
        }

        public override string ToString()
        {
            return "Course"+name;
        }

        public override int GetHashCode() { return 0; }
    }
}

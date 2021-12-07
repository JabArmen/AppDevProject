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
        public String Id { get; set; }

        public String Name { get; set; }

        public ArrayList Studnets = new ArrayList();

        public ArrayList FinalScores = new ArrayList();
        public Teacher Teacher { get; set; }
        public int MaxStudents { get; set; }

        public Course(String name, ArrayList students, Teacher teacher, int maxStudents) 
        {
            this.Name = name;
            this.Studnets = students;
            this.Teacher = teacher;
            this.MaxStudents = maxStudents;
            
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
            return "Course"+Name;
        }

        public override int GetHashCode() { return 0; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap15_Ex_GenericSets.Entities
{
    class Course
    {
        public HashSet<Student> students;
        public char Type { get; set; }

        public Course(char type)
        {
            students = new HashSet<Student>();
            Type = type;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

    }
}

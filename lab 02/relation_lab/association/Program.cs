using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace association
{
    class Teacher
    {
        public void teach(Student student)
        {
            Console.WriteLine(" Teacher is teaching .");
            student.learn();
        }
    }

    class Student
    {
        public void learn()
        {
            Console.WriteLine(" Student is learning .");
        }
    }

    class Classroom
    {
        private Teacher teacher;
        private Student student;

        public Classroom()
        {
            teacher = new Teacher();
            student = new Student();
        }

        public void startClass()
        {
            teacher.teach(student);
        }
    }

    public class Main
    {
        public static void main(String[] args)
        {
            Classroom classroom = new Classroom();
            classroom.startClass();
        }
    }
}

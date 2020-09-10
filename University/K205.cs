using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class K205
    {
        public List<Student> StudentList;
        public List<Teacher> TeacherList;
        public List<Prog> ProgList;
        public K205()
        {
            StudentList = new List<Student>();
            TeacherList = new List<Teacher>();
            ProgList = new List<Prog>();
        }
        public void AddStudent()
        {
            Console.WriteLine("\n***************************");
            Console.Write("Please write student name:");
            string name = Console.ReadLine();
            Student stu = new Student(name);
            StudentList.Add(stu);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nStudent added successfully");
        }

        public void AddTeacher()
        {
            Console.WriteLine("\n***************************");
            Console.Write("Please write teacher name:");
            string name = Console.ReadLine();
            Teacher teach = new Teacher(name);
            TeacherList.Add(teach);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTeacher added successfully");
        }

        public void AddProg()
        {
            Console.WriteLine("\n***************************");
            Console.Write("Please write prog name:");
            string name = Console.ReadLine();
            Prog pro = new Prog(name);
            ProgList.Add(pro);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nProg added successfully");
        }
    }
}

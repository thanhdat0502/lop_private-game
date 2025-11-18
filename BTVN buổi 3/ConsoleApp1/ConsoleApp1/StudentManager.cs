using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StudentManager
    {
        public static int totalStudents = 0;
        public List<Student> Students = new List<Student>();
        public void AddStuden(Student s)
        {
            Students.Add(s);
        }
        public void ShowAllStudent()
        {
            Console.WriteLine("Danh sach sinh vien: ");
            foreach (Student s in Students)
            {
                Console.WriteLine("Ten: " + s.Name);
                Console.WriteLine("Lop: " + s.Grade);
                Console.WriteLine("Diem: " + s.Score);
            }
        }
        public Student FindTopStudent()
        {
            if (Students.Count == 0)
            {
                return null;
            }
            Student top = new Student();
            float topScore =top .Score;
            foreach(Student s in Students)
            {
                if(s.Score > topScore)
                {
                    top = s;
                    topScore = s.Score;
                }
            }
            return top;
        }
    }
}

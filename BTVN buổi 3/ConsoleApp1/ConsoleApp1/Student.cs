using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        private string name;
        private string grade;
        private float score;

        public string Name { get { return name; } set { name = value; } }
        public string Grade { get { return grade; } set  {  grade = value; } } 
        public float Score { get { return score; } set { score = value; } }
        public void UpdateScore(float newscore)
        {
            if(newscore >=0 && newscore <= 10)
            {
                this.Score= newscore;
            }
            else
            {
                Console.WriteLine("Diem khong hop le!");
            }
        }

        public Student() { }

        public Student(string name, string grade, float score)
        {
            this.name = name;
            this.grade = grade;
            this.score = score;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GroupStudent.Models
{
    internal class Group
    {
        public int Id { get; }
        private static int _lastid = 100;
        
        public string GroupNo { get; set; }
        public List<Student> Students { get; set; }
        public int Limit { get; set; }

        public Group(int limit)
        {
            Id = _lastid;
            _lastid++;
            GroupNo = $"AP{Id}";
            Limit = limit;
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            if (Limit<=0)
            {
                throw new Exception("Limit kecilib");
            }
            else
            {
                Students.Add(student);
            }
            Limit--;
        }
        public void GetAllStudents()
        {
            foreach (Student student  in Students)
            {
                if (Students is null)
                {
                    throw new Exception("Sagird yoxdur");
                }
                else
                {
                    Console.WriteLine(student);
                }
            }
        }
        public List<Student> Sort() 
        {
            if (Students.Count==0)
            {
                throw new Exception("Sort etmeye adam yoxdur");
            }
            else
            {
                Students.Sort();
                Students.Reverse();
                return this.Students;
            }
        }
        public Student FindStudentById(int id)
        {
            Student fstudent = Students.Find(s => s.Id == id);
            if (fstudent is null)
            {
                throw new Exception("Bele bir sagird yoxdur");
            }
            else if(id==null)
            {
                throw new Exception("Daxil edilen dogru id deyil");
            }
            else
            {
                Student student = Students.Find(s=> s.Id == id);
                return student;
            }
        }
    }
}

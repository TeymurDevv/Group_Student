using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupStudent.Models
{
    internal class Student:IComparable<Student>
    {
        private static int _lastid = 0;
        public int Id { get;  }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public int Point { get; set; }

        public Student(string name,string surname, int age, int point)
        {
            _lastid++;
            Id = _lastid;
            Name = name;
            SurName = surname;
            Age = age;
            Point = point;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} SurName: {SurName} Age: {Age} Point: {Point}");
        }
        public override string ToString()
        {
            return $"Name: {Name} SurName: {SurName} Age: {Age} Point: {Point}";
        }

        public int CompareTo(Student? other)
        {
            return other.Point.CompareTo(Point);
        }
    }
}

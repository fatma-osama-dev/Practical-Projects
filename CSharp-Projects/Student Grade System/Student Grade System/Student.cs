using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grade_System
{
    internal class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; } = new List<double>();

        public Student(string name) {
            Name = name;
        }
        public double GetAverage() {
            if (Grades.Count() == 0) return 0;
            return Grades.Average();
        }
    }
}

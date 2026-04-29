using Student_Grade_System;
using System;
using System.Diagnostics;

namespace StudentGradeSystem
{
    class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("\n1. Add Student");
                Console.WriteLine("2. Add Grade");
                Console.WriteLine("3. Show Top Student");
                Console.WriteLine("4. Search Student");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose :- ");
                int.TryParse(Console.ReadLine(), out int choice);
                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        AddGrades();
                        break;
                    case 3:
                        ShowTopStudent();
                        break;
                    case 4:
                        SearchStudent();
                        break;
                    case 5:
                        return;
                }


            }
        }

        public static void AddStudent()
        {
            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();
            students.Add(new Student(name));

        }




        public static void AddGrades()
        {
            Console.WriteLine("enter student name : ");
            string name = Console.ReadLine();

            var student = students.Find(x => x.Name == name);

            if (student == null)
            {
                Console.WriteLine("student not found");
                return;
            }

            Console.WriteLine("Enter grades (separated by comma): ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("No grades entered");
                return;
            }

            string[] grades = input.Split(',');

            foreach (string g in grades)
            {
                if (double.TryParse(g.Trim(), out double grade))
                {
                    student.Grades.Add(grade);
                }
                else
                {
                    Console.WriteLine($"Invalid grade skipped: {g}");
                }
            }

            Console.WriteLine("Grades added successfully!");
        }

        static void ShowTopStudent() {
            if (students.Count() == 0)
            {
                Console.WriteLine("No Students Available");
                return;
            }
            students.Sort((a, b) => b.GetAverage().CompareTo(a.GetAverage()));
            for(int i=0;i<5;i++) Console.WriteLine($"Student Name : {students[i].Name} , GradeAverage : {students[i].GetAverage()}");
        
        }

        static void SearchStudent() {
            Console.WriteLine("enter student name you want search ");
            string name = Console.ReadLine();
            var student = students.Find(x=> x.Name == name);
            if (student == null)
            {
                Console.WriteLine("student name not found");
                return;
            }
            Console.WriteLine($"Student Name : {student.Name}   ");
            foreach (var i in student.Grades) {
                Console.WriteLine(i);
            }
            
        }


    }
}

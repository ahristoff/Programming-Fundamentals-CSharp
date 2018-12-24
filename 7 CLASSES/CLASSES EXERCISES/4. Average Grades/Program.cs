using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();

                string name = input[0];
                input.Remove(input[0]);

                var grades = new List<double>();
                grades = input.Select(double.Parse).ToList();

                var std = new Student()
                {
                    Name = name,
                    Grades = grades
                };

                students.Add(std);
            }

            var output = students.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrades()).Where(x => x.AverageGrades() >= 5.00).ToList();

            foreach (var x in output)
            {
                Console.WriteLine($"{x.Name} -> {x.AverageGrades():f2}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSharp_Tips_Traps_Cource
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Pad --- ");
            Console.WriteLine(String.Format("Name: {0, 20} Age: {1, 5}", Student.s1.name, Student.s1.age));
            Console.WriteLine($"Name: {Student.s1.name.PadLeft(20)} Age: {Student.s1.age.ToString().PadLeft(5)}");

            
            Console.WriteLine(String.Format("Name: {0, -20} Age: {1, -5}", Student.s1.name, Student.s1.age));
            Console.WriteLine($"Name: {Student.s1.name.PadRight(20)} Age: {Student.s1.age.ToString().PadRight(5)}");

            Console.WriteLine("--- Format --- ");
            const string ageFormat = "(Positive) Score(#);(Negative) Score(-#);(Zero) Score(#)";
            Console.WriteLine(Student.s1.score.ToString(ageFormat));
            Console.WriteLine(Student.s2.score.ToString(ageFormat));
            Console.WriteLine(Student.s3.score.ToString(ageFormat));

            Console.WriteLine("--- Format --- ");
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5};
            List<int> list2 = Enumerable.Range(1, 5).ToList();
            List<int> list3 = Enumerable.Range(10, 5).ToList();
            List<int> list4 = Enumerable.Repeat(1, 5).ToList();
            Console.WriteLine(string.Join(",", list1));
            Console.WriteLine(string.Join(",", list2));
            Console.WriteLine(string.Join(",", list3));
            Console.WriteLine(string.Join(",", list4));
            
            Console.WriteLine("--- Equality --- ");
            var a = new Uri("https://www.google.com");
            var b = new Uri("https://www.google.com");
            Console.WriteLine(a == b);
            Console.WriteLine(object.ReferenceEquals(a, b));
            b = a;
            Console.WriteLine(object.ReferenceEquals(a, b));


            Console.WriteLine("--- Path --- ");
            string pathStr = @".\CSharp_Tips_Traps_Cource.exe";
            string fullPath = Path.GetFullPath(pathStr);
            Console.WriteLine(fullPath);
            Console.WriteLine(Path.ChangeExtension(fullPath, "aaa"));
            Console.WriteLine(Path.GetFileName(fullPath));
            Console.WriteLine(Path.GetFileNameWithoutExtension(fullPath));

            Console.WriteLine("--- Path2 --- ");
            Console.WriteLine(Path.GetRandomFileName());
            Console.WriteLine(Path.GetTempFileName());
            Console.WriteLine(Path.GetTempPath());
            Console.WriteLine(String.Join("", Path.DirectorySeparatorChar));







            Console.WriteLine(string.Join("", Enumerable.Repeat("\n", 5).ToList()));
        }
    }
}

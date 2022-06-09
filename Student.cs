using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tips_Traps_Cource
{
    internal class Student
    {
        public static Student s1 = new Student("John", "Doe", 20, -5);
        public static Student s2 = new Student("Emrehan", "İlhan", 28, 10);
        public static Student s3 = new Student("Boş", "Soyad", 15, 0);

        public string name;
        public string surname;
        public int age;
        public int score;

        public Student(string name, string surname, int age, int score)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.score = score;
        }
    }
}

using System;

namespace Practice3.Task9
{
    internal class Student
    {
        public string name { get; set; }
        public int age { get; set; }
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public static void UpdateNameStudent(Student student)
        {
            student.name = "Аноним";
        }
    }
}

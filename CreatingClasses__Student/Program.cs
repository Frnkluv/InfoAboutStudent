using System;

namespace CreatingStudent
{
    //создания каркаса для класса студент
    class Student
    {
        public Guid id;
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group;
    }
    internal class Program
    {
        //описание студента (можно подвязать базу данных)
        static Student GetStudent()
        {
            Student student = new Student();

            student.id = Guid.NewGuid();
            student.firstName = "Egor";
            student.lastName = "Medvedev";
            student.middleName = "Petrovich";
            student.age = 23;
            student.group = "MMM-20";

            return student;
        }
        //метод для вывода всей инфы о студенте
        static void Print(Student student)
        {
            Console.WriteLine($"ФИО: {student.lastName} {student.firstName} {student.middleName}");
            Console.WriteLine($"Возраст: {student.age} years");
            Console.WriteLine($"Группа: {student.group}");
            Console.WriteLine($"id: {student.id}");

        }
        static void Main(string[] args)
        {
            var firstStudent = GetStudent();
            Print(firstStudent);
        }
    }
}

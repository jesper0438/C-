using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student mijnStudent = new Student(12345,"Gesper", "SRE1a");
            Student deStudent = new Student(123455,"erwin", "alles");

            // Dit gaat over mijn huis
            Console.WriteLine(mijnStudent.GeefStudentNummer());
            Console.WriteLine(mijnStudent.GeefStudentnaam());
            Console.WriteLine(mijnStudent.GeefCompetenties());

            Console.WriteLine(mijnStudent.GeefStudentNummer());
            Console.WriteLine(deStudent.GeefStudentnaam());
            Console.WriteLine(deStudent.GeefCompetenties());










            string name = Console.ReadLine();
            Console.Read();
        }
    }
}

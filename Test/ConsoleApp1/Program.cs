using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student mijnStudent = new Student(117476,"Jesper", "IAN1");
            Student deStudent = new Student(123455,"Erwin", "SRE1a");
            Persoon ikPersoon = new Persoon("Jeppie", 21, "Napoli", "Woef");

            // Dit gaat over mij als student
            Console.WriteLine("Studentnummer");
            Console.WriteLine(mijnStudent.GeefStudentNummer());
            Console.WriteLine("Studentnaam");
            Console.WriteLine(mijnStudent.GeefStudentnaam());
            Console.WriteLine("Competentie");
            Console.WriteLine(mijnStudent.GeefCompetenties());
            // Dit gaat over erwin als student
            Console.WriteLine("Studentnummer");
            Console.WriteLine(deStudent.GeefStudentNummer());
            Console.WriteLine("Studentnaam");
            Console.WriteLine(deStudent.GeefStudentnaam());
            Console.WriteLine("Competentie");
            Console.WriteLine(deStudent.GeefCompetenties());
            // Dit gaat over mij als persoon
            Console.WriteLine("Naam");
            Console.WriteLine(ikPersoon.GeefPersoonsNaam());
            Console.WriteLine("Leeftijd");
            Console.WriteLine(ikPersoon.GeefLeefijd());
            Console.WriteLine("Woonplaats");
            Console.WriteLine(ikPersoon.GeefWoonplaats());
            Console.WriteLine("Huisdier");
            Console.WriteLine(ikPersoon.GeefHuisdier());



            string name = Console.ReadLine();
            Console.Read();
        }
    }
}

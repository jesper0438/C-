using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student
    {
        private int Studentnummer;
        private string Competenties;
        private Boolean Propedeuse;
        private string StudentNaam;

        //Constructor
        public Student(int studentnummer, string studentnaam, string competenties)
        {
            this.Studentnummer = studentnummer;
            this.StudentNaam = studentnaam;
            this.Competenties = competenties;
            this.Propedeuse = true;
            
        }
        //Methodes
        public int GeefStudentNummer()
        {
            return this.Studentnummer;
        }

        public string GeefStudentnaam()
        {
            return this.StudentNaam;
        }

        public string  GeefCompetenties()
        {
            return this.Competenties;
        }
        
        public Boolean HeeftPropedeuse()
        {
            return this.Propedeuse;
        }
}

}     



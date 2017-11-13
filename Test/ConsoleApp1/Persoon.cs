using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Persoon
    {
        private string Naam;
        private int Leeftijd;
        private string Woonplaats;
        private string Huisdier;

        //Constructor
        public Persoon(string naam, int leeftijd, string woonplaats, string huisdier)
        {
            this.Naam = naam;
            this.Leeftijd = leeftijd;
            this.Woonplaats = woonplaats;
            this.Huisdier = huisdier;
        }

        public string GeefPersoonsNaam()
        {
            return this.Naam;
        }

        public int GeefLeefijd()
        {
            return this.Leeftijd;
        }

        public string GeefWoonplaats()
        {
            return this.Woonplaats;
        }

        public string GeefHuisdier()
        {
            return this.Huisdier;
        }


    }
}

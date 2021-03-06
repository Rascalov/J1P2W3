﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Kaartje
    {
        private string filmNaam;
        private int zaal;
        private DateTime aanvangsTijd;
        private int minimumLeeftijd;
        public decimal Prijs { get; private set; }
        public string FilmNaam
        {
            get { return filmNaam; }
            set
            {
                if (value != "")
                {
                    filmNaam = value;
                }
                else
                {
                    Console.WriteLine($"Error occured: Invalid name!");
                }
            }
        }
        public int Zaal
        {
            get { return zaal; }
            set
            {
                if (value >= 1 && value <= 5)
                {
                    zaal = value;
                }
                else
                {
                    Console.WriteLine($"Error occured, invalid cinema room ({value})!");
                }
            }
        }
        public DateTime AanvangTijd
        {
            get { return aanvangsTijd; }
            set
            {
                if (value.Minute == 0 || value.Minute == 30)
                {
                    aanvangsTijd = value;
                }
                else
                {
                    Console.WriteLine($"Error occured: Invalid start time! ({value})");
                }
            }
        }
        public int MinimumLeeftijd
        {
            get { return minimumLeeftijd; }
            set
            {
                int[] leeftijden = { 0, 6, 9, 12, 16 };
                if (leeftijden.Contains(value))
                {
                    minimumLeeftijd = value;
                }
                else
                {
                    Console.WriteLine($"Error occured: invalied minimum age ({value})!");
                }
            }
        }
        public bool Korting
        {
            get
            {
                return (AanvangTijd.DayOfWeek == DayOfWeek.Monday || AanvangTijd.DayOfWeek == DayOfWeek.Tuesday);
            }
        }
        public Kaartje(string naam, int zaal, decimal prijs, int minLeeftijd, DateTime startTijd)
        {
            FilmNaam = naam;
            Zaal = zaal;
            Prijs = prijs;
            MinimumLeeftijd = minLeeftijd;
            AanvangTijd = startTijd;
        }
    }
}

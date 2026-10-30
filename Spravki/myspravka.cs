using laba2.Interfaces;
using laba2.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace laba2.Spravki
{
    public class SpravkaPochUvol: ISpravka
    {
        public string SpravkaName { get; set; } = "Справка почему уволился.";
        public Patient Patient { get; set; }
        public decimal Price { get; set; }
        public string Whyout { get; set; }
        private int voprosi = 0;

        public void DisplayInfo()
        {
            Console.WriteLine($"Spravka Name: {SpravkaName}");
            Console.WriteLine($"Patient: {Patient.Name} {Patient.Surname}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Reason: {Whyout}");
        }

        public decimal CalculatePrice()
        {
            return Price;
        }

        public string GetShortInfo()
        {
            return $"{SpravkaName}: {CalculatePrice()}";
        }

        public void Whywhy()
        {
            if (voprosi == 0) { Console.WriteLine(Whyout); voprosi += 1; }
            else if (voprosi > 0) { Console.WriteLine("Да пошел ты лесом, я объяснил уже"); }
        }

    }
}
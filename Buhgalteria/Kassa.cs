using System;
using System.Collections.Generic;
using System.Text;
using laba2.Interfaces;

namespace laba2.Buhgalteria
{
    public class Kassa
    {
        public decimal Total(List<ISpravka> spravkas)
        {
            decimal total = 0;
            foreach (var spravka in spravkas)
            {
                total += spravka.CalculatePrice();
            }
            return total;
        }

        public decimal PrintCheck(List<ISpravka> spravki)
        {
            decimal totalprice = 0;
            foreach (var spravka in spravki)
            {
                Console.WriteLine(spravka.GetShortInfo());
                totalprice += spravka.CalculatePrice();
            }
            Console.WriteLine($"Total: {totalprice}");
            return totalprice;
        }
    }
}
using laba2.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace laba2.Interfaces
{
    public interface ISpravka
    {
        string SpravkaName { get; set; }
        Patient Patient { get; set; }
        decimal Price { get; set; }

        void DisplayInfo();

        decimal CalculatePrice();

        string GetShortInfo();
    }
}
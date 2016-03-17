using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassPractice
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public double DetermineMarketValue()
        {
            double carValue;

            if (Year > 1990)
                carValue = 2000.000;
            else
                carValue = 1000.000;
            return carValue;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassPractice
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Car myNewCar = new Car();

            myNewCar.Make = "Acura";
            myNewCar.Model = "Skylander";
            myNewCar.Year = 1989;
            myNewCar.Color = "Silver";

            double myMarketValue = myNewCar.DetermineMarketValue();

            resultLabel.Text = String.Format("{0} {1} {2} {3} {4:C}", myNewCar.Make, myNewCar.Model, myNewCar.Year.ToString(), myNewCar.Color, myMarketValue);
        }
    }

    class Car
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
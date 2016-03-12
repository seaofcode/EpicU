using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_036
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Car myNewCar = new Car();

            myNewCar.Make = "Oldsmobile";
            myNewCar.Model = "Cutless Supreme";
            myNewCar.Year = 1986;
            myNewCar.Color = "Silver";

            double myMarketValue = determineMarketValue(myNewCar);

            resultLabel.Text = String.Format("{0} - {1} - {2} - {3} - {4:C}", myNewCar.Make, myNewCar.Model, myNewCar.Year.ToString(), myNewCar.Color, myMarketValue);
        }

        private double determineMarketValue(Car car)
        {
            double carValue = 100.00;
            // Write some code to go online and look up the car's value
            // retrieve it in the carValue var;
            return carValue;
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

    }
}
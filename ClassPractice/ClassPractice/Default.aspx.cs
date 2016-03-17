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
}
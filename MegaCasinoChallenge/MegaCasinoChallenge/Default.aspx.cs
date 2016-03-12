using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaCasinoChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void pullButton_Click(object sender, EventArgs e)
        {
            //When someone clicks the pull button display a random button in Image 1
            string image = spinReel();
            Image1.ImageUrl = "/Images/" + image + ".png";
        }

        private string spinReel()
        {
            string[] images = new string[] { "Bar", "Bell", "Cherry", "Clover", "Diamond", "HorseShoe", "Lemon", "Orange", "Plum", "Seven", "Strawberry", "Watermellon" };
            Random random = new Random();
            return images[random.Next(11)];
        }
    }
}
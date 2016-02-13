using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstChallenge
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void fortuneButton_Click(object sender, EventArgs e)
        {
            string ageText = ageTextBox.Text;
            string moneyText = moneyTextBox.Text;

            string result = "At " + ageText + " years old, I would have expected you to have more than " + moneyText + " in your pocket.";

            resultLabel.Text = result;
        }
    }
}
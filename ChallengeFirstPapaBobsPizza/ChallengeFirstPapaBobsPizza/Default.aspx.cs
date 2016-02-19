using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeFirstPapaBobsPizza
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void totalButton_Click(object sender, EventArgs e)
        {
            double total = 0.00;

            // Size Conditional Checks
            if (babyBobSizeRadioButton.Checked)
            {
                total += 10.00;
            }
            else if (mamaBobSizeRadioButton.Checked)
            {
                total += 13.00;
            }
            else if (papaBobSizeRadioButton.Checked)
            {
                total += 16.00;
            }

            // Crust Type Check
            if (deepDishRadioButton.Checked)
            {
                total += 2.00;
            }

            // Toppings Check
            if (pepperoniCheckBox.Checked)
            {
                total += 1.50;
            }
            if (onionCheckBox.Checked)
            {
                total += 0.75;
            }
            if (greenPepperCheckBox.Checked)
            {
                total += 0.50;
            }
            if (redPepperCheckBox.Checked)
            {
                total += 0.75;
            }
            if (anchoviesCheckBox.Checked)
            {
                total += 2.00;
            }

            // Special Deal Check
            if (pepperoniCheckBox.Checked
                && greenPepperCheckBox.Checked
                && anchoviesCheckBox.Checked
                || pepperoniCheckBox.Checked
                && redPepperCheckBox.Checked
                && onionCheckBox.Checked)
            {
                total -= 2.00;
            }

            totalLabel.Text = total.ToString();
        }
    }
}
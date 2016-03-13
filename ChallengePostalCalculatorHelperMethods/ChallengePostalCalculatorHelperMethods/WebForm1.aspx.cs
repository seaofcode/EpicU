using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethods
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void event_Changed(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void calculateTotal()
        {
            // Do the values in the TextBoxes and CheckBoxes even exist?
            if (!valuesExist()) return;

            // Determine the Volume of the parcel
            int volume; 
            if (!tryGetVolume(out volume)) return;

            // What is the multiplier for the parcel
            double postageMultiplier = getPostageMultiplier();

            // Calculate total cost
            double cost = volume * postageMultiplier;

            // Show the Result to the user
            resultLabel.Text = String.Format("Your package will cost {0:C} to ship", cost);
        }

        private bool valuesExist()
        {
            if (!airRadioButton.Checked
                && !groundRadioButton.Checked
                && !nextDayRadioButton.Checked)
                return false;

            if (widthTextBox.Text.Trim().Length == 0
                || lengthTextBox.Text.Trim().Length == 0)
                return false;

            return true;
        }

        private bool tryGetVolume(out int volume)
        {
            volume = 0;
            int width, height, length = 0;

            if (!int.TryParse(widthTextBox.Text.Trim(), out width)) return false;
            if (!int.TryParse(lengthTextBox.Text.Trim(), out height)) return false;
            if (!int.TryParse(lengthTextBox.Text.Trim(), out length)) length = 1;

            volume = width * height * length;

            return true;
        }

        private double getPostageMultiplier()
        {
            if (groundRadioButton.Checked) return .15;
            else if (airRadioButton.Checked) return .25;
            else if (nextDayRadioButton.Checked) return .45;
            else return 0;
        }
    }
}
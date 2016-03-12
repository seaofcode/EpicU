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

        protected void width_TextChanged(object sender, EventArgs e)
        {

        }

        protected void lengthTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void heightTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void groundRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void airRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void nextDayRadioButton_CheckedChanged(object sender, EventArgs e)
        {

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
                || heightTextBox.Text.Trim().Length == 0)
                return false;

            return true;
        }

        private bool tryGetVolume(out int volume)
        {
            return;
        }

        private double getPostageMultiplier()
        {
            return;
        }
    }
}
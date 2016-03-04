using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_023
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Create new double[] hours with one item in it
                double[] hours = new double[0];
                // Add it to ViewState
                ViewState.Add("Hours", hours);
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            // Retrieve array in ViewState with another double[] hours, cast it into double[]
            double[] hours = (double[])ViewState["Hours"];

            // Use Array.Resize();
            Array.Resize(ref hours, hours.Length + 1);

            // Get the last Index of the Array, hold it in a int var
            int newestItem = hours.GetUpperBound(0);

            // Make last index of hours[] equal to hoursTextBox.Text, parse into double
            hours[newestItem] = double.Parse(hoursTextBox.Text);

            // Make ViewState "Hours" equal to hours, the resized Array
            ViewState["Hours"] = hours;

            // Print to resultLable, using String.Format along with Helper Functions, Sum, Min, Max and Average
            resultLabel.Text = String.Format("Total Hours:{0} <br /> Most Hours: {1} <br /> Least Hours: {2} <br /> Average Hours: {3:N}",
                                hours.Sum(),
                                hours.Max(),
                                hours.Min(),
                                hours.Average());
        }
    }
}
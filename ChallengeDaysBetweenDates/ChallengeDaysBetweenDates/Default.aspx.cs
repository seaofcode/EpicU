using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            DateTime startDate = startCalendar.SelectedDate;
            DateTime endDate = endCalendar.SelectedDate;

            if (startDate > endDate)
            {
                resultLabel.Text = "You cannot subtract a greater value than a lesser value";
            }
            else {
                TimeSpan lengthBetweenDate = endDate.Subtract(startDate);
                //string formatResult = String.Format("{0:0 Days}", lengthBetweenDate);
                resultLabel.Text = lengthBetweenDate.ToString();
                ;
            }
            
            
        }
    }
}
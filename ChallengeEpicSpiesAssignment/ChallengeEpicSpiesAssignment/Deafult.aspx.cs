using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Deafult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Initialize Calendars
                previousCalendar.SelectedDate = DateTime.Now.Date;
                startCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                endCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);
            }
            Page.MaintainScrollPositionOnPostBack = true;
        }

        protected void assignButton_Click(object sender, EventArgs e)
        {
            // Get Number of days against cost of spy per day
            TimeSpan assignmentLength = endCalendar.SelectedDate.Subtract(startCalendar.SelectedDate);
            double totalCost = assignmentLength.TotalDays * 500.00;

            // If current assignment is more than 21 days + $1000
            if (assignmentLength.TotalDays > 21)
            {
                totalCost += 1000.00;              
            }

            //If past assignment was 14 days ago
            TimeSpan previousAssignmentLength = startCalendar.SelectedDate.Subtract(previousCalendar.SelectedDate);
            double daysFromPreviousAssignment = previousAssignmentLength.TotalDays;

            if (daysFromPreviousAssignment >= 14)
            {
                resultLabel.Text = "Assignment of " +
                    spyNameTextBox.Text + " for Assignment " +
                    assignmentNameTextBox.Text + " is Authorized " +
                    "<br />Total Budget is : " + totalCost.ToString();
            }
            else
            {
                resultLabel.Text = "Error: " +
                "Start Date must be 2 weeks from Previous Assignment Date ";
                startCalendar.SelectedDate = previousCalendar.SelectedDate.Date.AddDays(14);
            }
        }
    }
}
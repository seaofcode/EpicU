using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
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

            // If start Date is before end date
            
            // Empty Text Box Error Checking

            //If past assignment was 14 days ago
            TimeSpan previousAssignmentLength = startCalendar.SelectedDate.Subtract(previousCalendar.SelectedDate);
            double daysFromPreviousAssignment = previousAssignmentLength.TotalDays;

            if (daysFromPreviousAssignment >= 14)
            {
                string result = String.Format("Assignment of {0} " +
                    "for Assignment {1} " +
                    "was Authorized. Budget is {2:C}", 
                    spyNameTextBox.Text,
                    assignmentNameTextBox.Text,
                    totalCost); 
                     
                resultLabel.Text = result;
            }
            else
            {
                resultLabel.Text = "Error: Start Date must be 2 weeks from Previous Assignment Date ";
                startCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
            }
        }
    }
}
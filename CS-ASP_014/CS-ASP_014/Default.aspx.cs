using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_014
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //DateTime myVaule = DateTime.Now;
            //resultLabel.Text = myVaule.ToString();
            //resultLabel.Text = myVaule.ToLongDateString();
            //resultLabel.Text = myVaule.ToLongTimeString();
            //resultLabel.Text = myVaule.ToShortDateString();
            //resultLabel.Text = myVaule.ToShortTimeString();

            //resultLabel.Text = myVaule.AddDays(2).ToString();
            //resultLabel.Text = myVaule.AddMonths(-2).ToString();

            //resultLabel.Text = myVaule.Month.ToString();
            //resultLabel.Text = myVaule.IsDaylightSavingTime().ToString();
            //resultLabel.Text = myVaule.DayOfWeek.ToString();
            //resultLabel.Text = myVaule.DayOfYear.ToString();

            //DateTime myVaule = DateTime.Parse("12/7/1969");
            DateTime myVaule = new DateTime(1969, 12, 7, 6, 30, 0);
            resultLabel.Text = myVaule.ToLongDateString();
        }
    }
}
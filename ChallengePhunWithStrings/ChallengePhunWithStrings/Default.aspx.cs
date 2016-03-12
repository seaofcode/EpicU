using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Reverse your name
            string name = "Matthew Pearson";

            for (int i = name.Length - 1; i >= 0; i--)
            {
                resultLabel.Text += name[i];
            }


        }
    }
}
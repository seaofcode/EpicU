﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_012
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void goButton_Click(object sender, EventArgs e)
        {
            //resultLabel.Text = (firstTextBox.Text == secondTextBox.Text) ? "Yes" : "No";

            /*
            resultLabel.Text = (oldCheckBox.Checked) ? "I'm teaching an old dog new tricks!"
                : "Young whipper snapper get off my lawn";
            */

            int result = (firstTextBox.Text == secondTextBox.Text) ? 100 : 50;
            resultLabel.Text = result.ToString();
        }
    }
}
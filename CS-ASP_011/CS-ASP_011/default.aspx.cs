﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_011
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";

            /*
            if (firstTextBox.Text == secondTextBox.Text)
            {
                resultLabel.Text = "Yes, They're equal";
            }
            else
            {
                resultLabel.Text = "No, They're not equal";
            }
            */


            /*
            if (coolCheckBox.Checked)
            {
                resultLabel.Text = "Yes, you are cool!";
            }
            else
            {
                resultLabel.Text = "I know you not cool";
            }
            */

            if (pizzaRadioButton.Checked)
            {
                resultLabel.Text = "Yous guys must be from Chicago";

            }
            else if (saladRadioButton.Checked)
            {
                resultLabel.Text = "You must be healthy";
            }
            else if (PBJRadioButton.Checked)
            {
                resultLabel.Text = "You must be a fun loving person";
            }
            else
            {
                resultLabel.Text = "Please select one of the options";
            }
        }
    }
}
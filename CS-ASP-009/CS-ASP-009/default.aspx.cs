﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_009
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void goButton_Click(object sender, EventArgs e)
        {
            //int i = 1;
            //int j = 2;
            //int result = i + j;
            //int result = i - j;
            //int result = i * j;
            //int result = i / j;

            /*
            i = i + 1;
            i += 1;
            i++;
            i--;
            */

            //int myInteger = 5 + 1 * 7;
            //resultLabel.Text = myInteger.ToString();

            //double myDouble = 5.5;
            //int myInteger = 7;
            //int myOtherInteger = 4;

            //double myResult = myDouble + myInteger;
            //int myResult = (int)myDouble + myInteger;
            //int myResult = myInteger / myOtherInteger;
            //double myResult = (double)myInteger / (double)myOtherInteger;

            //resultLabel.Text = myResult.ToString();

            
            int firstNumber = 2000000000;
            int secondNumber = 2000000000;
            int result = firstNumber * secondNumber;

            checked {
               // long resultNumber = firstNumber * secondNumber;
            }

            resultLabel.Text = result.ToString();

        }
    }
}
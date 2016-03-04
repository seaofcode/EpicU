using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_026
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";

            /*
            for (int i = 0; i < 10; i++)
            {
                result += "<br />" + i.ToString();
            }
            */

            /*
            for (int i = 5; i <= 15; i++)
            {
                result += "<br />" + i.ToString();
            }
            */

            /*
            for (int i = 15; i > 5; i--)
            {
                result += "<br />" + i.ToString();
            }
            */

            /*
            for (int i = 0; i < 15; i+=3)
            {
                result += "<br />" + i.ToString();
            }
            */


            /*
            for (int i = 0; i < names.Length; i++)
            {
                result += "<br />" + names[i];
            }
            */

            string[] names = new string[] { "Wolverine", "Cyclops", "Professor X", "Phoenix" };

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == "Professor X")
                {
                    result += String.Format("{0} is in {1} position", names[i], i );
                    break;
                }
            }

            resultLabel.Text = result;
        }
    }
}
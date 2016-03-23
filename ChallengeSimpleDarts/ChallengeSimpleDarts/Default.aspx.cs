using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleDarts
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void playButton_Click(object sender, EventArgs e)
        {

        }
    }

   
    class Score
    {
        // Contains a static method that will calculate the score for a dart throw
        // Each dart can score 1-20 or bullseye
        // If the dart lands on the outer ring      x2
        // If the dart lands on the inner ring      x3
        // If the dart lands on the outer bullseye  +25
        // If the dart lands on the inner bulleye   +50
    }
}
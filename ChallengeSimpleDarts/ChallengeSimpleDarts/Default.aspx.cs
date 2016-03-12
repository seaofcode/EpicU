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
    }

    class Game
     {
            // Two players will take turns throwing 3 darts each
            // Their respective scores will be added to each score via Player's Score
            // First player to reach 300 points wins
            // If the dart lands on the double or triple band, multiply the score 2x or 3x respectively
            // Display the both player's score and the winner on the web page
            // 
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
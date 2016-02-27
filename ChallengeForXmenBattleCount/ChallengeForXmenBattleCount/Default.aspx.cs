using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";

            // Your Code Here!

            
            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers.Max())
                {
                    maxIndex = i;
                }
                if (numbers[i] == numbers.Min())
                {
                    minIndex = i;
                }
            }

            result = String.Format("MaxBattleCount is {0} for {1} <br /> MinBattleCount is {2} for {3}",
                numbers[maxIndex],
                names[maxIndex],
                numbers[minIndex],
                names[minIndex]);


            resultLabel.Text = result;
        }
    }
}
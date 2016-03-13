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
                resultLabel1.Text += name[i];
            }
            

            // Reverse this sequence
            //string names = "Luke,Leia,Han,Chewy";
            /*
            string[] rebelScum = names.Split(',');
            string result = "";
            for (int i = rebelScum.Length - 1; i >= 0; i--)
            {
                result += rebelScum[i] + ",";
            }
            result = result.Remove(result.Length - 1, 1);
            resultLabel.Text = "<br/> " + result;
            */

            /*string[] rebelScum = names.Split(',');
            string result = "";
            for (int i = 0; i < rebelScum.Length; i++)
            {
                int padLeft = (14 - rebelScum[i].Length) / 2;
                string temp = rebelScum[i].PadLeft(rebelScum[i].Length + padLeft, '*');
                result += temp.PadRight(14, '*');
                result += "<br />";
            }
            */

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD ME ZO COME ZO ZHE AID OF ZHEIR COUNTRY.";
            string removeMe = "remove-me";
            int index = puzzle.IndexOf(removeMe);
            puzzle = puzzle.Remove(index, removeMe.Length);
            puzzle = puzzle.ToLower();
            puzzle = puzzle.Replace('z', 't');
            puzzle = puzzle.Remove(0, 1);
            puzzle = puzzle.Insert(0, "N");

            resultLabel4.Text = puzzle;
        }
    }
}
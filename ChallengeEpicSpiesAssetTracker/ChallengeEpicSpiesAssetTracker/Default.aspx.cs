using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Create 3 Arrays to hold Name, Election and Subterfudge Data
                string[] names = new string[0];
                int[] elections = new int[0];
                double[] subterfudge = new double[0];

                // Add them to ViewState
                ViewState.Add("Names", names);
                ViewState.Add("Elections", elections);
                ViewState.Add("Subterfudge", subterfudge);
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            // Retrieve Data from ViewState, cast them to appropriate data types
            string[] names = (string[])ViewState["Names"];
            int[] elections = (int[])ViewState["Elections"];
            double[] subterfudge = (double[])ViewState["Subterfudge"];

            // Resize each Array to hold Length + 1
            Array.Resize(ref names, names.Length + 1);
            Array.Resize(ref elections, elections.Length + 1);
            Array.Resize(ref subterfudge, subterfudge.Length + 1);

            // Get the last index of each array by GetUpperBound(0);
            int lastName = names.GetUpperBound(0);
            int lastElection = elections.GetUpperBound(0);
            int lastSubterfudge = subterfudge.GetUpperBound(0);

            // Have array[lastIndex] = to each Textbox, Parsing them as nessessary
            names[lastName] = nameTextBox.Text;
            elections[lastElection] = int.Parse(electionTextBox.Text);
            subterfudge[lastSubterfudge] = double.Parse(subterfudgeTextBox.Text);

            // Update each new ViewState
            ViewState["Names"] = names;
            ViewState["Elections"] = elections;
            ViewState["Subterfudge"] = subterfudge;

            // Print out to Result Label using String.Format
            resultLabel.Text = String.Format("Total Elections Rigged: {0}<br /> Average acts of Subterfudge per Asset: {1:N}<br /> (Last Asset you Added: {2})",
                                        elections.Sum(),
                                        subterfudge.Average(),
                                        names[lastName]);
        }
    }
}
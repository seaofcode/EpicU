using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            int result = int.Parse(firstTextBox.Text) + int.Parse(secondTextBox.Text);
            resultLabel.Text = result.ToString();
        }

        protected void subtractButton_Click(object sender, EventArgs e)
        {
            int result = int.Parse(firstTextBox.Text) - int.Parse(secondTextBox.Text);
            resultLabel.Text = result.ToString();
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            int result = int.Parse(firstTextBox.Text) * int.Parse(secondTextBox.Text);
            resultLabel.Text = result.ToString();
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            double result = double.Parse(firstTextBox.Text) / double.Parse(secondTextBox.Text);
            resultLabel.Text = result.ToString();
        }
    }
}
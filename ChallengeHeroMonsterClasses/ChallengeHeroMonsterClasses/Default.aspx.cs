using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClasses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Make two objects of class Character
            Character hero = new Character();
            hero.Name = "Maximus";
            hero.Health = 100;
            hero.MaximumDamage = 50;
            hero.AttackBonus = false;

            Character monster = new Character();
            monster.Name = "Balrog";
            monster.Health = 150;
            monster.MaximumDamage = 75;
            monster.AttackBonus = true;

            // Hero's Combat Round

            // Monster's Combat Rounds

            // Print Results
            printResults(hero);
        }

        private void printResults(Character character)
        {
             resultLabel.Text = String.Format("</p>Name: {0} Health: {1} Maximum Damage: {2} Attack Bonus: {3}</p>", character.Name, character.Health, character.MaximumDamage, character.AttackBonus );
        }
    }
}
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
            // Create two Objects of Character class
            Character hero = new Character();
            hero.Name = "Maximus";
            hero.Health = 50;
            hero.MaximumDamage = 15;
            hero.AttackBonus = false;

            Character monster = new Character();
            monster.Name = "Balrog";
            monster.Health = 75;
            monster.MaximumDamage = 20;
            monster.AttackBonus = true;

            // Hero Attack Round
            int damage = hero.Attack();
            monster.Defend(damage);

            // Monster Attack Round
            damage = monster.Attack();
            hero.Defend(damage);

            // Print results to screen
            printResults(hero);
            printResults(monster);
        }

        private void printResults(Character character)
        {
            resultLabel.Text += String.Format("<p>Name: {0} - Health: {1} - MaximumDamage: {2} - AttackBonus: {3}</p>", character.Name, character.Health, character.MaximumDamage, character.AttackBonus);
        }
    }
}
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
            hero.AttackBonus = true;

            Character monster = new Character();
            monster.Name = "Balrog";
            monster.Health = 150;
            monster.MaximumDamage = 75;
            monster.AttackBonus = true;

            Dice dice = new Dice();

            //Bonus Attack 
            if (hero.AttackBonus)
                monster.Defend(hero.Attack(dice));
            if (monster.AttackBonus)
                hero.Defend(monster.Attack(dice));

            //Battle Loop
            while (hero.Health >= 0 && monster.Health >= 0)
            {
                hero.Defend(monster.Attack(dice));
                monster.Defend(hero.Attack(dice));

                printResults(hero);
                printResults(monster);
            }

            displayResults(hero, monster);
        }

        private void displayResults(Character opponent1, Character opponent2)
        {
            if (opponent1.Health <= 0 && opponent2.Health <= 0)
                resultLabel.Text += String.Format("<p>{0} and {1} both lose</p>", opponent1.Name, opponent2.Name);
            else if (opponent1.Health <= 0)
                resultLabel.Text += String.Format("<p>{0} deafeated {1}</p>", opponent2.Name, opponent1.Name);
            else
                resultLabel.Text += String.Format("<p>0} defeated {1}</p>", opponent1.Name, opponent2.Name);
        }

        private void printResults(Character character)
        {
             resultLabel.Text += String.Format("</p>Name: {0} - Health: {1} - Maximum Damage: {2} - Attack Bonus: {3} - </p>", character.Name, character.Health, character.MaximumDamage, character.AttackBonus );
        }
    }
}
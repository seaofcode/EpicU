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
            Character hero = new Character();
            hero.Name = "Maximus";
            hero.Health = 25;
            hero.DamageMaximum = 15;
            hero.AttackBonus = false;

            Character monster = new Character();
            monster.Name = "Balrog";
            monster.Health = 50;
            monster.DamageMaximum = 20;
            monster.AttackBonus = true;

            int damage = hero.Attack();
            monster.Defend(damage);

            damage = monster.Attack();
            hero.Defend(damage);

            printResults(hero);
            printResults(monster);
        }

        private void printResults(Character character)
        {
            resultLabel.Text += String.Format("<p>Name: {0} Health: {1} DamageMaximum: {2} AttackBonus: {3}</p>", character.Name, character.Health, character.DamageMaximum, character.AttackBonus);
        }
    }

    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack()
        {
            Random random = new Random();
            int damage = random.Next(this.DamageMaximum);
            return damage;
        }

        public void Defend(int damage)
        {
            this.Health -= damage;
        }
    }
}
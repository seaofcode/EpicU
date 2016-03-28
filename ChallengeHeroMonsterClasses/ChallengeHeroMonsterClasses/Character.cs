using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeHeroMonsterClasses
{
    class Character
    {
        // Name, Health, Maximum Damage, AttackBonus Properties
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaximumDamage { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack(Dice dice)
        {
            dice.Sides = this.MaximumDamage;
            return dice.Roll();
        }

        public void Defend(int damage)
        {
            Health -= damage;
        }
    }
}
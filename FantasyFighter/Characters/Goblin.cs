﻿namespace FantasyFighter
{
    public class Goblin : Character, ICanDefend, ICanAttack 
    {
        public Goblin(string name) : base(name, health: 30, attackPoints: 3, defensePoints: 2)
        {

        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Defend()
        {
            throw new NotImplementedException();
        }
    }
}

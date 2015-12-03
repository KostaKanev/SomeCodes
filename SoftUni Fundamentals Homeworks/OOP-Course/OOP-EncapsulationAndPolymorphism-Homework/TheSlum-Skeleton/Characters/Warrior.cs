namespace TheSlum.Characters
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using System.Linq;

    public class Warrior : Character,IAttack
    {
        public Warrior(string id, int x, int y, Team team) 
            : base(id, x, y, 200, 100, team, 2)
        {
            this.AttackPoints = 150;
        }

        public int AttackPoints
        {
            get { return this.AttackPoints; }

            set { this.AttackPoints = value; }
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            Character target = null;
            foreach (var currentTarget in targetsList)
            {
                target = currentTarget;
                break;
            }
            return target;
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
        }
    }
}

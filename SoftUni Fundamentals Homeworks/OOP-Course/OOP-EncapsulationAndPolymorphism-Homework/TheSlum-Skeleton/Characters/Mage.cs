namespace TheSlum.Characters
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using System.Linq;

    public class Mage : Character, IAttack
    {
        public Mage(string id, int x, int y, Team team) 
            : base(id, x, y,150 , 50, team, 5)
        {
            this.AttackPoints = 300;
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
            Character[] targetsArray = targetsList.ToArray();
            Array.Reverse(targetsArray);
            Character target = null;
            foreach (var item in targetsArray)
            {
                target = item;
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

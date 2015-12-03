namespace TheSlum.Characters
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using System.Linq;
    public class Healer : Character, IHeal
    {
        public Healer(string id, int x, int y, Team team) 
            : base(id, x, y,75 , 50, team, 6)
        {
            this.HealingPoints = 60;
        }

        public int HealingPoints
        {
            get { return this.HealingPoints; }
            set { this.HealingPoints = value; }
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            Character target = null;
            var orderedTargets = targetsList.OrderBy(t => t.HealthPoints);
            foreach (var item in orderedTargets)
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
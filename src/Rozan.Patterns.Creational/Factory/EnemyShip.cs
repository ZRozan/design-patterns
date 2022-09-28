using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Creational.Factory
{
    public abstract class EnemyShip
    {
        private string _name;
        private double _amountDamage;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double AmountDamage
        {
            get { return _amountDamage; }
            set { _amountDamage = value; }
        }

        public void FollowHeroShip()
        {
            Console.WriteLine($"{Name} is following the hero.");
        }
        public void DisplayEnemyShip()
        {
            Console.WriteLine($"{Name} is on screen.");
        }
        public void EnemyShipShoots()
        {
            Console.WriteLine($"{Name} attacks and does {AmountDamage}!");
        }
    }
}

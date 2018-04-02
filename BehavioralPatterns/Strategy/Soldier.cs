using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Strategy
{
    /// <summary>
    /// Age of Empires Game
    /// Soldier can be of type Spearman, Archer, Gunman, Palladin and will attack() enemy
    /// Each type of soldier will use their kind of tools to attack
    /// Spearman uses spears, Archer uses bow, Gunman uses pistols, palladin rides on horse with sword
    /// </summary>
    public class Soldier
    {
        IWeapon weapon;
        IRefillBehavior refillBehavior;
        IRepairBehavior repairBehavior;

        public Soldier(IWeapon weapon, IRefillBehavior refillBehavior, IRepairBehavior repairBehavior)
        {
            this.weapon = weapon;
            this.repairBehavior = repairBehavior;
            this.refillBehavior = refillBehavior;
        }

        public void ChangeWeapon(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public void ChangeRefill(IRefillBehavior refillBehavior)
        {
            this.refillBehavior = refillBehavior;
        }

        public void Fight()
        {
            weapon.Attack();
        }

        public void Refill()
        {
            refillBehavior.Refill();
        }

        public void Repair()
        {
            repairBehavior.Repair();
        }
    }
}

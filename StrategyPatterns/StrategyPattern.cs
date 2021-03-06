﻿using System;
using Core;
using StrategyPatterns.Implementation.RefillType;
using StrategyPatterns.Implementation.RepairType;
using StrategyPatterns.Implementation.Troops;
using StrategyPatterns.Implementation.Weapon;

namespace StrategyPatterns
{
    public class StrategyPattern : IPattern
    {
        public void Implement()
        {
            // Learning a strategy Pattern
            Console.WriteLine("\nLearning Strategy Pattern\n");
            Soldier soldier1 = new Archerman(new Archer(), new WeaponBasedRefill(), new NoRepair());
            soldier1.Fight();
            soldier1.Refill();
            soldier1.Repair();

            Gunman soldier2 = new Gunman(new Gun(), new TimeBasedRefill(), new NoRepair());
            soldier2.Fight();
            soldier2.Refill();
            soldier2.Repair();

            //Superman can use any the weapon and is self repairable
            Soldier superman = new Superman(new Gun(), new TimeBasedRefill(), new SelfRepair());
            superman.Fight();
            superman.ChangeWeapon(new Archer());
            superman.ChangeRefill(new WeaponBasedRefill());
            superman.Fight();

            //Robot can use any the weapon and need human to repair
            Soldier robot = new Robot(new Archer(), new WeaponBasedRefill(), new ManualRepair());
            robot.Fight();
            robot.ChangeWeapon(new Gun());
            robot.ChangeRefill(new TimeBasedRefill());
            robot.Fight();
        }
    }
}

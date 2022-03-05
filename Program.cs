using System;
using DioRPG.src.entities;

namespace DioRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight hero = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennice", 23, "Wizard");
            Boss boss = new Boss("Salazar", 30, "Barbarian");;
            

            Console.WriteLine(hero.Attack());
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(boss.AttackBoss());
        }
    }
}

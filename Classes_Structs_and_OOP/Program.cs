using static Classes_Structs_and_OOP.Character;

namespace Classes_Structs_and_OOP
{
    //this class relates to the character and its name and exp
    public class Character
    {
        public string name;
        public int exp;

        public Character()
        {
            Reset();
        }

        public Character(string name)
        {
            this.name = name;
        }

        public virtual void PrintStatsInfo()
        {
            Console.WriteLine("Hero: " + this.name + " - " + this.exp + " EXP");
        }

        private void Reset()
        {
            this.name = "Not assigned";
            this.exp = 0;
        }


    }

    //child class of character
    public class Paladin : Character
    {
        public Weapon weapon;
        public Paladin(string name, Weapon weapon) : base(name)
        {
            this.weapon = weapon;
        }

        // ex: polymorphism overides parent class of PrintStatsInfo
        public override void PrintStatsInfo()
        {
            Console.WriteLine("Hail " + this.name + " - take up your " + this.weapon.name + "!");
        }
    }

    //this class is for the weapon and damage
    public struct Weapon
    {
        public string name;
        public int damage;

        public Weapon(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }

        public void PrintWeaponStats()
        {
            Console.WriteLine("Weapon: " + this.name + " - " + this.damage + " DMG");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Character hero = new Character();
            //Console.WriteLine("Hero: " + hero.name + " - " + hero.exp + " EXP");
            hero.PrintStatsInfo();

            Character heroine = new Character("Agatha");
            //Console.WriteLine("Hero: " + heroine.name + " - " + heroine.exp + " EXP");
            heroine.PrintStatsInfo();

            Weapon huntingBow = new Weapon("Hunting Bow", 105);
            huntingBow.PrintWeaponStats();

            //Testing reference types
            Character villian = hero;

            hero.PrintStatsInfo();
            villian.PrintStatsInfo();

            villian.name = "King Bob the Minion";

            hero.PrintStatsInfo();
            villian.PrintStatsInfo();

            Weapon warBow = huntingBow;
            huntingBow.PrintWeaponStats();
            warBow.PrintWeaponStats();

            //changes hunting bow into war bow and increase in dmg
            warBow.name = "War Bow";
            warBow.damage = 155;

            huntingBow.PrintWeaponStats();
            warBow.PrintWeaponStats();

            //Experimenting with Inheritance
            Paladin knight = new Paladin("Sir Arthur", huntingBow);
            knight.PrintStatsInfo();

            //Testing external files
            Adventurer mike = new Adventurer("Mike");
            mike.PrintStatsInfo();

            //testing dude new cs file
            Dude dave = new Dude("Dave");
            dave.PrintStatsInfo();
        }
    }
}

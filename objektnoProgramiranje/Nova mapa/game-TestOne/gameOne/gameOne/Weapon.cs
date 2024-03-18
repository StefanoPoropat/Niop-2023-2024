using System;

namespace gameOne
{
    internal class Weapon
    {
        public int w_power;
        public string w_name;
        public int w_weight;

        public Weapon(int power, string name, int weight)
        {
            w_power = power;
            w_name = name;
            w_weight = weight;
        }

        // Pre-defined weapons
        public static Weapon Axe => new Weapon(15, "Axe", 7);
        public static Weapon Staff => new Weapon(12, "Staff", 5);
        public static Weapon Bow => new Weapon(10, "Bow", 4);
        public static Weapon Mace => new Weapon(14, "Mace", 6);
        public static Weapon Fists => new Weapon(5, "Fists", 1);
        public static Weapon Sword => new Weapon(13, "Sword", 6);
    }
}

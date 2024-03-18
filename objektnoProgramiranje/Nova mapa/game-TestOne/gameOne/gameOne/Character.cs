using System;

namespace gameOne
{
    internal abstract class Character
    {
        public string name;
        public string type;
        public int health;
        public int power;
        public Weapon[] inventory = new Weapon[10];
        public int currentWeaponIndex = -1;
        public const int MaxWeight = 100; // Maximum weight the inventory can hold without being considered overweight

        public abstract void Attack(Character target);
        public abstract void ChangeWeapon(int index); // Modified to take an index
        public abstract void Add(Weapon weapon);
        public abstract void ChooseWeapon(int index);
        public abstract void Print();
        public abstract void SpecialAttack(Character target);
        public abstract void PickUp(Weapon weapon);
        public abstract int Weight();
    }
}

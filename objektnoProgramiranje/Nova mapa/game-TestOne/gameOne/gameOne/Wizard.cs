using System;

namespace gameOne
{
    internal class Wizard : Character
    {
        public Wizard(string name, string type, int health, int power)
        {
            this.name = name;
            this.type = type;
            this.health = health;
            this.power = power;
            currentWeaponIndex = -1;
        }

        public override void Attack(Character target)
        {
            Console.WriteLine(name + " attacks " + target.name + ".");
            int baseDamage = power;
            int totalWeight = Weight();
            if (totalWeight > 0.6 * MaxWeight)
            {
                baseDamage /= 2;
            }
            target.health -= baseDamage;
            Console.WriteLine(name + " deals " + baseDamage + " damage to " + target.name + ".\n");
        }

        public override void ChangeWeapon(int index)
        {
            if (index >= 0 && index <= currentWeaponIndex)
            {
                Console.WriteLine(name + " changes weapon to " + inventory[index].w_name + ".\n");
                currentWeaponIndex = index;
                power = inventory[index].w_power;
            }
            else
            {
                Console.WriteLine("Invalid weapon index.\n");
            }
        }

        public override void Add(Weapon weapon)
        {
            Console.WriteLine(name + " picks up " + weapon.w_name + ".");
            if (currentWeaponIndex == -1) 
            {
                currentWeaponIndex++;
                inventory[currentWeaponIndex] = weapon;
                power += weapon.w_power;
            }
            else if (currentWeaponIndex < 9)
            {
                currentWeaponIndex++;
                inventory[currentWeaponIndex] = weapon;
            }
            else
            {
                Console.WriteLine("Inventory is full.\n");
            }
        }

        public override void ChooseWeapon(int index)
        {
            ChangeWeapon(index);
        }

        public override void Print()
        {
            Console.WriteLine("Name: " + name + ", Type: " + type + ", Power: " + power + ", Health: " + health + ", Weight: " + Weight() + "\n");
        }

        public override void SpecialAttack(Character target)
        {
            Console.WriteLine(name + " performs special attack.");
            /*int damage = power * 2;
            Random rand = new Random();
            if (rand.Next(100) < 5)
            {
                Console.WriteLine("Critical Hit!");
                damage *= 4;
            }
            Console.WriteLine(name + " deals " + damage + " damage.");
            target.health -= damage;*/
            target.health +=60;
            Console.WriteLine(name + " heals 60 HP.\n");

        }

        public override void PickUp(Weapon weapon)
        {
            Add(weapon);
        }

        public override int Weight()
        {
            int totalWeight = 0;
            foreach (var weapon in inventory)
            {
                if (weapon != null)
                {
                    totalWeight += weapon.w_weight;
                }
            }
            return totalWeight;
        }
    }
}

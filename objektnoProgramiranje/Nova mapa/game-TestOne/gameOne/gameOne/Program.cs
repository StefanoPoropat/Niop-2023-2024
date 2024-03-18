using System;

namespace gameOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a knight character
            Knight knight = new Knight("Sir Knight", "Knight", 100, 20);
            Wizard mage = new Wizard("Dumbledoor", "Mage", 50, 200);

            // Performing actions
            knight.PickUp(Weapon.Sword);
            mage.PickUp(Weapon.Staff);
            knight.PickUp(Weapon.Mace);
            mage.PickUp(Weapon.Bow);

            knight.ChooseWeapon(1);
            knight.ChangeWeapon(0);
            knight.Attack(mage);
            knight.SpecialAttack(mage);

            mage.Attack(knight);
            mage.SpecialAttack(mage);

            knight.Print();
            mage.Print();


            Console.ReadKey();
        }
    }
}

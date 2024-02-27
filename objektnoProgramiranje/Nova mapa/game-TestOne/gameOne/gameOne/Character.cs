using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameOne
{
    internal class Character
    {
        public string m_name;
        public string m_type;
        public int m_HP;
        public int m_power;
        public Weapon[] m_inventory;

        public abstract class attack(m_type) { };
        public abstract class changeWeapon() { };
        public abstract class pickUp() { };
        public abstract class chooserWeapon() { };
        public abstract class write() { };
        public abstract class spAt() { };
        public abstract class weight() { };

    }
    class Knight : Character
    {
        Knight(string name, string type, int HP, int power)
        {
            m_name = name;
            m_type = type;
            m_HP = HP;
            m_power = power;
        }
        public override attack(){

    }
}

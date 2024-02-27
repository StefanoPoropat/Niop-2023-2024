using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace example_GeoBody
{
    public abstract class geoBody
    {
        public string m_name;
        public abstract double surface();
    }
    public class Circle : geoBody
    {
        public double m_radius;

        public Circle(string name = " ", double radius = 0.0)
        {
            m_name = name;
            m_radius = radius;
        }
        public override double surface()
        {
            return 3.14 * (m_radius * m_radius);
        }
        public void write()
        {
            Console.WriteLine("My nam is " + m_name);
        }

    }
    public class Triangle : geoBody
    {
        public double m_a;
        public double m_b;

        public Triangle(string name = " ", double a = 0, double b = 0)
        {
            m_name = name;
            m_a = a;
            m_b = b;
        }
        public override double surface()
        {
            return (m_a * m_b) / 2;
        }
        public void write()
        {
            Console.WriteLine("My nam is " + m_name);
        }
    }
}

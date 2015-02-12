using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using AbstractProduct;
using ConcreteFactory;
using Product;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ContinentFactory cf = new AmericanFactory();
            Carnivore c = cf.produceCarnivore();
            Herbivore h = cf.produceHerbivore();
            c.eat(h);
            h.eaten(c);

            cf = new AfricanFactory();
            c = cf.produceCarnivore();
            h = cf.produceHerbivore();
            c.eat(h);
            h.eaten(c);

            Console.ReadLine();
        }
    }
}

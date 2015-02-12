using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using Product;

namespace ConcreteFactory
{
    public class AmericanFactory : ContinentFactory
    {

        public AbstractProduct.Carnivore produceCarnivore()
        {
            return new Wolf();
        }

        public AbstractProduct.Herbivore produceHerbivore()
        {
            return new Bison();
        }
    }
}

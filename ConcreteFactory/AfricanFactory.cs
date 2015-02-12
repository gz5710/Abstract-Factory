using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using Product;

namespace ConcreteFactory
{
    public class AfricanFactory : ContinentFactory
    {
        public AbstractProduct.Carnivore produceCarnivore()
        {
            return new Lion();
        }

        public AbstractProduct.Herbivore produceHerbivore()
        {
            return new Wildebeest();
        }
    }
}

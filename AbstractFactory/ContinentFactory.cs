using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractProduct;

namespace AbstractFactory
{
    public interface ContinentFactory
    {
        Carnivore produceCarnivore();
        Herbivore produceHerbivore();
    }
}

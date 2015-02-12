using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProduct
{
    public interface Carnivore
    {
        string getName();
        void eat(Herbivore herbivore);
    }
}

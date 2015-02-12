using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProduct
{
    public interface Herbivore
    {
        string getName();
        void eaten(Carnivore carnivore);
    }
}

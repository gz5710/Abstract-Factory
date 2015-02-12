using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class Bison : AbstractProduct.Herbivore
    {
        public string Name { get; set; }

        public Bison() {
            this.Name = "Bison";
        }

        public void eaten(AbstractProduct.Carnivore carnivore)
        {
            Console.WriteLine("This Bison will be eaten by " + carnivore.getName() + " in america.");
        }

        public string getName()
        {
            return this.Name;
        }
    }
}

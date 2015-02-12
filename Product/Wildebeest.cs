using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class Wildebeest : AbstractProduct.Herbivore
    {
        public string Name { get; set; }

        public Wildebeest() {
            this.Name = "Wildebeest";
        }
        

        public string getName()
        {
            return this.Name;
        }


        public void eaten(AbstractProduct.Carnivore carnivore)
        {
            Console.WriteLine("This wildebeest will be eaten by " + carnivore.getName() + " in africa.");
        }
    }
}

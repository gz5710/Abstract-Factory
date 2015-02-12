using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class Wolf : AbstractProduct.Carnivore
    {
        public string Name { get; set; }
        public Wolf() {
            this.Name = "Wolf";
        }
        public void eat(AbstractProduct.Herbivore herbivore)
        {
            Console.WriteLine("This wolf will eat " + herbivore.getName() + " in america.");
        }

        public string getName()
        {
            return this.Name;
        }
    }
}

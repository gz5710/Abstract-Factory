using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractProduct;

namespace Product
{
    public class Lion : AbstractProduct.Carnivore
    {
        public string Name { get; set; }

        public Lion() {
            this.Name = "Lion";
        }
        

        public string getName()
        {
            return this.Name;
        }


        public void eat(Herbivore herbivore)
        {
            Console.WriteLine("This lion will eat " + herbivore.getName() + " in africa.");
        }
    }
}

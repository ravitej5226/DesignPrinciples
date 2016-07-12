using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class SandwichBuilder
    {
        public Sandwich sandwich;

        public Sandwich GetSandwich()
        {
            return sandwich;
        }

        public void CreateSandwich()
        {
            this.sandwich = new Sandwich();
        }

        public abstract void PrepareBread();

        public abstract void AddCheese();

        public abstract void AddCondiments();

        public abstract void AddVegetables();
        
    }
}

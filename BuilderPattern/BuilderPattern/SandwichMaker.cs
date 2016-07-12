using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class SandwichMaker
    {
        public SandwichBuilder builder { get; set; }

        public SandwichMaker(SandwichBuilder sandwichBuilder)
        {
            this.builder = sandwichBuilder;
        }

        public void BuildSandwich()
        {
            builder.CreateSandwich();
            builder.PrepareBread();
            builder.AddCheese();
            builder.AddCondiments();
            builder.AddVegetables();
        }

        public Sandwich GetSandwich()
        {
            return this.builder.GetSandwich();
        }

    }
}

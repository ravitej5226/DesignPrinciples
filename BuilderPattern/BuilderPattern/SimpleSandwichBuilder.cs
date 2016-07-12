using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class SimpleSandwichBuilder : SandwichBuilder
    {
        public override void PrepareBread()
        {
            this.sandwich.Bread = BuilderPattern.Sandwich.BreadType.White;
            this.sandwich.IsToasted = false;
        }

        public override void AddCheese()
        {
            this.sandwich.Cheese = BuilderPattern.Sandwich.CheeseType.Parmesan;
        }

        public override void AddCondiments()
        {
            this.sandwich.HasMayo = true;
            this.sandwich.HasMustard = false;
        }

        public override void AddVegetables()
        {
            this.sandwich.Vegetables = new List<string> { "Tomato", "Lettuce", "Olives" };
        }
    }
}

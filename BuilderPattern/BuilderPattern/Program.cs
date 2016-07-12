using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Sandwich sandwich = new Sandwich(Sandwich.BreadType.Wheat, Sandwich.CheeseType.American, true, false, true, new List<string> { "Tomato", "Lettuce" });

            //Sandwich kidSandwich = new Sandwich();
            //kidSandwich.Bread = BuilderPattern.Sandwich.BreadType.Wheat;
            //kidSandwich.Cheese = BuilderPattern.Sandwich.CheeseType.Parmesan;
            //kidSandwich.HasMayo = true;
            //kidSandwich.HasMustard = false;
            //kidSandwich.IsToasted = true;
            //kidSandwich.Vegetables = new List<string> { "Tomato", "Lettuce", "Olives" };
            //kidSandwich.Display();
            

            //sandwich.Display();

            //SandwichBuilder builder = new ClubSandwichBuilder();
            //builder.CreateSandwich();
            //Sandwich sandwich = builder.GetSandwich();

            SandwichMaker maker = new SandwichMaker(new ClubSandwichBuilder());
            maker.BuildSandwich();
            Sandwich sandwich = maker.GetSandwich();

            sandwich.Display(); 
        }
    }
}

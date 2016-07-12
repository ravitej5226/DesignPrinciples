using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Sandwich
    {
        public enum BreadType
        {
            White,
            Wheat,
            Oats
        }

        public enum CheeseType
        {
            American,
            Mozarella,
            Parmesan
        }

        public BreadType Bread;
        public CheeseType Cheese { get; set; }
        public bool HasMayo { get; set; }
        public bool IsToasted { get; set; }
        public bool HasMustard { get; set; }
        public List<string> Vegetables;

        public Sandwich()
        {

        }

        public Sandwich(BreadType bread, CheeseType cheese, bool hasMayo, bool istoasted, bool HasMustard, List<string> vegetables)
        {
            this.Bread = bread;
            this.Cheese = cheese;
            this.HasMayo = hasMayo;
            this.IsToasted = IsToasted;
            this.HasMustard = HasMustard;
            this.Vegetables = vegetables;
        }

        public void Display()
        {
            Console.WriteLine(string.Format("Bread: {0}", this.Bread.ToString()));
            Console.WriteLine(string.Format("Cheese: {0}", this.Cheese));
            Console.WriteLine(string.Format("Has Mayo: {0}", this.HasMayo));
            Console.WriteLine(string.Format("Has Mustard: {0}", this.HasMustard));
            Console.WriteLine(string.Format("Is Toasted: {0}", this.IsToasted));

            Console.WriteLine(string.Format("Vegetables: "));
            foreach (var item in this.Vegetables)
            {
                Console.WriteLine(string.Format("{0}", item));
            }
        }
    }
}

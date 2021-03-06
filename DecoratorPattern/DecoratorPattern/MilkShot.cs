﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class MilkShot : BeverageDecorator
    {
        public MilkShot(Beverage beverage)
            : base(beverage)
        {

        }

        public override string GetDescription()
        {
            return string.Format("{0}, {1}", this.beverage.GetDescription(), "Milk Shot");
        }

        public override double GetCost()
        {
            return this.beverage.GetCost() + 0.25;
        }
    }
}

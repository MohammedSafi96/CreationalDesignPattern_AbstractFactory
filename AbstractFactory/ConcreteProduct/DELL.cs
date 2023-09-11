using AbstractFactoryDesignPattren.AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFactoryDesignPattren.Enums.Enums;

namespace AbstractFactoryDesignPattren.AbstractFactory.ConcreteProduct
{
    internal class DELL : IBrand
    {
        public string GetBrand()
        {
            return Brands.DELL.ToString();
        }
    }
}

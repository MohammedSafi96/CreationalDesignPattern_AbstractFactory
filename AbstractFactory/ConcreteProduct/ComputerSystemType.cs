using AbstractFactoryDesignPattren.AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFactoryDesignPattren.Enums.Enums;

namespace AbstractFactoryDesignPattren.AbstractFactory.ConcreteProduct
{
    internal class Laptop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerType.Laptop.ToString();
        }
    }
    internal class Desktop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerType.Desktop.ToString();
        }
    }
}

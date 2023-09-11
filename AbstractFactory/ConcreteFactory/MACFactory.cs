using AbstractFactoryDesignPattren.AbstractFactory.AbstractInterface;
using AbstractFactoryDesignPattren.AbstractFactory.AbstractProduct;
using AbstractFactoryDesignPattren.AbstractFactory.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattren.AbstractFactory.ConcreteFactory
{
    internal class MACFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new MAC();
        }

        public IProcessor Processor()
        {
            return new I7();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }
    internal class MACLaptopFactory : MACFactory 
    {

        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}

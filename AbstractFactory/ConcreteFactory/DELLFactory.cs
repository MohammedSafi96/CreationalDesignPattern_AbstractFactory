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
    internal class DELLFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new DELL();
        }

        public IProcessor Processor()
        {
            return new I5();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }
    internal class DELLLaptopFactory : DELLFactory
    {
        
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryDesignPattren.AbstractFactory.AbstractProduct;

namespace AbstractFactoryDesignPattren.AbstractFactory.AbstractInterface
{
    internal interface IComputerFactory
    {
        IBrand Brand();
        IProcessor Processor();
        ISystemType SystemType();
    }
}

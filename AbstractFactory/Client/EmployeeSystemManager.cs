using AbstractFactoryDesignPattren.AbstractFactory.AbstractInterface;
using AbstractFactoryDesignPattren.AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattren.AbstractFactory.Client
{
    internal class EmployeeSystemManager
    {
        IComputerFactory computerFactory;
        public EmployeeSystemManager(IComputerFactory computerFactory)
        {
            this.computerFactory = computerFactory;
        }
        public string GetSystemDetails()
        {
            IBrand brand = computerFactory.Brand();
            IProcessor processor = computerFactory.Processor();
            ISystemType systemType = computerFactory.SystemType();
            return $"{brand.GetBrand()} {processor.GetProcessor()} {systemType.GetSystemType()}";
        }
    }
}

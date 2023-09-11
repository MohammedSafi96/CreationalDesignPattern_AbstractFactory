using AbstractFactoryDesignPattren.AbstractFactory.AbstractInterface;
using AbstractFactoryDesignPattren.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattren.AbstractFactory.ConcreteFactory
{
    internal class EmployeeSystemFactory
    {
        public IComputerFactory Create(EmployeeDTO emp)
        {
            IComputerFactory factory = null;
            if (emp.EmpLevel == 1) 
            {
                if (emp.JobDescription == "Manager")
                {
                    factory = new MACLaptopFactory();
                }
                else
                {
                    factory = new MACFactory();
                }
            } 
            else if (emp.EmpLevel == 2)
            {
                if (emp.JobDescription == "Manager")
                {
                    factory = new DELLLaptopFactory();
                }
                else
                {
                    factory = new DELLFactory();
                }
            }
            return factory;
        }
    }
}

using AbstractFactoryDesignPattren.AbstractFactory.AbstractInterface;
using AbstractFactoryDesignPattren.AbstractFactory.Client;
using AbstractFactoryDesignPattren.AbstractFactory.ConcreteFactory;
using AbstractFactoryDesignPattren.Model;

EmployeeDTO employee = new EmployeeDTO()
{
    EmpLevel = 1,
    JobDescription = "Manager"
};
IComputerFactory factory = new EmployeeSystemFactory().Create(employee);
EmployeeSystemManager manager = new EmployeeSystemManager(factory);
employee.ComputerDetails =  manager.GetSystemDetails();
Console.WriteLine($"Employee Computer Details: {employee.ComputerDetails}");
Console.ReadLine();
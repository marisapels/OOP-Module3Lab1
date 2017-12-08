using System;

namespace Mod2_Lab1
{
    public abstract class Employee
    {

        private static int employeeCount = 0;
        
        public int Id { get; set; }
        public string Name { get; set; }
        public double BaseSalary { get; set; }

        public Employee(string name, double baseSalary)
        {
            this.Id = employeeCount + 1;
            this.Name = name;
            this.BaseSalary = baseSalary;
            employeeCount ++;
        }

        public double GetBaseSalary() => this.BaseSalary;

        public String GetName() => this.Name;

        public int GetEmployeeID() => this.Id;

        public String toString() => ($"{this.Id} {this.Name}");

        public abstract String employeeStatus();
    }

    //TechnicalEmployee Class inheriting from Employee Class
    public class TechnicalEmployee : Employee
    {
        private int successfulCheckIns = 5;
        
        // Calls upon base-class (Employee Class) constructor from within deveived Class (Technical Class)
        // Sets salary to 75000 for all Technicans
        public TechnicalEmployee(String name) : base(name, 75000)
        {
            
        }

        // Returns basic info as in base class and adds specific to technican- successful check in info
        public override String employeeStatus()
        {
            return this.toString() + " has " + successfulCheckIns + " successful check ins";
        }
    }

    public class BusinessEmployee : Employee
    {
        private int bonusBudget = 10000;

        // Calls upon base-class (Employee Class) constructor from within deveived Class (Business Class)
        // Sets salary to 50000 for all managers
        public BusinessEmployee (string name) : base (name,50000)
        {

        }

        public override String employeeStatus()
        {
            return this.toString() + " has " + bonusBudget + " bonus budget";
        }

    }
}
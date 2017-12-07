using System;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var techy1 = new TechnicalEmployee("Tech Juros");
            Console.WriteLine(techy1.employeeStatus());
            var justEmp = new Employee("Emp Juros",55555);
            Console.WriteLine(justEmp.employeeStatus());
            var biznessEm = new BusinessEmployee("Biz Juros");
            Console.WriteLine(biznessEm.employeeStatus());
        }
    }
}

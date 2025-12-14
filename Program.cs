using System;
using EmployeeApp;

namespace EmployeeApp
{
    class Program
    {
        static void Main()
        {
            Employee emp = new Employee("Suryakala", 30000);

            emp.CalculateNetPay();
            emp.Display();
        }
    }
}

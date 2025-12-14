using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp
{
    internal class Employee
    {
        public string EmployeeName;
        public decimal BasicSalary;
        public decimal HRA;
        public decimal DA;
        public decimal Tax;
        public decimal GrossPay;
        public decimal NetPay;
        public Employee(string name, decimal basicSalary)
        {
            EmployeeName = name;
            BasicSalary = basicSalary;
        }
        public void CalculateNetPay()
        {
            HRA = BasicSalary * 0.15m;
            DA = BasicSalary * 0.10m;
            GrossPay = BasicSalary + HRA + DA;
            Tax = GrossPay * 0.08m;
            NetPay = GrossPay - Tax;
        }
        public void Display()
        {
            Console.WriteLine("Employee Name : " + EmployeeName);
            Console.WriteLine("Basic Salary  : " + BasicSalary);
            Console.WriteLine("HRA           : " + HRA);
            Console.WriteLine("DA            : " + DA);
            Console.WriteLine("Gross Pay     : " + GrossPay);
            Console.WriteLine("Tax           : " + Tax);
            Console.WriteLine("Net Pay       : " + NetPay);
        }
    }
}
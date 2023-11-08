using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Enter Employee ID:");
                int employeeId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Employee Name:");
                string employeeName = Console.ReadLine();

                Console.WriteLine("Enter Employee Gender:");
                string employeeGender = Console.ReadLine();

                Console.WriteLine("Enter Employee Salary:");
                double employeeSalary = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Date of Joining (MM/dd/yyyy):");
                DateTime dateOfJoining = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", null);

                Console.WriteLine();
                Console.WriteLine("Employee Details:");
                Console.WriteLine("ID: " + employeeId);
                Console.WriteLine("Employee Name: " + employeeName);
                Console.WriteLine("Employee Gender: " + employeeGender);
                Console.WriteLine("Employee Salary: " + employeeSalary.ToString("C")); // Format as currency
                Console.WriteLine("DOJ: " + dateOfJoining.ToString("MM/dd/yyyy"));

                // Calculate and display tax
                double taxRate = (employeeSalary > 90000) ? 0.30 : 0.15;
                double taxAmount = employeeSalary * taxRate;
                Console.WriteLine();
                Console.WriteLine("You have to pay " + (taxRate * 100) + "% tax, which is: " + taxAmount.ToString("C"));

                Console.ReadLine(); // Keep the console window open
            
        }
    }
    
}

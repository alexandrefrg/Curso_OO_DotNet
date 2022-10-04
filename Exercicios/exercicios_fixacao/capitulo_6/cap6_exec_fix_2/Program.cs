using System;
using System.Collections.Generic;

namespace cap6_exec_fix_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int entryQuantity = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= entryQuantity; i++)
            {

                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                Console.WriteLine();

                list.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            Employee employee = list.Find(x => x.Id == searchId);
            if (employee != null)
            {
                Console.Write("Enter the percentage: ");
                double bonusPercentage = double.Parse(Console.ReadLine());
                employee.increaseSalary(bonusPercentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach(Employee employeeItem in list) {
                Console.WriteLine(employeeItem);
            }
        }
    }
}

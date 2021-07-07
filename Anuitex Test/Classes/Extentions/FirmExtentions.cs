using System;
using System.Linq;
using System.Collections.Generic;

namespace Anuitex_Test.Classes
{
    static class FirmExtentions
    {
        public static bool IsEmployeeInFirm(this Firm firm, Employee employee) => firm.Employees.Contains(employee);
        public static List<Employee> GetEmployees<T>(this Firm firm) =>
            firm.Employees
            .Where(e => e is T)
            .ToList();
        public static int GetEmployeesCount<T>(this Firm firm) =>
            firm.Employees
            .Where(e => e is T)
            .Count();
        public static void PrintEmployeesInfo(this Firm firm)
        {
            List<Manager> managers = new();
            List<Foreman> foremans = new();
            List<Worker> workers = new();

            foreach(var employee in firm.Employees)
                if (employee is Manager manager)
                    managers.Add(manager);
                else if (employee is Foreman foreman)
                    foremans.Add(foreman);
                else if (employee is Worker worker)
                    workers.Add(worker);

            if (managers.Count > 0)
            {
                Console.WriteLine("Managers:");
                managers.ForEach(m => m.ShowInfo());
            }
            if (foremans.Count > 0)
            {
                Console.WriteLine("Foremans:");
                foremans.ForEach(f => f.ShowInfo());
            }
            if (workers.Count > 0)
            {
                Console.WriteLine("Workers:");
                workers.ForEach(w => w.ShowInfo());
            }
        }
    }
}

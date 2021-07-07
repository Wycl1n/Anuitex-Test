using System.Collections.Generic;

namespace Anuitex_Test.Classes
{
    class Firm
    {
        public List<Employee> Employees { get; private set; } = new();

        public static Firm operator +(Firm firm, Employee newEmployee)
        {
            firm.Employees.Add(newEmployee);
            return firm;
        }
        public static Firm operator -(Firm firm, Employee employeeToRemove)
        {
            firm.Employees.Remove(employeeToRemove);
            return firm;
        }
    }
}

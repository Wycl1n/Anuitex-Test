using Anuitex_Test.Classes;
using System;

namespace Anuitex_Test
{
    class Program
    {
        static void Main()
        {
            Firm firm = new();

            var tempManager = new Manager("Alex Sviridov", 0.5);
            firm += tempManager;
            Console.WriteLine(firm.IsEmployeeInFirm(tempManager));
            Console.WriteLine(firm.IsEmployeeInFirm(new Manager(" ", 1)));

            firm += new Foreman("Foreman 1", 1);
            firm += new Foreman("Foreman 2", 2);
            firm += new Worker("Worker 1", 1);
            firm += new Worker("Worker 2", 2);
            firm += new Worker("Worker 3", 3);
            firm += new Worker("Worker 4", 4);
            firm += new Worker("Worker 5", 5);
            Console.WriteLine("__________________________________________________");

            (firm.GetEmployees<Manager>()[0] as Manager).GiveTask();
            (firm.GetEmployees<Manager>()[0] as Manager).Work();
            (firm.GetEmployees<Foreman>()[0] as Foreman).CheckWorkers();
            (firm.GetEmployees<Foreman>()[0] as Foreman).Work();
            (firm.GetEmployees<Worker>()[0] as Worker).Work();
            Console.WriteLine();
            Console.WriteLine("__________________________________________________");

            Console.WriteLine($"Managers: {firm.GetEmployeesCount<Manager>()}");
            Console.WriteLine($"Foremans: {firm.GetEmployeesCount<Foreman>()}");
            Console.WriteLine($"Workers: {firm.GetEmployeesCount<Worker>()}");
            Console.WriteLine();

            firm.PrintEmployeesInfo();

            firm -= tempManager;
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("Delete Alex");
            Console.WriteLine("__________________________________________________");
            firm.PrintEmployeesInfo();
        }
    }
}

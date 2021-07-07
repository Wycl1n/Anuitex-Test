namespace Anuitex_Test.Classes
{
    class Worker : Employee
    {
        public Worker(string fullName, double experience) 
            : base(fullName, experience) { }
        public override void Work()
        {
            System.Console.WriteLine("Worker released product");
        }
    }
}

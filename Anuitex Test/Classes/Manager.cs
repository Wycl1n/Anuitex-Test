namespace Anuitex_Test.Classes
{
    class Manager : Employee
    {
        public Manager(string fullName, double experience) 
            : base(fullName, experience) { }

        public override void Work()
        {
            System.Console.WriteLine("Manager took an order");
        }
        public void GiveTask()
        {
            System.Console.WriteLine("Manager gave a task");
        }
    }
}

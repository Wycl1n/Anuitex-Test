namespace Anuitex_Test.Classes
{
    class Foreman : Employee
    {
        public Foreman(string fullName, double experience) 
            : base(fullName, experience) { }
        public override void Work()
        {
            System.Console.WriteLine("Foreman bought materials");
        }
        public void CheckWorkers()
        {
            System.Console.WriteLine("Foreman checked workers");
        }
    }
}

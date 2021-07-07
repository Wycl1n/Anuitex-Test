namespace Anuitex_Test.Classes
{
    abstract class Employee
    {
        protected string _fullName = "";
        protected double _experience = 0;

        public string FullName
        {
            get => _fullName;
            set
            {
                if (value.Length > 0)
                    _fullName = value;
                else
                    throw new System.Exception("FullName cannot be equal to nothing");
            }
        }
        public double Experience
        {
            get => _experience;
            set
            {
                if (value >= 0)
                    _experience = value;
                else
                    throw new System.Exception("Experience cannot be less then 0");
            }
        }
        protected Employee(string fullName, double experience)
        {
            FullName = fullName;
            Experience = experience;
        }
        public void ShowInfo()
        {
            System.Console.WriteLine($"\t{FullName} - {Experience} ({(Experience == 1 ? "year" : "years")})");
        }
        public abstract void Work();
    }
}

namespace Core.Entities
{
    public class Soldier
    {
        public string _name { get; set; }
        public string _surname { get; set; }
        public int _age { get; set; }
        public string _rank { get; set; }
        public int _yearOfService { get; set; }
        public bool _isCurrentlyWorking { get; set; }

        public Soldier(string name, string surName, int age, string rank, int yearOfService, bool isCurrentlyWorking)
        {
            string _name = name;
            string _surname = surName;
            int _age = age;
            string _rank = rank;
            int _yearOfService = yearOfService;
            bool _isCurrentlyWorking = isCurrentlyWorking;
        }

        public virtual void PerformDuty(string mission)
        {
            if (CheckRequirements())
            {
                Console.WriteLine($"{mission} tapşırığı şamil olundu");
            }
           else
            {
                Console.WriteLine($"{mission} tapşırığı şamil oluna bilməz");
            }
        }


        private bool CheckRequirements()
        {
            if (_yearOfService < 3 || !_isCurrentlyWorking)
            {
                return false;
            }
            return true;
        }

    }

}

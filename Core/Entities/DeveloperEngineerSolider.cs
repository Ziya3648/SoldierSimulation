namespace Core.Entities
{
    public class DeveloperEngineerSolider : Soldier
    {
        private string _engineerSpeciality { get; set; }

        public DeveloperEngineerSolider(string name, string surName, int age, string rank, int yearOfService, bool isCurrentlyWorking, string engineerSpeciality)
            : base(name, surName, age, rank, yearOfService, isCurrentlyWorking)
        {
            _engineerSpeciality = engineerSpeciality;
            _name = name;
            _surname = surName;
            _age = age;
            _rank = rank;
            _yearOfService = yearOfService;
            _isCurrentlyWorking = isCurrentlyWorking;
        }

        public override void PerformDuty(string mission)
        {
            Console.WriteLine($"{mission} tapşırığı alan {_rank} {_surname} {_name} {_engineerSpeciality} ixtisasındadır");
        }
    }
}

namespace Core.Entities
{
    public class MedicSolider : Soldier
    {
        private string _medicSpeciality { get; set; }

        public MedicSolider(string name, string surName, int age, string rank, int yearOfService, bool isCurrentlyWorking, string medicSpeciality)
            : base(name, surName, age, rank, yearOfService, isCurrentlyWorking)
        {
            _medicSpeciality = medicSpeciality;
            _name = name;
            _surname = surName;
            _age = age;
            _rank = rank;
            _yearOfService = yearOfService;
            _isCurrentlyWorking = isCurrentlyWorking;
        }

        public override void PerformDuty(string mission)
        {
            Console.WriteLine($"{mission} tapşırığı alan {_rank} {_surname} {_name} {_medicSpeciality} ixtisasındadır");
        }
    }
}

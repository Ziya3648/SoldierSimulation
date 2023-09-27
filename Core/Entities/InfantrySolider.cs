namespace Core.Entities
{
    public class InfantrySolider : Soldier
    {
        private string _primaryWeapon { get; set; }

        public InfantrySolider(string name, string surName, int age, string rank, int yearOfService, bool isCurrentlyWorking, string primaryWeapon)
            : base(name, surName, age, rank, yearOfService, isCurrentlyWorking)
        {
            _primaryWeapon = primaryWeapon;
            _name = name;
            _surname = surName;
            _age = age;
            _rank = rank;
            _yearOfService = yearOfService;
            _isCurrentlyWorking = isCurrentlyWorking;
        }

        public override void PerformDuty(string mission)
        {
            Console.WriteLine($"{_rank} {_surname} {_name} {mission} tapşırığı aldı və ona {_primaryWeapon} silahı təhkim olundu");
        }
    }

}

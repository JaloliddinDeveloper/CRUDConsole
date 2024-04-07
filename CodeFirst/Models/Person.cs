namespace CodeFirst.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Ism { get; set; }
        public int Yoshi { get; set; }
        public string Mutahasis { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}

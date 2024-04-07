namespace CodeFirst.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string KompaniyaNomi { get; set; }
        public string Lakatsiya { get; set; }
        public ICollection<Person> People { get; set; }
    }
}

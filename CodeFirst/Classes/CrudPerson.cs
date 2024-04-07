using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Classes
{
    public class CrudPerson
    {
        public void Create()
        {
            using (var db = new AppDbContext())
            {
                Console.Write("Nechta Person qo'shmoqchisiz: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    var person = new Person();
                    Console.WriteLine($"{i}-Odam Ismini kiriting: ");
                    person.Ism = Console.ReadLine();
                    Console.WriteLine($"{i}-Odam Yoshini kiriting: ");
                    person.Yoshi = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{i}-Odam mutaxasisligini kiriting");
                    person.Mutahasis = Console.ReadLine();
                    Console.WriteLine($"{i}-Odam Ishlaydigan Companiya Idsini kiriting: ");
                    person.CompanyId = int.Parse(Console.ReadLine());
                    db.People.Add(person);
                    db.SaveChanges();
                }
            }
        }
        public void Read()
        {
            using (var db = new AppDbContext())
            {
                Console.WriteLine("Odamlar ro'yxati: ");
                var people = db.People.Include(a => a.Company).ToList();
                foreach (var p in people)
                {
                    Console.WriteLine($"{p.Id}.{p.Ism}  {p.Yoshi}  {p.Mutahasis} {p.Company.KompaniyaNomi}");
                }
            }
        }
        public void Update()
        {
            using (var db = new AppDbContext())
            {
                Console.Write("O'zgartiriladigan Odam Idsini kiriting: ");
                var updatedPerson = db.People.FirstOrDefault(t => t.Id == int.Parse(Console.ReadLine()));

                Console.Write("O'zgartiriladigan Odam Ismini kiriting: ");
                updatedPerson.Ism = Console.ReadLine();
                Console.Write("O'zgartiriladigan Odam yoshini kiriting: ");
                updatedPerson.Yoshi = int.Parse(Console.ReadLine());
                Console.Write("O'zgartiriladigan Odam mutahasisligini kiriting: ");
                updatedPerson.Mutahasis = Console.ReadLine();
                Console.WriteLine("O'zgartiriladigan Odam Ishlaydigan kompaniya Idisini kiriting kiriting: ");
                updatedPerson.CompanyId = int.Parse(Console.ReadLine());
                db.People.Update(updatedPerson);
                db.SaveChanges();
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("O'zgargandan keyingi odamlar ro'yxati: ");
                var people = db.People.Include(a => a.Company).ToList();
                foreach (var p in people)
                {
                    Console.WriteLine($"{p.Id}.{p.Ism}  {p.Yoshi}  {p.Mutahasis} {p.Company.KompaniyaNomi}");
                }
            }
        }
        public void Delete()
        {
            using (var db = new AppDbContext())
            {
                Console.Write("O'chiriladigan Odam Idsini kiriting: ");
                var deletedPerson = db.People.FirstOrDefault(d => d.Id == int.Parse(Console.ReadLine()));
                db.People.Remove(deletedPerson);
                db.SaveChanges();
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("O'chirilgandan keyingi odamlar ro'yxati: ");
                var people = db.People.Include(a => a.Company).ToList();
                foreach (var p in people)
                {
                    Console.WriteLine($"{p.Id}.{p.Ism}  {p.Yoshi}  {p.Mutahasis} {p.Company.KompaniyaNomi}");
                }
            }
        }
    }
}

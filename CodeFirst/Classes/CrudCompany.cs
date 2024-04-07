//====
//CRUD
//====
using CodeFirst.Models;

namespace CodeFirst.Classes
{
    public class CrudCompany
    {
        public void Create()
        {
            using (var db = new AppDbContext())
            {
                Console.Write("Nechta kompaniya qo'shmoqchisiz: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    var company = new Company();
                    Console.Write($"{i}-kompaniya nomini kiriting: ");
                    company.KompaniyaNomi = Console.ReadLine();
                    Console.Write($"{i}-kompaniyani lakatsiyasini kiriting: ");
                    company.Lakatsiya = Console.ReadLine();
                    db.Companiyalar.Add(company);
                    db.SaveChanges();
                }
            }
        }
        public void Read()
        {
            using (var db = new AppDbContext())
            {
                Console.WriteLine("Kompaniyalar Ro'yxati: ");
                var companiyalar = db.Companiyalar.ToList();
                foreach (var c in companiyalar)
                {
                    Console.WriteLine($"{c.Id}.{c.KompaniyaNomi}  {c.Lakatsiya}");
                }
            }
        }
        public void Update()
        {
            using (var db = new AppDbContext())
            {
                Read();
                Console.Write("O'zgartiriladigan Kompaniya Idsini kiriting: ");
                var updatedCompany = db.Companiyalar.FirstOrDefault(a => a.Id == int.Parse(Console.ReadLine()));
                Console.WriteLine("Kompaniyani yangi nomini kiriting: ");
                updatedCompany.KompaniyaNomi = Console.ReadLine();
                Console.WriteLine("Kompaniyani yangi lakatsiyasini kiriting: ");
                updatedCompany.Lakatsiya = Console.ReadLine();
                db.Companiyalar.Update(updatedCompany);
                db.SaveChanges();
                Console.WriteLine("------------------------------------------------");

                Console.WriteLine("O'zgargan kompaniyalar ro'yxati: ");
                var companiyalar = db.Companiyalar.ToList();
                foreach (var c in companiyalar)
                {
                    Console.WriteLine($"{c.Id}.{c.KompaniyaNomi}  {c.Lakatsiya}");
                }
            }
        }
        public void Delete()
        {
            using (var db = new AppDbContext())
            {
                Read();
                Console.Write("O'chiriladigan Kompaniya Idsini kiriting: ");
                var deletedCompany = db.Companiyalar.FirstOrDefault(b => b.Id == int.Parse(Console.ReadLine()));
                db.Remove(deletedCompany);
                db.SaveChanges();
                Console.WriteLine("------------------------------------------------");

                Console.WriteLine("O'chirilgandan keyingi kompaniyalar ro'yxati: ");
                var companiyalar = db.Companiyalar.ToList();
                foreach (var c in companiyalar)
                {
                    Console.WriteLine($"{c.Id}.{c.KompaniyaNomi}  {c.Lakatsiya}");
                }
            }
        }
        public void Exit()
        {
            return;
        }
    }
}

//====
//CRUD
//====
using CodeFirst.Classes;

var crudCompany = new CrudCompany();
var crudPerson = new CrudPerson();

while (true)
{
    Console.WriteLine("Qaysi model ustida amal bajarmoqchisiz: ");
    Console.WriteLine("1.Company");
    Console.WriteLine("2.Person");

    string value = Console.ReadLine();
    int n;
    if (int.TryParse(value, out n) && n == 1 && n <= 2)
    {
        Console.Clear();
        while (true)
        {
            Console.WriteLine("Company model ustida qanday amal bajarmoqchisiz: ");
            Console.WriteLine("1.Create");
            Console.WriteLine("2.Read");
            Console.WriteLine("3.Update");
            Console.WriteLine("4.Delete");
            Console.WriteLine("5.Back");
            string _value = Console.ReadLine();
            int k;
            if (int.TryParse(_value, out k) && k == 1 && k <= 5)
            {
                Console.Clear();
                crudCompany.Create();
            }
            else if (int.TryParse(_value, out k) && k == 2 && k <= 5)
            {
                Console.Clear();
                crudCompany.Read();
            }
            else if (int.TryParse(_value, out k) && k == 3 && k <= 5)
            {
                Console.Clear();
                crudCompany.Update();
            }
            else if (int.TryParse(_value, out k) && k == 4 && k <= 5)
            {
                Console.Clear();
                crudCompany.Delete();
            }
            else if (int.TryParse(_value, out k) && k == 5 && k <= 5)
                break;
            else
            {
                Console.Clear();
                Console.WriteLine("Mos amalni kiriting 1,2,3,4,5");
            }
        }
    }
    else if (int.TryParse(value, out n) && n == 2 && n <= 2)
    {
        Console.Clear();
        while (true)
        {
            Console.WriteLine("Person model ustida qanday amal bajarmoqchisiz: ");
            Console.WriteLine("1.Create");
            Console.WriteLine("2.Read");
            Console.WriteLine("3.Update");
            Console.WriteLine("4.Delete");
            Console.WriteLine("5.Back");
            string value_ = Console.ReadLine();
            int h;
            if (int.TryParse(value_, out h) && h == 1 && h <= 5)
            {
                Console.Clear();
                crudPerson.Create();
            }
            else if (int.TryParse(value_, out h) && h == 2 && h <= 5)
            {
                Console.Clear();
                crudPerson.Read();
            }
            else if (int.TryParse(value_, out h) && h == 3 && h <= 5)
            {
                Console.Clear();
                crudPerson.Update();
            }
            else if (int.TryParse(value_, out h) && h == 4 && h <= 5)
            {
                Console.Clear();
                crudPerson.Delete();
            }
            else if (int.TryParse(value_, out h) && h == 5 && h <= 5)
                break;
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Mos amalni kiriting 1 yoki 2");
    }
}


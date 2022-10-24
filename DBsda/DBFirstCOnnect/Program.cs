using DBFirstCOnnect;
using DBFirstCOnnect.Models;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ConnectDBClass())
            {
                var users = db.Customers.ToList();
                Console.WriteLine("Список объектов:");
                foreach (Customer u in users)
                {
                    Console.WriteLine($"{u.ContactName}.{u.City} - {u.Country}");
                }
            }
            Console.ReadKey();
        }
    }
}

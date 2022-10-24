using System;
using System.Linq;
using DBsda;
using Microsoft.EntityFrameworkCore;

namespace HelloApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                Company microsoft = new Company { Name = "Microsoft" };
                Company google = new Company { Name = "Google" };
                db.Companies.AddRange(microsoft, google);

                User tom = new User { Name = "Tom", Company = microsoft };
                User bob = new User { Name = "Bob", Company = google };
                User alice = new User { Name = "Alice", Company = microsoft };
                User kate = new User { Name = "Kate", Company = google };
                db.Users.AddRange(tom, bob, alice, kate);

                db.SaveChanges();

                var users = db.Users
                    .Include(u => u.Company)
                    .ToList();
                foreach (var user in users)
                    Console.WriteLine($"{user.Name} - {user.Company?.Name}");
                db.Database.EnsureDeleted();
            }
        }
    }
}
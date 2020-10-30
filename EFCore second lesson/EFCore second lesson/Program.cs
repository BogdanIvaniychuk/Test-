using System;
using System.Linq;

namespace EFCore_second_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            using (helloappdbContext db = new helloappdbContext())
            {
                var users = db.Users.ToList();
                foreach (var t in users)
                    Console.WriteLine($"Name: {t.Name}; Age: {t.Age}");
            }

            Console.ReadLine();
        }
    }
}

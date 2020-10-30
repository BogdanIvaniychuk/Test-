using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<User> users = new List<User>
            //{
            //    new User {Name="Том", Age=23, Languages = new List<string> {"английский", "немецкий" }},
            //    new User {Name="Боб", Age=27, Languages = new List<string> {"английский", "французский" }},
            //    new User {Name="Джон", Age=29, Languages = new List<string> {"английский", "испанский" }},
            //    new User {Name="Элис", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            //};

            //var selectedUsers = from user in users
            //                    from lang in user.Languages
            //                    where user.Age > 25
            //                    where lang == "английский"
            //                    select user;


            //foreach (User user in selectedUsers)
            //    Console.WriteLine($"{user.Name} - {user.Age}");

            //for (int i = 0; i < 50; i++)
            //    Console.Write("-");
            //Console.WriteLine();

            //-------------------------------------------------------------------------------

            //var SelectedUsers = users.Where(t => t.Age > 25 && t.Languages.Contains("французский")).Reverse();

            //foreach (var user in SelectedUsers)
            //    Console.WriteLine($"{user.Name} - {user.Age}");

            //for (int i = 0; i < 50; i++)
            //    Console.Write("-");
            //Console.WriteLine();

            //-------------------------------------------------------------------------------

            //var selectedNewUsers = users.Where(t => t.Age > 20).Select(t => new { Name = t.Name, DateBirthday = DateTime.Now.Year - t.Age });

            //foreach (var t in selectedNewUsers)
            //    Console.WriteLine($"{t.Name} - DateBirthday: {t.DateBirthday}");

            //for (int i = 0; i < 50; i++)
            //    Console.Write("-");
            //Console.WriteLine();

            //-------------------------------------------------------------------------------

            //List<User> users = new List<User>()
            //{
            //    new User { Name = "Sam", Age = 43 },
            //    new User { Name = "Tom", Age = 33 }
            //};

            //List<Phone> phones = new List<Phone>()
            //{
            //    new Phone {Name="Lumia 630", Company="Microsoft" },
            //    new Phone {Name="iPhone 6", Company="Apple"},
            //};

            //var people = from u in users
            //             from p in phones
            //             let t = u.Name + " Test how this work!"
            //             select new { Name = t, phone = p.Name };            


            //foreach (var t in people)
            //    Console.WriteLine($"Name: {t.Name}, phone: {t.phone}");


        }
    }
    
}

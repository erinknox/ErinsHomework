using System;
using System.Collections.Generic;
using System.Linq;


namespace Lists
{
    
    class Program
    {
       
           
        static void Main(string[] args)
        {


            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });

            users.ForEach(u => u.ToString());
            List<Models.User> passwordList =new List<Models.User>(users.Where(u => u.Password == "hello"));
            users.RemoveAll(u => u.Password == u.Name.ToLower());
           
            users.Remove(users.Where(u => u.Password == "hello").FirstOrDefault());

            users.ForEach(u => Console.WriteLine(u.Name +" "+ u.Password));

            Console.ReadLine();


        }
    }
}

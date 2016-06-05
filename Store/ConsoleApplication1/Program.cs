using Store.domain.Models;
using Store.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContextData _context = new ContextData();

            string Username = "Jeison";
            string Password = "Teste123";
            string TypeUser = "Admin";

            User user = new User(Username,Password,TypeUser);

            _context.Users.Add(user);
            _context.SaveChanges();
            _context.Dispose();
        }
    }
}

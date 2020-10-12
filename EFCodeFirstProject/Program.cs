using System;
using System.Linq;

namespace EFCodeFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //must ALWAYS create instance of context to do anything with database you just created
            var _context = new AppDbContext();
            //creating new instance (cust) in Customer from the properties of the Customer class
            var cust = new Customer()
            {
                Name = "MAX Technical Training", Active = true, Sales = 1000, Created = DateTime.Now
            };
            //adding the cust to the customer table
            _context.Customers.Add(cust);
            //saving it to database
            _context.SaveChanges();
            //returning a list of all customers in Customer table
            var custs = _context.Customers.ToList();
            foreach(var c in custs)
            {
                //will work if you keep adding more customers
                Console.WriteLine($"{c.Id}|{c.Name}|{c.Active}|{c.Sales}|{c.Created}");
            }
        }
    }
}

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
                Name = "MAX Technical Training", Code = "MAX", Active = true, Sales = 1000, Created = DateTime.Now
            };
            //adding the cust to the customer table
            //_context.Customers.Add(cust);
            ////saving it to database
            //_context.SaveChanges();
            //returning a list of ALL customers in Customer table
            var custs = _context.Customers.ToList();
            foreach(var c in custs)
            {
                //will work if you keep adding more customers
                Console.WriteLine($"{c.Id}|{c.Name}|{c.Active}|{c.Sales}|{c.Created}|{c.Code}");
            }

            //creating new order
            var ord = new Order()
            {
                Description = "First Order",
                Total = 1000,
                Created = DateTime.Now,
                CustomerId = 1
            };
            _context.Orders.Add(ord);
            _context.SaveChanges();
            //just want to see 1 and the 1 we just made
            var order = _context.Orders.Find(1);
            Console.WriteLine($"{order.Id}|{order.Description}|{order.Total}|{order.Created}|{order.CustomerId}");

            //creating new OrderLine
            var ordlin = new OrderLine() 
            { 
               
            };
        }
    }
}

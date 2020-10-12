using System;

namespace EFCodeFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //must ALWAYS create instance of context to do anything with database you just created
            var _context = new AppDbContext();

        }
    }
}

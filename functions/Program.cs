using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma nimi");
            string Username = Console.ReadLine();
            
            
            sayHello(Username);

        }

        private static void sayHello(string somename)
        {
            Console.WriteLine($"Hi There! {somename}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Programming_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <string> Class = new List<string>();
            Student kid = new Student("George", "Washington");
            Class.Add(kid.FirstName + " " + kid.LastName);
            kid.FirstName = "John"; kid.LastName = "Doe";
            Class.Add(kid.FirstName + " " + kid.LastName);
            kid.FirstName = "Jack"; kid.LastName = "Eitel";
            Class.Add(kid.FirstName + " " + kid.LastName);
            foreach (string s in Class)
            {
                Console.WriteLine(s);
            }
            Class.Clear();
            for (int i  = 0; i < 2; i++)
            {
                Console.WriteLine("Enter a first name and then a last name...");
                kid.FirstName=Console.ReadLine();
                kid.LastName=Console.ReadLine();
                Class.Add(kid.FirstName + " " + kid.LastName);
            }
            foreach (string s in Class)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}

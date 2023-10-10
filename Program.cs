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
            int select=0;
            bool valid;
            List<Student> students = new List<Student>();
            students.Add(new Student("Andrew", "Monteith"));
            students.Add(new Student("George", "Washington"));
            students.Add(new Student("Luke", "Skywalker"));
            while (true)
            {
                string menuOption;
                Console.WriteLine("Press 1 to Display Students");
                Console.WriteLine("Press 2 to View Student Details");
                Console.WriteLine("Press 3 to Add a Student");
                Console.WriteLine("Press 4 to Remove a Student");
                Console.WriteLine("Press 5 to Search for a Student");
                Console.WriteLine("Press 6 to Edit a Student");
                Console.WriteLine("Press 7 to Sort Students");
                Console.WriteLine("Press Q for Quit");
                menuOption = Console.ReadLine();
                if (menuOption == "1")
                {
                    Console.WriteLine("Students in this class... ");
                    foreach (Student student in students)
                    {
                        Console.WriteLine(student);
                    }
                }
                else if (menuOption == "2")
                {
                    for (int i=0; i<students.Count; i++)
                    {
                        Console.WriteLine($"{i+1}. {students[i]}");
                    }
                    Console.WriteLine("Enter the corresponding number to view details");
                    valid = false;
                    while (!valid)
                    {
                        if (int.TryParse(Console.ReadLine(), out select) && select <= students.Count() && select>0)
                        {
                            valid = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Selection");
                        }
                    }
                    Console.WriteLine($"Name: {students[select - 1].FirstName} {students[select - 1].LastName}");
                    Console.WriteLine($"Number: {students[select - 1].StudentNumber}");
                    Console.WriteLine($"Email: {students[select - 1].Email}");
                }
                else if (menuOption == "3")
                {
                    Console.WriteLine("Enter a first name and then a last name");
                    students.Add(new Student (Console.ReadLine(), Console.ReadLine()));
                    Console.WriteLine($"{students[students.Count - 1]} has been added to the class");
                }
                else if (menuOption == "4")
                {
                    
                }
                else if (menuOption == "5")
                {
                    
                }
                else if (menuOption == "6")
                {
                    
                }
                else if (menuOption == "7")
                {
                    students.Sort();
                    foreach (Student student in students)
                    {
                        Console.WriteLine(student);
                    }
                }
                else if (menuOption == "Q" || menuOption == "q")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
    }
}

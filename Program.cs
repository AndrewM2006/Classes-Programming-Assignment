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
            string menuOption, newName, search, whatSearch;
            List<Student> students = new List<Student>();
            students.Add(new Student("Andrew", "Monteith"));
            students.Add(new Student("George", "Washington"));
            students.Add(new Student("Luke", "Skywalker"));
            while (true)
            {
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
                            Console.WriteLine($"Name: {students[select - 1].FirstName} {students[select - 1].LastName}");
                            Console.WriteLine($"Number: {students[select - 1].StudentNumber}");
                            Console.WriteLine($"Email: {students[select - 1].Email}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Selection");
                        }
                    }
                }
                else if (menuOption == "3")
                {
                    Console.WriteLine("Enter a first name and then a last name");
                    students.Add(new Student (Console.ReadLine().Trim(), Console.ReadLine().Trim()));
                    students[students.Count - 1].FirstName= char.ToUpper(students[students.Count - 1].FirstName[0]) + students[students.Count - 1].FirstName.Substring(1).ToLower();
                    students[students.Count - 1].LastName = char.ToUpper(students[students.Count - 1].LastName[0]) + students[students.Count - 1].LastName.Substring(1).ToLower();
                    Console.WriteLine($"{students[students.Count - 1]} has been added to the class");
                }
                else if (menuOption == "4")
                {
                    for (int i=0; i<students.Count; i++)
                    {
                        Console.WriteLine(students[i].FirstName + " " + students[i].LastName + " " + students[i].StudentNumber);
                    }
                    Console.WriteLine("Enter a student number to remove student");
                    valid = false;
                    while (!valid)
                    {
                        if (int.TryParse(Console.ReadLine(), out select) && students.Exists(x => x.StudentNumber == select))
                        {
                            valid = true;
                            for (int i=0; i < students.Count; i++)
                            {
                                if (select == students[i].StudentNumber)
                                {
                                    students.Remove(students[i]);
                                }
                            }
                            foreach (Student student in students)
                            {
                                Console.WriteLine(student);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Selection");
                        }
                    }
                }
                else if (menuOption == "5")
                {
                    Console.WriteLine("Are you searching for a first (f) or last (l) name?");
                    valid = false;
                    while (!valid)
                    {
                        whatSearch = Console.ReadLine().ToLower().Trim();
                        if (whatSearch == "f")
                        {
                            valid = true;
                            Console.Write("Enter a First Name: ");
                            search = Console.ReadLine().Trim();
                            if (students.Exists(x => x.FirstName == search))
                            {
                                for (int i=0; i < students.Count; i++)
                                {
                                    if (students[i].FirstName == search)
                                    {
                                        Console.WriteLine(students[i]);
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine(search + " was not found");
                            }
                        }
                        else if (whatSearch == "l")
                        {
                            valid = true;
                            Console.Write("Enter a Last Name: ");
                            search = Console.ReadLine().Trim();
                            if (students.Exists(x => x.LastName == search))
                            {
                                for (int i = 0; i < students.Count; i++)
                                {
                                    if (students[i].LastName == search)
                                    {
                                        Console.WriteLine(students[i]);
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine(search + " was not found");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, enter f for first name or l for last name");
                        }
                    }
                }
                else if (menuOption == "6")
                {
                    for (int i = 0; i < students.Count; i++)
                    {
                        Console.WriteLine(students[i].FirstName + " " + students[i].LastName + " " + students[i].StudentNumber);
                    }
                    Console.WriteLine("Enter a student number to edit student");
                    valid = false;
                    while (!valid)
                    {
                        if (int.TryParse(Console.ReadLine(), out select) && students.Exists(x => x.StudentNumber == select))
                        {
                            valid = true;
                            for (int i = 0; i < students.Count; i++)
                            {
                                if (select == students[i].StudentNumber)
                                {
                                    Console.WriteLine("Enter a new First name then last name");
                                    Console.WriteLine("Leave blank to avoid editing");
                                    Console.Write("First Name: ");
                                    newName = Console.ReadLine().Trim();
                                    newName = char.ToUpper(newName[0]) + newName.Substring(1).ToLower();
                                    if (newName != "")
                                    {
                                        students[i].FirstName = newName.Trim();
                                    }
                                    Console.Write("Last Name: ");
                                    newName = Console.ReadLine().Trim();
                                    newName = char.ToUpper(newName[0]) + newName.Substring(1).ToLower();
                                    if (newName != "")
                                    {
                                        students[i].LastName = newName.Trim();
                                    }
                                }
                            }
                            foreach (Student student in students)
                            {
                                Console.WriteLine(student);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Selection");
                        }
                    }
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

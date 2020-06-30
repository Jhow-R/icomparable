using IComparable.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\TEMP\names.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }

                    list.Sort();
                    list.ForEach(delegate (Employee emp)
                    {
                        Console.WriteLine(emp);
                    });

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}

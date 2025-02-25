using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Numerics;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registered? Teste");
            int N = int.Parse(Console.ReadLine());

            List<Dados> list = new List<Dados>();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Emplyoee #" + i + ":");
                Console.Write("ID: ");
                int _id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string _name = Console.ReadLine();
                Console.Write("Salario: ");
                double _salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                list.Add(new Dados(_id, _name, _salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employeer id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Dados dados = list.Find(x => x.Id == searchId);
            if (dados != null)
            {
                Console.WriteLine("Enter the porcetage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                dados.increaseSalary(percentage);
            } else
            {
                Console.WriteLine("Id not existent.");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employeers: ");
            foreach (Dados obj in list)
            {
                Console.WriteLine(obj);
            }
        }   
    }
}

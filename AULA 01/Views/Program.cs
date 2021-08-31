using System;

namespace AULA_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Digite o seu nome: ");
            name = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nome: " + name);
            Console.WriteLine($"Idade: {age}");
            if (age >= 18)
            {
                Console.WriteLine($"{name} é maior de idade");
            }
            else
            {
                Console.WriteLine($"{name} é menor de idade");
            }
        }
    }
}

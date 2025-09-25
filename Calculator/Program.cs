using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("-----------CALCULADORA-----------");
            Console.WriteLine("Qual operação deseja efetuar?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("");
            // short res = short.Parse(Console.ReadLine());
            string? entrada1 = Console.ReadLine();
            int res;

            while (!int.TryParse(entrada1, out res))
            {
                Console.WriteLine("Valor inválido, por favor informe um número válido:");
                entrada1 = Console.ReadLine();
            }

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }
        static void Soma()
        {

            Console.Clear();
            Console.WriteLine("Informe o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma dos valores é {resultado}");

            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Informe o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;

            Console.WriteLine($"O resultado da subtração dos valores é {resultado}");

            Menu();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Informe o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;

            Console.WriteLine($"O resultado da divisão é {resultado}");

            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Informe o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação dos valores é {resultado}");

            Menu();

        }
    }
}
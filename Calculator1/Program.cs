using System;

namespace Calculator1
{
    class Program
    {
        public static float v1, v2;
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

        static void Coleta()
        {
            Console.Clear();
            Console.WriteLine("Informe o primeiro valor: ");
            string? entrada1 = Console.ReadLine();
            //float v1;

            while (!float.TryParse(entrada1, out v1))
            {
                Console.WriteLine("Valor inválido. Por favor, informe um número válido:");
                entrada1 = Console.ReadLine();
            }

            Console.WriteLine("Informe o segundo valor: ");
            string? entrada2 = Console.ReadLine();
            //float v2;

            while (!float.TryParse(entrada2, out v2))
            {
                Console.WriteLine("Valor inválido. Por favor, informe um número válido:");
                entrada2 = Console.ReadLine();
            }


        }

        static void Soma()
        {
            Coleta();
            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma dos valores é {resultado}");
            Console.WriteLine("Pressione ENTER para voltar ao Menu!");
            Console.ReadLine();
            Menu();
        }

        static void Subtracao()
        {
            Coleta();
            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração dos valores é {resultado}");
            Console.WriteLine("Pressione ENTER para voltar ao Menu!");
            Console.ReadLine();
            Menu();
        }

        static void Divisao()
        {
            Coleta();
            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão dos valores é {resultado}");
            Console.WriteLine("Pressione ENTER para voltar ao Menu!");
            Console.ReadLine();
            Menu();
        }

        static void Multiplicacao()
        {
            Coleta();
            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação dos valores é {resultado}");
            Console.WriteLine("Pressione ENTER para voltar ao Menu!");
            Console.ReadLine();
            Menu();
        }

    }

}
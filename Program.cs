using System;

namespace media_4_notas
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4;
            double mediafinal;

            Console.Write  ("Digite sua 1ºNota: ");
            nota1 = double.Parse(Console.ReadLine());

            if (nota1 < 0 || nota1 > 10)
            {
                 Console.WriteLine();
                 Console.WriteLine("Digite somente numeros de 0 a 10, ");
                 Console.WriteLine("Pressione Enter para sair, e execute o programa novamente!");
                 Console.ReadKey();
                 Environment.Exit(-1);   
            }

            Console.Write  ("Digite sua 2ºNota: ");
            nota2 = double.Parse(Console.ReadLine());

            if (nota2 < 0 || nota2 > 10)
            {
                Console.WriteLine();
                 Console.WriteLine("Digite somente numeros de 0 a 10, ");
                 Console.WriteLine("Pressione Enter para sair, e execute o programa novamente!");
                 Console.ReadKey();
                 Environment.Exit(-1);   
            }

            Console.Write  ("Digite sua 3ºNota: ");
            nota3 = double.Parse(Console.ReadLine());

            if (nota3 < 0 || nota3 > 10)
            {
                Console.WriteLine();
                 Console.WriteLine("Digite somente numeros de 0 a 10, ");
                 Console.WriteLine(" Pressione Enter para sair, e execute o programa novamente!");
                 Console.ReadKey();
                 Environment.Exit(-1);   
            }

            Console.Write  ("Digite sua 4ºNota: ");
            nota4 = double.Parse(Console.ReadLine());

            if (nota4 < 0 || nota4 > 10)
            {
                Console.WriteLine();
                 Console.WriteLine("Digite somente numeros de 0 a 10, ");
                 Console.WriteLine("Pressione Enter para sair, e execute o programa novamente!");
                 Console.ReadKey();
                 Environment.Exit(-1);   
            }

            mediafinal = (nota1 + nota2 + nota3 + nota4) /4;

            if (mediafinal >= 7 )
            {
            Console.WriteLine();
            Console.WriteLine($"Sua media final é: {Math.Round(mediafinal, 1)}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Parabéns Você foi Aprovado!");
            Console.ResetColor();
            }
            else if (mediafinal >= 5 && mediafinal <= 6)
            {
            Console.WriteLine();
            Console.WriteLine($"Sua media final é: {Math.Round(mediafinal, 1)}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Você está de Recuperação!");
            Console.ResetColor();

            }

            else
            {
            Console.WriteLine();
            Console.WriteLine($"Sua media final é: {Math.Round(mediafinal, 1)}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Você foi Reprovado!");
            Console.ResetColor();

            }



        }  
    }
}

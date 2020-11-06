using System;

namespace DoadorSangue
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Qual sua idade:");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18 && idade <= 67) 
            { 
                Console.WriteLine(); 
                Console.WriteLine("Liberado(a) para doar sangue");
                Console.WriteLine("Pressione Enter para sair");
                Console.ReadKey();
            } 
            else 
            { 
                Console.WriteLine(); 
                Console.WriteLine("Você não pode ser doador de sangue.");
                Console.ReadKey();
            }
        }
    }
}

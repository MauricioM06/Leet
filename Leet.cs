using System;

namespace Leet
{

    public class Program 
    {
        public static void Main(string [] args)
        {
			Console.WriteLine("Leet Tradutor \nDigite o texto a ser traduzido...:");
			string Frase = Console.ReadLine();
			Console.WriteLine();
			Console.Write("Texto traduzido: ");
			Console.WriteLine(Frase.Replace("A" , "4")
			                       .Replace("a" , "4")
			                       .Replace("E" , "3")
			                       .Replace("e" , "3")
			                       .Replace("I" , "1")
			                       .Replace("i" , "1")
			                       .Replace("L" , "1")
			                       .Replace("l" , "1")
			                       .Replace("O" , "0")
			                       .Replace("o" , "0")
			                       .Replace("T" , "7")
			                       .Replace("t" , "7")
			                       .Replace("S" , "5")
			                       .Replace("s" , "5"));
        }
    }
}
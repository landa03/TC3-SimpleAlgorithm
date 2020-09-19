using System;

namespace TC3_SimpleAlgorithm
{
    class Program
    {
        static int numero;
        static void Main(string[] args)
        {
           System.Console.WriteLine("escrive la lonjitud de tu array");
           numero = Convert.ToInt32(Console.ReadLine());
           System.Console.Write(numero);
           for (int i = 1; i <= numero; i++)
           {
               System.Console.Write($",{i}");
           }
        }
    }
}
//pare que usas numeros, cuando puedes usar letras que paresen numeros
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //this code could change
            int code = 13;

            Console.WriteLine("favor ingrese la palabra a codificar");
            string word = Console.ReadLine();
            char[] letters = word.ToCharArray();

            string result = "";

            for (int i = 0; i < word.Length; i++)
            {
                if (letters[i] + code <= 'z')
                    result += (char)(letters[i] + code);
                else
                {
                    int position = (int)(letters[i] - code);
                    result += (char)(position);
                }
            }

            Console.WriteLine($"Su palabra codificada es {result}");
            Console.Read();
        }
    }
}

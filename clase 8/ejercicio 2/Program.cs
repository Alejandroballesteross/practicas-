using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos las variables

            string s1 = "AnImAl";
            string s2 = "animal";

            //mostramos y comparamos

            Console.WriteLine("comparacion de ({0}) y({1}): {2}",
                            s1, s2, String.Compare(s1, s2));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefeningArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Info over het project weergeven
            Console.WriteLine("**************************************************");
            Console.WriteLine("Project: oefeningArray");
            Console.WriteLine("Auteur: Ralph Verspui    Datum:  24 Okt. 2016");
            Console.WriteLine("**************************************************");

            //Make a text array with 5 tabs, give each tab a different fruit
            string[] arrayFruit = new string[5];
            arrayFruit[0] = "appel";
            arrayFruit[1] = "banaan";
            arrayFruit[2] = "citroen";
            arrayFruit[3] = "druif";
            arrayFruit[4] = "peer";

            //print the array
            Console.WriteLine(Environment.NewLine + "Array list contains");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arrayFruit[i]);
            }

            //Wait till the user presses enter
            Console.ReadLine();
        }
    }
}

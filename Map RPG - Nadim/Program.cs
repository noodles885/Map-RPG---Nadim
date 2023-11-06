using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map_RPG___Nadim
{
    internal class Program
    {
        static char[,] map = new char[,] // dimensions defined by following data:
        {
            {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
            {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
            {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
            {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
            {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
            {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        };

        // usage: map[y, x]

        // map legend:
        // ^ = mountain
        // ` = grass
        // ~ = water
        // * = trees

        
        static void Main(string[] args)
        {
            
            int scale = Console.Read();

            Console.WriteLine(" Map Legend:");
            Console.WriteLine(" ^ = mountain");
            Console.WriteLine(" ` = grass");
            Console.WriteLine(" ~ = water");
            Console.WriteLine(" * = trees");


            // ^ = mountain
            // ` = grass
            // ~ = water
            // * = trees


            DisplayMap();
            DisplayMap(1);
            DisplayMap(2);
        }


        static void DisplayMap()
        {
            Console.WriteLine("+" + new string('-', map.GetLength(1)) + "+");

            for (int i = 0; i < map.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("+" + new string('-', map.GetLength(1)) + "+");
            Console.ReadKey(true);
        }

        
        static void DisplayMap(int scale)
        {
            int row = map.GetLength(0) * scale;
            int cols = map.GetLength(1) * scale;

            Console.WriteLine("+" + new string('-', cols) + "+");

            for (int i = 0; i < row; i++)
            {
                Console.Write("|");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(map[i / scale, j / scale]);
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("+" + new string('-', cols) + "+");
            Console.ReadKey(true);
        }
        

    }

}

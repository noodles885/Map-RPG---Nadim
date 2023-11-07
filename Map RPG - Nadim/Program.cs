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
            {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`'},
            {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','*','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','*','`','`','`'},
            {'^','`','`','`','`','`','`','`','`','`','`','`','`','*','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','*','*','`','`'},
            {'`','`','`','`','`','~','~','`','`','`','`','`','*','*','*','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','*','*','`','`'},
            {'`','`','`','`','~','~','~','`','`','`','`','`','`','*','*','*','*','`','`','`','`','`','`','^','^','`','`','`','`','`','`','`','`','*','*','*','`','`'},
            {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','*','*','`','`','`','`','`','`','^','^','^','^','^','`','`','`','`','`','`','*','*','*','`','`'},
            {'`','`','`','`','`','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','^','^','^','`','`','`','`','`','`','`','*','`','`'},
            {'`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','^','^','^','`','`','`','`','`','`','~','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','0','^','^','^','`','`','`','`','`','~','~','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','~','`'},
            {'`','`','`','`','`','`','~','~','`','`','`','`','`','`','`','`','`','`','%','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','`','`'},
            {'`','`','`','`','`','~','~','~','~','x','`','`','`','`','`','`','`','%','%','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','~','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','%','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','~','~','~','~','~','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','%','%','%','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','~','~','~','~','`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','%','%','%','%','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','~','~','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','%','%','%','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},

        };

        // usage: map[y, x]

        // map legend:
        // ^ = mountain
        // ` = grass
        // ~ = water
        // * = trees
        // % = rocks
        // 0 = Cave Entrance
        // x = Treasure
        
        static void Main(string[] args)
        {


            theLegend();
            DisplayMap();
            theLegend();
            DisplayMap(2);
            theLegend();
            DisplayMap(3);

        }

        static void theLegend()
        {
            Console.WriteLine(" Map Legend:");
            Console.WriteLine(" ^ = Mountain");
            Console.WriteLine(" ` = Grass");
            Console.WriteLine(" ~ = Water");
            Console.WriteLine(" * = Trees");
            Console.WriteLine(" % = Rocks");
            Console.WriteLine(" 0 = Cave Entrance");
            Console.WriteLine(" x = Treasure");
            Console.WriteLine();
        }

        static void DisplayMap()
        {
            Console.WriteLine("+" + new string('-', map.GetLength(1)) + "+");

            for (int i = 0; i < map.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.ForegroundColor = GetTileColor(map[i, j]);
                    Console.Write(map[i, j]);
                    Console.ResetColor();
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
                    Console.ForegroundColor = GetTileColor(map[i / scale, j / scale]);
                    Console.Write(map[i / scale, j / scale]);
                    Console.ResetColor();
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("+" + new string('-', cols) + "+");
            Console.ReadKey(true);
        }

        // map legend:
        // ^ = mountain
        // ` = grass
        // ~ = water
        // * = trees
        // % = rocks
        // 0 = Cave Entrance
        // x = Treasure

        static ConsoleColor GetTileColor (char tile)
        {
            switch (tile)
            {
                case '^':
                    return ConsoleColor.Gray;
                case '`':
                    return ConsoleColor.Green;
                case '~':
                    return ConsoleColor.Blue;
                case '*':
                    return ConsoleColor.DarkGreen;
                case '%':
                    return ConsoleColor.DarkGray;
                case '0':
                    return ConsoleColor.DarkYellow;
                case 'x':
                    return ConsoleColor.Yellow;
                default: 
                    return ConsoleColor.White;
                      
            }

        }

    }

}

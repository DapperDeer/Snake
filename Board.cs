using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Snake
{
    public static class Board
    {
        // Static Constructor

        static Board()
        {
        }

        public static void RenderBoard()
        {
            Console.WriteLine("Height:{0}\nWidth:{1}", Height, Width);
            PrintLine(Width);
            for (int i = 0; i < Height; i++)
                PrintRow("");
            PrintLine(Width);
        }

        // Private Methods

        private static void PrintLine(int w)
        {
            Console.Write("+");
            Console.Write(new string('-', w - 1));
            Console.Write("+\n");
        }

        private static void PrintRow(params string[] columns)
        {
            int width = (Board.Width - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
                row += AlignCenter(column, width) + "|";
            Console.WriteLine(row);
        }

        private static string AlignCenter(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;
            if (string.IsNullOrEmpty(text))
                return new string(' ', width);
            else
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
        }
        
        // End Private Methods

        // Private Properties

        private static int Width = 50;
        private static int Height = 15;

        // End Private Properties
    }
}

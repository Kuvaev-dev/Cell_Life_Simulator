using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LifeSimulator_Console
{
    class Program
    {
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hwnd, int cmdShow);

        private const int MAXIMIZE = 3;

        static void Main(string[] args)
        {
            Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(GetConsoleWindow(), MAXIMIZE);
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);

            var gameEngine = new GameEngine
            (
                // 1920 x 1080
                rows: 111,
                cols: 337,
                density: 2
            );

            while (true)
            {
                Console.Title = $"Generation: {gameEngine.CurrentGeneration.ToString()}";
                var field = gameEngine.GetCurrentGeneration();
                for (int y = 0; y < field.GetLength(1); y++)
                {
                    var str = new char[field.GetLength(0)];
                    for (int x = 0; x < field.GetLength(0); x++)
                    {
                        if (field[x, y])
                            str[x] = '#';
                        else
                            str[x] = ' ';
                    }
                    Console.WriteLine(str);
                }
                Console.SetCursorPosition(0, 0);
                gameEngine.NextGeneration();
            }
        }
    }
}

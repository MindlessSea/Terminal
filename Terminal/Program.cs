using System;
using System.Linq;

namespace Terminal
{
    internal class Program
    {
        private const string PREFIX = ">";
        private static Command[] commands = new[]
        {
            new Command("help", "Shows this command", Help),
            new Command("clear", "Clears the console", Clear),
            new Command("exit", "Quits the command line", Exit)
        };
        
        private static void Help()
        {
            foreach (var cmd in commands)
            {
                Console.WriteLine($"{cmd.name} - {cmd.description}");
            }
        }

        private static void Clear()
        {
            Console.Clear();
        }
        
        private static void Exit()
        {
            Environment.Exit(0);
        }

        public static void Main(string[] _)
        {
            while (true)
            {
                Console.Write($"{PREFIX} ");
                string[] args = Console.ReadLine().Split(' ');

                try
                {
                    var command = commands.First(x => x.name == args[0].ToLower());
                    command.function();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{args[0]} not found!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
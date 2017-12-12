using System;
using System.Threading.Tasks;

namespace CSharp71
{
    public class Program
    {

        public static async Task Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("C# 7.1 - Specification");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("https://github.com/J0rgeSerran0");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------");
            Console.WriteLine("Async Main");
            Console.WriteLine("----------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            await MainAsync();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------------------");
            Console.WriteLine("Inferred Tuple Element Names");
            Console.WriteLine("----------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            InferredTupleElementNames();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------------------");
            Console.WriteLine("Default Literals Expressions");
            Console.WriteLine("----------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            DefaultLiteralsExpressions();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Press any key to close");
            Console.ReadLine();
        }

        #region "Async Main"

        private static async Task MainAsync()
        {
            Console.WriteLine($"{nameof(MainAsync)}");
            await Task.Delay(250);
        }

        #endregion

        #region "Inferred Tuple Element Names"

        private static void InferredTupleElementNames()
        {
            var name = "Fiscal Year";
            var count = 2017;
            // C# 7.0
            //var data = (name: name, count: count);
            // C# 7.1
            var data = (name, count);

            Console.WriteLine($"{nameof(data.name)} => {data.name}");
            Console.WriteLine($"{nameof(data.count)} => {data.count}");
        }

        #endregion

        #region "Default Literals Expressions"

        private static void DefaultLiteralsExpressions()
        {
            // Before C# 7.1
            string name = default(string);
            Console.WriteLine($"{nameof(name)} is null => {name == null}");

            // C# 7.1
            string otherName = default;
            Console.WriteLine($"{nameof(otherName)} is null => {otherName == null}");
        }

        #endregion

    }

}
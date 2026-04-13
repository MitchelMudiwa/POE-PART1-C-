namespace CybersecurityBot
{
    public static class DisplayManager
    {
        public static void TypeWrite(string message, ConsoleColor color = ConsoleColor.White, int delay = 30)
        {
            Console.ForegroundColor = color;
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void PrintColored(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void PrintDivider(char symbol = '═', int length = 60)
        {
            PrintColored(new string(symbol, length), ConsoleColor.DarkCyan);
        }

        public static void ShowHeader()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
  ██████╗██╗   ██╗██████╗ ███████╗██████╗     ██████╗  ██████╗ ████████╗
 ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗    ██╔══██╗██╔═══██╗╚══██╔══╝
 ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝    ██████╔╝██║   ██║   ██║   
 ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗    ██╔══██╗██║   ██║   ██║   
 ╚██████╗   ██║   ██████╔╝███████╗██║  ██║    ██████╔╝╚██████╔╝   ██║   
  ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝    ╚═════╝  ╚═════╝    ╚═╝  
");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
         🔒  C Y B E R S E C U R I T Y   A W A R E N E S S   B O T  🔒
                     Keeping You Safe in the Digital World
");
            Console.ResetColor();
            PrintDivider();
        }

        public static void BotSay(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n  🤖 Bot: ");
            Console.ResetColor();
            TypeWrite(message, ConsoleColor.White);
        }

        public static string UserPrompt(string username)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"\n  👤 {username}: ");
            Console.ResetColor();
            return Console.ReadLine() ?? string.Empty;
        }
    }
}
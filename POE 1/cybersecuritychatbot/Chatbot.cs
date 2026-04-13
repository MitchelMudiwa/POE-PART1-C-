namespace CybersecurityBot
{
    public class Chatbot
    {
        private User? _user;

        public void Start()
        {
            GreetAndGetName();
            RunConversationLoop();
        }

        private void GreetAndGetName()
        {
            DisplayManager.BotSay("Hello! Welcome to the Cybersecurity Awareness Bot.");
            DisplayManager.BotSay("What's your name?");

            string name = string.Empty;
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n  👤 Your name: ");
                Console.ResetColor();
                name = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(name))
                    DisplayManager.BotSay("I didn't catch that — please enter your name.");
            }

            _user = new User(name.Trim());
            DisplayManager.PrintDivider();
            DisplayManager.BotSay($"Nice to meet you, {_user.Name}! 👋");
            DisplayManager.BotSay("Type 'help' to see topics, or 'exit' to quit.");
            DisplayManager.PrintDivider();
        }

        private void RunConversationLoop()
        {
            while (true)
            {
                string input = DisplayManager.UserPrompt(_user!.Name);

                if (string.IsNullOrWhiteSpace(input))
                {
                    DisplayManager.BotSay("I didn't quite catch that. Could you rephrase?");
                    continue;
                }

                if (input.Trim().ToLower() == "exit")
                {
                    DisplayManager.PrintDivider();
                    DisplayManager.BotSay($"Stay safe out there, {_user.Name}! Goodbye 👋");
                    DisplayManager.PrintDivider();
                    break;
                }

                if (input.Trim().ToLower() == "help")
                {
                    ShowHelp();
                    continue;
                }

                string response = ResponseEngine.GetResponse(input);
                _user.SessionQuestions++;

                if (!string.IsNullOrEmpty(response))
                    DisplayManager.BotSay(response);
                else
                    DisplayManager.BotSay("I didn't quite understand that. Try typing 'help' to see available topics.");
            }
        }

        private void ShowHelp()
        {
            DisplayManager.PrintDivider('─');
            DisplayManager.BotSay("Topics you can ask about:\n" +
                "  🔑  password\n" +
                "  🎣  phishing\n" +
                "  🌐  browsing\n" +
                "  🔐  2fa / two-factor\n" +
                "  🦠  malware\n" +
                "  💀  ransomware\n" +
                "  🎭  social engineering\n" +
                "  🚪  exit");
            DisplayManager.PrintDivider('─');
        }
    }
}
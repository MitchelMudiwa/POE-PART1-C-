namespace CybersecurityBot
{
    public class User
    {
        public string Name { get; set; }
        public int SessionQuestions { get; set; }

        public User(string name)
        {
            Name = name;
            SessionQuestions = 0;
        }
    }
}
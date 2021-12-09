using Sharprompt;

namespace TextRPG
{
    public abstract class Menu
    {
        public string Display(string prompt, List<string> options)
        {
            return Prompt.Select(prompt, options);
        }
    }
}

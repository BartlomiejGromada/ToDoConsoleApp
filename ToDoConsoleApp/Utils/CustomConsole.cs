namespace ToDoConsoleApp.Utils
{
    public static class CustomConsole
    {
        public static void Error(string text)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void Success(string text)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}

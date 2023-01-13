using static System.Console;

namespace Challenges.Console;

public static class ConsoleUtils
{
    public static bool AskQuit()
    {
        const string message = "To exit press 'Q'";
        Write(message);

        var key = ReadKey();
        if (key.KeyChar == 'Q')
        {
            ClearLine(message.Length + 1);
            Write("Quitting...");
            return true;
        }

        ClearLine(message.Length);
        return false;
    }

    public static void ClearLine(int length)
    {
        SetCursorPosition(0, CursorTop);
        Write(new string(' ', ++length));
        SetCursorPosition(0, CursorTop);
    }
}

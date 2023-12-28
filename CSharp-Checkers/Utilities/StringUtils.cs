namespace CSharp_Checkers.Utilities;

public class StringUtils
{
    public static void PrintError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("----- Error -----");
        Console.WriteLine("The sum of rows and columns must be even. Setting board size to 8x8.");
        Console.WriteLine("-----------------\n");
        Console.ResetColor();
        
    }
    
    public static void PrintWelcome(string gameName)
    {
        Console.WriteLine("-----------------------");
        Console.WriteLine($"----- {gameName} -----");
        Console.WriteLine("-----------------------");
    }
}
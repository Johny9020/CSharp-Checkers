using CSharp_Checkers.Board;
using CSharp_Checkers.Utilities;

namespace CSharp_Checkers;

public class GameManager
{
    private static GameManager? _instance;
    private static string? _gameName;
    private static CheckersBoard? _board;

    public static GameManager Instance
    {
        get
        {
            return _instance ??= new GameManager();
        }
    }
    
    private GameManager()
    {
        _gameName = "Checkers v1";
        StringUtils.PrintWelcome(_gameName);
    }
    
    public CheckersBoard GetBoard()
    {
        return _board ?? throw new NullReferenceException();
    }
    
    // Create the Checkers Board
    private void CreateBoard(int rows, int columns)
    {
        var boardBuilder = new BoardBuilder();
        boardBuilder.CreateBoard();
        boardBuilder.SetBoardSize(rows, columns);
        _board = boardBuilder.Build();
    }

    public void Setup(int rows = 8, int columns = 8)
    {
        const int minSize = 8;

        if (rows % 2 != 0 || columns % 2 != 0 || rows < minSize || columns < minSize)
        {
            StringUtils.PrintError($"Both rows and columns must be even, and greater than or equal to {minSize}.");
            rows = minSize;
            columns = minSize;
        }
        
        CreateBoard(rows, columns);
        Console.WriteLine("Setup complete!\n");
    }
}
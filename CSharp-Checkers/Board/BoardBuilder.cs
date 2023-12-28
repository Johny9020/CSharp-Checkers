using CSharp_Checkers.Pieces;

namespace CSharp_Checkers.Board;

public class BoardBuilder : IBoardBuilder
{
    private CheckersBoard? _board;
    
    public void SetBoardSize(int rows, int columns)
    {
        _board?.SetBoardSize(rows, columns);
        Console.WriteLine($"Setting board rows: {rows}.\nSetting board columns: {columns}");
    }

    public void AddPiece(int row, int column, Piece piece)
    {
        throw new NotImplementedException();
    }

    public void CreateBoard()
    {
        _board = new CheckersBoard();
    }

    public CheckersBoard Build()
    {
        return _board ?? throw new NullReferenceException();
    }
}
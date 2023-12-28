using CSharp_Checkers.Pieces;

namespace CSharp_Checkers.Board;

public class CheckersBoard
{
    private int _rows;
    private int _columns;
    private Piece[,] _boardArray;
    public void SetBoardSize(int rows, int columns) 
    {
        _rows = rows;
        _columns = columns;
        _boardArray = new Piece[_rows, _columns];
        
        // Populate the board with empty pieces
        for(var i = 0; i < _rows; i++)
        {
            for(var j = 0; j < _columns; j++)
            {
                _boardArray[i, j] = new Piece(PieceType.None);
            }
        }
        
        // Initialize the pieces
        InitializePieces();
    }

    private void InitializePieces()
    {
        // Initialize the X pieces
        for (var i = 0; i < _rows / 2 - 1; i++)
        {
            for (var j = 0; j < _columns; j++)
            {
                // If the sum of i and j is even, then the piece is an X
                _boardArray[i, j] = new Piece((i + j) % 2 == 0 ? PieceType.None : PieceType.X);
            }
        }
        
        // Initialize the O pieces
        for (var i = _rows / 2 + 1; i < _rows; i++)
        {
            for (var j = 0; j < _columns; j++)
            {
                // If the sum of i and j is even, then the piece is an O
                _boardArray[i, j] = new Piece((i + j) % 2 == 0 ? PieceType.O : PieceType.None);
            }
        }
    }

    public void PrintBoard()
    {
        Console.WriteLine(new string('-', _columns * 4));
        for (var i = 0; i < _rows; i++)
        {
            for (var j = 0; j < _columns; j++)
            {
                var cellValue = _boardArray[i, j].GetPieceType() switch
                {
                    PieceType.None => ' ',
                    PieceType.X => 'X',
                    PieceType.O => 'O'
                };
                Console.Write($" {cellValue} |");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', _columns * 4));
        }
    }
}
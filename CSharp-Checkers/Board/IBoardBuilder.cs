using CSharp_Checkers.Pieces;

namespace CSharp_Checkers.Board;

public interface IBoardBuilder
{
    void SetBoardSize(int rows, int columns);
    void AddPiece(int row, int column, Piece piece);
    void CreateBoard();
    CheckersBoard Build();
}
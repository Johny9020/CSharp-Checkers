namespace CSharp_Checkers.Pieces;

public class Piece : IPieceCloneable
{
    private PieceType _pieceType;

    public Piece(PieceType pieceType)
    {
        _pieceType = pieceType;
    }

    public PieceType GetPieceType()
    {
        return _pieceType;
    }

    public Piece Clone()
    {
        return new Piece(_pieceType);
    }
}
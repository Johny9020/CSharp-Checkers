namespace CSharp_Checkers;

class Program
{
    private static GameManager _gameManager = GameManager.Instance;
    
    private static void Main(string[] args)
    {
        _gameManager.Setup(10, 10);
        _gameManager.GetBoard().PrintBoard();
    }
}
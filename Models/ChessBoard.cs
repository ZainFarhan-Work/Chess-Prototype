namespace Chess_Prototype.Models;

public class ChessBoard
{
    public static int[] squares;

    public static void CreateBoard()
    {
        squares = new int[64];
    }
}
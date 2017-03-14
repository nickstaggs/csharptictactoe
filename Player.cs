using System;

namespace csharptictactoe
{
  class Player
  {
    private string name;
    private TicTacToe.BoardPiece boardPiece;

    public Player(string name, TicTacToe.BoardPiece boardPiece)
    {
      this.name = name;
      this.boardPiece = boardPiece;
    }

    public int[] MakeMove()
    {


      int x;
      Console.WriteLine("Select x coordinate to put {0} (0-2).", boardPiece);

      while(!Int32.TryParse(Console.ReadLine(), out x)){
        Console.WriteLine("That was not an integer!");
        Console.WriteLine("Select x coordinate to put {0} (0-2).", boardPiece);
      }

      int y;
      Console.WriteLine("Select y coordinate to put {0} (0-2).", boardPiece);

      while(!Int32.TryParse(Console.ReadLine(), out y)){
        Console.WriteLine("That was not an integer!");
        Console.WriteLine("Select y coordinate to put {0} (0-2).", boardPiece);
      }

      return new int[] {x,y};
    }

    public string GetName()
    {
      return name;
    }

    public TicTacToe.BoardPiece GetBoardPiece()
    {
      return boardPiece;
    }

    public void PrintIntro() 
    {
      Console.WriteLine("{0} is {1}", name, boardPiece);
    }
  }
}
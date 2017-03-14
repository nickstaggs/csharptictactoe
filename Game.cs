using System;

namespace csharptictactoe
{
  class Game
  {
    private Player player1;
    private Player player2;
    private Grid grid = new Grid();

    public Game(string player1Name, string player2Name)
    {
      player1 = new Player(player1Name, TicTacToe.BoardPiece.X);
      player2 = new Player(player2Name, TicTacToe.BoardPiece.O);
    }

    public void Play()
    {

      player1.PrintIntro();
      player2.PrintIntro();

      for (int i = 1; i <= 9; i++) {

        Player currPlayer = WhoseTurn(i);

        Console.WriteLine("It is {0}'s turn.", currPlayer.GetName());

        while (!grid.IsValidMove(currPlayer.MakeMove(), currPlayer.GetBoardPiece()));

        Display.Show(grid.GetGrid());

        if (grid.IsWinner())
        {
          Console.WriteLine("{0} wins!", currPlayer.GetName());
          return;
        }
      }

      Console.WriteLine("It's a cat's game!");
    }

    private bool IsEven(int i) {
      if (i%2 == 0)
      {
        return true;
      }

      return false;
    }

    private Player WhoseTurn(int i)
    {

      if (IsEven(i))
      {
        return player2;
      }

      return player1;
    }
  }
}

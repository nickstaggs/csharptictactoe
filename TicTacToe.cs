using System;

namespace csharptictactoe
{
  class TicTacToe
  {

    public enum BoardPiece {Empty, X, O}

    static void Main(string[] args)
    {
      Console.WriteLine("Would you like to play TicTacToe?(y/n)");

      string input;
      input = Console.ReadLine();
      while(TicTacToe.IsYes(input))
      {

        Console.WriteLine("What is player 1's name?");
        String player1 = Console.ReadLine();

        Console.WriteLine("What is player 2's name?");
        string player2 = Console.ReadLine();

        Game game = new Game(player1, player2);
        game.Play();

        Console.WriteLine("Would you like to play again?(y/n)");
        input = Console.ReadLine();
      }
    }

    private static bool IsYes(string response)
    {

      if (response.Equals("y"))
      {
        return true;
      }

      else if (response.Equals("n"))
      {
        return false;
      }

      Console.WriteLine("That is not an accepted response.");
      Console.WriteLine("Would you like to play TicTacToe?(y/n)");
      return IsYes(Console.ReadLine());
    }
  }
}
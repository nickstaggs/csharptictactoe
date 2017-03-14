using System;

namespace csharptictactoe
{
  static class Display
  {

    public static void Show(TicTacToe.BoardPiece[,] grid)
    {

      Console.WriteLine("=======");
      string line ="";

      for (int i = 0; i < 3; i++)
      {
        for (int j = 0; j < 3; j++)
        {

          line += "|";

          if ((int)grid[i,j] == 0)
          {
            line += " ";
          }

          else
          {
            line += grid[i,j].ToString();
          }
        }

        line += "|";
        Console.WriteLine(line);
        line = "";
        
        Console.WriteLine("=======");
      }
    }
  }
}
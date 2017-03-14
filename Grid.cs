using System;

namespace csharptictactoe
{
  class Grid
  {
    private TicTacToe.BoardPiece[,] grid = new TicTacToe.BoardPiece[3,3];
    private TicTacToe.BoardPiece currBoardPiece;

    public Grid()
    {

      for (int i = 0; i < 3; i++)
      {

        for (int j = 0; j < 3; j++)
        {
          grid[i,j] = TicTacToe.BoardPiece.Empty;
        }
      }
    }

    public bool IsValidMove(int[] coordinate, TicTacToe.BoardPiece boardPiece)
    {

      currBoardPiece = boardPiece;

      if (coordinate[0] > 3 || coordinate[1] > 3)
      {
        Console.WriteLine("One of the coordinates you entered is out of bounds.");
        return false;
      }

      if ((int)grid[coordinate[0],coordinate[1]] != 0)
      {
        Console.WriteLine("That space is already taken.");
        return false;
      }

      grid[coordinate[0],coordinate[1]] = currBoardPiece;
      return true;
    }

    public bool IsWinner() {
      int xInARow = 0;
      int yInARow = 0;
      int diagonalDRInARow = 0;
      int diagonalURInARow = 0;

      for (int i = 0; i < 3; i++)
      {
        for (int j = 0; j < 3; j++)
        {

          if (grid[i,j] == currBoardPiece)
          {
            xInARow++;
          }
          if (grid[j,i] == currBoardPiece)
          {
            yInARow++;
          }
        }

        if (xInARow == 3 || yInARow == 3)
        {
          return true;
        }
        xInARow = 0;
        yInARow = 0;

        if (grid[i,i] == currBoardPiece)
        {
          diagonalDRInARow++;
        }

        if (grid[i,2-i] == currBoardPiece)
        {
          diagonalURInARow++;
        }


      }

      if (diagonalURInARow == 3 || diagonalDRInARow == 3)
      {
        return true;
      }

      return false;
    }

    public TicTacToe.BoardPiece[,] GetGrid() {
      return grid;
    }
  }
}
using System;

namespace ET_1_ChessBoard
{
    public class ChessBoard
    {
        public Cell[,] Cells { get; private set; }

        public ChessBoard(int length, int height)
        {
            Cells = new Cell[length, height];
            InitChessBoard();
        }

        private void InitChessBoard()
        {
            int x = 0;
            int y = 0;
            bool isNextWhite = true;
            while(y <= Cells.GetLength(1))
            {
                if (x < Cells.GetLength(0) && y == Cells.GetLength(1))
                {
                    x++;
                    y = 0;
                }
                if (x == Cells.GetLength(0))
                {
                    break;
                }

                if (x % 2 == 1 && y == 0)
                {
                    Cells[x, y] = new Cell(x, y, Cell.CellColor.Black);
                    isNextWhite = true;
                    y++;
                }
                else if (x % 2 == 0 && y == 0)
                {
                    Cells[x, y] = new Cell(x, y, Cell.CellColor.White);
                    isNextWhite = false;
                    y++;
                }

                if (isNextWhite)
                {
                    Cells[x, y] = new Cell(x, y, Cell.CellColor.White);
                    isNextWhite = false;
                }
                else
                {
                    Cells[x, y] = new Cell(x, y, Cell.CellColor.Black);
                    isNextWhite = true;
                }

                y++;

            }
        }

        public void Draw(char white, char black)
        {
            int x = 0;
            int y = 0;
            while (y < Cells.GetLength(1))
            {
                if (Cells[x, y].Color == Cell.CellColor.White)
                {
                    Console.Write(white);
                }
                else
                {
                    Console.Write(black);
                }

                y++;
                if (x < Cells.GetLength(0) && y == Cells.GetLength(1))
                {
                    x++;
                    y = 0;
                    Console.WriteLine();
                }
                if (x == Cells.GetLength(0))
                {
                    break;
                }
            }
        }
    }
}

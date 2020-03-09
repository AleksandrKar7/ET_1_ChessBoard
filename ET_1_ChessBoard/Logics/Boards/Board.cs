using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_1_ChessBoard.Logics.Boards
{
    public class Board
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public Cell[,] Cells { get; protected set; }

        public Board(int length, int height)
        {
            Rows = length;
            Columns = height;
        }

        public virtual void InitCells()
        {
            int x = 0;
            int y = 0;
            bool isNextWhite = true;

            Cells = new Cell[Rows, Columns];
            while (y <= Cells.GetLength(1))
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
    }
}

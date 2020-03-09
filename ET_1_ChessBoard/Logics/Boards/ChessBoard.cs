using ET_1_ChessBoard.Logics.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_1_ChessBoard.Logics.Boards
{
    public class ChessBoard : Board
    {
        public const int StandardChessBoardSize = 8;
        public ChessFigure[,] Figures { get; protected set; }
        public ChessBoard(int length, int height) : base(length, height)
        {
            
        }

        public void SetStandardChessFigures()
        {
            Figures = new ChessFigure[Rows, Columns];
            int x = 0;
            int y = 0;

            while (y <= Figures.GetLength(1))
            {
                if (x < Figures.GetLength(0) && y == Figures.GetLength(1))
                {
                    x++;
                    y = 0;
                }
                if (x == Figures.GetLength(0))
                {
                    break;
                }
                //Set white main figures
                if (x == 0)
                {
                    Figures[x, y] = new ChessFigure(x, y,
                        ChessFigure.FigureType.White | 
                        GetMainFigureType(y));
                }
                //Set white pawns
                if (x == 1 && y < StandardChessBoardSize)
                {
                    Figures[x, y] = new ChessFigure(x, y,
                       ChessFigure.FigureType.White | 
                       ChessFigure.FigureType.Pawn);
                }

                //Set black pawns
                if (x == Figures.GetLength(0) - 2 && Figures.GetLength(0) >= 3)
                {
                    Figures[x, y] = new ChessFigure(x, y,
                       ChessFigure.FigureType.Black | 
                       ChessFigure.FigureType.Pawn);
                }
                //Set black main figures
                if (x == Figures.GetLength(0) - 1 && Figures.GetLength(0) >= 4)
                {
                    Figures[x, y] = new ChessFigure(x, y,
                        ChessFigure.FigureType.Black | 
                        GetMainFigureType(y));
                }

                y++;
            }
        }

        private ChessFigure.FigureType GetMainFigureType(int y)
        {
            //Go from Rook to King
            if (y < 5)
            {
                return (ChessFigure.FigureType)Math.Pow(2, y + Math.Log(
                            (double)ChessFigure.FigureType.Rook, 2));
            }
            //Comming back from King to Rook
            if (y >= 5 && y < StandardChessBoardSize)
            {
                return (ChessFigure.FigureType)Math.Pow(2,
                            Math.Log((double)ChessFigure.FigureType.Rook, 2) +
                            (Figures.GetLength(1) - 1 - y));
            }
            return 0;
        }
    }
}

﻿using System;
using System.Collections.Generic;

using ET_1_ChessBoard.Logics.Boards;
using ET_1_ChessBoard.Logics.Figures;

namespace ET_1_ChessBoard.Logics.Printers
{
    static class ConsolePrinter
    {
        private static readonly Dictionary<Cell.CellColor, ConsoleColor> standardCellsColor =
            new Dictionary<Cell.CellColor, ConsoleColor>()
            {
                { Cell.CellColor.Black, ConsoleColor.DarkGray },
                { Cell.CellColor.White, ConsoleColor.White}
            };

        static public readonly Dictionary<ChessFigure.FigureType, char> standardFiguresSymbol =
            new Dictionary<ChessFigure.FigureType, char> 
            {
                { ChessFigure.FigureType.Pawn, 'p' },
                { ChessFigure.FigureType.Rook, 'r' },
                { ChessFigure.FigureType.Knight, 'k' },
                { ChessFigure.FigureType.Bishop, 'b' },
                { ChessFigure.FigureType.Queen, 'Q' },
                { ChessFigure.FigureType.King, 'K' }
            };

        static public readonly Dictionary<ChessFigure.FigureType, ConsoleColor> standardFiguresColor =
            new Dictionary<ChessFigure.FigureType, ConsoleColor>
            {
                { ChessFigure.FigureType.White, ConsoleColor.DarkYellow },
                { ChessFigure.FigureType.Black, ConsoleColor.Black }
            };

        static public void PrintEmptyBoard(Board board)
        {
            PrintEmptyBoard(board, standardCellsColor);
        }
        static public void PrintEmptyBoard(Board board,
            Dictionary<Cell.CellColor, ConsoleColor> cellsColor)
        {
            int x = 0;
            int y = 0;
            while (y < board.Cells.GetLength(1))
            {
                Console.BackgroundColor = cellsColor[board.Cells[x, y].Color];
                Console.Write(" ");

                y++;
                if (x < board.Cells.GetLength(0) && y == board.Cells.GetLength(1))
                {
                    x++;
                    y = 0;
                    Console.WriteLine();
                }
                if (x == board.Cells.GetLength(0))
                {
                    break;
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }

        static public void PrintChessBoard(ChessBoard board)
        {
            PrintChessBoard(board, standardCellsColor,
                standardFiguresColor, standardFiguresSymbol);
        }

        static public void PrintChessBoard(ChessBoard board,
    Dictionary<Cell.CellColor, ConsoleColor> cellsColor)
        {
            PrintChessBoard(board, cellsColor,
                standardFiguresColor, standardFiguresSymbol);
        }

        static public void PrintChessBoard(ChessBoard board,
            Dictionary<Cell.CellColor, ConsoleColor> cellsColor,
            Dictionary<ChessFigure.FigureType, ConsoleColor> figuresColor)
        {
            PrintChessBoard(board, cellsColor, figuresColor, standardFiguresSymbol);
        }

        static public void PrintChessBoard(ChessBoard board,
            Dictionary<Cell.CellColor, ConsoleColor> cellsColor,
            Dictionary<ChessFigure.FigureType, ConsoleColor> figuresColor,
            Dictionary<ChessFigure.FigureType, char> figuresSymbol)
        {
            int x = 0;
            int y = 0;
            char symbol;
            while (y < board.Cells.GetLength(1))
            {
                Console.BackgroundColor = cellsColor[board.Cells[x, y].Color];

                if (board.Figures[x, y] != null &&
                    board.Figures[x, y].Type.HasFlag(ChessFigure.FigureType.White))
                {
                    Console.ForegroundColor = figuresColor[ChessFigure.FigureType.White];

                    symbol = board.Figures[x, y] != null ?
                        figuresSymbol[board.Figures[x, y].Type ^
                        ChessFigure.FigureType.White] : ' ';
                }
                else if (board.Figures[x, y] != null && 
                    board.Figures[x, y].Type.HasFlag(ChessFigure.FigureType.Black))
                {
                    Console.ForegroundColor = figuresColor[ChessFigure.FigureType.Black];

                    symbol = board.Figures[x, y] != null ?
                        figuresSymbol[board.Figures[x, y].Type ^
                        ChessFigure.FigureType.Black] : ' ';
                }
                else
                {
                    symbol = ' ';
                }
                Console.Write(symbol);

                y++;
                if (x < board.Cells.GetLength(0) && y == board.Cells.GetLength(1))
                {
                    x++;
                    y = 0;
                    Console.WriteLine();
                }
                if (x == board.Cells.GetLength(0))
                {
                    break;
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}

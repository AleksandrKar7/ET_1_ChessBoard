using System;

namespace ET_1_ChessBoard
{
    class ConsolePrinter : IChessBoardPrinter
    {
        public void PrintChessBoard(ChessBoard chessBoard, char mainSymbol, char spaceSymbol)
        {
            for (int i = 0; i < chessBoard.Length; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(spaceSymbol);
                }
                for (int j = 0; j < chessBoard.Height; j++)
                {
                    Console.Write(mainSymbol);
                    Console.Write(spaceSymbol);
                }
                Console.WriteLine();
            }
        }
    }
}

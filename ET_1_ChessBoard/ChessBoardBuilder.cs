using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_1_ChessBoard
{
    public class ChessBoardBuilder : IChessBoardBuilder<string, SimpleConsolePrinter>
    {
        public string BuildChessBoard(ChessBoard chessBoard, SimpleConsolePrinter blocks)
        {
            StringBuilder result = new StringBuilder();
            bool isWhite = true;
            for (int i = 0; i < chessBoard.Height; i++)
            {
                for (int j = 0; j < chessBoard.Length; j++)
                {
                    if (i % 2 == 1 && j == 0)
                    {
                        result.Append(blocks.BlackCell);
                        isWhite = true;
                        continue;
                    }
                    else if (i % 2 == 0 && j == 0)
                    {
                        result.Append(blocks.WhiteCell);
                        isWhite = false;
                        continue;
                    }

                    if (isWhite)
                    {
                        result.Append(blocks.WhiteCell);
                        isWhite = false;
                    } 
                    else
                    {
                        result.Append(blocks.BlackCell);
                        isWhite = true;
                    }
                }
                result.Append("\n");
            }
            return result.ToString();
        }
    }
}

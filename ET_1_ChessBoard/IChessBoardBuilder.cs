using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_1_ChessBoard
{
    interface IChessBoardBuilder <U, V>
    {
        U BuildChessBoard(ChessBoard chessBoard, V blocks);
    }
}

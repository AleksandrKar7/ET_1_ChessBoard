using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_1_ChessBoard
{
    public class SimpleConsolePrinter
    {
        public char WhiteCell { get; set; }

        public char BlackCell { get; set; }

        public SimpleConsolePrinter(char whiteCell, char blackCell)
        {
            WhiteCell = whiteCell;
            BlackCell = blackCell;
        }
    }
}

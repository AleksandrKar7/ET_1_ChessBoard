using System;

namespace ET_1_ChessBoard
{
/*
1.Шахматная доска
Вывести шахматную доску с заданными размерами высоты и ширины, по принципу:
* * * * * *
 * * * * * *
* * * * * *
 * * * * * *
Программа запускается через вызов главного класса с параметрами.
*/
    class Program
    {

        static void Main(string[] args)
        {
            ProgramParams progParams;

            if (!ProgramParams.TryParse(args, out progParams))
            {
                Console.WriteLine(ProgramParams.GetInstruction());
                Console.ReadKey();
                return;
            }       

            ChessBoard chessBoard = new ChessBoard(progParams.Length, progParams.Height);
            IChessBoardPrinter printer = new ConsolePrinter();
            printer.PrintChessBoard(chessBoard, progParams.WhiteCell, progParams.BlackCell);

            Console.ReadKey();
        }    
    }
}

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
            string validResult = Validator.AreParamsValid(args);

            if (!String.IsNullOrEmpty(validResult))
            {
                Console.WriteLine(validResult);
                Console.WriteLine(Validator.GetInstruction());
                Console.ReadKey();
                return;
            }
            ProgramParams progParams = new ProgramParams(args);

            ChessBoard chessBoard = new ChessBoard(progParams.Length, progParams.Height);
            chessBoard.Draw(progParams.WhiteCell, progParams.BlackCell);
            //ChessBoardBuilder printer = new ChessBoardBuilder();
            //Console.WriteLine(printer.BuildChessBoard(chessBoard, new SimpleConsolePrinter(progParams.WhiteCell, progParams.BlackCell))); 

            Console.ReadKey();
        }    
    }
}

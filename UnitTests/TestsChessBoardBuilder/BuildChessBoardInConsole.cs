using System;

using NUnit.Framework;
using ET_1_ChessBoard;

namespace UnitTests.TestsChessBoardBuilder
{
    class BuildChessBoardInConsole
    {
        [Test]
        public void BuildChessBoard_BuilOneLine8Length()
        {
            //arrange
            ChessBoardBuilder builder = new ChessBoardBuilder();
            ChessBoard board = new ChessBoard(8, 1);
            char white = '#';
            char black = ' ';
            string expected = String.Format("{0}{1}{0}{1}{0}{1}{0}{1}\n", white, black);

            //act
            string result = builder.BuildChessBoard(board, new SimpleConsolePrinter(white, black));

            //assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void BuildChessBoard_BuilTwoLines8Length2Height()
        {
            //arrange
            ChessBoardBuilder builder = new ChessBoardBuilder();
            ChessBoard board = new ChessBoard(8, 2);
            char white = '#';
            char black = ' ';
            string expected = String.Format("{0}{1}{0}{1}{0}{1}{0}{1}\n" +
                "{1}{0}{1}{0}{1}{0}{1}{0}\n", white, black);

            //act
            string result = builder.BuildChessBoard(board, new SimpleConsolePrinter(white, black));

            //assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void BuildChessBoard_TryToBuildNegativeNumber()
        {
            //arrange
            ChessBoardBuilder builder = new ChessBoardBuilder();
            ChessBoard board = new ChessBoard(-2, -1);
            char white = '#';
            char black = ' ';
            string expected = "";

            //act
            string result = builder.BuildChessBoard(board, new SimpleConsolePrinter(white, black));

            //assert
            Assert.AreEqual(expected, result);
        }
    }
}

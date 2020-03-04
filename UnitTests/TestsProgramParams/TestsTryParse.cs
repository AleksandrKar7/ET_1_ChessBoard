using System;

using ET_1_ChessBoard;
using NUnit.Framework;

namespace UnitTests.TestsProgramParams
{
    class TestsTryParse
    {
        //[Test]
        //public void TryParse_CorrectParams_True()
        //{
        //    //arrange
        //    string[] args = { "8", "8", "#", " " };
        //    bool result;

        //    //act
        //    result = ProgramParams.TryParse(args, out _);

        //    //assert
        //    Assert.IsTrue(result);
        //}

        //[Test]
        //public void TryParse_NotEnoughParams_False()
        //{
        //    //arrange
        //    string[] args = new string[ProgramParams.MIN_COUNT_ARGS - 1];
        //    bool result;

        //    //act
        //    result = ProgramParams.TryParse(args, out _);

        //    //assert
        //    Assert.IsFalse(result);
        //}

        //[Test]
        //public void TryParse_TooManyParams_False()
        //{
        //    //arrange
        //    string[] args = new string[ProgramParams.MIN_COUNT_ARGS + 1];
        //    bool result;

        //    //act
        //    result = ProgramParams.TryParse(args, out _);

        //    //assert
        //    Assert.IsFalse(result);
        //}

        //[Test]
        //public void TryParse_IncorrectLength_False()
        //{
        //    //arrange
        //    string[] args = { "-1", "4" };
        //    bool result;

        //    //act
        //    result = ProgramParams.TryParse(args, out _);

        //    //assert
        //    Assert.IsFalse(result);
        //}

        //[Test]
        //public void TryParse_IncorrectHeight_False()
        //{
        //    //arrange
        //    string[] args = { "5", "-2" };
        //    bool result;

        //    //act
        //    result = ProgramParams.TryParse(args, out _);

        //    //assert
        //    Assert.IsFalse(result);
        //}

        //[Test]
        //public void TryParse_IncorrectWhiteCell_False()
        //{
        //    //arrange
        //    string[] args = { "1", "1", "6rfgy" };
        //    bool result;

        //    //act
        //    result = ProgramParams.TryParse(args, out _);

        //    //assert
        //    Assert.IsFalse(result);
        //}

        //[Test]
        //public void TryParse_IncorrectBlackCell_False()
        //{
        //    //arrange
        //    string[] args = { "1", "1", "#", "tg[po" };
        //    bool result;

        //    //act
        //    result = ProgramParams.TryParse(args, out _);

        //    //assert
        //    Assert.IsFalse(result);
        //}

        //[Test]
        //public void TryParse_CorrectParams_CorrectProgramParams()
        //{
        //    //arrange
        //    string[] args = { "8", "8", "#", " " };
        //    ProgramParams expected = new ProgramParams()
        //    {
        //        Length = Int32.Parse(args[0]),
        //        Height = Int32.Parse(args[1]),
        //        WhiteCell = Char.Parse(args[2]),
        //        BlackCell = Char.Parse(args[3])
        //    };
        //    //bool result;

        //    //act
        //    ProgramParams.TryParse(args, out ProgramParams actual);

        //    //assert
        //    Assert.IsTrue(expected.Equals(actual));
        //}
    }
}

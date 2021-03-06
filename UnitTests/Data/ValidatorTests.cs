﻿using ET_1_ChessBoard.Data;
using NUnit.Framework;

namespace UnitTests.Data
{
    class ValidatorTests
    {
        [Test]
        public void IsValid_Null_False()
        {
            //arrange
            bool result;
            string[] args = null;

            //act
            result = Validator.IsValid(args);

            //assert
            Assert.IsFalse(result);
        }

        [Test]
        public void IsValid_IncorrectCountParams_False()
        {
            //arrange
            bool result;
            string[] args = new string[InputData.CountParams + 1];

            //act
            result = Validator.IsValid(args);

            //assert
            Assert.IsFalse(result);
        }

        [Test]
        public void IsValid_EmptyArr_False()
        {
            //arrange
            bool result;
            string[] args = new string[InputData.CountParams];

            //act
            result = Validator.IsValid(args);

            //assert
            Assert.IsFalse(result);
        }

        [Test]
        public void IsValid_NegativeNumber_False()
        {
            //arrange
            bool result;
            string[] args = new string[InputData.CountParams]
                { "-5", "3"};

            //act
            result = Validator.IsValid(args);

            //assert
            Assert.IsFalse(result);
        }

        [Test]
        public void IsValid_NotNumber_False()
        {
            //arrange
            bool result;
            string[] args = new string[InputData.CountParams]
                { "asd", "3"};

            //act
            result = Validator.IsValid(args);

            //assert
            Assert.IsFalse(result);
        }

        [Test]
        public void IsValid_AllCorrect_True()
        {
            //arrange
            bool result;
            string[] args = new string[InputData.CountParams]
                { "2", "3"};

            //act
            result = Validator.IsValid(args);

            //assert
            Assert.IsTrue(result);
        }
    }
}

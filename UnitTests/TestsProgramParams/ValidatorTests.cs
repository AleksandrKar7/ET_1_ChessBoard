using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using ET_1_ChessBoard;

namespace UnitTests.TestsProgramParams
{
    class ValidatorTests
    {
        [Test]
        public void AreParamsValid_CorrectParams_True()
        {
            //arrange
            string[] args = { "8", "8", "#", " " };
            string result;

            //act
            result = Validator.AreParamsValid(args);

            //assert
            Assert.IsTrue(String.IsNullOrEmpty(result));
        }

        [Test]
        public void AreParamsValid_NotEnoughParams_False()
        {
            //arrange
            string[] args = new string[0];
            string result;

            //act
            result = Validator.AreParamsValid(args);

            //assert
            Assert.IsFalse(String.IsNullOrEmpty(result));
        }

        [Test]
        public void AreParamsValid_TooManyParams_False()
        {
            //arrange
            string[] args = new string[10];
            string result;

            //act
            result = Validator.AreParamsValid(args);

            //assert
            Assert.IsFalse(String.IsNullOrEmpty(result));
        }

        [Test]
        public void AreParamsValid_IncorrectLength_False()
        {
            //arrange
            string[] args = { "-1", "4" };
            string result;

            //act
            result = Validator.AreParamsValid(args);

            //assert
            Assert.IsFalse(String.IsNullOrEmpty(result));
        }

        [Test]
        public void AreParamsValid_IncorrectHeight_False()
        {
            //arrange
            string[] args = { "5", "-2" };
            string result;

            //act
            result = Validator.AreParamsValid(args);

            //assert
            Assert.IsFalse(String.IsNullOrEmpty(result));
        }

        [Test]
        public void AreParamsValid_IncorrectWhiteCell_False()
        {
            //arrange
            string[] args = { "1", "1", "6rfgy" };
            string result;

            //act
            result = Validator.AreParamsValid(args);

            //assert
            Assert.IsFalse(String.IsNullOrEmpty(result));
        }

        [Test]
        public void AreParamsValid_IncorrectBlackCell_False()
        {
            //arrange
            string[] args = { "1", "1", "#", "tg[po" };
            string result;

            //act
            result = Validator.AreParamsValid(args);

            //assert
            Assert.IsFalse(String.IsNullOrEmpty(result));
        }
    }
}

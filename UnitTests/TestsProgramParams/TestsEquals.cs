//using System;

//using ET_1_ChessBoard;
//using NUnit.Framework;

//namespace UnitTests.TestsProgramParams
//{
//    class TestsEquals
//    {
//        [Test]
//        public void Equals_Null_False()
//        {
//            //arrange
//            ProgramParams p = new ProgramParams();
//            bool result;

//            //act
//            result = p.Equals(null);

//            //assert
//            Assert.IsFalse(result);
//        }

//        [Test]
//        public void Equals_SameReference_True()
//        {
//            //arrange
//            ProgramParams left = new ProgramParams();
//            ProgramParams right = left;
//            bool result;

//            //act
//            result = left.Equals(right);

//            //assert
//            Assert.IsTrue(result);
//        }

//        [Test]
//        public void Equals_SameFields_True()
//        {
//            //arrange
//            ProgramParams left = new ProgramParams()
//            {
//                Length = 1,
//                Height = 2,
//                WhiteCell = '#',
//                BlackCell = ' '
//            };
//            ProgramParams right = new ProgramParams()
//            {
//                Length = left.Length,
//                Height = left.Height,
//                WhiteCell = left.WhiteCell,
//                BlackCell = left.BlackCell
//            };
//            bool result;

//            //act
//            result = left.Equals(right);

//            //assert
//            Assert.IsTrue(result);
//        }

//        [Test]
//        public void Equals_NotSameFields_True()
//        {
//            //arrange
//            ProgramParams left = new ProgramParams()
//            {
//                Length = 1,
//                Height = 2,
//                WhiteCell = '#',
//                BlackCell = ' '
//            };
//            ProgramParams right = new ProgramParams()
//            {
//                Length = 2,
//                Height = 1,
//                WhiteCell = '$',
//                BlackCell = '_'
//            };
//            bool result;

//            //act
//            result = left.Equals(right);

//            //assert
//            Assert.IsFalse(result);
//        }

//        [Test]
//        public void GetHashCode_SameObjects_True()
//        {
//            //arrange
//            ProgramParams left = new ProgramParams()
//            {
//                Length = 1,
//                Height = 2,
//                WhiteCell = '#',
//                BlackCell = ' '
//            };
//            ProgramParams right = new ProgramParams()
//            {
//                Length = left.Length,
//                Height = left.Height,
//                WhiteCell = left.WhiteCell,
//                BlackCell = left.BlackCell
//            };
//            int leftHashCode;
//            int rightHashCode;

//            //act
//            leftHashCode = left.GetHashCode();
//            rightHashCode = right.GetHashCode();

//            //assert
//            Assert.AreEqual(leftHashCode, rightHashCode);
//        }

//        [Test]
//        public void GetHashCode_DifferentObjects_False()
//        {
//            //arrange
//            ProgramParams left = new ProgramParams()
//            {
//                Length = 1,
//                Height = 2,
//                WhiteCell = '#',
//                BlackCell = ' '
//            };
//            ProgramParams right = new ProgramParams()
//            {
//                Length = 4,
//                Height = 2,
//                WhiteCell = '$',
//                BlackCell = '_'
//            };
//            int leftHashCode;
//            int rightHashCode;

//            //act
//            leftHashCode = left.GetHashCode();
//            rightHashCode = right.GetHashCode();

//            //assert
//            Assert.AreNotEqual(leftHashCode, rightHashCode);
//        }
//    }
//}

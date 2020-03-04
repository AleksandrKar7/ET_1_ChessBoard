using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_1_ChessBoard
{
    public static class Validator
    {
        #region Сonstants

        private const int MIN_COUNT_ARGS = 2;
        private const int MAX_COUNT_ARGS = 4;

        #endregion

        public static string AreParamsValid(string[] args)
        {
            if (args.Length < MIN_COUNT_ARGS || args.Length > MAX_COUNT_ARGS)
            {
                return "Incorrect number of variables";
            }
            if (!Int32.TryParse(args[0], out int length))
            {
                return "Length variable is invalid";
            }
            if (length < 0)
            {
                return "Length must be more than zero";
            }
            if (!Int32.TryParse(args[1], out int height))
            {
                return "Height variable is invalid";
            }        
            if(height < 0)
            {
                return "Height must be more than zero";
            }
            if ((args.Length > 2 && !Char.TryParse(args[2], out char white)) ||
                (args.Length > 3 && !Char.TryParse(args[3], out char black)))
            {
                return "Some optional parameters are not valid";
            }

            return String.Empty;
        }

        public static string GetInstruction()
        {
            return "Parameter List: " + "\n"
                + "Length <Numeric> More than zero" + "\n"
                + "Height <Numeric> More than zero" + "\n"
                + "White cell <Symbol> Optional" + "\n"
                + "Black cell <Symbol> Optional" + "\n"; ;
        }
    }
}

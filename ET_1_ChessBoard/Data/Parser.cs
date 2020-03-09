using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_1_ChessBoard.Data
{
    public class Parser
    {
        public static InputData Parse(string[] args)
        {
            if (args == null)
            {
                throw new NullReferenceException("Array of parameters is null"); //81
            }
            if (args.Length != InputData.CountParams)
            {
                throw new ArgumentException(
                    "The number of parameters is incorrect. " +
                    "There must be: " + InputData.CountParams);
            }

            return new InputData
            {
                Length = Int32.Parse(args[0]),
                Height = Int32.Parse(args[1]),
            };
        }
    }
}

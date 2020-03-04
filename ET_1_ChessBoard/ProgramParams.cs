using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_1_ChessBoard
{
    public class ProgramParams
    {
        #region Сonstants

        private const char STANDART_MAIN_SYMBOL = '#';
        private const char STANDART_SPACE_SYMBOL = ' ';

        #endregion

        public int Length { get; set; }
        public int Height { get; set; }
        public char WhiteCell { get; set; }
        public char BlackCell { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <exception cref="FormatException">If length or height is less than zero</exception>
        /// <exception cref="NullReferenceException">If any parameter is null</exception>
        public ProgramParams(string[] args)
        {
            WhiteCell = STANDART_MAIN_SYMBOL;
            BlackCell = STANDART_SPACE_SYMBOL;

            Length = Int32.Parse(args[0]);
            Height = Int32.Parse(args[1]);
            if (args.Length > 2)
            {
                WhiteCell = Char.Parse(args[2]);
            }
            if (args.Length > 3)
            {
                BlackCell = Char.Parse(args[3]);
            }        
        }

        public ProgramParams(int length, int height) :
            this(length, height, STANDART_MAIN_SYMBOL)
        {            
        }

        public ProgramParams(int length, int height, char white) :
            this(length, height, white, STANDART_SPACE_SYMBOL)
        {
        }

        public ProgramParams(int length, int height, char white, char black)
        {
            Length = length;
            Height = height;
            WhiteCell = white;
            BlackCell = black;
        }
    }
}

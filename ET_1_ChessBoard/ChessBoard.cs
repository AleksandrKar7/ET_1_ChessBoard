﻿namespace ET_1_ChessBoard
{
    public class ChessBoard
    {
        public int Length { get; set; }

        public int Height { get; set; }

        public ChessBoard(int length, int height)
        {
            Length = length;
            Height = height;
        }
    }
}

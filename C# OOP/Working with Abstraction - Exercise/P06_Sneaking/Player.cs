namespace P06_Sneaking
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Player
    {
        public Player(int row, int col)
        {
            this.CurrentRow = row;
            this.CurrentCol = col;
        }

        public int CurrentRow { get; set; }

        public int CurrentCol { get; set; }
    }
}

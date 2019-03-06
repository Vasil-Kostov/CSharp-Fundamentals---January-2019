namespace P03_JediGalaxy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Galaxy
    {
        private int[,] matrix;

        public Galaxy(int[] dimestions)
        {
            this.Matrix = new int[dimestions[0], dimestions[1]];

            this.FillTheMatrix();
        }

        public int[,] Matrix
        {
            get { return this.matrix; }
            set { this.matrix = value; }
        }

        private void FillTheMatrix()
        {
            int value = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = value++;
                }
            }
        }

        public bool IsInTheGalaxy(Person person)
        {
            return person.CurrentRow >= 0 && person.CurrentRow < this.Matrix.GetLength(0)
                && person.CurrentCol >= 0 && person.CurrentCol < this.Matrix.GetLength(1);
        }
    }
}

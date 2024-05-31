using System;
using System.Security.Cryptography.X509Certificates;

namespace pong 
{
    public class Field
    {
        private readonly char[,] _field;

        public Field(int width, int height, char tile = '#')
        {
            this._field = new char[height, width];

            for (int i = 0; i < height; i++)
            {
                this.Set(0, i, tile);
                this.Set(this.GetRows - 1, i, tile);
            }
        }
        public int GetRows => this._field.GetLength(0);
        public int GetCols => this._field.GetLength(1);

        public char Tile { get; }

        public char Get(int row, int col)
        {
            return this._field[row, col];
        }
        public void Set(int row, int col, char el)
        {
            this._field[row, col] = el;
        }





    }

    //public Field(int width, int height, char tile = '#')
    //    {
    //     
    //    }

            

}



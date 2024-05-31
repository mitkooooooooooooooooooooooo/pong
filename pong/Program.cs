using System.Runtime.CompilerServices;

namespace pong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Field field = new(51, 15);
            Console.SetWindowSize(field.GetCols + 1, field.GetRows + 5);

            Console.CursorVisible = false;
            while (true)
            {
                for (int i = 0; i < field.GetRows; i++)
                {
                    for (int j = 0; j < field.GetCols; j++)
                    {
                        DrawAt(i, j, field.Get(i, j).ToString());
                    }
                }
                Thread.Sleep(10);
            }


        }

        static void DrawAt(int x, int y, string s)
        {
            Console.SetCursorPosition(y, x);
            Console.WriteLine(s);

            
        }




    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static int[][] matrix =
        {
            new int[] {0, 0,  9, 6, 0, 0, 0, 0, 0, 0},
            new int[] {0, 0,  0, 0, 0, 0, 0, 0, 0, 0},
            new int[] {0, 0,  0, 0, 0, 0, 0, 0,32, 0},
            new int[] {0,16,  0,52, 0, 0, 0, 0, 0, 0},
            new int[] {0, 0,  0,18, 1, 0, 0, 0, 0, 0},
            new int[] {0, 0,100, 0, 0, 0, 0, 0, 0, 0},
            new int[] {0, 0,  0, 0, 0, 0, 0, 0, 0,58},
            new int[] {0, 0,  0, 0, 0, 0, 0, 0, 0, 0},
            new int[] {0, 0,  0, 0, 0, 0, 0,57, 0, 0},
            new int[] {0, 0, 93, 0,76, 0, 0, 0, 0,59}

        };

        static void Main(string[] args)
        {
            PrintMatrix();
            Console.ReadLine();
        }

        static void PrintMatrix()
        {
            string vertical = "-----------------------------------------";
            Console.Out.WriteLine(vertical);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Out.WriteLine(GetRowString(matrix[i]));
                Console.Out.WriteLine(vertical);
            }
        }

        static string GetRowString(int[] row)
        {
            string s = "|";
            for (int i = 0; i < row.GetLength(0); i++)
            {
                s += String.Format("{0, 4}", row[i].ToString() + "|");
            }
            return s;
        }

    }
}

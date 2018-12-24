using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Rectangle_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstRectangle = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var first = new Rectangle();
            first.Left = firstRectangle[0];
            first.Top = firstRectangle[1];
            first.Width = firstRectangle[2];
            first.Height = firstRectangle[3];

            var secondRectangle = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var second = new Rectangle();
            second.Left = secondRectangle[0];
            second.Top = secondRectangle[1];
            second.Width = secondRectangle[2];
            second.Height = secondRectangle[3];

            if (FirstIsInsideSecond(first, second) == true)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }                       
        }

        public static bool FirstIsInsideSecond(Rectangle first, Rectangle second)
        {
            var leftIsCorrect = first.Left >= second.Left;
            var rightIsCorrect = first.Right <= second.Right;
            var bottomIsCorrect = first.Bottom >= second.Bottom;
            var TopIsCorrect = first.Top <= second.Top;

            return leftIsCorrect && rightIsCorrect && bottomIsCorrect && TopIsCorrect;
        }
    }
}

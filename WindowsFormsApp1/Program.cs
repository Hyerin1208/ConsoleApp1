using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        static void Main()
        {
            var num = 1;
            Console.Write("0~9사이의 값을 입력:");

            var input = Console.ReadLine();

            if (num.ToString() == input)
            {
                Console.WriteLine("같은값을 입력했습니다.");
            }
            else if (num.ToString() != input)
            {
                Console.WriteLine("다른값을 입력했습니다.");
            }
        }
    }
}

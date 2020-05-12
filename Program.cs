using System;

namespace Test8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int result = 0;

            Console.WriteLine("整数1 = ");
            string strNo1 = Console.ReadLine();

            Console.WriteLine("整数2 = ");
            string strNo2 = Console.ReadLine();

            try
            {
                x = int.Parse(strNo1);
                y = int.Parse(strNo2);

                result = x / y;
                Console.WriteLine($"割り算の結果は {result} です。");
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("ゼロで割ることはできません。");
            }

            finally
            {
                Console.WriteLine("処理を終了します。");
            }
        }
    }
}

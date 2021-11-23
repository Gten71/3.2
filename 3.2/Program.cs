using System;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 9; i > -10 && i < 10; i += 9)
                sum += i;
            Console.Write(sum);
            

        }
    }
}

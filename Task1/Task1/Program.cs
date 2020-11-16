using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] maxAray = new int[13];
            Random rnd = new Random();
            for (int i = 0; i < maxAray.Length; i++)
            {
                maxAray[i] = rnd.Next(1, 99);
            }
            int maxValue = maxAray[0];
            for (int i = 1; i < maxAray.Length; i++)
            {
                if (maxAray[i] > maxValue)
                {
                    maxValue = maxAray[i];
                }
            }
            Console.WriteLine(maxValue);
            
        }
    }
}

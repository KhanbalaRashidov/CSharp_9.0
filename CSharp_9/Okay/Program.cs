using System;

namespace Okay
{
    class Program
    {
        public static int GetMaximumGenerated(int n)
        {

            int[] nums = new int[n + 1];
            nums[0] = 0;
            nums[1] = 1;
            int max = 0;
            for (int i = 1; i <=n; i++)
            {
                if (i * 2 >= 2 && i * 2 <= n)
                {
                    nums[i * 2] = nums[i];
                }
                if (((i * 2) + 1) >= 2 && ((i * 2) + 1) <= n)
                {
                    nums[i * 2 + 1] = nums[i] + nums[i + 1];
                }
            }
            
            max = nums[n];
            return max;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMaximumGenerated(n));
        }
    }
}

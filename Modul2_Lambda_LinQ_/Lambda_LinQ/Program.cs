using System;
using System.Linq;

namespace Lambda_LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 22, 18, 1, 7, 3, 4, 9, 6, 8, 4, 12, 9 };
            int[] nums1 = { 2, 3, 8, 5, 2, 4, 5, 7, 5, 2 };
            Console.WriteLine(string.Join(" ", nums));

            nums = nums.Where(x => x % 2 == 0).ToArray();
            Console.WriteLine(string.Join(" ", nums));

            int s = nums.Sum();
            Console.WriteLine(s);

            int count = nums.Length;
            Console.WriteLine(count);

            nums = nums.OrderBy(x => x).ToArray();
            nums = nums.Where(n => n >= 8).ToArray();
            Console.WriteLine(string.Join(" ", nums));

            nums = nums.OrderByDescending(n=> n).ToArray();
            Console.WriteLine(string.Join(" ", nums));

            nums = nums.Take(3).ToArray();
            Console.WriteLine(string.Join(" ", nums));

            nums = nums.Select(x => x * 10).ToArray();
            Console.WriteLine(string.Join(" ", nums));

            Console.WriteLine(string.Join(" ", nums1));
            nums1 = nums1.Distinct().ToArray();
            Console.WriteLine(string.Join(" ", nums1));

            var concatM = nums.Concat(nums1);
            Console.WriteLine(string.Join(" ", concatM));



        }
    }
}

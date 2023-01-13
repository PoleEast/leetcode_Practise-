using System;
using System.Linq;

namespace Two_sum
{
    class Program
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] ans= new int[2];
            foreach (int Iteam in nums)
            {
                var find = from data in nums
                           where data == target - Iteam
                           select data;
                foreach(var item in find)
                {
                    ans = new int[] { Iteam, item };
                }
            }
            return ans;
        }
        static void Main(string[] args)
        {
            int[] nums = new int[] {2, 7, 11, 15};
            int target = 9;
            int[] ans = TwoSum(nums, target);
            Console.WriteLine(ans[1].ToString()+"  "+ans[0].ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using leadCode.service;

namespace leadCode
{
    class Program
    {
        static void Main(string[] args)
        {
            soluation service = new soluation();

            int[] ans = new int[2];
            int[] nums = new int[] { 3,2, 4};
            int target = 6;

            ans = service.TwoSum(nums, target);

            for (int i = 0; i < ans.Length; i++)
            {
                Console.Write(ans[i]);
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leadCode.service
{
    public class soluation
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Hashtable ht = new Hashtable();
            List<int> list = new List<int>();
            list = nums.ToList<int>();
            int i = 0;
            foreach (int num in list)
            {
                if (!ht.Contains(num)) ht.Add(num, i);
                i++;
            }
            i = 0;
            foreach (int num in list)
            {
                int temp = target - num;
                if (ht.Contains(temp) && i != (int)ht[temp])
                {
                    int[] ans = new int[2];
                    ans[0] = i;
                    ans[1] = (int)ht[temp];
                    return ans;
                }
                i++;
            }
            return null;
        }
    }
}

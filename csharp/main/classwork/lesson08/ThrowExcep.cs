using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson08
{
    class ThrowExcep
    {
        public static int GetNumber(int index)
        {
            int[] nums = { 300, 600, 900 };

            if (index > nums.Length || index < 0)
            {
                throw new IndexOutOfRangeException("My message" + index + " is not a valid index for number");
            }
            return nums[index];
        }

    }
}

using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Open_Lab_04._12
{
    public class Numbers
    {
        public int MissingNum(int[] nums)
        {
            for(int i = 1; i<11; i++)
            {
                if (nums.Contains(i))
                {
                    
                }
                else
                {
                    return i;
                }
            }
            return 0;
        }
    }
}

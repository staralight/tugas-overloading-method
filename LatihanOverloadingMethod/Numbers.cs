using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {
        public int FindMinimum(int num1, int num2)
        {
            if (num1 >= num2) 
                return num2;
            else
                return num1;
        }

        public int FindMinimum(int num1, int num2, float num3)
        {
            if (num1 >= num2 || num2 >= num3)
            {
                if (num2 < num1 && num2 < num3)
                    return num2;
                else
                    return (int)num3;
            }
            else return num1;
        }

        public int FindMaximum(int num1, int num2)
        {
            if (num1 <= num2)
                return num2;
            else
                return num1;
        }

        public int FindMaximum(int num1, int num2, float num3)
        {
            if (num1 <= num2 || num1 <= num3)
            {
                if (num2 > num1 && num2 > num3)
                    return num2;
                else
                    return (int)num3;
            }
            else return num1;
        }
    }
}

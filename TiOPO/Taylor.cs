using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiOPO
{
    public class Taylor
    {

        public static double Factorial(int num)
        {
            if(num <= 1)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }
        public static double Power(double num, int pow)
        {
            double result = 1;

            if (pow > 0)
            {
                for (int i = 1; i <= pow; ++i)
                {
                    result *= num;
                }
            }
            else if (pow < 0)
            {
                for (int i = -1; i >= pow; --i)
                {
                    result /= num;
                }
            }

            return result;
        }
        public static double Abs(double num)
        {
            if (num >= 0)
            {
                return num;
            }

            return -num;
        }
        public static double Sin(double x)
        {
            double y = 0;
            for (int i = 1; i < 199; i++)
            {
                double first = Power(-1, i - 1) * Power(x, 2 * i - 1);
                double second = Factorial(2 * i - 1);
                y += first / second;
            }
            return y;
        }
        public static double Cos(double x)
        {
            double y = 1;
            for (int i = 1; i < 30; i += 1)
            {
                y += Power(-1, i) * (Power(x, 2 * i)) / (Factorial(2 * i));
            }
            return y;
        }
        public static double LnPlus(double x)
        {
            if (x <= -1 || x > 1) throw new OutOfRange();
            double y = x;
            for (int i = 2; i < 500; i++)
            {
                y += (Power(-1, i) * Power(x, i)) / (i);
            }
            return y;
        }
        //public static double SqrtPlus(double x)
        //{
        //    double y = 1;
        //    for (int i = 1; i < 1000; i++)
        //    {
        //        y += (Power(i, i + 1) * Factorial(2 * i)) / Power(2, 2 * i) * (2 * i - 1) * Power(Factorial(i), 2);
        //    }
        //    return y;
        //}
        public static double Exp(double x)
        {
            double exp = 1;
            for (int i = 1; i < 500; i++)
            {
                exp += Power(x, i) / Factorial(i);
            }
            return exp;
        }
    }
}

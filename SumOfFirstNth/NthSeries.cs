using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfFirstNth
{
    public class NthSeries
    {

        public static string SeriesSum(int n)
        {
            // You will only be given Natural Numbers as arguments.

            // 0.25          1/4
            // 0.14285714    1/7
            // 0.1           1/10
            // 0.0769        1/13

            double fraction = 4;
            double sum = 1;
            string output;
            int count = 1;
            
            while (n > count)
            {
                // 1 + 1/4 + 1/7 + 1/10 + 1/13 = "1.57"
                sum += 1 / fraction;
                fraction += 3;
                count++;

            }
            // You need to round the answer to 2 decimal places and return it as String.
            sum = Math.Round(sum, 2);
            output = sum.ToString("0.00");

            // If the given value is 0 then it should return 0.00
            if (n < 1)
            {
                output = "0.00";
            }

            return output;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcessing
{
    class MyCompute
    {
        public static double ComputeWeightedAvg(string major, int t1, int t2)
        {
            double res = 0;
            try
            {
                if (t1 == 0 || t2 == 0)
                    throw new Exception("one test is 0");
                if (major == "UG")
                    res = 0.4 * t1 + 0.6 * t2;
                else
                    res = 0.5 * t1 + 0.5 * t2;
            }catch (Exception ex)
            {
                throw;
            }
            return res;
        }
    }
}

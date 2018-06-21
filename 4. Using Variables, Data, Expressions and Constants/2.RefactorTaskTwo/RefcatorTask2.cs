using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.RefactorTaskTwo
{
    class RefcatorTask2
    {
        //        public void PrintStatistics(double[] arr, int count)
        //{
        //    double max, tmp;
        //    for (int i = 0; i < count; i++)
        //    {
        //        if (arr[i] > max)
        //        {
        //            max = arr[i];
        //        }
        //    }
        //    PrintMax(max);

        //                tmp = 0;
        //    max = 0;
        //    for (int i = 0; i < count; i++)
        //    {
        //        if (arr[i] < max)
        //        {
        //            max = arr[i];
        //        }
        //    }
        //    PrintMin(max);

        //    tmp = 0;
        //    for (int i = 0; i < count; i++)
        //    {
        //        tmp += arr[i];
        //    }
        //    PrintAvg(tmp/count);

        public void PrintStatistics(double[] numbers, int count)
        {
            double maxNumber = 0;
            double temperallyMinNumber = 0;

            for (int i = 0; i < count; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }

            PrintMaxNumber(maxNumber);

            temperallyMinNumber = 0;
            maxNumber = 0;

            for (int i = 0; i < count; i++)
            {
                if (numbers[i] < maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }

            PrintMinNumber(maxNumber);
            temperallyMinNumber = 0;

            for (int i = 0; i < count; i++)
            {
                temperallyMinNumber += numbers[i];
            }

            PrintAverageNumber(temperallyMinNumber / count);
        }
        static void Main(string[] args)
        {
        }
    }
}

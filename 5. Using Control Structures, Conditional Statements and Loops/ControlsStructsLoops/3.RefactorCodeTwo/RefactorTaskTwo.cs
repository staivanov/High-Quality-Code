using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.RefactorCodeTwo
{
    class RefactorTaskTwo
    {
//        int i=0;
//for (i = 0; i < 100;) 
//{
//   if (i % 10 == 0)
//   {
//    Console.WriteLine(array[i]);
//    if ( array[i] == expectedValue ) 
//    {
//       i = 666;
//    }
//    i++;
//   }
//   else
//   {
//        Console.WriteLine(array[i]);
//    i++;
//   }
//}
//// More code here
//if (i == 666)
//{
//    Console.WriteLine("Value Found");
//}
        public const int DEVIL_NUMBER = 666;

        static void Main(string[] args)
        {
            int i = 0;
            int[] arrayOfNumber = new int[1000];
            int expectedValue = DEVIL_NUMBER;

            for (i = 0; i < 100; )
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(arrayOfNumber[i]);

                    if (arrayOfNumber[i] == expectedValue)
                    {
                        i = DEVIL_NUMBER;
                    }

                    i++;
                }

                else
                {
                    Console.WriteLine(arrayOfNumber[i]);
                    i++;
                }

            }
            // More code here
            if (i != DEVIL_NUMBER)
            {
                Console.WriteLine("Value Found");
            }

        }
    }
}

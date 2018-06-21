using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.RefactorIfStatment
{
    class RefactorStatment
    {
        public static object MAX_Y { get; set; }
        public static object MIN_Y { get; set; }
        public static object MIN_X { get; set; }
        public static bool MAX_X { get; set; }

        static void Main(string[] args)
        {

         Potato potato = new Potato();

         if (potato != null)
         {
             if(!(potato.HasNotBeenPeeled && potato.IsRotten))
                  {
	                 Cook(potato);
                  }
         }

           bool  isVisited = false;
           bool isCorrect = ((MAX_Y >= y && MIN_Y <= y));

         if ((x >= MIN_X) && (x =< MAX_X) && isCorrect  && isVisited)
          {
                   VisitCell();
          }

        private static void VisitCell()
        {
            throw new NotImplementedException();
        }
    }
}

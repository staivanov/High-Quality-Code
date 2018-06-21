using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.RefactorTaskOne
{
    class TaksOne
    {
        //class class_123
        //{
        //    const int max_count = 6;

        //    class InClass_class_123
        //    {
        //        void Метод_нА_class_InClass_class_123(bool promenliva)
        //        {
        //            string promenlivaKatoString = promenliva.ToString();
        //            Console.WriteLine(promenlivaKatoString);
        //        }
        //    }
        //    public static void Метод_За_Вход()
        //    {
        //        class_123.InClass_class_123 инстанция =
        //          new class_123.InClass_class_123();
        //        инстанция.Метод_нА_class_InClass_class_123(true);
        //    }
        //}

        internal class Unnamed
        {
            private const int MAX_COUNT = 6;

            internal class Some
            {
                public void ConvertToString(bool myVariable)
                {
                    string variableToString = myVariable.ToString();
                    Console.WriteLine(variableToString);
                }
            }

            public static void MakeIstance()
            {
                Unnamed.Some instance = new Unnamed.Some();
                instance.ConvertToString(true);
            }
        }

        static void Main(string[] args)
        {

            Unnamed.MakeIstance();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorTaskTwo
{
    class TaskTwo
    {
        //    class TaskTwo
        //    {
        //        class Hauptklasse
        //{
        //  enum Пол { ултра_Батка, Яка_Мацка };

        //  class чуек
        //  {
        //    public Пол пол { get; set; }
        //    public string име_на_Чуека { get; set; }
        //    public int Възраст { get; set; }
        //  }
        //      public void Make_Чуек(int магическия_НомерНаЕДИНЧОВЕК)
        //  {
        //    чуек new_Чуек = new чуек();
        //    new_Чуек.Възраст = магическия_НомерНаЕДИНЧОВЕК;
        //    if (магическия_НомерНаЕДИНЧОВЕК%2 == 0)
        //    {
        //      new_Чуек.име_на_Чуека = "Батката";
        //      new_Чуек.пол = Пол.ултра_Батка;
        //    }
        //    else
        //    {
        //      new_Чуек.име_на_Чуека = "Мацето";
        //      new_Чуек.пол = Пол.Яка_Мацка;
        //    }
        //  }
        //}

        public class Ddz
        {
            private const int number = 0;
            enum Sex { MALE, FEMALE };

           public class Humman
            {
                public Sex Sexf { get; set; }
                public string Name { get; set; }
                public int Age { get; set; }
            }

            public void MakeHumman(int number)
            {
                Humman humman = new Humman();
                humman.Age = number;

                if ((number % 2) == 0)
                {
                    humman.Name = "Big brother";
                    humman.Sexf = Sex.MALE;
                }
                else
                {
                    humman.Name = "The chick";
                    humman.Sexf = Sex.FEMALE;
                }
            }
        }

        static void Main(string[] args)
        {
        }
    }
}

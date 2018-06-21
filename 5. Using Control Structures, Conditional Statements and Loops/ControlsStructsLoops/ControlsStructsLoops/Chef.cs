using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlsStructsLoops
{
    class Chef
    {
     private Bowl GetBowl(){

           bowl.Add(carrot);

        }

     private Carrot GetCarrot(){

            Cut(carrot);
            return carrot;
        }

     private void Cut(Vegetable potato){

           Peel(potato); 
        }  

     private Potato GetPotato()
      {
       Cut(potato)
       return potato;
      }


      public void Cook() {
        Bowl bowl;
        Potato potato = GetPotato();
        Carrot carrot = GetCarrot();
        bowl = GetBowl();             
        Peel(carrot);      
        bowl.Add(carrot);
       }
    }
}

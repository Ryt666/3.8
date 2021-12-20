using System;
using System.Collections.Generic;
using System.Text;

namespace _3._8
{
    class Pressure : Sensor
    {
      
        public Pressure( int parametr) : base("Давление: ", "(им.рт.ст.)")
        {
            
            Parametr = parametr; 
        }
       
    }
}

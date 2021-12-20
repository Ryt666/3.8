using System;
using System.Collections.Generic;
using System.Text;

namespace _3._8
{
    class Temprature : Sensor
    { 
        public Temprature( double parametr) : base("Температура: ", "(С)")
        {
            Parametr = parametr;
        }
       
    }
}

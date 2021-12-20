using System;
using System.Collections.Generic;
using System.Text;

namespace _3._8
{
    class Power : Sensor
    {
        public Power(int parametr) : base("Сила ветра: ","(км/ч)")
        {
           
            Parametr = parametr;
        }
    }
}

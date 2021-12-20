using System;
using System.Collections.Generic;
using System.Text;

namespace _3._8
{
    abstract class Sensor
    {
        public readonly string Name;
        public readonly string Unit;
        protected double Parametr { set; get; }
        public  Sensor (string _name, string _unit)
        {
           Name = _name;
           Unit = _unit;
        }

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Console.Write(Parametr);
            Console.WriteLine(Unit);
           
        }
        public void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Unit);
        }

    }
}

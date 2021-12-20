using System;

namespace _3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Center_post center_post = new Center_post();
            /* Temprature temprature = new Temprature();
            center_post.ShowInfo(temprature); */
             Sensor[] telemetry_system = { new Temprature(6), new Pressure(728), new Power(13) };
              foreach(var i in telemetry_system)
              { 
                  center_post.CheckInfo(i);

              }
             
           Sensor one;
           one = new Route();
           one.Print();
           
        }

    }
}

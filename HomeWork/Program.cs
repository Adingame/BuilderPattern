using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace HomeWork
{
    class Program
    {
        static void Main()
        {
            CarBuilder car = new Toyota();
            AutoMechanic autoMechanic = new AutoMechanic();
            autoMechanic.CreateCar(car);
            Console.WriteLine(car);
        }
    }
}

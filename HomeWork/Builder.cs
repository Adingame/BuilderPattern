using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{

    public class Toyota : CarBuilder
    {
        public override void AddBox()
        {
            car.box = new Box() { Name = "Best box" };
        }

        public override void AddCarcase()
        {
            car.carcase = new Carcase() { Name = "Best Carcase" };
        }

        public override void AddMotor()
        {
            car.motor = new Motor() { Name = "Best motor" };
        }

        public override void AddWheel()
        {
            car.wheel = new Wheel() { Name = "Best wheel" };
        }
    }

    public class AutoMechanic
    {
        public Car CreateCar(CarBuilder car)
        {
            car.CreateCar();
            car.AddBox();
            car.AddCarcase();
            car.AddMotor();
            car.AddWheel();

            return car.car;
        }
    }

    public abstract class CarBuilder
    {
        public Car car { get; set; }
        public void CreateCar()
        {
            car = new Car();
        }

        public abstract void AddBox();
        public abstract void AddWheel();
        public abstract void AddMotor();
        public abstract void AddCarcase();
    }

    public class Car
    {
        public Box box { get; set; }
        public Wheel wheel { get; set; }
        public Motor motor { get; set; }
        public Carcase carcase { get; set; }
        public override string ToString()
        {
            string result = box.Name + Environment.NewLine +
                wheel.Name + Environment.NewLine +
                motor.Name + Environment.NewLine +
                carcase.Name + Environment.NewLine;
            return result;
        }
    }

    public class Box
    {
        public string Name { get; set; }
    }

    public class Wheel
    {
        public string Name { get; set; }
    }

    public class Motor 
    {
        public string Name { get; set; }
    }

    public class Carcase
    {
        public string Name { get; set; }
    }
}

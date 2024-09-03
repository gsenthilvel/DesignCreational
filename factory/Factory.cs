using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignCreational.Factory
{
    abstract class EVCar
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Battery { get; set; }
        public string Range { get; set; }
        public string Price { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Manufacturer: " + Manufacturer);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Battery: " + Battery);
            Console.WriteLine("Range: " + Range);
            Console.WriteLine("Price: " + Price);
        }
    }
    class Tesla : EVCar
    {
        public Tesla()
        {
            Name = "Tesla";
            Manufacturer = "Tesla Inc.";
            Model = "Model S";
            Year = "2021";
            Battery = "100 kWh";
            Range = "412 miles";
            Price = "$79,990";
        }
    }
    class Rivian : EVCar
    {
        public Rivian()
        {
            Name = "Rivian";
            Manufacturer = "Rivian Automotive Inc.";
            Model = "R1T";
            Year = "2021";
            Battery = "135 kWh";
            Range = "300 miles";
            Price = "$67,500";
        }
    }
    class Bolt : EVCar
    {
        public Bolt()
        {
            Name = "Chevrolet";
            Manufacturer = "General Motors";
            Model = "Bolt EV";
            Year = "2021";
            Battery = "66 kWh";
            Range = "259 miles";
            Price = "$36,500";
        }
    }

    interface EVCarFactory
    {
        EVCar GetEVCar();
    }
    class TeslaFactory : EVCarFactory
    {
        public EVCar GetEVCar() => new Tesla();
    }
    class RivianFactory : EVCarFactory
    {
        public EVCar GetEVCar() => new Rivian();
    }
    class BoltFactory : EVCarFactory
    {
        public EVCar GetEVCar() => new Bolt();
    }

    class FactoryUser
    {
        private EVCarFactory _evCarFactory;
        public FactoryUser(EVCarFactory evCarFactory)
        {
            _evCarFactory = evCarFactory;
        }
        public void ShowEVCarInfo()
        {
            EVCar evCar = _evCarFactory.GetEVCar();
            evCar.ShowInfo();
        }
    }
}

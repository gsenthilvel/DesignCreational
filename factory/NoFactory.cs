using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignCreational.NoFactory
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
    class Rav4 : EVCar
    {
        public Rav4()
        {
            Name = "Toyota";
            Manufacturer = "Toyota Motor Corporation";
            Model = "Rav4 Prime";
            Year = "2021";
            Battery = "18.1 kWh";
            Range = "42 miles";
            Price = "$38,100";
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

    class NoFactoryUser
    {
        private EVCar _evCar;
        public NoFactoryUser(int carModel)
        {
            if (carModel == 1)
            {
                _evCar = new Tesla();
            }
            else if (carModel == 2)
            {
                _evCar = new Rav4();
            }
            else if (carModel == 3)
            {
                _evCar = new Bolt();
            }
            else
            {
                _evCar = null;
            }
        }
        public void ShowEVCarInfo()
        {
            Console.WriteLine("Electric Vehicle Information");
            Console.WriteLine("----------------------------");
            if (_evCar != null)
                _evCar.ShowInfo();
            else
                Console.WriteLine("No car selected");
        }
    }
}

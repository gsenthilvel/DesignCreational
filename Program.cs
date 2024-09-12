using DesignCreational.NoFactory;
using DesignCreational.Factory;
using DesignCreational.AbstractFactory;
using DesignCreational.Prototype;
using System;
using System.Net.Sockets;

namespace DesignCreational
{

    internal class Program
    {
        private void SingletonTest()
        {
            Singleton instance = Singleton.GetInstance;
            instance.Execute();
        }
        private void NoFactoryTest()
        {
            NoFactoryUser _user = new NoFactoryUser(20);
            _user.ShowEVCarInfo();
        }
        private void FactoryTest()
        {
            FactoryUser _user = new FactoryUser(new TeslaFactory());
            _user.ShowEVCarInfo();
            _user = new FactoryUser(new RivianFactory());
            _user.ShowEVCarInfo();
        }
        private void AbstractFactoryTest()
        {
            IEVCarFactory _evCarFactory = new NA_EVCarFactory();
            AbstractFactory.EVCar _evCar = _evCarFactory.CreateEVCar();
            CarSpecfication _carSpecfication = _evCarFactory.CreateCarSpecfication();
            Console.WriteLine(_evCar.GetCarInfo());
            Console.WriteLine(_carSpecfication.GetSpecfication());
            _evCarFactory = new EU_EVCarFactory();
            _evCar = _evCarFactory.CreateEVCar();
            _carSpecfication = _evCarFactory.CreateCarSpecfication();
            Console.WriteLine(_evCar.GetCarInfo());
            Console.WriteLine(_carSpecfication.GetSpecfication());
        }
        private void ProtocolTypeTest()
        {
            Resume myResume = new Resume("Full Name", "Full Address", "Phone Number");
            Book myBook = new Book("Book Title", "Book Content");

            myResume.ShowInfo();
            myBook.ShowInfo();

        }
        static void BuilderTest()
        {
            Builder _gamingLaptopBuilder = new GamingLaptopBuilder();
            LaptopDirector _laptopDirector = new LaptopDirector(_gamingLaptopBuilder);
            _laptopDirector.Construct();

            Builder _personalLaptopBuilder = new PersonalLaptopBuilder();
            _laptopDirector = new LaptopDirector(_personalLaptopBuilder);
            _laptopDirector.Construct();

        }
        static void Main(string[] args)
        {
            BuilderTest();
        }
    }
}
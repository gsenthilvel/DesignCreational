using DesignCreational.NoFactory;
using DesignCreational.Factory;
using System;

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
        static void AbstractFactoryTest()
        {
            IEVCarFactory _evCarFactory = new NA_EVCarFactory();
            EVCar _evCar = _evCarFactory.CreateEVCar();
            CarSpecfication _carSpecfication = _evCarFactory.CreateCarSpecfication();
            Console.WriteLine(_evCar.GetCarInfo());
            Console.WriteLine(_carSpecfication.GetSpecfication());
            _evCarFactory = new EU_EVCarFactory();
            _evCar = _evCarFactory.CreateEVCar();
            _carSpecfication = _evCarFactory.CreateCarSpecfication();
            Console.WriteLine(_evCar.GetCarInfo());
            Console.WriteLine(_carSpecfication.GetSpecfication());
        }
        static void Main(string[] args)
        {
            AbstractFactoryTest();
        }
    }
}
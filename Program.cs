using DesignCreational.NoFactory;
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
        static void FactoryTest()
        {
            FactoryUser _user = new FactoryUser(new TeslaFactory());
            _user.ShowEVCarInfo();
            _user = new FactoryUser(new RivianFactory());
            _user.ShowEVCarInfo();
        }
        static void Main(string[] args)
        {
            FactoryTest();
        }
    }
}
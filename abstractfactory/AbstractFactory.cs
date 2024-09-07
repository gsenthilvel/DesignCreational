using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignCreational.AbstractFactory
{
    interface IEVCarFactory
    {
        EVCar CreateEVCar();
        CarSpecfication CreateCarSpecfication();
    }

    class NA_EVCarFactory : IEVCarFactory
    {
        CarSpecfication IEVCarFactory.CreateCarSpecfication()
        {
            return new NA_CarSpecfication();
        }

        EVCar IEVCarFactory.CreateEVCar()
        {
            return new SUV_EVCar();
        }
    }

    class EU_EVCarFactory : IEVCarFactory
    {
        CarSpecfication IEVCarFactory.CreateCarSpecfication()
        {
            return new EU_CarSpecfication();
        }

        EVCar IEVCarFactory.CreateEVCar()
        {
            return new Hatch_EVCar();
        }
    }

    interface CarSpecfication
    {
        string GetSpecfication();
    }

    class NA_CarSpecfication : CarSpecfication
    {
        string CarSpecfication.GetSpecfication()
        {
            return "North America Car Rules & Regulations";
        }
    }
    class EU_CarSpecfication : CarSpecfication
    {
        string CarSpecfication.GetSpecfication()
        {
            return "European Union Car Rules & Regulations";
        }
    }
    interface EVCar
    {
        string GetCarInfo();
    }
    class SUV_EVCar : EVCar
    {
        string EVCar.GetCarInfo()
        {
            return "Sports Utility Vehicle SUV Car";
        }

    }
    class Hatch_EVCar : EVCar
    {
        string EVCar.GetCarInfo()
        {
            return "Hatchback Passanger Car";
        }
    }
}
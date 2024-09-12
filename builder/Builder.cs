using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignCreational
{
    class Laptop
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string GPU { get; set; }
        public string Display { get; set; }
        public string OS { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine("My laptop has " + CPU + " CPU, " + RAM + " RAM, " + Storage + " Storage, " + GPU + " GPU, " + Display + " Display, and " + OS + " OS");
        }
    }
    interface Builder
    {
        void SetCPU();
        void SetRAM();
        void SetStorage();
        void SetGPU();
        void SetDisplay();
        void SetOS();
        Laptop GetLaptop();
    }
    class GamingLaptopBuilder : Builder
    {
        private Laptop _laptop = new Laptop();
        public void SetCPU()
        {
            _laptop.CPU = "Intel Core i9";
        }
        public void SetRAM()
        {
            _laptop.RAM = "32GB";
        }
        public void SetStorage()
        {
            _laptop.Storage = "1TB SSD";
        }
        public void SetGPU()
        {
            _laptop.GPU = "Nvidia RTX 3080";
        }
        public void SetDisplay()
        {
            _laptop.Display = "4K";
        }
        public void SetOS()
        {
            _laptop.OS = "Windows 11";
        }
        public Laptop GetLaptop()
        {
            return _laptop;
        }
    }
    class PersonalLaptopBuilder : Builder
    {
        private Laptop _laptop = new Laptop();
        public void SetCPU()
        {
            _laptop.CPU = "Intel Core i5";
        }
        public void SetRAM()
        {
            _laptop.RAM = "16GB";
        }
        public void SetStorage()
        {
            _laptop.Storage = "512GB SSD";
        }
        public void SetGPU()
        {
            _laptop.GPU = "Intel Iris Xe";
        }
        public void SetDisplay()
        {
            _laptop.Display = "Full HD";
        }
        public void SetOS()
        {
            _laptop.OS = "Windows 10";
        }
        public Laptop GetLaptop()
        {
            return _laptop;
        }
    }
    class LaptopDirector
    {
        private Builder _builder;
        public LaptopDirector(Builder builder)
        {
            _builder = builder;
        }
        public void Construct()
        {
            _builder.SetCPU();
            _builder.SetRAM();
            _builder.SetStorage();
            _builder.SetGPU();
            _builder.SetDisplay();
            _builder.SetOS();
            _builder.GetLaptop().ShowInfo();
        }
    }
}

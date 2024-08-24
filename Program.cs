using System;

namespace DesignCreational
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton instance = Singleton.GetInstance;
            instance.Execute();
        }
    }
}
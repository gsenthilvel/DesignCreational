using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignCreational
{
    /*
     * sealed class ensures that no class can inherit the singleton class
     * can instantiate the class only once with instance and static members
     */
    sealed class Singleton
    {
        /*
         * Lazy initialization is thread safe with tactic of delaying the object creation, 
         * or some other expensive process until the first time it is needed.
         */
        private static readonly Lazy<Singleton> _instance = 
            new Lazy<Singleton>(() => new Singleton());

        /*
         * private constructor ensures that no object can be created outside the class
         */
        private Singleton() { }

        /*
         * public static property to provide the single instance of the class
         */
        public static Singleton GetInstance
        {
            get
            {
                return _instance.Value;
            }
        }

        /*
         * public method to execute the singleton instance
         */
        public void Execute()
        {
            Console.WriteLine("Singleton instance is executing here..");
        }
    }
}

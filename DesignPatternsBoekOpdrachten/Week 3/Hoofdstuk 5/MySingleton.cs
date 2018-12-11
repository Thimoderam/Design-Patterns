using System;

namespace DesignPatternsBoekOpdrachten.Week_3.Hoofdstuk_5
{
    public class MySingleton
    {
        private volatile static MySingleton instance;
        private static object block = new object();

        private MySingleton()
        {
            Console.WriteLine("Singleton created!");
        }
        public static MySingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (block)
                    {
                        if (instance == null)
                        {
                            instance = new MySingleton();
                        }
                    }
                }
                return instance;
            }
        }
        public void PrintText()
        {
            Console.WriteLine("I am a Singleton!");
        }
    }
}

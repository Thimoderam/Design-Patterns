using System;

namespace DesignPatternsBoekOpdrachten.Week_3.Hoofdstuk_5
{
    public class MySingleton
    {
        private static volatile MySingleton _instance;
        private static readonly object Block = new object();

        private MySingleton()
        {
            Console.WriteLine("Singleton created!");
        }
        public static MySingleton Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (Block)
                {
                    if (_instance == null)
                    {
                        _instance = new MySingleton();
                    }
                }
                return _instance;
            }
        }
        public void PrintText()
        {
            Console.WriteLine("I am a Singleton!");
        }
    }
}

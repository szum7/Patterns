using System;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton instance;

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        // Methods are NOT static
        public int GetNumber()
        {
            return 123;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var number = Singleton.Instance.GetNumber();
        }
    }
}

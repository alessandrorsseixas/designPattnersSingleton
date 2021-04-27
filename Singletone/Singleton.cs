using System;

namespace Singletone
{
        public class Ball
        {
            private static Ball instance = null;

           // public static Ball Instance { get =>  instance = instance == null?new Ball(): instance; }

            public static Ball GetInstanceWithSingleton()
            {
                if(instance == null)
                {
                    instance  = new Ball();
                    Console.WriteLine("A Bola esta em jogo");
              
                }
                return instance;
            }

            public static Ball GetInstanceWithoutSingleton()
            {
                instance = new Ball();
                Console.WriteLine("A Bola esta em jogo");

                return instance;
            }


        public void Message(string message)
            { 
                Console.WriteLine(message);
            }
        }
}
 
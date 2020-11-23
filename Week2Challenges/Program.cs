using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Challenges
{
    class Program 
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Please enter your name");
            Greeter greeter = new Greeter();
            string name = Console.ReadLine();
            greeter.Greeting(name);
            Console.ReadLine();
            greeter.Farewell(name);
            Console.ReadLine();

            
        }

        class Greeter
        {
            public void Greeting(string name)
            {
                Console.WriteLine($"Hello { name }");
            }
            public void Farewell(string name)
            {
                Console.WriteLine($"Goodbye { name }");
            }
            public void TimeOfDay()
            {
                int timeOfDay = DateTime.Now.Hour;
                if(timeOfDay >= 0 && timeOfDay < 12)
                {
                    Console.WriteLine("Good Morning");
                }
                else if(timeOfDay >= 12 && timeOfDay < 17)
                {
                    Console.WriteLine("Good Afternoon");
                }
                else if(timeOfDay >= 17 && timeOfDay < 20)
                {
                    Console.WriteLine("Good Evening");
                }
                else if(timeOfDay >= 20 && timeOfDay < 24)
                {
                    Console.WriteLine("Good Night!");
                }

                
            }
            


        }




        
        
    }
}

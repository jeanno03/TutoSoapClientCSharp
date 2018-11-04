using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoSoapClientCSharp.ServiceReference1;

namespace TutoSoapClientCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client stub = new ServiceReference1.Service1Client();

            Race race = stub.GetRaceExample();

            Console.WriteLine("******** Début *********");

            Animal[] animals = race.Animals;

            for(int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine("Animal n° "+(i+1) +" - nom : "+ animals[i].Name);  ;
            }

            Console.WriteLine("******** Fin *********");
            Console.ReadLine();
        }
    }
}

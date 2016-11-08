using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThreeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = 'd';

            switch(letter)
            {
                case 'a':

                    Console.WriteLine("it's an a.");
                    break;

                case 'e':

                    Console.WriteLine("it's an e.");
                    break;

                case 'd':

                    Console.WriteLine("it's a d.");
                    break; 


                default:

                    Console.WriteLine("unknown character");
                    break;
            }
        }
    }
}

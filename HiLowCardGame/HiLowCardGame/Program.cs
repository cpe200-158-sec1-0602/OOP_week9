using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlGame.SetUp();
            ControlGame.Playing();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class Client
    {
        public static void Main(string[] args)
        {
            Computer computer = new ();
            computer.Start();
        }
    }
}

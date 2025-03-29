using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.Electricity.Tr
{
    internal class TurkishPowerProvider : ITurkishPowerSource
    {
        public TurkishPowerProvider()
        {
            Console.WriteLine("TurkishPowerProvider is up and running.");
        }
        public void ProvidePowerAt220V()
        {
            Console.WriteLine("I provide electricity at 220V. Be careful, there may be some casual interruptions!");
        }

        public void TurnOff()
        {
            Console.WriteLine("TurkishPowerProvider started to provide electricity.");
        }

        public void TurnOn()
        {
            Console.WriteLine("TurkishPowerProvider stopped to provide electricity.");
        }
    }
}

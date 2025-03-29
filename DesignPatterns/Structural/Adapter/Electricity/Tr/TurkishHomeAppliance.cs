using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.Structural.Adapter.Electricity.Tr
{
    internal class TurkishHomeAppliance : HomeAppliance
    {
        protected string Name;
        public TurkishHomeAppliance(string name) => Name = name;
        public override void Start()
        {
            Console.WriteLine("TurkishHomeAppliance " + Name + " is starting!");
            PowerSource.TurnOn();
        }

        public override void Stop()
        {
            Console.WriteLine("TurkishHomeAppliance " + Name + " stoping!");
            PowerSource.TurnOff();
        }
    }
}

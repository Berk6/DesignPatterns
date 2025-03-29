using DesignPatterns.Structural.Adapter.Electricity.Tr;
using DesignPatterns.Structural.Adapter.Electricity.Us;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.Electricity.Adapters.PowerAdapter2
{
    internal class USTurkishPowerAdapter:ITurkishPowerSource
    {
        private readonly IUSPowerSource _usPowerSource;

        public USTurkishPowerAdapter(IUSPowerSource usPowerSource)
        {
            Console.WriteLine("\nUSTurkishPowerAdapter: Converting from USPowerSource to TurkishPowerSource");
            _usPowerSource = usPowerSource;
            Convert110To220(_usPowerSource);
        }

        public void ProvidePowerAt220V()
        {
            _usPowerSource.ProvidePowerAt110V();
            Convert110To220(_usPowerSource);
        }

        public void TurnOn()
        {
            _usPowerSource.PushSwitch();
        }

        public void TurnOff()
        {
            _usPowerSource.PushSwitch();
        }

        private void Convert110To220(IUSPowerSource usPowerSource)
        {
            Check();
            Console.WriteLine("USTurkishPowerAdapter: Converting from 110V to 220V");
            RegulateVoltage();
        }

        private void Check()
        {
            Console.WriteLine("Making some safety checks.");
        }

        private void RegulateVoltage()
        {
            Console.WriteLine("Regulating the voltage.");
        }
    }
}

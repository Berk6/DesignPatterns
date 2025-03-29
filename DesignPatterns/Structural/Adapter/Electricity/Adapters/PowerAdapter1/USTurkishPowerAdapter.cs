using DesignPatterns.Structural.Adapter.Electricity.Tr;
using DesignPatterns.Structural.Adapter.Electricity.Us;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesignPatterns.Structural.Adapter.Electricity.Adapters.PowerAdapter1
{
    internal class USTurkishPowerAdapter : ITurkishPowerSource
    {
        private IUSPowerSource _usPowerSource;

        public USTurkishPowerAdapter(IUSPowerSource usPowerSource)
        {
            Console.WriteLine("USTurkishPowerAdapter: Converting from USPowerSource to TurkishPowerSource");
            _usPowerSource = usPowerSource;
        }

        private bool _on;

        public void ProvidePowerAt220V()
        {
            _usPowerSource.ProvidePowerAt110V();
            Convert110To220(_usPowerSource);
        }

        public void TurnOff()
        {
            if (!_on)
            {
                _usPowerSource.PushSwitch();
                _on = true;
            }
        }

        public void TurnOn()
        {
            if (_on)
            {
                _usPowerSource.PushSwitch();
                _on = false;
            }
        }
        private void Convert110To220(IUSPowerSource usPowerSource)
        {
            Console.WriteLine("USTurkishPowerAdapter: Converting from 110V to 220V");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.Electricity.Tr
{
    public interface ITurkishPowerSource
    {
        public void ProvidePowerAt220V();
        public void TurnOn();
        public void TurnOff();
    }
}

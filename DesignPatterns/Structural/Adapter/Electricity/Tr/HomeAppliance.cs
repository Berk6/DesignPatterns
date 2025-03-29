using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.Electricity.Tr
{
    internal abstract class HomeAppliance : IAppliance
    {
        protected ITurkishPowerSource PowerSource;
        public void SetPowerSource(ITurkishPowerSource powerSource)
        {
            PowerSource = powerSource;
        }
        public abstract void Start();
        public abstract void Stop();
    }
}

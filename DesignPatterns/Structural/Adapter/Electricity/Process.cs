
using DesignPatterns.Structural.Adapter.Electricity.Tr;
using DesignPatterns.Structural.Adapter.Electricity.Us;
using DesignPatterns.Structural.Adapter.Electricity.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.Electricity
{
    internal class Process
    {
        public void PowerAdapter1Process()
        {
            IUSPowerSource usPowerSource = new USPowerProvider();
            Adapters.PowerAdapter1.USTurkishPowerAdapter uSTurkishPowerAdapter = new(usPowerSource);
            IAppliance shaver = new TurkishHomeAppliance("Shaver");
            shaver.SetPowerSource(uSTurkishPowerAdapter);
            shaver.Start();
            shaver.Stop();            
        }
        public void PowerAdapter1Process2()
        {
            IUSPowerSource usPowerSource = new USPowerProvider();
            Adapters.PowerAdapter2.USTurkishPowerAdapter uSTurkishPowerAdapter = new(usPowerSource);

            IAppliance turkishMixer = new TurkishHomeAppliance("Mixer");
            turkishMixer.SetPowerSource(uSTurkishPowerAdapter);
            turkishMixer.Start();
            turkishMixer.Stop();

            IAppliance turkishBroom = new TurkishHomeAppliance("Broom");
            turkishBroom.SetPowerSource(uSTurkishPowerAdapter);
            turkishBroom.Start();
            turkishBroom.Stop();
        }
        public void TwoWayUsTurkishPowerAdapterProcess()
        {
            IUSPowerSource usPowerSource = new USPowerProvider();
            Adapters.TwoWayUSTurkishPowerAdapter.TwoWayUSTurkishPowerAdapter twoWayUSTurkishPowerAdapter1 = new (usPowerSource);

            IAppliance turkishMixer = new TurkishHomeAppliance("Mixer");
            turkishMixer.SetPowerSource(twoWayUSTurkishPowerAdapter1);
            turkishMixer.Start();
            turkishMixer.Stop();           

            // In Turkey with US home appliance
            ITurkishPowerSource turkishPowerSource = new TurkishPowerProvider();
            Adapters.TwoWayUSTurkishPowerAdapter.TwoWayUSTurkishPowerAdapter twoWayUSTurkishPowerAdapter2 = new (turkishPowerSource);

            USHomeApplicance usBroom = new USHomeApplicance("Broom");
            usBroom.SetPowerSource(twoWayUSTurkishPowerAdapter2);
            usBroom.Start();
            usBroom.Stop();
        }
    }
}

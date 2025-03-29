using DesignPatterns.Structural.Adapter.Electricity.Tr;
using DesignPatterns.Structural.Adapter.Electricity.Us;

namespace DesignPatterns.Structural.Adapter.Electricity.Adapters.TwoWayUSTurkishPowerAdapter
{
    public class TwoWayUSTurkishPowerAdapter : IUSPowerSource, ITurkishPowerSource
    {
        private readonly IUSPowerSource _usPowerSource;
        private readonly ITurkishPowerSource _turkishPowerSource;
        private bool _isOn;
        private readonly string _powerSource;

        public TwoWayUSTurkishPowerAdapter(ITurkishPowerSource turkishPowerSource)
        {
            _turkishPowerSource = turkishPowerSource;
            _powerSource = "tr";
        }

        public TwoWayUSTurkishPowerAdapter(IUSPowerSource usPowerSource)
        {
            _usPowerSource = usPowerSource;
            _powerSource = "us";
        }

        public void ProvidePowerAt110V()
        {
            if (_powerSource == "us")
                _usPowerSource.ProvidePowerAt110V();
            else
                Convert220To110();
        }

        public void ProvidePowerAt220V()
        {
            if (_powerSource == "us")
                Convert110To220();
            else
                _turkishPowerSource.ProvidePowerAt220V();
        }

        public void PushSwitch()
        {
            if (!_isOn)
            {
                _isOn = true;
                if (_powerSource == "us")
                    _usPowerSource.PushSwitch();
                else
                    _turkishPowerSource.TurnOn();
            }
            else
            {
                _isOn = false;
                if (_powerSource == "us")
                    _usPowerSource.PushSwitch();
                else
                    _turkishPowerSource.TurnOff();
            }
        }

        public void TurnOn()
        {
            if (!_isOn)
            {
                if (_powerSource == "us")
                    _usPowerSource.PushSwitch();
                else
                    _turkishPowerSource.TurnOn();
                _isOn = true;
            }
        }

        public void TurnOff()
        {
            if (_isOn)
            {
                if (_powerSource == "us")
                    _usPowerSource.PushSwitch();
                else
                    _turkishPowerSource.TurnOff();
                _isOn = false;
            }
        }

        private void Convert110To220()
        {
            Console.WriteLine("TwoWayUSTurkishPowerAdapter: Converting from USPowerSource to provide 220V");
        }

        private void Convert220To110()
        {
            Console.WriteLine("TwoWayUSTurkishPowerAdapter: Converting from TurkishPowerSource to provide 110V");
        }
    }
}

namespace DesignPatterns.Structural.Adapter.Electricity.Us
{
    internal class USPowerProvider:IUSPowerSource
    {
        private bool _on;
        public void ProvidePowerAt110V()
        {
            Console.WriteLine("USPowerProvider provides electricity at 110V!");            
        }

        public USPowerProvider()
        {
            Console.WriteLine("USPowerProvider is up and running.");
        }

        public void PushSwitch()
        {
            if (!_on)
            {
                _on = true;
                Console.WriteLine("USPowerProvider started to provide electricity.");
            }
            else
            {
                _on = false;
                Console.WriteLine("USPowerProvider stopped to provide electricity.");
            }
        }
    }
}

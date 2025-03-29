namespace DesignPatterns.Structural.Adapter.Electricity.Tr
{
    internal interface IAppliance
    {
        public void SetPowerSource(ITurkishPowerSource powerSource);
        public void Start();
        public void Stop();
    }
}

namespace DesignPatterns.Structural.Adapter.Electricity.Us
{
    public interface IUSPowerSource
    {
        public void ProvidePowerAt110V();
        public void PushSwitch();
    }
}

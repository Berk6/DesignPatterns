namespace DesignPatterns.Structural.Adapter.Electricity.Us
{
    internal class USHomeApplicance
    {
        private string _name;
        private IUSPowerSource _usPowerSource;

        public USHomeApplicance(string name)
        {
            this._name = name;
        }

        public void SetPowerSource(IUSPowerSource usPowerSource)
        {
            this._usPowerSource = usPowerSource;
        }

        public void Start()
        {
            Console.WriteLine("USHomeApplicance " + _name + " is turning on!");
            _usPowerSource.PushSwitch();
        }

        public void Stop()
        {
            Console.WriteLine("USHomeApplicance " + _name + " turning off!");
            _usPowerSource.PushSwitch();
        }
    }
}

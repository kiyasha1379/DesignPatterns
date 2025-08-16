

namespace DesignePatterns.StructuralPatterns.Facade
{
    // (Subsystem)
    public class LightSystem
    {
        public void TurnOn() => Console.WriteLine("Lights are ON");
        public void TurnOff() => Console.WriteLine("Lights are OFF");
    }

    public class AirConditioningSystem
    {
        public void TurnOn() => Console.WriteLine("AC is ON");
        public void TurnOff() => Console.WriteLine("AC is OFF");
    }

    public class SecuritySystem
    {
        public void Arm() => Console.WriteLine("Security system armed");
        public void Disarm() => Console.WriteLine("Security system disarmed");
    }

    // Facade for managing subsystems
    public class SmartHomeFacade
    {
        private readonly LightSystem _light;
        private readonly AirConditioningSystem _ac;
        private readonly SecuritySystem _security;

        public SmartHomeFacade(LightSystem light,
            AirConditioningSystem ac,
            SecuritySystem security)
        {
            _light = light;
            _ac = ac;
            _security = security;
        }

        public void LeaveHome()
        {
            _light.TurnOff();
            _ac.TurnOff();
            _security.Arm();
            Console.WriteLine("Leaving home: All systems set.");
        }

        public void ArriveHome()
        {
            _security.Disarm();
            _light.TurnOn();
            _ac.TurnOn();
            Console.WriteLine("Arrived home: Welcome!");
        }
    }
}

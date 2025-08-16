
namespace DesignePatterns.Behavioral.Command
{
    // command interface
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    // Receiver
    public class Light
    {
        public void On() => Console.WriteLine("Light is ON");
        public void Off() => Console.WriteLine("Light is OFF");
    }

    // command for turn on lights
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;
        public LightOnCommand(Light light) => _light = light;

        public void Execute() => _light.On();
        public void Undo() => _light.Off();
    }

    // command for turn off lights
    public class LightOffCommand : ICommand
    {
        private readonly Light _light;
        public LightOffCommand(Light light) => _light = light;

        public void Execute() => _light.Off();
        public void Undo() => _light.On();
    }

    // Invoker 
    public class RemoteControl
    {
        private ICommand _command;
        public void SetCommand(ICommand command) => _command = command;

        public void PressButton() => _command.Execute();
        public void PressUndo() => _command.Undo();
    }

}

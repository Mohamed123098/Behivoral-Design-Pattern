using Command.Abstraction;
using Command.Implementation;
using Command.Models;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartHomeMobileApp smartHome = new();
            smartHome.Execute(new TurnOnLightCommand(new() { Name = "Living Room" }));
            SmartHomeShortCut smartHomeShortCut = new();
            smartHomeShortCut.SetCommand("ONL", new TurnOnLightCommand(new() { Name = "Living Room" }));
            smartHomeShortCut.SetCommand("OFFL", new TurnOffLightCommand(new() { Name = "Living Room" }));
            smartHomeShortCut.SetCommand("ONTV", new  TurnOnTVCommand(new() { Name = "LG TV"}));
            smartHomeShortCut.SetCommand("OFFTV", new TurnOffTVCommand(new(){ Name = "LG TV" }));
            smartHomeShortCut.OpenShortCut("ONTV");
            SmartHomeVoiceAssistant smartHomeVoiceAssistant = new();
            smartHomeVoiceAssistant.SetCommand("ONL", new TurnOnLightCommand(new() { Name = "Living Room" }));
            smartHomeVoiceAssistant.SetCommand("OFFL", new TurnOffLightCommand(new() { Name = "Living Room" }));
            smartHomeVoiceAssistant.SetCommand("ONTV", new TurnOnTVCommand(new() { Name = "LG TV" }));
            smartHomeVoiceAssistant.SetCommand("OFFTV", new TurnOffTVCommand(new() { Name = "LG TV" }));
            smartHomeVoiceAssistant.Say("OFFTV");

        }
    }
}

using Patterns.Bridge.Config;
using Patterns.Bridge.Device;
using Patterns.Bridge.Drivers;

namespace Patterns.Bridge;

public class Example
{
    void Run()
    {
        var laptop = new Laptop();

        var audioDriver = new AudioDriver(laptop);
        var mouseDriver = new MouseDriver(laptop);
        var keyboardDriver = new KeyboardDriver(laptop);

        var config1 = audioDriver.GetConfig();
        audioDriver.ApplyConfig(new AudioConfig());

        var config2 = mouseDriver.GetConfig();
        mouseDriver.ApplyConfig(new MouseConfig());

        var config3 = keyboardDriver.GetConfig();
        keyboardDriver.ApplyConfig(new KeyboardConfig());
    }
}

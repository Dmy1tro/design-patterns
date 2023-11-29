using Patterns.Bridge.Config;
using Patterns.Bridge.Device;

namespace Patterns.Bridge.Drivers;

internal class KeyboardDriver : IDriver
{
    private readonly IDevice _device;

    public KeyboardDriver(IDevice device)
    {
        _device = device;
    }

    public void ApplyConfig(IConfig config)
    {
    }

    public IConfig GetConfig()
    {
        return new KeyboardConfig();
    }
}

using Patterns.Bridge.Config;
using Patterns.Bridge.Device;

namespace Patterns.Bridge.Drivers;

internal interface IDriver
{
    IConfig GetConfig();

    void ApplyConfig(IConfig config);
}

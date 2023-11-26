﻿using Patterns.Bridge.Config;
using Patterns.Bridge.Device;

namespace Patterns.Bridge.Drivers
{
    internal class AudioDriver : IDriver
    {
        private readonly IDevice _device;

        public AudioDriver(IDevice device)
        {
            _device = device;
        }

        public void ApplyConfig(IConfig config)
        {
        }

        public IConfig GetConfig()
        {
            return new AudioConfig();
        }
    }
}

﻿using Microsoft.Extensions.Logging;
using StreamCore.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace StreamCore.Services.Mixer
{
    public class MixerService : StreamingServiceBase, IStreamingService
    {
        public Type ServiceType => typeof(MixerService);

        public MixerService(ILogger<MixerService> logger)
        {
            _logger = logger;
        }

        private ILogger _logger;
    }
}
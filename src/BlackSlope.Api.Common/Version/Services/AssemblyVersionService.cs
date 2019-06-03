﻿using BlackSlope.Api.Common.Version.Interfaces;

namespace BlackSlope.Api.Common.Version.Services
{
    public class AssemblyVersionService : IVersionService
    {
        public Version GetVersion()
        {
            var buildVersion = typeof(VersionController).Assembly.GetName().Version.ToString();
            return new Version(buildVersion);
        }
    }
}

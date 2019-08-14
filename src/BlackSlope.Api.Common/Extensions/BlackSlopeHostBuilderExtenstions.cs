﻿using System;
using BlackSlope.Api.Common.Configurtion;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace BlackSlope.Api.Common.Extensions
{
    public static class BlackSlopeHostBuilderExtenstions
    {
        public static IWebHostBuilder UseSerilog(this IWebHostBuilder webHostBuilder, string appSettingsSection) =>
             webHostBuilder.UseSerilog((ctx, config) =>
                {
                    var appSettings = ctx.Configuration.GetSection(appSettingsSection).Get<HostConfig>();
                    var serilogConfig = appSettings.Serilog;

                    // If they follow conventions for Serilog in config it will be read here.
                    config.ReadFrom.Configuration(ctx.Configuration);

                    SetLogLevel(config, serilogConfig);
                    LogToFile(config, serilogConfig);
                    LogToConsole(config, serilogConfig);
                    LogToApplicationInsights(config, appSettings, serilogConfig);
                });

        private static void LogToApplicationInsights(LoggerConfiguration config, HostConfig appSettings, SerilogConfig serilogConfig)
        {
            if (serilogConfig.WriteToAppInsights)
            {
                // TODO: TelemetryConverter should be configurable (defaulted to Trace)
                // Note: best practice is to use the existing Telemetry 
                if (string.IsNullOrEmpty(TelemetryConfiguration.Active.InstrumentationKey))
                {
                    config.WriteTo.ApplicationInsights(appSettings.ApplicationInsights.InstrumentationKey, TelemetryConverter.Traces);
                    config.WriteTo.ApplicationInsights(appSettings.ApplicationInsights.InstrumentationKey, TelemetryConverter.Events);
                }
                else
                {
                    config.WriteTo.ApplicationInsights(TelemetryConfiguration.Active, TelemetryConverter.Traces);
                    config.WriteTo.ApplicationInsights(TelemetryConfiguration.Active, TelemetryConverter.Events);
                }
            }
        }

        private static void LogToConsole(LoggerConfiguration config, SerilogConfig serilogConfig)
        {
            if (serilogConfig.WriteToConsole)
            {
                config.WriteTo.ColoredConsole();
            }
        }

        private static void LogToFile(LoggerConfiguration config, SerilogConfig serilogConfig)
        {
            if (serilogConfig.WriteToFile)
            {
                // TODO: Rolling Interval day should be configurable (defaulted to day)
                config.WriteTo.File(serilogConfig.FileName, rollingInterval: RollingInterval.Day);
            }
        }

        private static void SetLogLevel(LoggerConfiguration config, SerilogConfig serilogConfig)
        {
            Enum.TryParse<LogEventLevel>(serilogConfig.MinimumLevel, true, out var minimumLevel);
            var levelSwitch = new LoggingLevelSwitch
            {
                MinimumLevel = minimumLevel,
            };

            config.MinimumLevel.ControlledBy(levelSwitch);
        }
    }
}

using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.PlatformAbstractions;

namespace DockerDemo.Models
{
    public class SystemInfoViewModel
    {
        public static SystemInfoViewModel FromEnvironment(IHostingEnvironment hostingEnvironment)
        {
            var vm = new SystemInfoViewModel
            {
                OSVersion = Environment.OSVersion.VersionString,
                MachineName = Environment.MachineName,
                ProcessorCount = Environment.ProcessorCount,
                ClrVersion = Environment.Version.ToString(),
                RuntimeType = PlatformServices.Default.Application.RuntimeFramework.FullName,
                EnvironmentName = hostingEnvironment.EnvironmentName
            };
            return vm;
        }

        public string ClrVersion { get; private set; }
        public int ProcessorCount { get; private set; }
        public string MachineName { get; private set; }
        public string OSVersion { get; private set; }
        public string RuntimeType { get; private set; }
        public string EnvironmentName { get; private set; }
    }
}
using System;
using System.Runtime.InteropServices;

using ShipEngine.Services;

namespace ShipEngine
{
    sealed public class ShipEngine
    {
        private readonly string Version = "0.0.1";

        // SERVICES
        public readonly TagsService Tags;

        public ShipEngine()
        {
            var userAgent = this.DeriveUserAgent();
            // set config
            var config = new ShipEngineConfig();
            // set client
            var client = new ShipEngineClient(config);

            this.Tags = new TagsService(client);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string DeriveUserAgent()
        {
            var os = Environment.OSVersion.ToString().Replace(" ", "/");
            var runtime = RuntimeInformation.FrameworkDescription.Replace(" ", "/");

            return $"shipengine-dotnet/{Version} {os} {runtime}";
        }
    }
}

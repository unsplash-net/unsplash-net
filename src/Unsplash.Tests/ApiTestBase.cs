using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using WireMock.Server;

namespace Unsplash.Tests
{
    public class ApiTestBase : IDisposable
    {
        protected readonly WireMockServer Server;

        protected static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings()
        {
            Formatting = Newtonsoft.Json.Formatting.Indented,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            }
        };

        protected const string ACCESS_KEY = "Token";

        protected ApiTestBase()
        {
            Server = WireMockServer.Start();
        }

        public void Dispose()
        {
            Server.Stop();
            Server.Dispose();
        }
    }
}

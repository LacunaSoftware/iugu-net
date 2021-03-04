using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.Net;

namespace iugu.net.IntegratedTests
{
    [SetUpFixture]
    public class GlobalSetup
    {
        [OneTimeSetUp]
        public void IuguClientConfig()
        {
            string message = "{\"Message\": { \"Errors\": [\"Teste\", \"GG\" ]}}";
            string message2 = "{\"Message\": \"Ola\"}";
            var json = JObject.Parse(message);
            var json2 = JObject.Parse(message2);

            var test = json["Message"] is IDictionary<string, JToken>;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; 
            IuguClient.Init(new IuguClientProperties()
            {
                ApiKey = "0efa33557aa042fd13d9275ce310f5b8"
            });
        }
    }
}

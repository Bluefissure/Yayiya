using Newtonsoft.Json;
using System;
using System.Net;

namespace Yayiya
{
    public class Definitions
    {
        public short PlayerSpawn = 278;
        public short PlayerSetup = 710;
        public short MarketBoardItemRequestStart = 561;
        public short MarketBoardOfferings = 727;
        public short MarketBoardHistory = 223;
        public short ContentIdNameMapResp = 0x172;

        private static readonly Uri DefinitionStoreUrl = new Uri("https://gitee.com/bluefissure/universalis_act_plugin/raw/cn/definitions.json");

        public static string GetJson() => JsonConvert.SerializeObject(new Definitions());

        public static Definitions Get()
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    var definitionJson = client.DownloadString(DefinitionStoreUrl);
                    var deserializedDefinition = JsonConvert.DeserializeObject<Definitions>(definitionJson);

                    return deserializedDefinition;
                }
                catch (WebException exc)
                {
                    throw new Exception("Could not get definitions for Universalis.", exc);
                }
            }
        }
    }
}

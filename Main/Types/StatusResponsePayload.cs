namespace SharpenedMinecraft.Types
{
    using System;
    using System.Collections.Generic;
    using System.Net;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class StatusResponsePayload
    {
        [JsonProperty("version")]
        public Version Version { get; set; }

        [JsonProperty("players")]
        public Players Players { get; set; }

        [JsonProperty("description")]
        public Description Description { get; set; }
    }

    public partial class Description
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public partial class Players
    {
        [JsonProperty("max")]
        public long Max { get; set; }

        [JsonProperty("online")]
        public long Online { get; set; }
    }

    public partial class Version
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("protocol")]
        public long Protocol { get; set; }
    }

    public partial class StatusResponsePayload
    {
        public static StatusResponsePayload FromJson(string json) => JsonConvert.DeserializeObject<StatusResponsePayload>(json, SharpenedMinecraft.Types.Converter.Settings);
    }

    public static partial class Serialize
    {
        public static string ToJson(this StatusResponsePayload self) => JsonConvert.SerializeObject(self, SharpenedMinecraft.Types.Converter.Settings);
    }
}
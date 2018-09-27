using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Types
{
    public partial class ChatMessage
    {
        public ChatMessage()
        {
            this.Text = "";
        }

        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("bold", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Bold { get; set; }
        [JsonProperty("italic", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Italic { get; set; }
        [JsonProperty("underlined", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Underlined { get; set; }
        [JsonProperty("strikethrough", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Strikethrough { get; set; }
        [JsonProperty("obfuscated", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Obfuscated { get; set; }

        [JsonProperty("color", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Color { get; set; }

        [JsonProperty("extra", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ChatMessage[] Extra { get; set; }
    }

    #region Conversion
    public partial class ChatMessage
    {
        public static ChatMessage FromJson(string json) => JsonConvert.DeserializeObject<ChatMessage>(json, SharpenedMinecraft.Types.Converter.Settings);

        public static implicit operator ChatMessage(string s)
        {
            return new ChatMessage() { Text = s };
        }
    }

    public static partial class Serialize
    {
        public static string ToJson(this ChatMessage self) => JsonConvert.SerializeObject(self, SharpenedMinecraft.Types.Converter.Settings);
    }
    #endregion
}

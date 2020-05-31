using System;
using System.Text.Json.Serialization;

namespace compiler_api.Models
{
    public class Code
    {
        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("langcode")]
        public string LanguageCode { get; set; }
    }
}
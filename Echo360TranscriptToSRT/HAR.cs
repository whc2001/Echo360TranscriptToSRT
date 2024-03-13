using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo360TranscriptToSRT
{
    internal class HAR
    {
        public static bool IsHAR(JObject json)
        {
            return json["log"] != null && json["log"]["entries"] != null;
        }

        public static JObject GetTranscriptFromHAR(JObject json)
        {
            var transcriptEntry = json["log"]["entries"].FirstOrDefault(entry =>
            {
                if (entry["request"]["url"] == null)
                    return false;
                var url = entry["request"]["url"].ToString();
                return url.StartsWith("https://echo360.ca") && url.EndsWith("/transcript");
            });
            if (transcriptEntry == null)
                return null;
            var transcript = transcriptEntry["response"]["content"]["text"]?.ToString();
            if (transcript == null)
                return null;
            return JObject.Parse(transcript);
        }
    }
}

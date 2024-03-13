using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo360TranscriptToSRT
{
    internal class Echo360Transcript
    {
        public TranscriptEntry[] Entries { get; private set; }

        public Echo360Transcript(JObject json)
        {
            if (json == null)
                throw new ArgumentNullException(nameof(json));
            if (json["status"].Value<string>() != "ok"
                    || json["data"] == null
                    || json["data"]["status"].Value<string>() != "Available"
                    || json["data"]["contentJSON"] == null
                    || json["data"]["contentJSON"]["cues"] == null
                )
                throw new InvalidDataException("无效的 transcript 数据");
            this.Entries = new TranscriptEntry[json["data"]["contentJSON"]["cues"].Count()];
            for (int i = 0; i < this.Entries.Length; i++)
                this.Entries[i] = new TranscriptEntry((JObject)json["data"]["contentJSON"]["cues"][i]);
        }
    }
}

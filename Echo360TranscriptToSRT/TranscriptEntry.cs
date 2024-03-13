using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo360TranscriptToSRT
{
    internal class TranscriptEntry
    {
        public ulong Start { get; set; }
        public ulong End { get; set; }
        public string Speaker { get; set; }
        public string Content { get; set; }

        public TranscriptEntry(JObject json)
        {
            this.Start = json["startMs"].Value<ulong>();
            this.End = json["endMs"].Value<ulong>();
            this.Speaker = json["speaker"].Value<string>();
            this.Content = json["content"].Value<string>();
        }
    }
}

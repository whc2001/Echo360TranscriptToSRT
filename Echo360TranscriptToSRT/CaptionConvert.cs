using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo360TranscriptToSRT
{
    internal class CaptionConvert
    {
        public static string FormatTimestamp(ulong ms)
        {
            ulong seconds = ms / 1000;
            ulong minutes = seconds / 60;
            ulong hours = minutes / 60;

            return $"{hours:00}:{minutes % 60:00}:{seconds % 60:00}.{ms % 1000:000}";
        }

        public static void Convert(Echo360Transcript content, string outputFileName, bool showSpeaker, bool ignoreSpeaker0)
        {
            int index = 0;
            StringBuilder sb = new StringBuilder();

            foreach (var line in content.Entries)
            {
                sb.AppendLine($"{++index}");
                sb.AppendLine($"{FormatTimestamp(line.Start)} --> {FormatTimestamp(line.End)}");
                sb.AppendLine($"{(showSpeaker ? (ignoreSpeaker0 && line.Speaker == "Speaker 0" ? "" : $"[{line.Speaker}] ") : "")}{line.Content}");
                sb.AppendLine();
            }

            File.WriteAllText(outputFileName, sb.ToString());
        }
    }
}

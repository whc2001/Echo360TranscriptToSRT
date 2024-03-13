using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Echo360TranscriptToSRT
{
    public partial class frmMain : Form
    {
        private void Log(string message)
        {
            Action action = () =>
            {
                this.txtLog.Text += "[" + DateTime.Now + "] " + message + Environment.NewLine;
                this.txtLog.SelectionStart = this.txtLog.Text.Length;
                this.txtLog.ScrollToCaret();
            };
            if(this.InvokeRequired)
                this.Invoke(action);
            else
                action();
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                lstFiles.Items.AddRange(openFileDialog1.FileNames);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            foreach (string file in lstFiles.Items)
            {
                JObject fileContent, transcriptContent;
                try
                {
                    Log($"正在解析文件: {file}");
                    fileContent = JObject.Parse(System.IO.File.ReadAllText(file.ToString()));
                }
                catch (Exception ex)
                {
                    Log($"文件解析失败: {ex.Message}");
                    continue;
                }

                if (HAR.IsHAR(fileContent))
                {
                    Log("文件是 HAR，提取 transcript 请求");
                    transcriptContent = HAR.GetTranscriptFromHAR(fileContent);
                }
                else
                {
                    transcriptContent = fileContent;
                }

                try
                {
                    var transcript = new Echo360Transcript(transcriptContent);
                    var outFileName = $"{Path.GetDirectoryName(file)}\\{Path.GetFileNameWithoutExtension(file)}.srt";
                    Log($"transcript 读取成功，正在转换");
                    CaptionConvert.Convert(transcript, outFileName, this.chkShowSpeaker.Checked, this.chkIgnoreSpeaker0.Checked);
                    Log($"转换完成: {outFileName}");
                }
                catch (Exception ex)
                {
                    Log($"transcript 转换失败: {ex.Message}");
                    continue;
                }
            }
        }

        private void chkShowSpeaker_CheckedChanged(object sender, EventArgs e)
        {
            this.chkIgnoreSpeaker0.Enabled = this.chkShowSpeaker.Checked;
        }
    }
}

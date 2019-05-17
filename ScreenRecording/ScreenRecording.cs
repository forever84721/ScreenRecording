using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ScreenRecording
{
    public partial class ScreenRecording : Form
    {
        public ScreenRecording()
        {
            InitializeComponent();
            MaximizeBox = false;
        }
        Recorder rec;
        private void Recording_Click(object sender, EventArgs e)
        {
            int FrameRateValue = (int)FrameRate.Value;
            int QualityValue = (int)Quality.Value;
            rec = new Recorder(new RecorderParams($"Video_{DateTime.Now.ToString("yyyyMMddHHmmss")}_{FrameRateValue}_{QualityValue}.avi", FrameRateValue, SharpAvi.KnownFourCCs.Codecs.X264, QualityValue));
            Recording.Enabled = false;
            Stop.Enabled = true;
        }
        private void Stop_Click(object sender, EventArgs e)
        {
            rec.Dispose();
            Recording.Enabled = true;
            Stop.Enabled = false;
        }
    }
}

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
        }
        Recorder rec;
        private void Recording_Click(object sender, EventArgs e)
        {
            int FrameRate = 10;
            int Qty = 30;
            rec = new Recorder(new RecorderParams($"Video_{DateTime.Now.ToString("yyyyMMddHHmmss")}_{FrameRate}_{Qty}.avi", FrameRate, SharpAvi.KnownFourCCs.Codecs.MotionJpeg, Qty));
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

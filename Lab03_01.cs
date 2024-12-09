using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap03
{
    public partial class Lab03_01 : Form
    {
        public Lab03_01()
        {
            InitializeComponent();
        }


    private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.toolStripStatusLabel2.Text = string.Format("Hôm nay là ngày {0} - Bây giờ là {1}",
             DateTime.Now.ToString("dd/MMM/yyyy"),
             DateTime.Now.ToString("hh:mm:ss tt"));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "AVI file (*.avi)|*.avi|MPEG File (*.mpeg)|*.mpeg|Wav File (*.wav)|*.wav|Midi File (*.midi)|*.midi|MP4 File (*.mp4)|*.mp4|MP3 File (*.mp3)|*.mp3";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer2.URL = dlg.FileName;
            }
        }

    }
}

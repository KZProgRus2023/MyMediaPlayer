using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MyMediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private void axWindowsMediaPlayer1_MediaError(object sender, AxWMPLib._WMPOCXEvents_MediaErrorEvent e)
        {
            try
            // If the Player encounters a corrupt or missing file, 
            // show the hexadecimal error code and URL.
            {
                IWMPMedia2 errSource = e.pMediaObject as IWMPMedia2;
                IWMPErrorItem errorItem = errSource.Error;
                MessageBox.Show("Error " + errorItem.errorCode.ToString("X")
                                + " in " + errSource.sourceURL);
            }
            catch (InvalidCastException)
            // In case pMediaObject is not an IWMPMedia item.
            {
                MessageBox.Show("Error.");
            }
        }

        private WMPLib.WindowsMediaPlayer Player;

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"G:\Кира\Музыка:\10_iosif_kobzon_ya_lublu_tebya_rossiya_myzuka.fm.mp3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

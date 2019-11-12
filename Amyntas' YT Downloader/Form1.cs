using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amyntas__YT_Downloader
{
    public partial class Form1 : Form
    {
        //VARIABLES
        


        //MAIN FUNCTION
        public Form1()
        {
            InitializeComponent();
        }


        //CUSTOM FUNCTIONS



        //EVENT FUNCTIONS
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private async void btnPlayAudio_ClickAsync(object sender, EventArgs e)
        {
            var url = txtURL.Text;
            var ID = YoutubeExplode.YoutubeClient.ParseVideoId(url);

            var client = new YoutubeExplode.YoutubeClient();
            var streamInfoSet = await client.GetVideoMediaStreamInfosAsync(ID);
            var streamInfo = streamInfoSet.Audio.First();
            await client.DownloadMediaStreamAsync(streamInfo, $"downloaded_video.{"mp3"}");
        }
    }
}

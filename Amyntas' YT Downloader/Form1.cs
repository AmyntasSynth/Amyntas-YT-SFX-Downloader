using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
           
        }

        private void txtURL_MouseDown(object sender, MouseEventArgs e)
        {
            txtURL.Text = "";
        }

        private void checkSaveInprogramfolder_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSaveInprogramfolder.Checked)
            {
                checkSaveUsepreset.Checked = false;
            }
        }

        private void checkSaveManually_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkSaveUsepreset_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSaveUsepreset.Checked)
            {
                checkSaveInprogramfolder.Checked = false;
                checklistSavepresets.Enabled = true;
            }
            else
            {
                checklistSavepresets.Enabled = false;
            }
        }

        private void checkNameoriginal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNameoriginal.Checked)
            {
                checkNamecustom.Checked = false;
            }
        }

        private void checkNamecustom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNamecustom.Checked)
            {
                checkNameoriginal.Checked = false;
                txtCustomfilename.Enabled = true;
            }
            else
            {
                txtCustomfilename.Enabled = false;
            }
        }

        private void btnPresetAdd_Click(object sender, EventArgs e)
        {
            if (txtPresetPath.Text != "")
            {
                checklistSavepresets.Items.Add(txtPresetPath.Text);
                txtPresetPath.Text = "";
            }
            else
            {
                txtPresetPath.BackColor = Color.FromArgb(255, 130, 90, 90);
                lblError.Text = "No preset path entered!";
            }
        }

        private void txtPresetPath_Click(object sender, EventArgs e)
        {
            txtPresetPath.BackColor = Color.FromArgb(255, 90, 90, 90);
        }

        private void btnPresetRemove_Click(object sender, EventArgs e)
        {
            checklistSavepresets.Items.Remove(checklistSavepresets.SelectedItem);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Width = 604;
            this.Height = 407;
        }

        private async void btnDownloadAudio_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            if (txtURL.Text == "")
            {
                txtURL.BackColor = Color.FromArgb(255, 130, 90, 90);
                lblError.Text = "No URL entered!";
                return;
            }
            var url = txtURL.Text;
            var ID = "boi";
            try
            {
                ID = YoutubeExplode.YoutubeClient.ParseVideoId(url);
            }
            catch (Exception error)
            {
                lblError.Text = "Invalid URL!\n\n"+error;
                return;
            }

            var client = new YoutubeExplode.YoutubeClient();
            YoutubeExplode.Models.MediaStreams.MediaStreamInfoSet streamInfoSet;
            YoutubeExplode.Models.MediaStreams.AudioStreamInfo streamInfo;
            YoutubeExplode.Models.Video video;
            try
            {
                streamInfoSet = await client.GetVideoMediaStreamInfosAsync(ID);
                streamInfo = streamInfoSet.Audio.First();
                video = await client.GetVideoAsync(ID);
            }
            catch (Exception error)
            {
                lblError.Text = "There's a problem with receiving the data!\nPlease make sure that you have a working connection\nand have entered correct values.\n\n"+error;
                return;
            }
            
            var title = "boi";
            if (checkNameoriginal.Checked)
            {
                title = video.Title;
            }
            else if (checkNamecustom.Checked)
            {
                if (txtCustomfilename.Text != "")
                {
                    title = txtCustomfilename.Text;
                }
                else
                {
                    txtCustomfilename.BackColor = Color.FromArgb(255, 130, 90, 90);
                    lblError.Text = "No file name entered!";
                    return;
                }
            }

            try
            {
                await client.DownloadMediaStreamAsync(streamInfo, title + ".mp3");
            }
            catch (Exception error)
            {
                lblError.Text = "There's a problem with the download!\nPlease make sure that you have a working connection\nand that you're not spamming the button too much.\n\n"+error;
                return;
            }
            
            if (checkSaveInprogramfolder.Checked)
            {
                return;
            }
            else if (checkSaveUsepreset.Checked)
            {
                try
                {
                    File.Move(title + ".mp3", Convert.ToString(checklistSavepresets.SelectedItem)+"\\"+title+".mp3");
                }
                catch (Exception error)
                {
                    lblError.Text = "Couldn't move the file to the specified path!\nHave you entered the path correctly?\nFile was saved in this program's folder instead.\n\n"+error;
                    return;
                }
                
            }
            
        }

        private void txtCustomfilename_Click(object sender, EventArgs e)
        {
            txtCustomfilename.BackColor = Color.FromArgb(255, 90, 90, 90);
        }

        private void txtURL_Click(object sender, EventArgs e)
        {
            txtURL.BackColor = Color.FromArgb(255, 90, 90, 90);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

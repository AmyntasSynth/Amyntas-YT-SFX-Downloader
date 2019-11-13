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
        //----------------
        //VARIABLES
        //----------------
        Color configUIcolor;
        int configNameoption = 0;
        int configPresetoption = 0;


        //----------------
        //CONFIG VARIABLE LIST
        //----------------
        // 0. configUIcolor [W=white, S=salmon, O=orange, Y=yellow, L=limegreen, G=springgreen, B=lightblue, C=cornflowerblue, P=mediumpurple, V=violet]
        // 1. configNameoption [0=none, 1=originalYT-Name, 2=customYT-name]
        // 2. configPresetoption [0=none, 1=save in program folder, 2=use preset]


        //----------------
        //MAIN FUNCTION
        //----------------
        // *empty*
        public Form1()
        {
            InitializeComponent();

            
        }


        //----------------
        //CUSTOM FUNCTIONS
        //----------------

        // Saves "AmyYT-savedPresets.txt" to store added presets, from the preset-list
        private void RewritePresetSavefile()
        {
            try
            {
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AmyYT-savedPresets.txt");
            }
            catch
            { }

            string sPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AmyYT-savedPresets.txt";
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in checklistSavepresets.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();
        }

        // Saves "AmyYT-config.txt" to store settings
        private void RewriteConfigfile()
        {
            try
            {
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AmyYT-config.txt");
            }
            catch
            { }

            string sPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +"\\AmyYT-config.txt";
            StreamWriter SaveFile = new StreamWriter(sPath);
            if (configUIcolor == Color.White)
            {
                SaveFile.Write("W");
            }
            if (configUIcolor == Color.Salmon)
            {
                SaveFile.Write("S");
            }
            if (configUIcolor == Color.Orange)
            {
                SaveFile.Write("O");
            }
            if (configUIcolor == Color.Yellow)
            {
                SaveFile.Write("Y");
            }
            if (configUIcolor == Color.LimeGreen)
            {
                SaveFile.Write("L");
            }
            if (configUIcolor == Color.SpringGreen)
            {
                SaveFile.Write("G");
            }
            if (configUIcolor == Color.LightBlue)
            {
                SaveFile.Write("B");
            }
            if (configUIcolor == Color.CornflowerBlue)
            {
                SaveFile.Write("C");
            }
            if (configUIcolor == Color.MediumPurple)
            {
                SaveFile.Write("P");
            }
            if (configUIcolor == Color.Violet)
            {
                SaveFile.Write("V");
            }

            SaveFile.Write(configNameoption.ToString());
            SaveFile.Write(configPresetoption.ToString());

            SaveFile.Close();
        }

        // Used to recolor UI to what the user chooses / is saved in the config
        private void RecolorUI(Color Col)
        {
            label1.ForeColor = Col;
            label2.ForeColor = Col;
            label4.ForeColor = Col;
            label5.ForeColor = Col;
            checkNameoriginal.ForeColor = Col;
            checkNamecustom.ForeColor = Col;
            txtURL.ForeColor = Col;
            txtCustomfilename.ForeColor = Col;
            btnPaste.ForeColor = Col;
            btnDownloadAudio.ForeColor = Col;
            checkSaveInprogramfolder.ForeColor = Col;
            checkSaveUsepreset.ForeColor = Col;
            checklistSavepresets.ForeColor = Col;
            txtPresetPath.ForeColor = Col;
            btnPresetRemove.ForeColor = Col;
            btnPresetAdd.ForeColor = Col;
        }

        //----------------
        //EVENT FUNCTIONS
        //----------------

        // Loads config and saved presets
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (var line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AmyYT-savedPresets.txt"))
                {
                    checklistSavepresets.Items.Add(line);
                }
            }
            catch
            {

            }

            string cache = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AmyYT-config.txt");
            try
            {
                if (cache[0] == 'W')
                {
                    configUIcolor = Color.White;
                }
                if (cache[0] == 'S')
                {
                    configUIcolor = Color.Salmon;
                }
                if (cache[0] == 'O')
                {
                    configUIcolor = Color.Orange;
                }
                if (cache[0] == 'Y')
                {
                    configUIcolor = Color.Yellow;
                }
                if (cache[0] == 'L')
                {
                    configUIcolor = Color.LimeGreen;
                }
                if (cache[0] == 'G')
                {
                    configUIcolor = Color.SpringGreen;
                }
                if (cache[0] == 'B')
                {
                    configUIcolor = Color.LightBlue;
                }
                if (cache[0] == 'C')
                {
                    configUIcolor = Color.CornflowerBlue;
                }
                if (cache[0] == 'P')
                {
                    configUIcolor = Color.MediumPurple;
                }
                if (cache[0] == 'V')
                {
                    configUIcolor = Color.Violet;
                }
            }
            catch
            {
                configUIcolor = Color.White;
            }

            try
            {
                if (cache[1] == '1')
                {
                    checkNameoriginal.Checked = true;
                }
                if (cache[1] == '2')
                {
                    checkNamecustom.Checked = true;
                }
            }
            catch
            {
                checkNameoriginal.Checked = true;
            }

            try
            {
                if (cache[2] == '1')
                {
                    checkSaveInprogramfolder.Checked = true;
                }
                if (cache[2] == '2')
                {
                    checkSaveUsepreset.Checked = true;
                }
            }
            catch
            {
                checkSaveInprogramfolder.Checked = true;
            }

            RecolorUI(configUIcolor);
        }

        // Clears URL Textbox
        private void txtURL_MouseDown(object sender, MouseEventArgs e)
        {
            txtURL.Text = "";
        }

        // Enforces only one active checkbox
        // Changes config-value
        private void checkSaveInprogramfolder_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSaveInprogramfolder.Checked)
            {
                checkSaveUsepreset.Checked = false;
                configPresetoption = 1;
                RewriteConfigfile();
            }
        }

        // Enforces only one active checkbox
        // Enables/Disables preset-list
        // Changes config-value
        private void checkSaveUsepreset_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSaveUsepreset.Checked)
            {
                checkSaveInprogramfolder.Checked = false;
                checklistSavepresets.Enabled = true;
                configPresetoption = 2;
                RewriteConfigfile();
            }
            else
            {
                checklistSavepresets.Enabled = false;
            }
        }

        // Enforces only one active checkbox
        // Changes config-value
        private void checkNameoriginal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNameoriginal.Checked)
            {
                checkNamecustom.Checked = false;
                configNameoption = 1;
                RewriteConfigfile();
            }
        }

        // Enforces only one active checkbox
        // Enables/Disables file-name textbox
        // Changes config-value
        private void checkNamecustom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNamecustom.Checked)
            {
                checkNameoriginal.Checked = false;
                txtCustomfilename.Enabled = true;
                configNameoption = 2;
                RewriteConfigfile();
            }
            else
            {
                txtCustomfilename.Enabled = false;
            }
        }

        // Adds preset to preset-list
        private void btnPresetAdd_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
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
            RewritePresetSavefile();
        }

        // Returns normal BackColor to element
        private void txtPresetPath_Click(object sender, EventArgs e)
        {
            txtPresetPath.BackColor = Color.FromArgb(255, 90, 90, 90);
        }

        // Removes preset from preset-list
        private void btnPresetRemove_Click(object sender, EventArgs e)
        {
            checklistSavepresets.Items.Remove(checklistSavepresets.SelectedItem);
            RewritePresetSavefile();
        }

        // MAIN MAGIC HERE
        // Retrieves video-name from URL and attempts to download audio
        // If save-preset is chosen, will move file to designated filepath - if it fails, file will remain in program folder.
        private async void btnDownloadAudio_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            if (checklistSavepresets.SelectedItem == null && checkSaveUsepreset.Checked)
            {
                lblError.Text = "You need to either choose one of the presets, or choose to leave the file in this program's folder!";
                return;
            }
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

            progressBarDownload.Visible = true;
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
                progressBarDownload.Visible = false;
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
                    progressBarDownload.Visible = false;
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
                progressBarDownload.Visible = false;
                return;
            }
            
            if (checkSaveInprogramfolder.Checked)
            {
                progressBarDownload.Visible = false;
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
                    progressBarDownload.Visible = false;
                    return;
                }
                
            }
            else
            {
                checkSaveInprogramfolder.Checked = true;
            }
            progressBarDownload.Visible = false;
        }

        // Returns normal BackColor to element
        private void txtCustomfilename_Click(object sender, EventArgs e)
        {
            txtCustomfilename.BackColor = Color.FromArgb(255, 90, 90, 90);
        }

        // Returns normal BackColor to element
        private void txtURL_Click(object sender, EventArgs e)
        {
            txtURL.BackColor = Color.FromArgb(255, 90, 90, 90);
        }

        // Attempts to insert copied URL into URL-textbox
        private void btnPaste_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            try
            {
                txtURL.Text = Clipboard.GetText();
            }
            catch (Exception error)
            {
                lblError.Text = "There's nothing useful in your clipboard to paste!\n\n" + error;
            }
            if (txtURL.Text == "")
            {
                lblError.Text = "There's nothing useful in your clipboard to paste!\n\n";
            }
        }

        // Used to recolor UI
        private void btnColWhite_Click(object sender, EventArgs e)
        {
            RecolorUI(Color.White);
            configUIcolor = Color.White;
            RewriteConfigfile();
        }

        private void btnColSalmon_Click(object sender, EventArgs e)
        {
            RecolorUI(Color.Salmon);
            configUIcolor = Color.Salmon;
            RewriteConfigfile();
        }

        private void btnColOrange_Click(object sender, EventArgs e)
        {
            RecolorUI(Color.Orange);
            configUIcolor = Color.Orange;
            RewriteConfigfile();
        }

        private void btnColYellow_Click(object sender, EventArgs e)
        {
            RecolorUI(Color.Yellow);
            configUIcolor = Color.Yellow;
            RewriteConfigfile();
        }

        private void btnColLimegreen_Click(object sender, EventArgs e)
        {
            RecolorUI(Color.LimeGreen);
            configUIcolor = Color.LimeGreen;
            RewriteConfigfile();
        }

        private void btnColSpringgreen_Click(object sender, EventArgs e)
        {
            RecolorUI(Color.SpringGreen);
            configUIcolor = Color.SpringGreen;
            RewriteConfigfile();
        }

        private void btnColLightblue_Click(object sender, EventArgs e)
        {
            RecolorUI(Color.LightBlue);
            configUIcolor = Color.LightBlue;
            RewriteConfigfile();
        }

        private void btnColCornflowerblue_Click(object sender, EventArgs e)
        {
            RecolorUI(Color.CornflowerBlue);
            configUIcolor = Color.CornflowerBlue;
            RewriteConfigfile();
        }

        private void btnColMediumpurple_Click(object sender, EventArgs e)
        {
            RecolorUI(Color.MediumPurple);
            configUIcolor = Color.MediumPurple;
            RewriteConfigfile();
        }

        private void btnColViolet_Click(object sender, EventArgs e)
        {
            RecolorUI(Color.Violet);
            configUIcolor = Color.Violet;
            RewriteConfigfile();
        }
        //
    }
}

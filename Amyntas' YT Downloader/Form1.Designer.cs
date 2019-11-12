namespace Amyntas__YT_Downloader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDownloader = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.checkSaveInprogramfolder = new System.Windows.Forms.CheckBox();
            this.btnDownloadAudio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.checkSaveUsepreset = new System.Windows.Forms.CheckBox();
            this.btnPresetAdd = new System.Windows.Forms.Button();
            this.txtPresetPath = new System.Windows.Forms.TextBox();
            this.btnPresetRemove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkNameoriginal = new System.Windows.Forms.CheckBox();
            this.checkNamecustom = new System.Windows.Forms.CheckBox();
            this.txtCustomfilename = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.checklistSavepresets = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.tabControl1.SuspendLayout();
            this.tabDownloader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDownloader);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 369);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDownloader
            // 
            this.tabDownloader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabDownloader.Controls.Add(this.splitter2);
            this.tabDownloader.Controls.Add(this.checklistSavepresets);
            this.tabDownloader.Controls.Add(this.lblError);
            this.tabDownloader.Controls.Add(this.txtCustomfilename);
            this.tabDownloader.Controls.Add(this.checkNamecustom);
            this.tabDownloader.Controls.Add(this.checkNameoriginal);
            this.tabDownloader.Controls.Add(this.label5);
            this.tabDownloader.Controls.Add(this.label4);
            this.tabDownloader.Controls.Add(this.btnPresetRemove);
            this.tabDownloader.Controls.Add(this.txtPresetPath);
            this.tabDownloader.Controls.Add(this.btnPresetAdd);
            this.tabDownloader.Controls.Add(this.checkSaveUsepreset);
            this.tabDownloader.Controls.Add(this.txtURL);
            this.tabDownloader.Controls.Add(this.label2);
            this.tabDownloader.Controls.Add(this.label1);
            this.tabDownloader.Controls.Add(this.checkSaveInprogramfolder);
            this.tabDownloader.Controls.Add(this.btnDownloadAudio);
            this.tabDownloader.Controls.Add(this.splitter1);
            this.tabDownloader.ForeColor = System.Drawing.Color.Violet;
            this.tabDownloader.Location = new System.Drawing.Point(4, 22);
            this.tabDownloader.Name = "tabDownloader";
            this.tabDownloader.Padding = new System.Windows.Forms.Padding(3);
            this.tabDownloader.Size = new System.Drawing.Size(581, 343);
            this.tabDownloader.TabIndex = 0;
            this.tabDownloader.Text = "Downloader";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Violet;
            this.label2.Location = new System.Drawing.Point(213, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Save Location:";
            // 
            // checkSaveInprogramfolder
            // 
            this.checkSaveInprogramfolder.AutoSize = true;
            this.checkSaveInprogramfolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkSaveInprogramfolder.Checked = true;
            this.checkSaveInprogramfolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSaveInprogramfolder.ForeColor = System.Drawing.Color.Violet;
            this.checkSaveInprogramfolder.Location = new System.Drawing.Point(213, 18);
            this.checkSaveInprogramfolder.Name = "checkSaveInprogramfolder";
            this.checkSaveInprogramfolder.Size = new System.Drawing.Size(158, 17);
            this.checkSaveInprogramfolder.TabIndex = 12;
            this.checkSaveInprogramfolder.Text = "Save in this program\'s folder";
            this.checkSaveInprogramfolder.UseVisualStyleBackColor = false;
            this.checkSaveInprogramfolder.CheckedChanged += new System.EventHandler(this.checkSaveInprogramfolder_CheckedChanged);
            // 
            // btnDownloadAudio
            // 
            this.btnDownloadAudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDownloadAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadAudio.ForeColor = System.Drawing.Color.Violet;
            this.btnDownloadAudio.Location = new System.Drawing.Point(6, 294);
            this.btnDownloadAudio.Name = "btnDownloadAudio";
            this.btnDownloadAudio.Size = new System.Drawing.Size(192, 46);
            this.btnDownloadAudio.TabIndex = 11;
            this.btnDownloadAudio.Text = "Download Audio";
            this.btnDownloadAudio.UseVisualStyleBackColor = false;
            this.btnDownloadAudio.Click += new System.EventHandler(this.btnDownloadAudio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ForeColor = System.Drawing.Color.Violet;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "URL:";
            // 
            // txtURL
            // 
            this.txtURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.txtURL.ForeColor = System.Drawing.Color.Violet;
            this.txtURL.Location = new System.Drawing.Point(43, 6);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(155, 20);
            this.txtURL.TabIndex = 9;
            this.txtURL.Click += new System.EventHandler(this.txtURL_Click);
            this.txtURL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtURL_MouseDown);
            // 
            // checkSaveUsepreset
            // 
            this.checkSaveUsepreset.AutoSize = true;
            this.checkSaveUsepreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkSaveUsepreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSaveUsepreset.ForeColor = System.Drawing.Color.Violet;
            this.checkSaveUsepreset.Location = new System.Drawing.Point(213, 38);
            this.checkSaveUsepreset.Name = "checkSaveUsepreset";
            this.checkSaveUsepreset.Size = new System.Drawing.Size(146, 17);
            this.checkSaveUsepreset.TabIndex = 16;
            this.checkSaveUsepreset.Text = "Use preset save location:";
            this.checkSaveUsepreset.UseVisualStyleBackColor = false;
            this.checkSaveUsepreset.CheckedChanged += new System.EventHandler(this.checkSaveUsepreset_CheckedChanged);
            // 
            // btnPresetAdd
            // 
            this.btnPresetAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPresetAdd.ForeColor = System.Drawing.Color.Violet;
            this.btnPresetAdd.Location = new System.Drawing.Point(485, 316);
            this.btnPresetAdd.Name = "btnPresetAdd";
            this.btnPresetAdd.Size = new System.Drawing.Size(87, 23);
            this.btnPresetAdd.TabIndex = 18;
            this.btnPresetAdd.Text = "Add preset";
            this.btnPresetAdd.UseVisualStyleBackColor = false;
            this.btnPresetAdd.Click += new System.EventHandler(this.btnPresetAdd_Click);
            // 
            // txtPresetPath
            // 
            this.txtPresetPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.txtPresetPath.ForeColor = System.Drawing.Color.Violet;
            this.txtPresetPath.Location = new System.Drawing.Point(213, 318);
            this.txtPresetPath.Name = "txtPresetPath";
            this.txtPresetPath.Size = new System.Drawing.Size(266, 20);
            this.txtPresetPath.TabIndex = 19;
            this.txtPresetPath.Click += new System.EventHandler(this.txtPresetPath_Click);
            // 
            // btnPresetRemove
            // 
            this.btnPresetRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPresetRemove.ForeColor = System.Drawing.Color.Violet;
            this.btnPresetRemove.Location = new System.Drawing.Point(485, 293);
            this.btnPresetRemove.Name = "btnPresetRemove";
            this.btnPresetRemove.Size = new System.Drawing.Size(87, 23);
            this.btnPresetRemove.TabIndex = 20;
            this.btnPresetRemove.Text = "Remove preset";
            this.btnPresetRemove.UseVisualStyleBackColor = false;
            this.btnPresetRemove.Click += new System.EventHandler(this.btnPresetRemove_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Violet;
            this.label4.Location = new System.Drawing.Point(213, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Preset Path:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Violet;
            this.label5.Location = new System.Drawing.Point(5, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Save As:";
            // 
            // checkNameoriginal
            // 
            this.checkNameoriginal.AutoSize = true;
            this.checkNameoriginal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkNameoriginal.Checked = true;
            this.checkNameoriginal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkNameoriginal.ForeColor = System.Drawing.Color.Violet;
            this.checkNameoriginal.Location = new System.Drawing.Point(8, 57);
            this.checkNameoriginal.Name = "checkNameoriginal";
            this.checkNameoriginal.Size = new System.Drawing.Size(109, 17);
            this.checkNameoriginal.TabIndex = 24;
            this.checkNameoriginal.Text = "Original YT Name";
            this.checkNameoriginal.UseVisualStyleBackColor = false;
            this.checkNameoriginal.CheckedChanged += new System.EventHandler(this.checkNameoriginal_CheckedChanged);
            // 
            // checkNamecustom
            // 
            this.checkNamecustom.AutoSize = true;
            this.checkNamecustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkNamecustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNamecustom.ForeColor = System.Drawing.Color.Violet;
            this.checkNamecustom.Location = new System.Drawing.Point(8, 74);
            this.checkNamecustom.Name = "checkNamecustom";
            this.checkNamecustom.Size = new System.Drawing.Size(95, 17);
            this.checkNamecustom.TabIndex = 25;
            this.checkNamecustom.Text = "Custom Name:";
            this.checkNamecustom.UseVisualStyleBackColor = false;
            this.checkNamecustom.CheckedChanged += new System.EventHandler(this.checkNamecustom_CheckedChanged);
            // 
            // txtCustomfilename
            // 
            this.txtCustomfilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.txtCustomfilename.Enabled = false;
            this.txtCustomfilename.ForeColor = System.Drawing.Color.Violet;
            this.txtCustomfilename.Location = new System.Drawing.Point(8, 91);
            this.txtCustomfilename.Name = "txtCustomfilename";
            this.txtCustomfilename.Size = new System.Drawing.Size(190, 20);
            this.txtCustomfilename.TabIndex = 26;
            this.txtCustomfilename.Click += new System.EventHandler(this.txtCustomfilename_Click);
            // 
            // lblError
            // 
            this.lblError.AutoEllipsis = true;
            this.lblError.ForeColor = System.Drawing.Color.LightCoral;
            this.lblError.Location = new System.Drawing.Point(8, 114);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(192, 172);
            this.lblError.TabIndex = 27;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // checklistSavepresets
            // 
            this.checklistSavepresets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.checklistSavepresets.Enabled = false;
            this.checklistSavepresets.ForeColor = System.Drawing.Color.Violet;
            this.checklistSavepresets.FormattingEnabled = true;
            this.checklistSavepresets.Location = new System.Drawing.Point(213, 61);
            this.checklistSavepresets.Name = "checklistSavepresets";
            this.checklistSavepresets.Size = new System.Drawing.Size(359, 225);
            this.checklistSavepresets.TabIndex = 28;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitter1.Location = new System.Drawing.Point(3, 3);
            this.splitter1.MinimumSize = new System.Drawing.Size(1, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(202, 337);
            this.splitter1.TabIndex = 29;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.White;
            this.splitter2.Location = new System.Drawing.Point(205, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(2, 337);
            this.splitter2.TabIndex = 30;
            this.splitter2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(588, 368);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Amyntas\' YT SFX Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabDownloader.ResumeLayout(false);
            this.tabDownloader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDownloader;
        private System.Windows.Forms.Button btnPresetRemove;
        private System.Windows.Forms.TextBox txtPresetPath;
        private System.Windows.Forms.Button btnPresetAdd;
        private System.Windows.Forms.CheckBox checkSaveUsepreset;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkSaveInprogramfolder;
        private System.Windows.Forms.Button btnDownloadAudio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomfilename;
        private System.Windows.Forms.CheckBox checkNamecustom;
        private System.Windows.Forms.CheckBox checkNameoriginal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ListBox checklistSavepresets;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
    }
}


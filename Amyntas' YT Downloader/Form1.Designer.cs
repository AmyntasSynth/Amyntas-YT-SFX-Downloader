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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDownloadAudio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(43, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(157, 20);
            this.txtURL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL:";
            // 
            // btnDownloadAudio
            // 
            this.btnDownloadAudio.Location = new System.Drawing.Point(12, 38);
            this.btnDownloadAudio.Name = "btnDownloadAudio";
            this.btnDownloadAudio.Size = new System.Drawing.Size(103, 23);
            this.btnDownloadAudio.TabIndex = 3;
            this.btnDownloadAudio.Text = "Download Audio";
            this.btnDownloadAudio.UseVisualStyleBackColor = true;
            this.btnDownloadAudio.Click += new System.EventHandler(this.btnPlayAudio_ClickAsync);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 374);
            this.Controls.Add(this.btnDownloadAudio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtURL);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Amyntas\' YT-Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDownloadAudio;
    }
}


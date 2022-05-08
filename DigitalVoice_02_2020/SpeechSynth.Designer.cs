namespace DigitalVoice_02_2020
{
    partial class SpeechSynth
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
            this.components = new System.ComponentModel.Container();
            this.tblpnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlNotSpeaking = new System.Windows.Forms.Panel();
            this.pcbxSpeaking = new System.Windows.Forms.PictureBox();
            this.tblpnlLower = new System.Windows.Forms.TableLayoutPanel();
            this.tblpnlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSpeech = new System.Windows.Forms.TextBox();
            this.tmrStandby = new System.Windows.Forms.Timer(this.components);
            this.tblpnlMain.SuspendLayout();
            this.pnlNotSpeaking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSpeaking)).BeginInit();
            this.tblpnlLower.SuspendLayout();
            this.tblpnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblpnlMain
            // 
            this.tblpnlMain.ColumnCount = 1;
            this.tblpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlMain.Controls.Add(this.pnlNotSpeaking, 0, 0);
            this.tblpnlMain.Controls.Add(this.tblpnlLower, 0, 1);
            this.tblpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlMain.Location = new System.Drawing.Point(0, 0);
            this.tblpnlMain.Name = "tblpnlMain";
            this.tblpnlMain.RowCount = 2;
            this.tblpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnlMain.Size = new System.Drawing.Size(964, 495);
            this.tblpnlMain.TabIndex = 0;
            // 
            // pnlNotSpeaking
            // 
            this.pnlNotSpeaking.BackgroundImage = global::DigitalVoice_02_2020.Properties.Resources.blue_line;
            this.pnlNotSpeaking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNotSpeaking.Controls.Add(this.pcbxSpeaking);
            this.pnlNotSpeaking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNotSpeaking.Location = new System.Drawing.Point(3, 3);
            this.pnlNotSpeaking.Name = "pnlNotSpeaking";
            this.pnlNotSpeaking.Size = new System.Drawing.Size(958, 390);
            this.pnlNotSpeaking.TabIndex = 0;
            // 
            // pcbxSpeaking
            // 
            this.pcbxSpeaking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbxSpeaking.Image = global::DigitalVoice_02_2020.Properties.Resources.audio_spectrum_gif_5;
            this.pcbxSpeaking.Location = new System.Drawing.Point(0, 0);
            this.pcbxSpeaking.Name = "pcbxSpeaking";
            this.pcbxSpeaking.Size = new System.Drawing.Size(958, 390);
            this.pcbxSpeaking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxSpeaking.TabIndex = 0;
            this.pcbxSpeaking.TabStop = false;
            this.pcbxSpeaking.Visible = false;
            // 
            // tblpnlLower
            // 
            this.tblpnlLower.ColumnCount = 1;
            this.tblpnlLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlLower.Controls.Add(this.tblpnlButtons, 0, 1);
            this.tblpnlLower.Controls.Add(this.txtSpeech, 0, 0);
            this.tblpnlLower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlLower.Location = new System.Drawing.Point(3, 399);
            this.tblpnlLower.Name = "tblpnlLower";
            this.tblpnlLower.RowCount = 2;
            this.tblpnlLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblpnlLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblpnlLower.Size = new System.Drawing.Size(958, 93);
            this.tblpnlLower.TabIndex = 1;
            // 
            // tblpnlButtons
            // 
            this.tblpnlButtons.ColumnCount = 5;
            this.tblpnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnlButtons.Controls.Add(this.btnResume, 0, 0);
            this.tblpnlButtons.Controls.Add(this.btnPause, 1, 0);
            this.tblpnlButtons.Controls.Add(this.btnSpeak, 2, 0);
            this.tblpnlButtons.Controls.Add(this.btnStop, 3, 0);
            this.tblpnlButtons.Controls.Add(this.btnClear, 4, 0);
            this.tblpnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlButtons.Location = new System.Drawing.Point(3, 30);
            this.tblpnlButtons.Name = "tblpnlButtons";
            this.tblpnlButtons.RowCount = 1;
            this.tblpnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlButtons.Size = new System.Drawing.Size(952, 60);
            this.tblpnlButtons.TabIndex = 0;
            // 
            // btnResume
            // 
            this.btnResume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResume.Location = new System.Drawing.Point(3, 3);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(184, 54);
            this.btnResume.TabIndex = 4;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnPause
            // 
            this.btnPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPause.Location = new System.Drawing.Point(193, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(184, 54);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnSpeak
            // 
            this.btnSpeak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSpeak.Location = new System.Drawing.Point(383, 3);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(184, 54);
            this.btnSpeak.TabIndex = 2;
            this.btnSpeak.Text = "Speak";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.Location = new System.Drawing.Point(573, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(184, 54);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Location = new System.Drawing.Point(763, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(186, 54);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSpeech
            // 
            this.txtSpeech.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSpeech.Location = new System.Drawing.Point(3, 3);
            this.txtSpeech.MaxLength = 99999;
            this.txtSpeech.Multiline = true;
            this.txtSpeech.Name = "txtSpeech";
            this.txtSpeech.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSpeech.Size = new System.Drawing.Size(952, 21);
            this.txtSpeech.TabIndex = 1;
            this.txtSpeech.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tmrStandby
            // 
            this.tmrStandby.Enabled = true;
            this.tmrStandby.Tick += new System.EventHandler(this.tmrStandby_Tick);
            // 
            // SpeechSynth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 495);
            this.Controls.Add(this.tblpnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SpeechSynth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YUI Voice Command Mode";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tblpnlMain.ResumeLayout(false);
            this.pnlNotSpeaking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSpeaking)).EndInit();
            this.tblpnlLower.ResumeLayout(false);
            this.tblpnlLower.PerformLayout();
            this.tblpnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblpnlMain;
        private System.Windows.Forms.Panel pnlNotSpeaking;
        private System.Windows.Forms.PictureBox pcbxSpeaking;
        private System.Windows.Forms.TableLayoutPanel tblpnlLower;
        private System.Windows.Forms.TableLayoutPanel tblpnlButtons;
        private System.Windows.Forms.TextBox txtSpeech;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Timer tmrStandby;
    }
}


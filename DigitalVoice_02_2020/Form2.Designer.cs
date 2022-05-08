namespace DigitalVoice_02_2020
{
    partial class Form2
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
            this.tblpnlMain2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlNotSpeaking2 = new System.Windows.Forms.Panel();
            this.pcbxSpeaking2 = new System.Windows.Forms.PictureBox();
            this.tblpnlLower2 = new System.Windows.Forms.TableLayoutPanel();
            this.tblpnlSynthesizerArea = new System.Windows.Forms.TableLayoutPanel();
            this.txtSpeechSynth2 = new System.Windows.Forms.TextBox();
            this.tblpnlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.tblpnlButtonsUpper = new System.Windows.Forms.TableLayoutPanel();
            this.btnPause2 = new System.Windows.Forms.Button();
            this.btnSpeak2 = new System.Windows.Forms.Button();
            this.btnStop2 = new System.Windows.Forms.Button();
            this.tblpnlButtonsLower = new System.Windows.Forms.TableLayoutPanel();
            this.btnResume2 = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.tblpnlCommandArea = new System.Windows.Forms.TableLayoutPanel();
            this.txtSpeechCommand = new System.Windows.Forms.TextBox();
            this.tblpnlButtonsCmd = new System.Windows.Forms.TableLayoutPanel();
            this.btnInitiate = new System.Windows.Forms.Button();
            this.btnSwitchVC = new System.Windows.Forms.Button();
            this.tblpnlMain2.SuspendLayout();
            this.pnlNotSpeaking2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSpeaking2)).BeginInit();
            this.tblpnlLower2.SuspendLayout();
            this.tblpnlSynthesizerArea.SuspendLayout();
            this.tblpnlButtons.SuspendLayout();
            this.tblpnlButtonsUpper.SuspendLayout();
            this.tblpnlButtonsLower.SuspendLayout();
            this.tblpnlCommandArea.SuspendLayout();
            this.tblpnlButtonsCmd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblpnlMain2
            // 
            this.tblpnlMain2.ColumnCount = 1;
            this.tblpnlMain2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlMain2.Controls.Add(this.pnlNotSpeaking2, 0, 0);
            this.tblpnlMain2.Controls.Add(this.tblpnlLower2, 0, 1);
            this.tblpnlMain2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlMain2.Location = new System.Drawing.Point(0, 0);
            this.tblpnlMain2.Name = "tblpnlMain2";
            this.tblpnlMain2.RowCount = 2;
            this.tblpnlMain2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblpnlMain2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblpnlMain2.Size = new System.Drawing.Size(953, 456);
            this.tblpnlMain2.TabIndex = 0;
            // 
            // pnlNotSpeaking2
            // 
            this.pnlNotSpeaking2.BackgroundImage = global::DigitalVoice_02_2020.Properties.Resources.blue_line;
            this.pnlNotSpeaking2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNotSpeaking2.Controls.Add(this.pcbxSpeaking2);
            this.pnlNotSpeaking2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNotSpeaking2.Location = new System.Drawing.Point(3, 3);
            this.pnlNotSpeaking2.Name = "pnlNotSpeaking2";
            this.pnlNotSpeaking2.Size = new System.Drawing.Size(947, 313);
            this.pnlNotSpeaking2.TabIndex = 0;
            // 
            // pcbxSpeaking2
            // 
            this.pcbxSpeaking2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbxSpeaking2.Image = global::DigitalVoice_02_2020.Properties.Resources.audio_spectrum_gif_5;
            this.pcbxSpeaking2.Location = new System.Drawing.Point(0, 0);
            this.pcbxSpeaking2.Name = "pcbxSpeaking2";
            this.pcbxSpeaking2.Size = new System.Drawing.Size(947, 313);
            this.pcbxSpeaking2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxSpeaking2.TabIndex = 0;
            this.pcbxSpeaking2.TabStop = false;
            this.pcbxSpeaking2.Visible = false;
            // 
            // tblpnlLower2
            // 
            this.tblpnlLower2.ColumnCount = 2;
            this.tblpnlLower2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlLower2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlLower2.Controls.Add(this.tblpnlSynthesizerArea, 0, 0);
            this.tblpnlLower2.Controls.Add(this.tblpnlCommandArea, 1, 0);
            this.tblpnlLower2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlLower2.Location = new System.Drawing.Point(3, 322);
            this.tblpnlLower2.Name = "tblpnlLower2";
            this.tblpnlLower2.RowCount = 1;
            this.tblpnlLower2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlLower2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpnlLower2.Size = new System.Drawing.Size(947, 131);
            this.tblpnlLower2.TabIndex = 1;
            // 
            // tblpnlSynthesizerArea
            // 
            this.tblpnlSynthesizerArea.ColumnCount = 1;
            this.tblpnlSynthesizerArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlSynthesizerArea.Controls.Add(this.txtSpeechSynth2, 0, 0);
            this.tblpnlSynthesizerArea.Controls.Add(this.tblpnlButtons, 0, 1);
            this.tblpnlSynthesizerArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlSynthesizerArea.Location = new System.Drawing.Point(3, 3);
            this.tblpnlSynthesizerArea.Name = "tblpnlSynthesizerArea";
            this.tblpnlSynthesizerArea.RowCount = 2;
            this.tblpnlSynthesizerArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnlSynthesizerArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblpnlSynthesizerArea.Size = new System.Drawing.Size(467, 125);
            this.tblpnlSynthesizerArea.TabIndex = 0;
            // 
            // txtSpeechSynth2
            // 
            this.txtSpeechSynth2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSpeechSynth2.Location = new System.Drawing.Point(3, 3);
            this.txtSpeechSynth2.Name = "txtSpeechSynth2";
            this.txtSpeechSynth2.Size = new System.Drawing.Size(461, 20);
            this.txtSpeechSynth2.TabIndex = 0;
            this.txtSpeechSynth2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tblpnlButtons
            // 
            this.tblpnlButtons.ColumnCount = 1;
            this.tblpnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlButtons.Controls.Add(this.tblpnlButtonsUpper, 0, 0);
            this.tblpnlButtons.Controls.Add(this.tblpnlButtonsLower, 0, 1);
            this.tblpnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlButtons.Location = new System.Drawing.Point(3, 28);
            this.tblpnlButtons.Name = "tblpnlButtons";
            this.tblpnlButtons.RowCount = 2;
            this.tblpnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlButtons.Size = new System.Drawing.Size(461, 94);
            this.tblpnlButtons.TabIndex = 1;
            // 
            // tblpnlButtonsUpper
            // 
            this.tblpnlButtonsUpper.ColumnCount = 3;
            this.tblpnlButtonsUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblpnlButtonsUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblpnlButtonsUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblpnlButtonsUpper.Controls.Add(this.btnPause2, 0, 0);
            this.tblpnlButtonsUpper.Controls.Add(this.btnSpeak2, 1, 0);
            this.tblpnlButtonsUpper.Controls.Add(this.btnStop2, 2, 0);
            this.tblpnlButtonsUpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlButtonsUpper.Location = new System.Drawing.Point(3, 3);
            this.tblpnlButtonsUpper.Name = "tblpnlButtonsUpper";
            this.tblpnlButtonsUpper.RowCount = 1;
            this.tblpnlButtonsUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlButtonsUpper.Size = new System.Drawing.Size(455, 41);
            this.tblpnlButtonsUpper.TabIndex = 0;
            // 
            // btnPause2
            // 
            this.btnPause2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPause2.Location = new System.Drawing.Point(3, 3);
            this.btnPause2.Name = "btnPause2";
            this.btnPause2.Size = new System.Drawing.Size(145, 35);
            this.btnPause2.TabIndex = 0;
            this.btnPause2.Text = "Pause";
            this.btnPause2.UseVisualStyleBackColor = true;
            this.btnPause2.Click += new System.EventHandler(this.btnPause2_Click);
            // 
            // btnSpeak2
            // 
            this.btnSpeak2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSpeak2.Location = new System.Drawing.Point(154, 3);
            this.btnSpeak2.Name = "btnSpeak2";
            this.btnSpeak2.Size = new System.Drawing.Size(145, 35);
            this.btnSpeak2.TabIndex = 1;
            this.btnSpeak2.Text = "Speak";
            this.btnSpeak2.UseVisualStyleBackColor = true;
            this.btnSpeak2.Click += new System.EventHandler(this.btnSpeak2_Click);
            // 
            // btnStop2
            // 
            this.btnStop2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop2.Location = new System.Drawing.Point(305, 3);
            this.btnStop2.Name = "btnStop2";
            this.btnStop2.Size = new System.Drawing.Size(147, 35);
            this.btnStop2.TabIndex = 2;
            this.btnStop2.Text = "Stop";
            this.btnStop2.UseVisualStyleBackColor = true;
            this.btnStop2.Click += new System.EventHandler(this.btnStop2_Click);
            // 
            // tblpnlButtonsLower
            // 
            this.tblpnlButtonsLower.ColumnCount = 2;
            this.tblpnlButtonsLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlButtonsLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlButtonsLower.Controls.Add(this.btnResume2, 0, 0);
            this.tblpnlButtonsLower.Controls.Add(this.btnClear2, 1, 0);
            this.tblpnlButtonsLower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlButtonsLower.Location = new System.Drawing.Point(3, 50);
            this.tblpnlButtonsLower.Name = "tblpnlButtonsLower";
            this.tblpnlButtonsLower.RowCount = 1;
            this.tblpnlButtonsLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlButtonsLower.Size = new System.Drawing.Size(455, 41);
            this.tblpnlButtonsLower.TabIndex = 1;
            // 
            // btnResume2
            // 
            this.btnResume2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResume2.Location = new System.Drawing.Point(3, 3);
            this.btnResume2.Name = "btnResume2";
            this.btnResume2.Size = new System.Drawing.Size(221, 35);
            this.btnResume2.TabIndex = 0;
            this.btnResume2.Text = "Resume";
            this.btnResume2.UseVisualStyleBackColor = true;
            this.btnResume2.Click += new System.EventHandler(this.btnResume2_Click);
            // 
            // btnClear2
            // 
            this.btnClear2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear2.Location = new System.Drawing.Point(230, 3);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(222, 35);
            this.btnClear2.TabIndex = 1;
            this.btnClear2.Text = "Clear";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // tblpnlCommandArea
            // 
            this.tblpnlCommandArea.ColumnCount = 1;
            this.tblpnlCommandArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlCommandArea.Controls.Add(this.txtSpeechCommand, 0, 0);
            this.tblpnlCommandArea.Controls.Add(this.tblpnlButtonsCmd, 0, 1);
            this.tblpnlCommandArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlCommandArea.Location = new System.Drawing.Point(476, 3);
            this.tblpnlCommandArea.Name = "tblpnlCommandArea";
            this.tblpnlCommandArea.RowCount = 2;
            this.tblpnlCommandArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnlCommandArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblpnlCommandArea.Size = new System.Drawing.Size(468, 125);
            this.tblpnlCommandArea.TabIndex = 1;
            // 
            // txtSpeechCommand
            // 
            this.txtSpeechCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSpeechCommand.Location = new System.Drawing.Point(3, 3);
            this.txtSpeechCommand.Name = "txtSpeechCommand";
            this.txtSpeechCommand.Size = new System.Drawing.Size(462, 20);
            this.txtSpeechCommand.TabIndex = 0;
            this.txtSpeechCommand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tblpnlButtonsCmd
            // 
            this.tblpnlButtonsCmd.ColumnCount = 2;
            this.tblpnlButtonsCmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlButtonsCmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlButtonsCmd.Controls.Add(this.btnInitiate, 0, 0);
            this.tblpnlButtonsCmd.Controls.Add(this.btnSwitchVC, 1, 0);
            this.tblpnlButtonsCmd.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblpnlButtonsCmd.Location = new System.Drawing.Point(3, 28);
            this.tblpnlButtonsCmd.Name = "tblpnlButtonsCmd";
            this.tblpnlButtonsCmd.RowCount = 1;
            this.tblpnlButtonsCmd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlButtonsCmd.Size = new System.Drawing.Size(462, 94);
            this.tblpnlButtonsCmd.TabIndex = 1;
            // 
            // btnInitiate
            // 
            this.btnInitiate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInitiate.Location = new System.Drawing.Point(3, 3);
            this.btnInitiate.Name = "btnInitiate";
            this.btnInitiate.Size = new System.Drawing.Size(225, 23);
            this.btnInitiate.TabIndex = 0;
            this.btnInitiate.Text = "Initiate";
            this.btnInitiate.UseVisualStyleBackColor = true;
            this.btnInitiate.Click += new System.EventHandler(this.btnInitiate_Click);
            // 
            // btnSwitchVC
            // 
            this.btnSwitchVC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSwitchVC.Location = new System.Drawing.Point(234, 3);
            this.btnSwitchVC.Name = "btnSwitchVC";
            this.btnSwitchVC.Size = new System.Drawing.Size(225, 23);
            this.btnSwitchVC.TabIndex = 1;
            this.btnSwitchVC.Text = "Switch to Voice Command";
            this.btnSwitchVC.UseVisualStyleBackColor = true;
            this.btnSwitchVC.Click += new System.EventHandler(this.btnSwitchVC_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 456);
            this.Controls.Add(this.tblpnlMain2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YUI Manual Mode";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tblpnlMain2.ResumeLayout(false);
            this.pnlNotSpeaking2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSpeaking2)).EndInit();
            this.tblpnlLower2.ResumeLayout(false);
            this.tblpnlSynthesizerArea.ResumeLayout(false);
            this.tblpnlSynthesizerArea.PerformLayout();
            this.tblpnlButtons.ResumeLayout(false);
            this.tblpnlButtonsUpper.ResumeLayout(false);
            this.tblpnlButtonsLower.ResumeLayout(false);
            this.tblpnlCommandArea.ResumeLayout(false);
            this.tblpnlCommandArea.PerformLayout();
            this.tblpnlButtonsCmd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblpnlMain2;
        private System.Windows.Forms.Panel pnlNotSpeaking2;
        private System.Windows.Forms.PictureBox pcbxSpeaking2;
        private System.Windows.Forms.TableLayoutPanel tblpnlLower2;
        private System.Windows.Forms.TableLayoutPanel tblpnlSynthesizerArea;
        private System.Windows.Forms.TextBox txtSpeechSynth2;
        private System.Windows.Forms.TableLayoutPanel tblpnlButtons;
        private System.Windows.Forms.TableLayoutPanel tblpnlButtonsUpper;
        private System.Windows.Forms.Button btnPause2;
        private System.Windows.Forms.Button btnSpeak2;
        private System.Windows.Forms.Button btnStop2;
        private System.Windows.Forms.TableLayoutPanel tblpnlButtonsLower;
        private System.Windows.Forms.Button btnResume2;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.TableLayoutPanel tblpnlCommandArea;
        private System.Windows.Forms.TextBox txtSpeechCommand;
        private System.Windows.Forms.TableLayoutPanel tblpnlButtonsCmd;
        private System.Windows.Forms.Button btnInitiate;
        private System.Windows.Forms.Button btnSwitchVC;
    }
}
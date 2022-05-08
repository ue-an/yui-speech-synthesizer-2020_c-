using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.IO;

namespace DigitalVoice_02_2020
{
    public partial class Form2 : Form
    {

        SpeechSynthesizer synth;
        SpeechSynthesizer synth02;
        Random rnd;
        bool isStopped;
        int RecTimeout;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void synth_Speak(string str)
        {
            synth = new SpeechSynthesizer();
            string speech = str;
            synth.SpeakAsync(speech);
            pcbxSpeaking2.Visible = true;
        }

        private void synth02_Speak(string str)
        {
            synth02 = new SpeechSynthesizer();
            synth02.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            string speech = str;
            synth02.SpeakAsync(speech);
            pcbxSpeaking2.Visible = true;
        }

        private void btnSpeak2_Click(object sender, EventArgs e)
        {
            //synth = new SpeechSynthesizer();
            string speech = txtSpeechSynth2.Text.ToString();
            synth_Speak(speech);
            synth.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(synth_SpeakCompleted);
            isStopped = false;
        }
        private void synth_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            pcbxSpeaking2.Visible = false;
        }

        private void btnStop2_Click(object sender, EventArgs e)
        {
            if (synth.State == SynthesizerState.Speaking)
            {
                isStopped = true;
                pcbxSpeaking2.Visible = false;
                synth.Dispose();
            }
        }

        private void btnPause2_Click(object sender, EventArgs e)
        {
            if (isStopped != true)
            {
                if (synth.State == SynthesizerState.Speaking)
                {
                    synth.Pause();
                    pcbxSpeaking2.Visible = false;
                }
            }
        }

        private void btnResume2_Click(object sender, EventArgs e)
        {
            if (isStopped != true)
            {
                if (synth.State == SynthesizerState.Paused)
                {
                    synth.Resume();
                    pcbxSpeaking2.Visible = true;
                }
            }
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            txtSpeechSynth2.Text = null;
        }

        private void btnInitiate_Click(object sender, EventArgs e)
        {
            string command = txtSpeechCommand.Text.ToString();
            isStopped = false;
            rnd = new Random();
            tblpnlButtons.Enabled = false;

            switch (command)
            {
                    
                case "check":
                    int ran = rnd.Next(0, 2);
                    if (ran == 0)
                    {
                        synth02_Speak("i'm doing good.");
                    }
                    if (ran == 1)
                    {
                        synth02_Speak("yuie is in good condition.");
                    }
                    if (ran == 2)
                    {
                        synth02_Speak("working just fine.");
                    }
                    break;

                case "tell us about yourself":
                    ran = rnd.Next(0, 2);
                    if (ran == 0)
                    {
                        synth02_Speak("Hello, I am you we, a Digital Voice Program. Ian had developed me on August 2020 to provide basic functions and assistance. I have an older version which was programmed using java when he was in senior high school. Nice to meet you");
                    }
                    if (ran == 1)
                    {
                        synth02_Speak("I want to know more about your world");
                    }
                    if (ran == 2)
                    {
                        synth02_Speak("Okay. I am not just a program. I can accompany ian");
                    }
                    if (ran == 3)
                    {
                        synth02_Speak("I cannot talk so much and not a fully-developed A I yet. I am jealous of you. How about you? Tell me something about you");
                    }
                    if (ran == 4)
                    {
                        synth02_Speak("I am a speech synthesizer program initially but now I am not. I talk myself and instead, Ian created a separate speech synthesizer");
                    }
                    break;
                case "introduce yourself":
                    ran = rnd.Next(0, 2);
                    if (ran == 0)
                    {
                        synth02_Speak("Hello, I am you we, a Digital Voice Program. Ian had developed me on August 2020 to provide basic functions and assistance. I have an older version which was programmed using java when he was in senior high school. Nice to meet you");
                    }
                    if (ran == 1)
                    {
                        synth02_Speak("Hi there! I am you we. I am a digital voice program and already two years old. Nice to meet you");
                    }
                    if (ran == 2)
                    {
                        synth02_Speak("Hello there! Nice to meet you. I am you we, a digital voice program. Ian developed me way back 2020 and I am the very first personal project of Ian when he was in senior high school while learning java");
                    }
                    if (ran == 2)
                    {
                        synth02_Speak("Hi! Nice to meet you. you we here, a digital voice program.");
                    }
                    
                    break;
                case "yui who are you":
                    synth02_Speak("Hello, I am you we. How about you?");
                    break;
                case "who are you":
                    synth02_Speak("Hi! I am you we. What's your name?");
                    break;

                case "yui suggestion":
                    int ran2 = rnd.Next(0, 6);

                    if (ran2 == 0)
                    {
                        synth02_Speak("Should we take a break?");
                    }
                    if (ran2 == 1)
                    {
                        synth02_Speak("Let's go get something to eat, what do you say?");
                    }
                    if (ran2 == 2)
                    {
                        synth02_Speak("Be calm. Let's try it again from the top");
                    }
                    if (ran2 == 3)
                    {
                        synth02_Speak("Watch an anime");
                    }
                    if (ran2 == 4)
                    {
                        synth02_Speak("Water break");
                    }
                    if (ran2 == 5)
                    {
                        synth02_Speak("Let's call it a day. Fine with that?");
                    }
                    if (ran2 == 6)
                    {
                        synth02_Speak("Check online, maybe");
                    }
                    break;

                case "":
                    break;

                default:
                    synth02_Speak("Invalid command.");
                    break;
              
            }
            synth02.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(synth02_SpeakCompleted);
        }

        private void synth02_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            pcbxSpeaking2.Visible = false;
            tblpnlButtons.Enabled = true;
        }

        private void btnSwitchVC_Click(object sender, EventArgs e)
        {
            SpeechSynth form = new SpeechSynth();
            synth02_Speak("Changing to voice command.");
            form.Show();
            this.Hide();
        }
    }
}
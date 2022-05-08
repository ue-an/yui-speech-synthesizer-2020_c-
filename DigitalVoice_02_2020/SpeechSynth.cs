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
    public partial class SpeechSynth : Form
    {

//===================== I n i t i a l i z a t i o n =========================

        SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();
        SpeechRecognitionEngine startlistening = new SpeechRecognitionEngine();
        //SpeechSynthesizer synth = new SpeechSynthesizer();
        //SpeechSynthesizer synth02 = new SpeechSynthesizer();
        SpeechSynthesizer synth;
        SpeechSynthesizer synth02;
        int RecTimeout;
        Random rnd = new Random();
        bool isStopped;


        public SpeechSynth()
        {
            InitializeComponent();
        }
//=========================== M a i n  F u n c t i o n s ==============================

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSpeech.Focus();
            recognizer.SetInputToDefaultAudioDevice();
            recognizer.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"Commands.txt")))));
            recognizer.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(recognizer_SpeechDetected);
            recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Default_SpeechRecognized);
            recognizer.RecognizeAsync(RecognizeMode.Multiple);

            startlistening.SetInputToDefaultAudioDevice();
            startlistening.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"Commands.txt")))));
            startlistening.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(startlistening_SpeechRecognized);
        }

        private void Synth_Speak(string str)
        {
            startlistening.RecognizeAsyncCancel();
            synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Teen);
            pcbxSpeaking.Visible = true;
            synth.SpeakAsync(str);
            //synth.Rate = -6;
        }

        private void Synth02_Speak(string str)
        {
            synth02 = new SpeechSynthesizer();
            synth02.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            pcbxSpeaking.Visible = true;
            synth02.SpeakAsync(str);         
        }

        private void recognizer_SpeechDetected(object sender, SpeechDetectedEventArgs e)
        {
            RecTimeout = 0;
        }

        private void startlistening_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;

            if (speech.ToLower() == "yui generate")
            {
                Synth02_Speak("Yes, working now.");
                startlistening.RecognizeAsyncCancel();
                recognizer.RecognizeAsync(RecognizeMode.Multiple);
            }

            //if (speech.ToLower() == "wait")
            //{
            //    if (isStopped == false)
            //    {
            //        if (synth.State == SynthesizerState.Speaking)
            //        {
            //            synth.Pause();
            //            pcbxSpeaking.Visible = false;
            //        }
            //    }
            //}

            //if (speech.ToLower() == "okay" || speech.ToLower() == "proceed")
            //{
            //    if (isStopped == false)
            //    {
            //        if (synth.State == SynthesizerState.Paused)
            //        {
            //            synth.Resume();
            //            pcbxSpeaking.Visible = true;
            //        }
            //    }
            //}
        }

        private void Default_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;
            int ran = rnd.Next(0, 2);
            

            if (speech.ToLower() == "introduce yourself")
            {
                Synth02_Speak("Hello, I am you we, a Digital Voice Program. Ian had developed me on August 2020 to provide basic functions and assistance. I have an older version which was programmed using java when he was in senior high school. Nice to meet you");
                //tblpnlButtons.Enabled = false;
            }

            if (speech.ToLower() == "sleep you we")
            {
                recognizer.RecognizeAsyncCancel();
                startlistening.RecognizeAsync(RecognizeMode.Multiple);
                synth02.SpeakAsyncCancelAll();
                Synth02_Speak("Okay, call me again if you need me.");
                tblpnlButtons.Enabled = false;
            }

            if (speech.ToLower() == "you we change mode")
            {
                Synth02_Speak("Understood.");
                Form2 form = new Form2();
                recognizer.RecognizeAsyncCancel();
                //startlistening.RecognizeAsync(RecognizeMode.Multiple);
                startlistening.RecognizeAsyncCancel();
                form.Show();
                this.Hide();
            }

            if (speech.ToLower() == "wait")
            {
                if (isStopped == false)
                {
                    if (synth02.State == SynthesizerState.Speaking)
                    {
                        synth02.Pause();
                        ////pcbxSpeaking.Visible = false;
                    }
                }
            }

            if (speech.ToLower() == "okay" || speech.ToLower() == "proceed")
            {
                if (isStopped == false && synth02.State == SynthesizerState.Paused)
                {
                    synth02.Resume();
                        //pcbxSpeaking.Visible = true;
                    
                }
            }

            
            if (speech.ToLower() == "how are you you we")
            {
                if (ran == 0)
                {
                    Synth02_Speak("working just fine.");
                }
                if (ran == 1)
                {
                    Synth02_Speak("you we is in good condition");
                }
                if (ran == 2)
                {
                    Synth02_Speak("i'm doing good");
                }

                //tblpnlButtons.Enabled = false;
            }
            if (
                speech.ToLower() == "yui suggestion" || 
                speech.ToLower() == "what should we do"
            || speech.ToLower() == "what should i do"
            || speech.ToLower() == "what to do"
            || speech.ToLower() == "yui what should we do"
            || speech.ToLower() == "yui what should i do"
            || speech.ToLower() == "yui what to do"
            || speech.ToLower() == "what should we do yui"
            || speech.ToLower() == "what should i do yui"
            || speech.ToLower() == "what to do yui"
            )
            {

                if (ran == 0)
                {
                    Synth02_Speak("Should we take a break?");
                }
                if (ran == 1)
                {
                    Synth02_Speak("Let's go get something to eat, what do you say?");
                }
                if (ran == 2)
                {
                    Synth02_Speak("Be calm. Let's try it again from the top");
                }
                if (ran == 3)
                {
                    Synth02_Speak("Watch an anime");
                }
                if (ran == 4)
                {
                    Synth02_Speak("Water break");
                }
                if (ran == 5)
                {
                    Synth02_Speak("Let's call it a day. Fine with that?");
                }
                if (ran == 6)
                {
                    Synth02_Speak("Check online, maybe");
                }
            }
            if (
            speech.ToLower() == "yui are you hungry" ||
            speech.ToLower() == "are you hungry"
        || speech.ToLower() == "are you hungry yui"
        )
            {

                if (ran == 0)
                {
                    Synth02_Speak("Yes.");
                }
                if (ran == 1)
                {
                    Synth02_Speak("No");
                }
                if (ran == 2)
                {
                    Synth02_Speak("Not really");
                }
                if (ran == 3)
                {
                    Synth02_Speak("Yes. got a problem with that?");
                }
                if (ran == 4)
                {
                    Synth02_Speak("What do you think huh");
                }
                if (ran == 5)
                {
                    Synth02_Speak("What do you think");
                }
                if (ran == 6)
                {
                    Synth02_Speak("A little");
                }
            }

             //if (speech.ToLower() == "again")
            //{
            //    if (isStopped == false)
            //    {
            //        if (synth.State == SynthesizerState.Paused)
            //        {
            //            if (txtSpeech != null)
            //            {
            //                pcbxSpeaking.Visible = false;
            //                synth.Dispose();
            //                isStopped = true;
            //            }
            //        }
            //    }
            //    synth = new SpeechSynthesizer();
            //    string again = txtSpeech.Text.ToString();
            //    Synth_Speak(again);
            //    synth.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(synth_SpeakCompleted);
            //    isStopped = false;
            //}

            else
            {
                Synth02_Speak("");
                //synth.Pause();
                //pcbxSpeaking.Visible = false;
            }
            txtSpeech.Focus();
            synth02.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(synth02_SpeakCompleted);
        }

        private void synth02_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            pcbxSpeaking.Visible = false;
            tblpnlButtons.Enabled = true;
            txtSpeech.Focus();
        }
        
//======================= B u t t o n s  F u n c t i o n s ============================
        private void btnSpeak_Click(object sender, EventArgs e)
        {
            synth = new SpeechSynthesizer();
            //synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Child);
            string speech = txtSpeech.Text.ToString();
            Synth_Speak(speech);

            synth.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(synth_SpeakCompleted);
            isStopped = false;
        }

        private void synth_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            pcbxSpeaking.Visible = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (isStopped == false)
            {
                if (synth.State == SynthesizerState.Speaking)
                {
                    synth.Pause();
                    pcbxSpeaking.Visible = false;
                }
            }
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            if (isStopped == false)
            {
                if (synth.State == SynthesizerState.Paused)
                {
                    synth.Resume();
                    pcbxSpeaking.Visible = true;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSpeech.Text = null;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (txtSpeech != null)
            {
                pcbxSpeaking.Visible = false;
                synth.Dispose();
                isStopped = true;
            }
        }

        private void tmrStandby_Tick(object sender, EventArgs e)
        {
            if (RecTimeout == 10)
            {
                Synth02_Speak("I'll standby");
                recognizer.RecognizeAsyncCancel();
            }
            else if (RecTimeout == 11)
            {
                Synth02_Speak("you we standby. call me again");
                recognizer.RecognizeAsyncCancel();
                startlistening.RecognizeAsync(RecognizeMode.Multiple);
                RecTimeout = 0;
            }
        }
    }
}
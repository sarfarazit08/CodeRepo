using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Speech synthesis libraries
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;

//Epub Reader libraries
using eBdb.EpubReader;
using Ionic.Zip;

//reference Nuget Package NAudio.Lame
//Install-Package NAudio.Lame
//using NAudio.Wave;
//using NAudio.Lame;


namespace WINTEXT2MP3
{
    public partial class TEXT2MP3 : Form
    {
        SpeechSynthesizer speech;
        public TEXT2MP3()
        {
            InitializeComponent();
        }

        private void TEXT2MP3_Load(object sender, EventArgs e)
        {
            speech = new SpeechSynthesizer();

            PopulateInstalledVoices();

            BtnPause.Enabled = false;
            BtnResume.Enabled = false;
            BtnStop.Enabled = false;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (txtBoxLarge.Text.Length > 0)
            {
                speech = new SpeechSynthesizer();

                if (ComboBoxVoices.SelectedIndex != -1)
                {
                    speech.SelectVoice(ComboBoxVoices.SelectedItem.ToString());

                    speech.Rate = trackBarSpeechRate.Value;
                    speech.Volume = trackBarVolume.Value;

                    speech.SpeakAsync(txtBoxLarge.Text);

                    lblSpeechStatus.Text = "Speaking";
                    BtnPause.Enabled = true;
                    BtnStop.Enabled = true;
                    speech.SpeakCompleted += speech_SpeakCompleted;
                }
                else
                {
                    MessageBox.Show("Select a voice first.", "Select a voice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }           
            }
            else
            {
                MessageBox.Show("Please enter some text in the textbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //System.Speech.AudioFormat.SpeechAudioFormatInfo synthFormat =
            //new System.Speech.AudioFormat.SpeechAudioFormatInfo(System.Speech.AudioFormat.EncodingFormat.Pcm, 8000, 16, 1, 16000, 2, null);
            //speech.SetOutputToAudioStream(MemStream, synthFormat);
        }

        void speech_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            lblSpeechStatus.Text = "Stopped";
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            if (speech != null)
            {
                if (speech.State == SynthesizerState.Speaking)
                {
                    speech.Pause();
                    lblSpeechStatus.Text = "Paused";
                    BtnResume.Enabled = true;
                }
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (speech != null)
            {
                speech.Dispose();
                lblSpeechStatus.Text = "Stopped";
                BtnPause.Enabled = false;
                BtnResume.Enabled = false;
                BtnStop.Enabled = false;
            }
        }

        private void BtnResume_Click(object sender, EventArgs e)
        {
            if (speech != null)
            {
                if (speech.State == SynthesizerState.Paused)
                {
                    speech.Resume();
                    lblSpeechStatus.Text = "Speaking";
                }
                BtnResume.Enabled = false;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDocFile = new OpenFileDialog();

            openDocFile.Filter = "Text files (*.txt)|*.txt|E Book(*.epub)|*.epub|All files (*.*)|*.*";
            openDocFile.FilterIndex = 3;
            openDocFile.RestoreDirectory = true;

            if (openDocFile.ShowDialog() == DialogResult.OK)
            {
                if (openDocFile.FileName.Contains(".epub"))
                {
                    Epub EbookPath = new Epub(openDocFile.FileName);
                    try
                    {
                        txtBoxLarge.Text = EbookPath.GetContentAsPlainText();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        txtBoxLarge.Text = File.ReadAllText(openDocFile.FileName.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxLarge.Text.Length > 0)
                {
                    speech = new SpeechSynthesizer();
                    //SpeechAudioFormatInfo FormatInfo = new SpeechAudioFormatInfo(6, AudioBitsPerSample.Sixteen, AudioChannel.Mono);

                    if (ComboBoxVoices.SelectedIndex != -1)
                    {
                        speech.SelectVoice(ComboBoxVoices.SelectedItem.ToString());

                        speech.Rate = trackBarSpeechRate.Value;
                        speech.Volume = trackBarVolume.Value;

                        SaveFileDialog savefile = new SaveFileDialog();
                        // set filters - this can be done in properties as well
                        savefile.Filter = "Wave Files (*.wav)|*.wav|All files (*.*)|*.*";

                        if (savefile.ShowDialog() == DialogResult.OK)
                        {
                            speech.SetOutputToWaveFile(savefile.FileName);
                            speech.SpeakAsync(txtBoxLarge.Text);
                            MessageBox.Show("File saved in .wav format.", "Save Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("Select a voice first.", "Select a voice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter some text in the textbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewBlogSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Visit : http:\\www.sarfarazit.wordpress.com to know more.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Check this link for the code.", "Sarfaraz's Blog Posts", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, "https://sarfarazit.wordpress.com/2016/05/14/text-to-speech-reader/");
        }

        private void ComboBoxVoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            var voice = ComboBoxVoices.SelectedItem as String;
            if (voice != null)
            {
                speech.SelectVoice(voice);
            }
        }

        private void PopulateInstalledVoices()
        {
            foreach (InstalledVoice voice in speech.GetInstalledVoices())
            {
                VoiceInfo info = voice.VoiceInfo;
                ComboBoxVoices.Items.Add(info.Name);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
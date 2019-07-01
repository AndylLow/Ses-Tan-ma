using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace Ses_Tanıma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public SpeechRecognitionEngine recognitionEngine = new SpeechRecognitionEngine();
        private void pictureBoxMic_Click(object sender, EventArgs e)
        {
            pictureBoxMic.Visible = false;
            pictureBoxPause.Visible = true;
            recognitionEngine.RecognizeAsync();
        }

        private void pictureBoxPause_Click(object sender, EventArgs e)
        {
            pictureBoxPause.Visible = false;
            pictureBoxMic.Visible = true;
            recognitionEngine.RecognizeAsyncCancel();
        }
        public void sestanima_ayarlar()
        {
            string[] ihtimaller = { "merhaba", "Dünya" };
            Choices seçenekler = new Choices(ihtimaller);
            Grammar grammar = new Grammar(new GrammarBuilder(seçenekler));
            recognitionEngine.LoadGrammar(grammar);
            recognitionEngine.SetInputToDefaultAudioDevice();
            recognitionEngine.SpeechRecognized += ses_tanindiginda;
        }

        private void ses_tanindiginda(object sender, SpeechRecognizedEventArgs e)
        {
            textBox.Text = textBox.Text+" "+e.Result.Text;
        }
    }
}

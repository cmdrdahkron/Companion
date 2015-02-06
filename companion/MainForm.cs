using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace companion
{
    public partial class MainForm : Form
    {
        private Native _engine = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _engine = new Native();
            _engine.Start();
        }

        void InitializeSpeechRecognition()
        {
            //_speech.LoadGrammar(new Grammar(new GrammarBuilder("test")) { Name = "testGrammar" });

            //_speech.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(_SpeechRecognized);
            //_speech.SpeechHypothesized += new EventHandler<SpeechHypothesizedEventArgs>(_SpeechHypothesized);
            //_speech.SpeechRecognitionRejected += new EventHandler<SpeechRecognitionRejectedEventArgs>(_SpeechRejected);

            //_speech.SetInputToDefaultAudioDevice();
            //_speech.RecognizeAsync(RecognizeMode.Multiple);
        }

        void InitializeScripting()
        {
            //using (var runtime = new LuaRuntime())
            //{
            //    using (var fn = runtime.CreateFunctionFromDelegate(new Func<int, int>(x => x * x)))
            //    {
            //        runtime.Globals["square"] = fn;
            //    }

            //    runtime.DoString("print(square(4))").Dispose();
            //}
        }
    }
}

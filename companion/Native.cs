using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using IronRuby;
using IronRuby.Builtins;
using Microsoft.Scripting.Hosting;
using System.IO;

namespace companion {
  class Native {
    public SpeechRecognitionEngine speechEngine = null;
    public ScriptEngine            scriptEngine = null;

    public FileSystemWatcher fileSystemWatcher = null;

    public Dictionary<string, object> vars = null;

    public Native() {

    }

    public void Reload() {
      System.Console.WriteLine("Reloading...");

      speechEngine.UnloadAllGrammars();
      scriptEngine.ExecuteFile("main.rb");
    }

    public void On(String pattern, RubyArray values) {
      System.Console.WriteLine("Registering pattern: " + pattern);
    }

    public void Play(String filename) {

    }

    public void Press() {

    }

    public void Click() {

    }

    private void CreateSpeechEngine() {
      speechEngine = new SpeechRecognitionEngine();
    }

    private void CreateScriptEngine() {
      vars = new Dictionary<string, object>();

      scriptEngine = Ruby.CreateEngine();

#if DEBUG
      string baseDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..");
#else
      string baseDir = AppDomain.CurrentDomain.BaseDirectory;
#endif

      string rubylibDir = Path.Combine(baseDir, "rubylib");
      string scriptsDir = Path.Combine(baseDir, "scripts");

      List<string> searchPaths = new List<string>();
      // searchPaths.Add(baseDir);
      searchPaths.Add(Path.Combine(rubylibDir, "IronRuby"));
      searchPaths.Add(Path.Combine(rubylibDir, "ruby", "site_ruby", "1.9.1"));
      searchPaths.Add(Path.Combine(rubylibDir, "ruby", "site_ruby"));
      searchPaths.Add(Path.Combine(rubylibDir, "ruby", "1.9.1"));
      // searchPaths.Add(Path.Combine(rubylibDir, "vendor"));
      scriptEngine.SetSearchPaths(searchPaths);

      scriptEngine.Runtime.Globals.SetVariable("Native", this);

      fileSystemWatcher = new FileSystemWatcher(baseDir, rubylibDir);
      fileSystemWatcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
      fileSystemWatcher.IncludeSubdirectories = true;
      fileSystemWatcher.Filter = "*.rb";
      fileSystemWatcher.Changed += fileSystemWatcher_Changed;
      fileSystemWatcher.Created += fileSystemWatcher_Created;
      fileSystemWatcher.Deleted += fileSystemWatcher_Deleted;
      fileSystemWatcher.Renamed += fileSystemWatcher_Renamed;
      fileSystemWatcher.EnableRaisingEvents = true;
    }

    void fileSystemWatcher_Renamed(object sender, RenamedEventArgs e) {
      Reload();
    }

    void fileSystemWatcher_Deleted(object sender, FileSystemEventArgs e) {
      Reload();
    }

    void fileSystemWatcher_Created(object sender, FileSystemEventArgs e) {
      Reload();
    }

    void fileSystemWatcher_Changed(object sender, FileSystemEventArgs e) {
      Reload();
    }

    public void Start() {
      CreateSpeechEngine();
      CreateScriptEngine();

      Reload();
    }

    void _SpeechRecognized(object sender, SpeechRecognizedEventArgs e) {
    }

    void _SpeechHypothesized(object sender, SpeechHypothesizedEventArgs e) {
    }

    void _SpeechRejected(object sender, SpeechRecognitionRejectedEventArgs e) {
    }
  }
}

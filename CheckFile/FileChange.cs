using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckFile
{
    internal class FileChange
    {
        public readonly FileSystemWatcher watcher;
        public FileChange()
        {
            watcher = new FileSystemWatcher("C:\\folder2\\CheckFile\\CheckFile", "*.json");
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Changed += OnChanged;
            watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            var jsonString = new JsonReader().Read();

            var data = new MySerialization().SerializeTo(jsonString);
           e.
            PrintMessage.Print("some message", data);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckFile
{
    internal class JsonReader
    {
        private string _path = "C:\\folder2\\CheckFile\\CheckFile\\Configuration.json";

        public string Read()
        {
            using (StreamReader sr = new StreamReader(_path))
            {
                var result = "";
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    result += line;
                }
                return result;
            }
        }
    }
}

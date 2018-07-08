using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterInfo
{
   public class CsvReader
    {
        public string[] Readdecomp()
        {

            List<string> characters = new List<string>();
            return Properties.Resources.decomp.Split(Environment.NewLine[0]);
        }
        public string[] ReaddecompT()
        {

            List<string> characters = new List<string>();
            return Properties.Resources.decompT.Split(new[] { "\r\n", "\r", "\n" },StringSplitOptions.None);
        }
        public string[] Readadjlist()
        {

            List<string> characters = new List<string>();
            return Properties.Resources.AdjList.Split(Environment.NewLine[0]);
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRuneterraDataDragon.JsonPattern;

namespace TestRuneterraDataDragon
{
    internal class Util
    {
        public static bool GetGlobalData(out Dictionary<string, Global> globals)
        {
            // TODO: 毎回アクセスするのではなく、既に取得していたらその内容を返すように

            // グローバルのメタデータを収集する
            string filePath = Properties.Settings.Default.CoreDataFilePath;
            string globalMetaJson = File.ReadAllText(filePath);
            Metadata metadata = JsonConvert.DeserializeObject<Metadata>(globalMetaJson);

            // グローバルのデータを収集する
            Dictionary<string, Global> globalDictionary = new Dictionary<string, Global>();
            foreach (var locale in metadata.locales)
            {
                string separator = Path.DirectorySeparatorChar.ToString();
                string globalPath = Path.GetDirectoryName(filePath) + separator + locale + separator + "data" + separator + "globals-" + locale + ".json";
                string globalJson = File.ReadAllText(globalPath);
                Global global = JsonConvert.DeserializeObject<Global>(globalJson);
                globalDictionary.Add(locale, global);
            }

            globals = globalDictionary;
            return true;
        }

        public static bool GetSet1Data(out Dictionary<string, Set1> set1s)
        {
            // TODO: 毎回アクセスするのではなく、既に取得していたらその内容を返すように

            // Set1のメタデータを収集する
            string filePath = Properties.Settings.Default.SetDataFilePath;
            string setMetaJson = File.ReadAllText(filePath);
            Metadata metadata = JsonConvert.DeserializeObject<Metadata>(setMetaJson);

            // Set1のデータを収集する
            Dictionary<string, Set1> set1Dictionary = new Dictionary<string, Set1>();
            foreach (var locale in metadata.locales)
            {
                string separator = Path.DirectorySeparatorChar.ToString();
                string setPath = Path.GetDirectoryName(filePath) + separator + locale + separator + "data" + separator +
                                 "set1-" + locale + ".json";
                string setJson = File.ReadAllText(setPath);
                Set1 set1 = JsonConvert.DeserializeObject<Set1>(setJson);
                set1Dictionary.Add(locale, set1);
            }

            set1s = set1Dictionary;
            return true;
        }
    }
}

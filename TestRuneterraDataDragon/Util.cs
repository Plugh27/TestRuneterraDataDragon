using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoRDeckCodes;
using TestRuneterraDataDragon.JsonPattern;

namespace TestRuneterraDataDragon
{
    internal class Util
    {
        public static string JapaneseCode = "ja_jp";
        public static string EnglishCode = "en_us";

        private static string _userDecksFilePath = "UserDecks.json";
        private static string _userInputDataFilePath = "UserInputData.json";

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

        public static bool GetGlobalData(out Global global, string locale)
        {
            GetGlobalData(out Dictionary<string, Global> globals);
            global = globals[locale]; // TODO: エラー処理

            return true;
        }

        public static bool GetCardInfosDictionary(out Dictionary<string, List<CardInfo>> cardInfosDictionary)
        {
            // TODO: 毎回アクセスするのではなく、既に取得していたらその内容を返すように

            // Set1のメタデータを収集する
            string filePath = Properties.Settings.Default.SetDataFilePath;
            string setMetaJson = File.ReadAllText(filePath);
            Metadata metadata = JsonConvert.DeserializeObject<Metadata>(setMetaJson);

            // Set1のデータを収集する
            Dictionary<string, List<CardInfo>> tempDicstionary = new Dictionary<string, List<CardInfo>>();
            foreach (var locale in metadata.locales)
            {
                string separator = Path.DirectorySeparatorChar.ToString();
                string setPath = Path.GetDirectoryName(filePath) + separator + locale + separator + "data" + separator +
                                 "set1-" + locale + ".json";

                string setJson = File.ReadAllText(setPath);
                List<CardInfo> cardInfos = JsonConvert.DeserializeObject<List<CardInfo>>(setJson);
                tempDicstionary.Add(locale, cardInfos);
            }

            cardInfosDictionary = tempDicstionary;
            return true;
        }

        public static bool GetCardInfos(out List<CardInfo> cardInfos, string locale)
        {
            GetCardInfosDictionary(out var cardInfosDictionary);
            cardInfos = cardInfosDictionary[locale]; // TODO: エラー処理

            return true;
        }

        public static CardInfo GetCardInfoFromCardCodeAndCount(List<CardInfo> cardInfos,
            CardCodeAndCount cardCodeAndCount)
        {
            CardInfo cardInfo = cardInfos.FirstOrDefault(s => s.cardCode == cardCodeAndCount.CardCode);
            if (cardInfo == null)
            {
                // TODO: アサート
                return null;
            }

            return cardInfo;
        }

        public static CardCodeAndCount GetCardCodeAndCountFromCardInfo(List<CardCodeAndCount> cardCodeAndCounts,
            CardInfo cardInfo)
        {
            CardCodeAndCount cardCodeAndCount = cardCodeAndCounts.FirstOrDefault(s => s.CardCode == cardInfo.cardCode);
            if (cardCodeAndCount == null)
            {
                // TODO: アサート
                return null;
            }

            return cardCodeAndCount;
        }

        public static string GetImageFilePath(CardInfo cardInfo, string locale)
        {
            string metaFileDir = Path.GetDirectoryName(Properties.Settings.Default.SetDataFilePath);
            string separator = Path.DirectorySeparatorChar.ToString();
            string cardImageDir = metaFileDir + separator + locale + separator + "img" + separator + "cards" + separator;

            string cardImageFileName = Path.GetFileName(cardInfo.assets[0].gameAbsolutePath);
            return cardImageDir + cardImageFileName;
        }

        public static List<DeckAndName> GetDeckAndNameList() // TODO: 名前をファイル由来っぽく
        {
            // ファイルが存在しなければ空のリストを返す
            if (!File.Exists(_userDecksFilePath))
            {
                return new List<DeckAndName>();
            }

            // ファイルの情報をリストに変換して返す
            var json = File.ReadAllText(_userDecksFilePath);
            return JsonConvert.DeserializeObject<List<DeckAndName>>(json);
        }

        public static void SetDeckAndNameList(List<DeckAndName> deckAndNameList) // TODO: 名前をファイル由来っぽく
        {
            var json = JsonConvert.SerializeObject(deckAndNameList, Formatting.Indented);
            File.WriteAllText(_userDecksFilePath, json);
        }

        public static List<UserInputData> GetUserInputDatasFromJsonFile()
        {
            // ファイルが存在しなければ空のリストを返す
            if (!File.Exists(_userInputDataFilePath))
            {
                return new List<UserInputData>();
            }

            // ファイルの情報をリストに変換して返す
            var json = File.ReadAllText(_userInputDataFilePath);
            return JsonConvert.DeserializeObject<List<UserInputData>>(json);
        }

        public static void SetupUserInputDatasToJsonFile(List<UserInputData> userInputDatas)
        {
            var json = JsonConvert.SerializeObject(userInputDatas, Formatting.Indented);
            File.WriteAllText(_userInputDataFilePath, json);
        }
    }
}

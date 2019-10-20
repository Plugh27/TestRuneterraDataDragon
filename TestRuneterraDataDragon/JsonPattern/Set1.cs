using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRuneterraDataDragon.JsonPattern
{
    public class Asset
    {
        public string gameAbsolutePath { get; set; }
        public string fullAbsolutePath { get; set; }
    }

    public class CardInfo
    {
        public List<string> associatedCards { get; set; }
        public List<string> associatedCardRefs { get; set; }
        public List<Asset> assets { get; set; }
        public string region { get; set; }
        public string regionRef { get; set; }
        public int attack { get; set; }
        public int cost { get; set; }
        public int health { get; set; }
        public string description { get; set; }
        public string descriptionRaw { get; set; }
        public string flavorText { get; set; }
        public string artistName { get; set; }
        public string name { get; set; }
        public string cardCode { get; set; }
        public List<string> keywords { get; set; }
        public List<string> keywordRefs { get; set; }
        public string spellSpeed { get; set; }
        public string spellSpeedRef { get; set; }
        public string rarity { get; set; }
        public string rarityRef { get; set; }
        public string subtype { get; set; }
        public string supertype { get; set; }
        public string type { get; set; }
        public bool collectible { get; set; }
    }

    public class Set1
    {
        public List<CardInfo> cardInfos { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRuneterraDataDragon.JsonPattern
{
    public class Keyword
    {
        public string description { get; set; }
        public string name { get; set; }
        public string nameRef { get; set; }
    }

    public class Region
    {
        public string abbreviation { get; set; }
        public string iconAbsolutePath { get; set; }
        public string name { get; set; }
        public string nameRef { get; set; }
    }

    public class SpellSpeed
    {
        public string name { get; set; }
        public string nameRef { get; set; }
    }

    public class Rarity
    {
        public string name { get; set; }
        public string nameRef { get; set; }
    }

    public class Global
    {
        public List<Keyword> keywords { get; set; }
        public List<Region> regions { get; set; }
        public List<SpellSpeed> spellSpeeds { get; set; }
        public List<Rarity> rarities { get; set; }
    }
}

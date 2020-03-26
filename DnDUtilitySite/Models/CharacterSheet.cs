using System.Collections.Generic;
using System.Linq;

namespace DnDUtilitySite.Models
{
    public class CharacterSheet
    {
        public string Name { get; set; }
        public Dictionary<CharacterClass, int> ClassLevels { get; set; }
        public int OverallLevel => ClassLevels.Values.Sum();

        public DnDStat BaseStrengthStat { get; set; }
        public DnDStat BaseConstitutionStat { get; set; }
        public DnDStat BaseDexterityStat { get; set; }
        public DnDStat BaseIntelligenceStat { get; set; }
        public DnDStat BaseWisdomStat { get; set; }
        public DnDStat BaseCharismaStat { get; set; }

        public string GetClassesAsString()
        {
            return string.Join("\n",
                ClassLevels.Select(charClass => $"{charClass.Key}: {charClass.Value}"));
        }
    }
}
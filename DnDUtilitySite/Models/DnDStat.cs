namespace DnDUtilitySite.Models
{
    /// <summary>
    /// Mutable stats for players.
    /// </summary>
    public struct DnDStat
    {
        public StatTypes Stat { get; set; }
        public int BaseStat { get; set; }

        public int ModifierStat
        {
            get
            {
                switch (BaseStat)
                {
                    case 1:
                        return -5;
                    case 2:
                    case 3:
                        return -4;
                    case 4:
                    case 5:
                        return -3;
                    case 6:
                    case 7:
                        return -2;
                    case 8:
                    case 9:
                        return -1;
                    case 10:
                    case 11:
                        return 0;
                    case 12:
                    case 13:
                        return 1;
                    case 14:
                    case 15:
                        return 2;
                    case 16:
                    case 17:
                        return 3;
                    case 18:
                    case 19:
                        return 4;
                    case 20:
                        return 5;
                    default:
                        return 0;
                }
            }
        }

        public string ModifierDisplay => DnDUtility.DisplayModifier(ModifierStat);
    }

    /// <summary>
    /// Enumeration of available stat types.
    /// </summary>
    public enum StatTypes
    {
        Strength,
        Constitution,
        Dexterity,
        Intelligence,
        Wisdom,
        Charisma
    }
}
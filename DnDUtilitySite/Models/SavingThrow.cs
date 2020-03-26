using System;

namespace DnDUtilitySite.Models
{
    public class SavingThrow
    {
        public string Name => Stat.ToString();

        public StatTypes Stat { get; set; }

        public bool IsProficient { get; set; }

        public int GetModifier(DnDStat playerStat, int proficiencyBonus)
        {
            if (playerStat.Stat != Stat)
            {
                throw new ArgumentException(
                    $"Invalid player stat! They need to be the same stat type! Input Stat: {playerStat.Stat} Expected: {Stat}");
            }

            return playerStat.ModifierStat + (IsProficient ? proficiencyBonus : 0);
        }
    }
}
using System;

namespace DnDUtilitySite.Models
{
    public class PlayerSkill
    {
        public Skill RelevantSkill { get; set; }

        public bool IsProficient { get; set; }

        public string Name => RelevantSkill.Name;

        public StatTypes ApplicableStat => RelevantSkill.ApplicableStat;
        
        public int GetModifier(DnDStat playerStat, int proficiencyBonus)
        {
            if (playerStat.Stat != ApplicableStat)
            {
                throw new ArgumentException(
                    $"Invalid player stat! They need to be the same stat type! Input Stat: {playerStat.Stat} Expected: {RelevantSkill.ApplicableStat}");
            }

            return playerStat.ModifierStat + (IsProficient ? proficiencyBonus : 0);
        }
    }
}
using System;

namespace DnDUtilitySite.Models
{
    public class Skill
    {
        public SkillTypes SkillType { get; set; }

        public string Name => SkillType.ToString();

        public StatTypes ApplicableStat => LookupApplicableStat(SkillType);

        private static StatTypes LookupApplicableStat(SkillTypes skillType)
        {
            switch (skillType)
            {
                case SkillTypes.Acrobatics:
                case SkillTypes.SleightOfHand:
                case SkillTypes.Stealth:
                    return StatTypes.Dexterity;

                case SkillTypes.AnimalHandling:
                case SkillTypes.Insight:
                case SkillTypes.Medicine:
                case SkillTypes.Perception:
                case SkillTypes.Survival:
                    return StatTypes.Wisdom;

                case SkillTypes.Arcana:
                case SkillTypes.History:
                case SkillTypes.Investigation:
                case SkillTypes.Nature:
                case SkillTypes.Religion:
                    return StatTypes.Intelligence;

                case SkillTypes.Athletics:
                    return StatTypes.Strength;

                case SkillTypes.Deception:
                case SkillTypes.Intimidation:
                case SkillTypes.Persuasion:
                    return StatTypes.Charisma;

                default:
                    throw new ArgumentOutOfRangeException(nameof(skillType), skillType, null);
            }
        }
    }

    public enum SkillTypes
    {
        Acrobatics,
        AnimalHandling,
        Arcana,
        Athletics,
        Deception,
        History,
        Insight,
        Intimidation,
        Investigation,
        Medicine,
        Nature,
        Perception,
        Persuasion,
        Religion,
        SleightOfHand,
        Stealth,
        Survival
    }
}
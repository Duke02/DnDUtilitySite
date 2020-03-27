using System.Collections.Generic;
using System.Linq;
using DnDUtilitySite.Models;
using Microsoft.AspNetCore.Mvc;

namespace DnDUtilitySite.Controllers
{
    public class CharacterSheetController : Controller
    {
        private readonly CharacterSheet _defaultCharacterSheet;

        public Dictionary<SkillTypes, Skill> AvailableSkills { get; private set; }

        public CharacterSheetController() : base()
        {
            var skillTypes = new List<SkillTypes>()
            {
                SkillTypes.Acrobatics, SkillTypes.Arcana, SkillTypes.Athletics, SkillTypes.Deception,
                SkillTypes.History, SkillTypes.Insight, SkillTypes.Intimidation, SkillTypes.Investigation,
                SkillTypes.Medicine, SkillTypes.Nature, SkillTypes.Perception, SkillTypes.Persuasion,
                SkillTypes.Religion, SkillTypes.Stealth, SkillTypes.Survival, SkillTypes.AnimalHandling,
                SkillTypes.SleightOfHand, SkillTypes.Performance
            };

            var skills = skillTypes.Select(skillType => new Skill() {SkillType = skillType});

            AvailableSkills = skills.ToDictionary(skill => skill.SkillType);

            var savingThrows = new List<SavingThrow>()
            {
                new SavingThrow() {IsProficient = false, Stat = StatTypes.Strength},
                new SavingThrow() {IsProficient = true, Stat = StatTypes.Dexterity},
                new SavingThrow() {IsProficient = true, Stat = StatTypes.Constitution},
                new SavingThrow() {IsProficient = true, Stat = StatTypes.Intelligence},
                new SavingThrow() {IsProficient = false, Stat = StatTypes.Wisdom},
                new SavingThrow() {IsProficient = true, Stat = StatTypes.Charisma}
            };

            var playerSkills = new List<PlayerSkill>()
            {
                new PlayerSkill() {RelevantSkill = AvailableSkills[SkillTypes.Acrobatics], IsProficient = false},
                new PlayerSkill() {RelevantSkill = AvailableSkills[SkillTypes.AnimalHandling], IsProficient = false},
                new PlayerSkill() {RelevantSkill = AvailableSkills[SkillTypes.Arcana], IsProficient = true},
                new PlayerSkill() {RelevantSkill = AvailableSkills[SkillTypes.Athletics], IsProficient = false},
                new PlayerSkill() {RelevantSkill = AvailableSkills[SkillTypes.Deception], IsProficient = true},
                new PlayerSkill() {RelevantSkill = AvailableSkills[SkillTypes.History], IsProficient = true},
                new PlayerSkill() {RelevantSkill = AvailableSkills[SkillTypes.Insight], IsProficient = false},
                new PlayerSkill() {RelevantSkill = AvailableSkills[SkillTypes.Intimidation], IsProficient = false},
                new PlayerSkill() {RelevantSkill = AvailableSkills[SkillTypes.Investigation], IsProficient = false},
                new PlayerSkill() {RelevantSkill = AvailableSkills[SkillTypes.Medicine], IsProficient = false},
                new PlayerSkill() {RelevantSkill = AvailableSkills[SkillTypes.Nature], IsProficient = false},
                new PlayerSkill() {RelevantSkill = AvailableSkills[SkillTypes.Perception], IsProficient = false},
                new PlayerSkill() {RelevantSkill = AvailableSkills[SkillTypes.Performance], IsProficient = true},
                new PlayerSkill() {RelevantSkill = AvailableSkills[SkillTypes.Persuasion], IsProficient = true},
                new PlayerSkill() {RelevantSkill = AvailableSkills[SkillTypes.Religion], IsProficient = false},
                new PlayerSkill() {RelevantSkill = AvailableSkills[SkillTypes.SleightOfHand], IsProficient = false},
                new PlayerSkill() {RelevantSkill = AvailableSkills[SkillTypes.Stealth], IsProficient = false},
                new PlayerSkill() {RelevantSkill = AvailableSkills[SkillTypes.Survival], IsProficient = false}
            };

            _defaultCharacterSheet = new CharacterSheet()
            {
                Name = "Tantris",
                ClassLevels = new Dictionary<CharacterClass, int>()
                {
                    {CharacterClass.AvailableClasses.Fighter, 1},
                    {CharacterClass.AvailableClasses.Sorcerer, 3}
                },
                BaseStrengthStat = new DnDStat() {Stat = StatTypes.Strength, BaseStat = 10},
                BaseCharismaStat = new DnDStat() {Stat = StatTypes.Charisma, BaseStat = 18},
                BaseConstitutionStat = new DnDStat() {Stat = StatTypes.Constitution, BaseStat = 14},
                BaseDexterityStat = new DnDStat() {Stat = StatTypes.Dexterity, BaseStat = 15},
                BaseIntelligenceStat = new DnDStat() {Stat = StatTypes.Intelligence, BaseStat = 16},
                BaseWisdomStat = new DnDStat() {Stat = StatTypes.Wisdom, BaseStat = 6},

                ProficiencyBonus = 2,
                SavingThrows = savingThrows,
                Skills = playerSkills
            };
        }

        // GET
        public IActionResult Index()
        {
            return View(_defaultCharacterSheet);
        }
    }
}
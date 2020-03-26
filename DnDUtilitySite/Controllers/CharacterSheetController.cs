using System.Collections.Generic;
using DnDUtilitySite.Models;
using Microsoft.AspNetCore.Mvc;

namespace DnDUtilitySite.Controllers
{
    public class CharacterSheetController : Controller
    {
        private readonly CharacterSheet _defaultCharacterSheet;

        public CharacterSheetController() : base()
        {
            _defaultCharacterSheet = new CharacterSheet()
            {
                Name = "Kildrik",
                ClassLevels = new Dictionary<CharacterClass, int>()
                {
                    {CharacterClass.AvailableClasses.Ranger, 1},
                    {CharacterClass.AvailableClasses.Sorcerer, 3}
                },
                BaseStrengthStat = new DnDStat() {Stat = StatTypes.Strength, BaseStat = 14},
                BaseCharismaStat = new DnDStat() {Stat = StatTypes.Charisma, BaseStat = 8},
                BaseConstitutionStat = new DnDStat() {Stat = StatTypes.Constitution, BaseStat = 17},
                BaseDexterityStat = new DnDStat() {Stat = StatTypes.Dexterity, BaseStat = 16},
                BaseIntelligenceStat = new DnDStat() {Stat = StatTypes.Intelligence, BaseStat = 4},
                BaseWisdomStat = new DnDStat() {Stat = StatTypes.Wisdom, BaseStat = 9},
                ProficiencyBonus = 2,
                SavingThrows = new List<SavingThrow>()
                {
                    new SavingThrow() {IsProficient = true, Stat = StatTypes.Charisma},
                    new SavingThrow() {IsProficient = false, Stat = StatTypes.Wisdom},
                    new SavingThrow() {IsProficient = true, Stat = StatTypes.Constitution},
                    new SavingThrow() {IsProficient = false, Stat = StatTypes.Dexterity},
                    new SavingThrow() {IsProficient = true, Stat = StatTypes.Strength},
                    new SavingThrow() {IsProficient = false, Stat = StatTypes.Intelligence}
                }
            };
        }

        // GET
        public IActionResult Index()
        {
            return View(_defaultCharacterSheet);
        }
    }
}
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
                    {CharacterClass.AvailableClasses.Ranger, 1}
                },
                BaseStrengthStat = new DnDStat() {StatName = "Strength", BaseStat = 14},
                BaseCharismaStat = new DnDStat() {StatName = "Charisma", BaseStat = 8},
                BaseConstitutionStat = new DnDStat() {StatName = "Constitution", BaseStat = 17},
                BaseDexterityStat = new DnDStat(){StatName = "Dexterity", BaseStat = 16},
                BaseIntelligenceStat = new DnDStat() {StatName = "Intelligence", BaseStat = 4},
                BaseWisdomStat = new DnDStat(){StatName = "Wisdom", BaseStat = 9}
            };
        }

        // GET
        public IActionResult Index()
        {
            return View(_defaultCharacterSheet);
        }
    }
}
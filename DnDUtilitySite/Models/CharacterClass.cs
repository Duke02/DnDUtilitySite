using System;

namespace DnDUtilitySite.Models
{
    public class CharacterClass
    {
        public class AvailableClasses
        {
            public static readonly CharacterClass Ranger = new CharacterClass("Ranger");
            public static readonly CharacterClass Barbarian = new CharacterClass("Barbarian");
            public static readonly CharacterClass Wizard = new CharacterClass("Wizard");
            public static readonly CharacterClass Sorcerer = new CharacterClass("Sorcerer");
            public static readonly CharacterClass Monk = new CharacterClass("Monk");
        }

        private CharacterClass(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Class {Name}";
        }
    }
}
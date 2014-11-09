using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetManager.Models
{
    public static class BasicCharacteristics
    {
        public static Dictionary<string, Ability> Abilities;
        public static Dictionary<string, Skill> Skills;
        public static Dictionary<string, SavingThrow> SavingThrows;
        public static Dictionary<string, Dictionary<string, ushort>> BaseSaves;

        private static short _spellResistance;
        public static short SpellResistance
        {
            set { _spellResistance = value; }
            get { return _spellResistance; }
        }

        private static short _sizeModifier;
        public static short SizeModifier
        {
            set { _sizeModifier = value; }
            get { return _sizeModifier; }
        }

        private static short _grappleBonus;
        public static short GrappleBonus
        {
            set { _grappleBonus = value; }
            get { return _grappleBonus; }
        }
        private static short _grappleModifier;
        public static short GrappleModifier
        {
            set { _grappleModifier = value; }
            get { return (short)(_grappleModifier + _sizeModifier + _grappleBonus); }
        }

        private static short _baseAttackBonus;
        public static short BaseAttackBonus
        {
            set { _baseAttackBonus = value; }
            get { return _baseAttackBonus; }
        }

        private static short _level;
        public static short Level
        {
            set { _level = value; }
            get { return _level; }
        }

        private static string _class;
        public static string Class
        {
            set { _class = value; }
            get { return _class; }
        }
    }
}

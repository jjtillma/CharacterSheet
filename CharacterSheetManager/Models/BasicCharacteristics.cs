using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetManager.Models
{
    public  class BasicCharacteristics
    {

        public BasicCharacteristics()
        {

        }
        public  Dictionary<string, Ability> Abilities;
        public  Dictionary<string, Skill> Skills;
        public  Dictionary<string, SavingThrow> SavingThrows;
        public  Dictionary<string, Dictionary<string, ClassAndRaceTraits>> ClassAndRaceFeatures;

        private short _spellResistance;
        public short SpellResistance
        {
            set { _spellResistance = value; }
            get { return _spellResistance; }
        }

        private short _sizeModifier;
        public short SizeModifier
        {
            set { _sizeModifier = value; }
            get { return _sizeModifier; }
        }

        private  short _grappleBonus;
        public  short GrappleBonus
        {
            set { _grappleBonus = value; }
            get { return _grappleBonus; }
        }
        private  short _grappleModifier;
        public  short GrappleModifier
        {
            set { _grappleModifier = value; }
            get { return (short)(_grappleModifier + _sizeModifier + _grappleBonus); }
        }

        private List<ushort> _baseAttackBonus;
        public List<ushort> BaseAttackBonus
        {
            get { return _baseAttackBonus; }
        }

        private short _level;
        public short Level
        {
            get { return _level; }
        }

        private uint _xp;
        public uint XP
        {
            set { _xp = value; }
            get { return _xp; }
        }

        private string _class;
        public string Class
        {
            set { _class = value; }
            get { return _class; }
        }

        private ushort _naturalArmorBonus;
        public ushort NaturalArmorBonus
        {
            set { _naturalArmorBonus = value; }
            get { return _naturalArmorBonus; }
        }
    }
}

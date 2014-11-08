using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetManager.Models
{
    public class BasicCharacteristics
    {

        private byte _spellResistance;
        public byte SpellResistance
        {
            set { _spellResistance = value; }
            get { return _spellResistance; }
        }

        private byte _sizeModifier;
        public byte SizeModifier
        {
            set { _sizeModifier = value; }
            get { return _sizeModifier; }
        }

        private byte _grappleBonus;
        public byte GrappleBonus
        {
            set { _grappleBonus = value; }
            get { return _grappleBonus; }
        }
        private byte _grappleModifier;
        public byte GrappleModifier
        {
            set { _grappleModifier = value; }
            get { return (byte)(_grappleModifier + _sizeModifier + _grappleBonus); }
        }

        private byte _baseAttackBonus;
        public byte BaseAttackBonus
        {
            set { _baseAttackBonus = value; }
            get { return _baseAttackBonus; }
        }
    }
}

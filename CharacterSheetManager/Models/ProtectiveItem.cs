using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetManager.Models
{
    public class ProtectiveItem : Item
    {
        private bool _masterwork;
        public bool Masterwork
        {
            set { _masterwork = value; }
            get { return _masterwork; }
        }
        private ushort _enhancementACBonus;
        public ushort EnhancementACBonus
        {
            set { _enhancementACBonus = value; }
            get { return _enhancementACBonus; }
        }

        private short _spellFailurePercent;
        public short SpellFailurePercent
        {
            set { _spellFailurePercent = value; }
            get { return _spellFailurePercent; }
        }

        private short _acBonus;
        public short ACBonus
        {
            get { return _acBonus; }
        }

        private string _armorType = string.Empty;
        public string ArmorType
        {
            set { _armorType = value; }
            get { return _armorType; }
        }

        private ushort _armorCheckPenalty;
        public ushort ArmorCheckPenalty
        {
            set { _armorCheckPenalty = value; }
            get { return _armorCheckPenalty; }
        }

        private ushort _maxSpeed;
        public ushort MaxSpeed
        {
            set { _maxSpeed = value; }
            get { return _maxSpeed; }
        }

        private ushort _maxDexBonus;
        public ushort MaxDexterityBonus
        {
            set { _maxDexBonus = value; }
            get { return _maxDexBonus; }
        }
    }
}

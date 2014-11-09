using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetManager.Models
{
    public class Weapon : Item
    {
        private bool _masterwork;
        public bool Masterwork
        {
            set { _masterwork = value; }
            get { return _masterwork; }
        }
        private ushort _enhancementAttackBonus;
        public ushort EnhancementAttackBonus
        {
            set { _enhancementAttackBonus = value; }
            get { return _enhancementAttackBonus; }
        }

        private short _miscAttackBonus;
        public short MiscellaneousAttackBonus
        {
            set { _miscAttackBonus = value; }
            get { return _miscAttackBonus; }
        }

        private short _totalAttack;
        public short TotalAttack
        {
            get { return _totalAttack; }
        }

        private ushort _rangeIncrement;
        public ushort RangeIncrement
        {
            set { _rangeIncrement = value; }
            get { return _rangeIncrement; }
        }

        private string _gripType = string.Empty;
        public string GripType
        {
            set { _gripType = value; }
            get { return _gripType; }
        }

        private string _weaponType = string.Empty;
        public string WeaponType
        {
            set { _weaponType = value; }
            get { return _weaponType; }
        }

        private string _damageRoll = string.Empty;
        public string DamageRoll
        {
            set { _damageRoll = value; }
            get { return _damageRoll; }
        }

    }
}

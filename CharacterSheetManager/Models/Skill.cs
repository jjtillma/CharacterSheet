using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetManager.Models
{
    public class Skill : ModelBase
    {
        Skill(string name)
        {
            if(string.IsNullOrEmpty(name) == true)
            {
                throw new InvalidOperationException();
            }
            _name = name;
        }

        private readonly string _name = string.Empty;
        public string Name
        {
            get { return _name; }
        }

        public short Total
        {
            get { return (short)(Ranks + ModifierBonus + ClassBonus + RacialBonus + ArmorPenalty); }
        }

        private short _ranks;
        public short Ranks
        {
            set { _ranks = value; }
            get { return _ranks; }
        }
        private short _modifierBonus;
        public short ModifierBonus
        {
            set { _modifierBonus = value; }
            get { return _modifierBonus; }
        }
        
        //this will be table look up
        private short _classBonus;
        public short ClassBonus
        {
            get { return _classBonus; }
        }

        //this will be table look up
        private short _racialBonus;
        public short RacialBonus
        {
            get { return _racialBonus; }
        }

        //this will be table look up
        private string _type = string.Empty;
        public string Type
        {
            get { return _type; }
        }

        //this will be taken from another class
        private short _armorPenalty;
        public short ArmorPenalty
        {
            get { return _armorPenalty; }
        }

        //this will be table look up
        private bool _affectedByArmor;
        public bool IsAffectedByArmor
        {
            get { return _affectedByArmor; }
        }

        //this will be table look up
        private bool _isClassSkill;
        public bool IsClassSkill
        {
            get { return _isClassSkill; }
        }

        //this will be table look up
        private bool _isTrainedOnly;
        public bool IsTrainedOnly
        {
            set { _isTrainedOnly = value; }
            get { return _isTrainedOnly; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetManager.Models
{
    public class Skill : ModelBase
    {
        private readonly string _name = string.Empty;
        private readonly string _class = string.Empty;
        private readonly string _race = string.Empty;
        private readonly ClassAndRaceTraits _traits;
        private readonly Dictionary<string, Ability> _abilities;
        public Skill(string name, string charClass, string race, Dictionary<string, Ability> abilities, ClassAndRaceTraits traits)
        {
            _abilities = abilities;
            _name = name;
            _class = charClass;
            _race = race;
            _traits = traits;
        }
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
        public short ClassBonus
        {
            get { return _traits.SkillBonuses.ContainsKey(_class) ? _traits.SkillBonuses[_class] : (short)0; }
        }

        //this will be table look up
        public short RacialBonus
        {
            get { return _traits.SkillBonuses.ContainsKey(_class) ? _traits.SkillBonuses[_class] : (short)0; }
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
        public bool IsClassSkill
        {
            get { return _traits.ClassSkills[_name]; }
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

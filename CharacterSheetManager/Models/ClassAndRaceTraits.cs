using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetManager.Models
{
    public class ClassAndRaceTraits
    {
        private readonly string _className = string.Empty;
        private readonly ushort _classLevel;

        private readonly Dictionary<string, short> _abilityBonuses;
        public Dictionary<string, short> AbilityBonuses
        {
            get { return _abilityBonuses; }
        }

        private Dictionary<string, short> _skillBonuses;
        public Dictionary<string, short> SkillBonuses
        {
            get { return _skillBonuses; }
        }

        private Dictionary<string,short> _savingThrowBonuses;
        public Dictionary<string, short> SaveBonuses
        {
            get { return _savingThrowBonuses; }
        }

        private Dictionary<string, bool> _classSkills;
        public Dictionary<string, bool> ClassSkills
        {
            get { return _classSkills; }
        }

        private Dictionary<string, string> _racialTraits;
        public List<KeyValuePair<string, string>> RacialTraits
        {
            get { return _racialTraits.ToList(); }
        }

        private Dictionary<string, string> _classTraits;
        public List<KeyValuePair<string, string>> ClassTraits
        {
            get { return _classTraits.ToList(); }
        }
    }
}

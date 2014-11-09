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

        private readonly Dictionary<string, ushort> _abilityBonuses;
        public List<KeyValuePair<string, ushort>> AbilityBonuses
        {
            get { return _abilityBonuses.ToList(); }
        }

        private Dictionary<string, ushort> _skillBonuses;
        public List<KeyValuePair<string, ushort>> SkillBonuses
        {
            get { return _skillBonuses.ToList(); }
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

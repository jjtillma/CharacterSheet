using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetManager.Models
{
    public class Ability : ModelBase
    {
        private readonly string _name = string.Empty;
        private readonly string _class = string.Empty;
        private readonly string _race = string.Empty;
        private readonly ClassAndRaceTraits _traits;
        private readonly Dictionary<string, Ability> _abilities;
        public Ability(string name, string charClass, string race, Dictionary<string, Ability> abilities, ClassAndRaceTraits traits)
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

        private short _score;
        public short Score
        {
            set { _score = value; }
            get { return _score; }
        }

        public short Total
        {
            get { return (short)(Modifier + Bonus + TemporaryModifier + ClassBonus + RaceBonus); }
        }

        public short Modifier
        {
            get
            {
                short toReturn;

                if(TemporaryScore != 0 && TemporaryScore != Score)
                {
                    toReturn = (short)(Math.Floor((double)(TemporaryScore / 2)) - 5);
                }
                else
                {
                    toReturn = (short)(Math.Floor((double)(Score / 2)) - 5);
                }
                return toReturn;
            }
        }
        private short _bonus;
        public short Bonus
        {
            set { _bonus = value; }
            get { return _bonus; }
        }

        private short _temporaryModifier;
        public short TemporaryModifier
        {
            set { _temporaryModifier = value; }
            get { return _temporaryModifier; }
        }

        private short _temporaryScore;
        public short TemporaryScore
        {
            set { _temporaryScore = value; }
            get { return _temporaryScore; }
        }

        public short ClassBonus
        {
            get { return _traits.AbilityBonuses.ContainsKey(_class) ? _traits.AbilityBonuses[_class] : (short)0; }
        }

        public short RaceBonus
        {
            get { return _traits.AbilityBonuses.ContainsKey(_race) ? _traits.AbilityBonuses[_race] : (short)0; }
        }
    }
}

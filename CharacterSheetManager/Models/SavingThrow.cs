using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetManager.Models
{
    public class SavingThrow : ModelBase
    {
        private readonly string _name = string.Empty;
        private readonly string _class = string.Empty;
        private readonly string _race = string.Empty;
        private readonly ClassAndRaceTraits _traits;
        private readonly Dictionary<string, Ability> _abilities;
        public SavingThrow(string name, string charClass, string race, Dictionary<string, Ability> abilities, ClassAndRaceTraits traits)
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

        public short _total;
        public short Total
        {
            get { return (short)(AbilityModifier + BaseSave + MiscellaneousBonus + TemporaryBonus + ClassBonus + RaceBonus); }
        }

        public short AbilityModifier
        {
            get
            {
                short temp = 0;
                switch (_name)
                {
                    case ConstantResources.SavingThrows.FORTITUDE:
                    {
                        temp = _abilities[ConstantResources.Abilities.CONSTITUTION].Modifier;
                        break;
                    }
                    case ConstantResources.SavingThrows.REFLEX:
                    {
                        temp = _abilities[ConstantResources.Abilities.DEXTERITY].Modifier;
                        break;
                    }
                    case ConstantResources.SavingThrows.WILL:
                    {
                        temp = _abilities[ConstantResources.Abilities.WISDOM].Modifier;
                        break;
                    }
                }
                return temp;
            }
        }

        public short _miscellaneousBonus;
        public short MiscellaneousBonus
        {
            set { _miscellaneousBonus = value; }
            get { return _miscellaneousBonus; }
        }
        public short _temporaryBonus;
        public short TemporaryBonus
        {
            set { _temporaryBonus = value; }
            get { return _temporaryBonus; }
        }

        public ushort BaseSave
        {
            get { return 0; }
        }

        public short ClassBonus
        { 
            get
            {
                return _traits.SaveBonuses.ContainsKey(_class) ? _traits.SaveBonuses[_class] : (short)0;
            }
        }

        public short RaceBonus
        { 
            get
            {
                return _traits.SaveBonuses.ContainsKey(_race) ? _traits.SaveBonuses[_race] : (short)0;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetManager.Models
{
    public class SavingThrow : ModelBase
    {
        public SavingThrow()
        {
            if(baseCharacteristics == null)
            {
                baseCharacteristics = new BasicCharacteristics();
            }
        }
        private static BasicCharacteristics baseCharacteristics;

        SavingThrow(string name)
        {
            if (string.IsNullOrEmpty(name) == true)
            {
                throw new InvalidOperationException("Invalid Save Name");
            }
            _name = name;
        }

        private readonly string _name = string.Empty;
        public string Name
        {
            get { return _name; }
        }

        public short _total;
        public short Total
        {
            get { return (short)(AbilityModifier + BaseSave + MiscellaneousBonus + TemporaryBonus); }
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
                        temp = baseCharacteristics.Abilities[ConstantResources.Abilities.CONSTITUTION].Modifier;
                        break;
                    }
                    case ConstantResources.SavingThrows.REFLEX:
                    {
                        temp = baseCharacteristics.Abilities[ConstantResources.Abilities.DEXTERITY].Modifier;
                        break;
                    }
                    case ConstantResources.SavingThrows.WILL:
                    {
                        temp = baseCharacteristics.Abilities[ConstantResources.Abilities.WISDOM].Modifier;
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

        public short _baseSave;
        public short BaseSave
        {
            get { return baseCharacteristics.SavingThrows[_name].Total; }
        }
    }
}

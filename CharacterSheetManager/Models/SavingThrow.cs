using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetManager.Models
{
    public class SavingThrow : ModelBase
    {
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
                        temp = BasicCharacteristics.Abilities[ConstantResources.Abilities.CONSTITUTION].Modifier;
                        break;
                    }
                    case ConstantResources.SavingThrows.REFLEX:
                    {
                        temp = BasicCharacteristics.Abilities[ConstantResources.Abilities.DEXTERITY].Modifier;
                        break;
                    }
                    case ConstantResources.SavingThrows.WILL:
                    {
                        temp = BasicCharacteristics.Abilities[ConstantResources.Abilities.WISDOM].Modifier;
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

        public ushort _baseSave;
        public ushort BaseSave
        {
            get{ return BasicCharacteristics.BaseSaves[BasicCharacteristics.Class][_name]; }
        }
    }
}

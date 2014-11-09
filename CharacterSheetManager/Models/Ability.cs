using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetManager.Models
{
    public class Ability : ModelBase
    {
        Ability(string name)
        {
            if(name == null)
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

        private short _score;
        public short Score
        {
            set { _score = value; }
            get { return _score; }
        }

        private short _modifier;
        public short Modifier
        {
            set { _modifier = value; }
            get { return _modifier; }
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
    }
}

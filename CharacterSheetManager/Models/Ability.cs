using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetManager.Models
{
    class Ability
    {
        private byte _score;
        public byte Score
        {
            set { _score = value; }
            get { return _score; }
        }

        private byte _modifier;
        public byte Score
        {
            set { _modifier = value; }
            get { return _modifier; }
        }
        private byte _bonus;
        public byte Score
        {
            set { _bonus = value; }
            get { return _bonus; }
        }
        private byte _temporaryModifier;

        public byte TemporaryModifier
        {
            set { _temporaryModifier = value; }
            get { return _temporaryModifier; }
        }

        private byte _temporaryScore;
        public byte TemporaryScore
        {
            set { _temporaryScore = value; }
            get { return _temporaryScore; }
        }
    }
}

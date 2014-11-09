using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetManager.Models
{
    public class Item : ModelBase
    {
        protected string _name = string.Empty;
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        protected ushort _weight;
        public ushort Weight
        {
            set { _weight = value; }
            get { return _weight; }
        }

        public uint TotalWeight
        {
            get { return _weight * _quantity; }
        }

        protected ushort _worth;
        public ushort Worth
        {
            set { _worth = value; }
            get { return _worth; }
        }

        protected uint _quantity = 1;
        public  uint Quantity
        {
            set { _quantity = value; }
            get { return _quantity; }
        }

        protected string _enhancements = string.Empty;
        public string Enhancements
        {
            set { _enhancements = value; }
            get { return _enhancements; }
        }

        protected string _comments = string.Empty;
        public string Comments
        {
            set { _comments = value; }
            get { return _comments; }
        }
    }
}

using CharacterSheetManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetManager.ViewModels
{
    public class ItemsAndMoney : ViewModelBase
    {
        public List<Item> Items;

        public List<KeyValuePair<string, uint>> Money;
    }
}

using CharacterSheetManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Data;

namespace CharacterSheetManager.ViewModels
{
    public class WeaponsAndArmor : ViewModelBase
    {
        public ICollectionView Weapons { get; private set; }

        public List<ProtectiveItem> Armor;

        public WeaponsAndArmor()
        {
            var _weapons = new List<Weapon> { 
                        new Weapon { Name = "Short Sword", DamageRoll = "1d6" },
                        new Weapon { Name = "Long Sword", DamageRoll = "1d8" },
                        new Weapon { Name = "Great Sword", DamageRoll = "1d10" }
                        };


            Weapons = CollectionViewSource.GetDefaultView(_weapons);
        }
    }
}

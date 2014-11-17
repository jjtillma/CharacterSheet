using CharacterSheetManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetManager.ViewModels
{
    public class Overview : ViewModelBase
    {
        public string Name;
        public ushort Age;
        public string SizeCategory;
        public string Class;
        public string Race;
        public Weapon CurrentWeapon;
        public List<ProtectiveItem> CurrentArmor;
        public List<Skill> ImportantSkills;
        public uint CurrentGold;
        public ushort CurrentWeight;
        public string CurrentLoadCategory;
        public string NextLoadCategory;
        public short HitPoints;
        public ushort ArmorClass;
        public ushort TouchAC;
        public ushort FlatFootedAC;
        public short Initiative;
        public ushort Grapple;
        public ushort BaseAttackBonus;
        List<SavingThrow> SavingThrows;
    }
}

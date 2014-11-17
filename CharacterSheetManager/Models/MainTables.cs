using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetManager.Models
{
    public class MainTables
    {
        private readonly string _charClass;

        private Dictionary<bool, List<ushort>> _baseSaves;
        public Dictionary<string, Dictionary<string, ushort>> ClassBonuses;
        public Dictionary<string, Dictionary<string, ushort>> RaceBonuses;
        public List<string> TrainedOnlySkills;
        public Dictionary<string, string> SkillAbilities;
        public List<string> SkillsWithArmorPenalty;
        public Dictionary<string, ushort> SKillsWithHighArmorPenalty;
        public List<uint> MediumLevels;
        public List<uint> FastLevels;
        public List<uint> SlowLevels;

        public MainTables(string charClass)
        {
            _charClass = charClass;
            MakeBaseSaves();
            MakeClassBonuses();
            MakeRaceBonuses();
            MakeTrainedOnlySkills();
            MakeSkillAbilities();
            MakeSkillsWithArmorPenalty();
            MakeMediumLevels();
            MakeFastLevels();
            MakeSlowLevels();
        }

        public ushort GetBaseSave(string saveName, ushort level)
        {
            bool good = false;
            switch(_charClass)
            {
                case ConstantResources.Classes.BARBARIAN:
                {
                    switch(saveName)
                    {
                        case ConstantResources.SavingThrows.FORTITUDE:
                        {
                            good = true;
                            break;
                        }
                    }
                    break;
                }
                case ConstantResources.Classes.BARD:
                {
                    switch (saveName)
                    {
                        case ConstantResources.SavingThrows.REFLEX:
                        {
                            good = true;
                            break;
                        }
                        case ConstantResources.SavingThrows.WILL:
                        {
                            good = true;
                            break;
                        }
                    }
                    break;
                }
                case ConstantResources.Classes.CLERIC:
                {
                    switch (saveName)
                    {
                        case ConstantResources.SavingThrows.FORTITUDE:
                        {
                            good = true;
                            break;
                        }
                        case ConstantResources.SavingThrows.WILL:
                        {
                            good = true;
                            break;
                        }
                    }
                    break;
                }
                case ConstantResources.Classes.DRUID:
                {
                    switch (saveName)
                    {
                        case ConstantResources.SavingThrows.FORTITUDE:
                        {
                            good = true;
                            break;
                        }
                        case ConstantResources.SavingThrows.WILL:
                        {
                            good = true;
                            break;
                        }
                    }
                    break;
                }
                case ConstantResources.Classes.FIGHTER:
                {
                    switch (saveName)
                    {
                        case ConstantResources.SavingThrows.FORTITUDE:
                        {
                            good = true;
                            break;
                        }
                    }
                    break;
                }
                case ConstantResources.Classes.MONK:
                {
                    switch (saveName)
                    {
                        case ConstantResources.SavingThrows.FORTITUDE:
                        {
                            good = true;
                            break;
                        }
                        case ConstantResources.SavingThrows.REFLEX:
                        {
                            good = true;
                            break;
                        }
                        case ConstantResources.SavingThrows.WILL:
                        {
                            good = true;
                            break;
                        }
                    }
                    break;
                }
                case ConstantResources.Classes.PALADIN:
                {
                    switch (saveName)
                    {
                        case ConstantResources.SavingThrows.FORTITUDE:
                        {
                            good = true;
                            break;
                        }
                    }
                    break;
                }
                case ConstantResources.Classes.RANGER:
                {
                    switch (saveName)
                    {
                        case ConstantResources.SavingThrows.FORTITUDE:
                        {
                            good = true;
                            break;
                        }
                        case ConstantResources.SavingThrows.REFLEX:
                        {
                            good = true;
                            break;
                        }
                    }
                    break;
                }
                case ConstantResources.Classes.ROGUE:
                {
                    switch (saveName)
                    {
                        case ConstantResources.SavingThrows.REFLEX:
                        {
                            good = true;
                            break;
                        }
                    }
                    break;
                }
                case ConstantResources.Classes.SORCERER:
                {
                    switch (saveName)
                    {
                        case ConstantResources.SavingThrows.WILL:
                        {
                            good = true;
                            break;
                        }
                    }
                    break;
                }
                case ConstantResources.Classes.WIZARD:
                {
                    switch (saveName)
                    {
                        case ConstantResources.SavingThrows.WILL:
                        {
                            good = true;
                            break;
                        }
                    }
                    break;
                }
            }

            return _baseSaves[good][level - 1];
        }
        public void MakeBaseSaves()
        {
            _baseSaves = new Dictionary<bool, List<ushort>>();
            _baseSaves.Add(true, new List<ushort>(){0,0,1,1,1,2,2,2,3,3,3,4,4,4,5,5,5,6,6,6});
            _baseSaves.Add(false, new List<ushort>(){2,3,3,4,4,5,5,6,6,7,7,8,8,9,9,10,10,11,11,12});
        }

        public void MakeClassBonuses()
        {

        }

        public void MakeRaceBonuses()
        {

        }

        public void MakeTrainedOnlySkills()
        {
            TrainedOnlySkills = new List<string>()
            {
                ConstantResources.Skills.DECIPHTER_SCRIPT,
                ConstantResources.Skills.DISABLE_DEVICE,
                ConstantResources.Skills.HANDLE_ANIMAL,
                ConstantResources.Skills.KNOWLEDGE,
                ConstantResources.Skills.OPEN_LOCK,
                ConstantResources.Skills.PROFESSION,
                ConstantResources.Skills.SLEIGHT_OF_HAND,
                ConstantResources.Skills.SPEAK_LANGUAGE,
                ConstantResources.Skills.SPELLCRAFT,
                ConstantResources.Skills.TUMBLE,
                ConstantResources.Skills.USE_MAGIC_DEVICE
            };
        }

        public void MakeSkillAbilities()
        {
            SkillAbilities.Add(ConstantResources.Skills.APPRAISE, ConstantResources.Abilities.INTELLIGENCE_ABR);
            SkillAbilities.Add(ConstantResources.Skills.BALANCE, ConstantResources.Abilities.DEXTERITY_ABR);
            SkillAbilities.Add(ConstantResources.Skills.BLUFF, ConstantResources.Abilities.CHARISMA_ABR);
            SkillAbilities.Add(ConstantResources.Skills.CLIMB, ConstantResources.Abilities.STRENGTH_ABR);
            SkillAbilities.Add(ConstantResources.Skills.CONCENTRATION, ConstantResources.Abilities.CONSTITUTION_ABR);
            SkillAbilities.Add(ConstantResources.Skills.CRAFT, ConstantResources.Abilities.INTELLIGENCE_ABR);
            SkillAbilities.Add(ConstantResources.Skills.DECIPHTER_SCRIPT, ConstantResources.Abilities.INTELLIGENCE_ABR);
            SkillAbilities.Add(ConstantResources.Skills.DIPLOMACY, ConstantResources.Abilities.CHARISMA_ABR);
            SkillAbilities.Add(ConstantResources.Skills.DISABLE_DEVICE, ConstantResources.Abilities.INTELLIGENCE_ABR);
            SkillAbilities.Add(ConstantResources.Skills.DISGUISE, ConstantResources.Abilities.CHARISMA_ABR);
            SkillAbilities.Add(ConstantResources.Skills.ESCAPE_ARTIST, ConstantResources.Abilities.DEXTERITY_ABR);
            SkillAbilities.Add(ConstantResources.Skills.FORGERY, ConstantResources.Abilities.CHARISMA_ABR);
            SkillAbilities.Add(ConstantResources.Skills.GATHER_INFORMATION, ConstantResources.Abilities.CHARISMA_ABR);
            SkillAbilities.Add(ConstantResources.Skills.HANDLE_ANIMAL, ConstantResources.Abilities.CHARISMA_ABR);
            SkillAbilities.Add(ConstantResources.Skills.HEAL, ConstantResources.Abilities.WISDOM_ABR);
            SkillAbilities.Add(ConstantResources.Skills.HIDE, ConstantResources.Abilities.DEXTERITY_ABR);
            SkillAbilities.Add(ConstantResources.Skills.INTIMIDATE, ConstantResources.Abilities.CHARISMA_ABR);
            SkillAbilities.Add(ConstantResources.Skills.JUMP, ConstantResources.Abilities.STRENGTH_ABR);
            SkillAbilities.Add(ConstantResources.Skills.KNOWLEDGE, ConstantResources.Abilities.INTELLIGENCE_ABR);
            SkillAbilities.Add(ConstantResources.Skills.LISTEN, ConstantResources.Abilities.WISDOM_ABR);
            SkillAbilities.Add(ConstantResources.Skills.MOVE_SILENTLY, ConstantResources.Abilities.DEXTERITY_ABR);
            SkillAbilities.Add(ConstantResources.Skills.OPEN_LOCK, ConstantResources.Abilities.DEXTERITY_ABR);
            SkillAbilities.Add(ConstantResources.Skills.PERFORM, ConstantResources.Abilities.CHARISMA_ABR);
            SkillAbilities.Add(ConstantResources.Skills.PROFESSION, ConstantResources.Abilities.WISDOM_ABR);
            SkillAbilities.Add(ConstantResources.Skills.RIDE, ConstantResources.Abilities.DEXTERITY_ABR);
            SkillAbilities.Add(ConstantResources.Skills.SEARCH, ConstantResources.Abilities.INTELLIGENCE_ABR);
            SkillAbilities.Add(ConstantResources.Skills.SENSE_MOTIVE, ConstantResources.Abilities.WISDOM_ABR);
            SkillAbilities.Add(ConstantResources.Skills.SLEIGHT_OF_HAND, ConstantResources.Abilities.DEXTERITY_ABR);
            SkillAbilities.Add(ConstantResources.Skills.SPEAK_LANGUAGE, string.Empty);
            SkillAbilities.Add(ConstantResources.Skills.SPELLCRAFT, ConstantResources.Abilities.INTELLIGENCE_ABR);
            SkillAbilities.Add(ConstantResources.Skills.SPOT, ConstantResources.Abilities.WISDOM_ABR);
            SkillAbilities.Add(ConstantResources.Skills.SURVIVAL, ConstantResources.Abilities.WISDOM_ABR);
            SkillAbilities.Add(ConstantResources.Skills.SWIM, ConstantResources.Abilities.STRENGTH_ABR);
            SkillAbilities.Add(ConstantResources.Skills.TUMBLE, ConstantResources.Abilities.DEXTERITY_ABR);
            SkillAbilities.Add(ConstantResources.Skills.USE_MAGIC_DEVICE, ConstantResources.Abilities.CHARISMA_ABR);
            SkillAbilities.Add(ConstantResources.Skills.USE_ROPE, ConstantResources.Abilities.DEXTERITY_ABR);
        }

        public void MakeSkillsWithArmorPenalty()
        {
            SkillsWithArmorPenalty = new List<string>()
            {
                ConstantResources.Skills.BALANCE,
                ConstantResources.Skills.CLIMB,
                ConstantResources.Skills.ESCAPE_ARTIST,
                ConstantResources.Skills.HIDE,
                ConstantResources.Skills.JUMP,
                ConstantResources.Skills.MOVE_SILENTLY,
                ConstantResources.Skills.SLEIGHT_OF_HAND,
                ConstantResources.Skills.TUMBLE,
            };

            SKillsWithHighArmorPenalty = new Dictionary<string, ushort>();
            SKillsWithHighArmorPenalty.Add(ConstantResources.Skills.SWIM, 2);
        }

        public void MakeMediumLevels()
        {
            MediumLevels.Add(0);
            MediumLevels.Add(1000);
            MediumLevels.Add(3000);
            MediumLevels.Add(6000);
            MediumLevels.Add(10000);
            MediumLevels.Add(15000);
            MediumLevels.Add(21000);
            MediumLevels.Add(28000);
            MediumLevels.Add(36000);
            MediumLevels.Add(45000);
            MediumLevels.Add(55000);
            MediumLevels.Add(66000);
            MediumLevels.Add(78000);
            MediumLevels.Add(91000);
            MediumLevels.Add(105000);
            MediumLevels.Add(120000);
            MediumLevels.Add(136000);
            MediumLevels.Add(171000);
            MediumLevels.Add(190000);
        }

        public void MakeFastLevels()
        {

        }

        public void MakeSlowLevels()
        {

        }

        public static uint GetCurrentLevel(List<uint> toSearch, uint xp)
        {
            uint toReturn = 0;

            foreach(uint item in toSearch)
            {
                if(item > xp)
                {
                    break;
                }
                else
                {
                    toReturn++;
                }
            }
            return toReturn;
        }
    }
}

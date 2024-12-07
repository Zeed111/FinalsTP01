using CharacterStructure;
using Stats;

namespace CharacterAbstruct {
    public abstract class Character {
        public abstract BasicAttributesStruct Attributes { get; set; }
        public abstract HomeWorldStruct World { get; set; }
        public abstract OccupationStruct Role { get; set; }
        public abstract ApperanceStruct Look { get; set; }
        public abstract SpecialPowerStruct SP { get; set; }
        public abstract CompanionStruct Partner { get; set; }
        public abstract PrimaryWeapStruct PryWeap { get; set; }
        public abstract SecondaryWeapStruct SdryWeap { get; set; }
        public abstract MeleeStruct Melee { get; set; }
        public abstract GrenadeStruct Grenade { get; set; }

        public abstract void GetBasicAttributes();
        public abstract void GetHomeWorld();
        public abstract void GetOccupation();
        public abstract void GetApperance();
        public abstract void CharacterStats(AllocateStatPoints CharStat);
        public abstract void GetSpecialPower();
        public abstract void GetCompanion();
        public abstract void GetPrimary();
        public abstract void GetSecondary();
        public abstract void GetMelee();
        public abstract void GetGrenade();
    }
}
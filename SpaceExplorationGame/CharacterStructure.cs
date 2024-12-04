namespace CharacterStructure {
    public interface IDisplayInfo {
        public void Display();
    }
    public struct BasicAttributesStruct : IDisplayInfo {
        public string Species { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }

        public BasicAttributesStruct(string species, string gender, string age) {
            Species = species;
            Gender = gender;
            Age = age;
        }

        public void Display() {
            Console.WriteLine(" ");
            Console.WriteLine("-----Your New Character-----");
            Console.WriteLine($"Species: {Species}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Age: {Age}");
        }
    }

    public struct HomeWorldStruct : IDisplayInfo {
        public string HomeWorld { get; set; }

        public HomeWorldStruct(string homeWorld) {
            HomeWorld = homeWorld;
        }

        public void Display() {
            Console.WriteLine($"HomeWorld: {HomeWorld}");
        }
    }

    public struct OccupationStruct : IDisplayInfo {
        public string Occupation { get; set; }

        public OccupationStruct(string occupation) {
            Occupation = occupation;
        }

        public void Display() {
            Console.WriteLine($"Occupation: {Occupation}");
        }
    }

    public struct ApperanceStruct : IDisplayInfo {
        public string HairColor { get; set; }
        public string HairType { get; set; }
        public string EyeColor { get; set; }
        public string SkinTone { get; set; }
        public string HeadAccessory { get; set; }
        public string BodyAccessory { get; set; }
        public string ArmAccessory { get; set; }
        public string LegAccessory { get; set; }
        public string Tail { get; set; }
        public string Aura { get; set; }

        public ApperanceStruct(string hairColor, string hairType, string eyeColor, string skinTone, string headAccessory, 
            string bodyAccessory, string armAccessory, string legAccessory, string tail, string aura) {
                HairColor = hairColor;
                HairType = hairType;
                EyeColor = eyeColor;
                SkinTone = skinTone;
                HeadAccessory = headAccessory;
                BodyAccessory = bodyAccessory;
                ArmAccessory = armAccessory;
                LegAccessory = legAccessory;
                Tail = tail;
                Aura = aura;
            }

        public void Display() {
            Console.WriteLine($"HairColor: {HairColor}");
            Console.WriteLine($"HairType: {HairType}");
            Console.WriteLine($"EyeColor: {EyeColor}");
            Console.WriteLine($"SkinTone: {SkinTone}");
            Console.WriteLine($"HeadAccessory: {HeadAccessory}");
            Console.WriteLine($"BodyAccessory: {BodyAccessory}");
            Console.WriteLine($"ArmAccessory: {ArmAccessory}");
            Console.WriteLine($"LegAccessory: {LegAccessory}");
            Console.WriteLine($"Tail: {Tail}");
            Console.WriteLine($"Aura: {Aura}");
        }
    }

    public struct SpecialPowerStruct : IDisplayInfo {
        public string SpecialPower { get; set; }

        public SpecialPowerStruct(string specialPower) {
            SpecialPower = specialPower;
        }

        public void Display() {
            Console.WriteLine($"Speacial Power: {SpecialPower}");
        }    
    }

    public struct CompanionStruct : IDisplayInfo {
        public string Companion { get; set; }

        public CompanionStruct(string companion) {
            Companion = companion;
        }

        public void Display() {
            Console.WriteLine($"Companion: {Companion}");
        }
    }

    public struct PrimaryWeapStruct : IDisplayInfo {
        public string PrimaryWeap { get; set; }

        public PrimaryWeapStruct(string primaryWeap) {
            PrimaryWeap = primaryWeap;
        }

        public void Display() {
            Console.WriteLine($"PrimaryWeapon: {PrimaryWeap}");
        }
    }

    public struct SecondaryWeapStruct : IDisplayInfo {
        public string SecondaryWeap { get; set; }

        public SecondaryWeapStruct(string secondaryWeap) {
            SecondaryWeap = secondaryWeap;
        }

        public void Display() {
            Console.WriteLine($"SecondaryWeapon: {SecondaryWeap}");
        }
    }

    public struct MeleeStruct : IDisplayInfo {
        public string MeleeWeap { get; set; }

        public MeleeStruct(string meleeWeap) {
            MeleeWeap = meleeWeap;
        }

        public void Display() {
            Console.WriteLine($"Melee: {MeleeWeap}");
        }
    }

    public struct GrenadeStruct : IDisplayInfo {
        public string GrenadeWeap { get; set; }

        public GrenadeStruct(string grenadeWeap) {
            GrenadeWeap = grenadeWeap;
        }

        public void Display() {
            Console.WriteLine($"Grenede: {GrenadeWeap}");
        }
    }
}
namespace CharacterStructure {
    public struct BasicAttributesStruct {
        public string Species;
        public string Gender; 
        public string Age;

        public void Display() {
            Console.WriteLine(" ");
            Console.WriteLine("-----Your New Character-----");
            Console.WriteLine($"Species: {Species}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Age: {Age}");
        }
    }

    public struct HomeWorldStruct {
        public string HomeWorld;

        public void Display() {
            Console.WriteLine($"HomeWorld: {HomeWorld}");
        }
    }

    public struct OccupationStruct {
        public string Occupation;

        public void Display() {
            Console.WriteLine($"Occupation: {Occupation}");
        }
    }

    public struct ApperanceStruct {
        public string HairColor;
        public string HairType;
        public string EyeColor;
        public string SkinTone;
        public string HeadAccessory;
        public string BodyAccessory;
        public string ArmAccessory;
        public string LegAccessory;
        public string Tail;
        public string Aura;

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
}
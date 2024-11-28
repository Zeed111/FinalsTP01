using CharacterStructure;

namespace CharCreate {
    public class CharacterCreation {
    
        public BasicAttributesStruct GetBasicAttributes() {
            BasicAttributesStruct Attributes = new BasicAttributesStruct();

            Console.WriteLine("--Basic Attributes--");
            Console.WriteLine("Species:");
            Console.WriteLine("[1] Humans");
            Console.WriteLine("[2] Titans");
            Console.WriteLine("[3] Cyborg");
            Console.WriteLine("[4] Shapeshifter");
            Console.WriteLine("[5] Elves");
            Console.Write("Choice: ");
            int ChoiceSpecies = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(" ");
            Console.WriteLine("Gender:");
            Console.WriteLine("[1] Male");
            Console.WriteLine("[2] Female");
            Console.WriteLine("[3] Non-Binary");
            Console.WriteLine("[4] Gay");
            Console.WriteLine("[5] Lesbian");
            Console.Write("Choice: ");
            int ChoiceGender = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Age:");
            Console.WriteLine("[1] Rising Star - 50 to 100");
            Console.WriteLine("[2] Super Rookie - 200 to 600");
            Console.WriteLine("[3] Prime - 800 to 1,000");
            Console.WriteLine("[4] Living Legend - 1,500 to 2,500");
            Console.WriteLine("[5] Echoes of Past - 5,000 to 10,000");
            Console.Write("Choice: ");
            int ChoiceAge = Convert.ToInt32(Console.ReadLine());

            switch (ChoiceSpecies) {
                case 1: Attributes.Species = "Humans"; break;
                case 2: Attributes.Species = "Titans"; break;
                case 3: Attributes.Species = "Cyborg"; break;
                case 4: Attributes.Species = "Shapeshifter"; break;
                case 5: Attributes.Species = "Elves"; break;
            }

            switch (ChoiceGender) {
                case 1: Attributes.Gender = "Male"; break;
                case 2: Attributes.Gender = "Female"; break;
                case 3: Attributes.Gender = "Non-Binary"; break;
                case 4: Attributes.Gender = "Gay"; break;
                case 5: Attributes.Gender = "Lesbian"; break;
            }

            switch (ChoiceAge) {
                case 1: Attributes.Age = "Rising Star"; break;
                case 2: Attributes.Age = "Super Rookie"; break;
                case 3: Attributes.Age = "Prime"; break;
                case 4: Attributes.Age = "Living Legend"; break;
                case 5: Attributes.Age = "Echoes of Past"; break;
            }

            return Attributes;
        }

        public HomeWorldStruct GetHomeWorld() {
            HomeWorldStruct World = new HomeWorldStruct();

            Console.WriteLine(" ");
            Console.WriteLine("--Homeworld--");
            Console.WriteLine("[1] Ashara (High-Tech World)");
            Console.WriteLine("[2] Pyros IX (Desert World)");
            Console.WriteLine("[3] Vextris (Wasted Earth version)");
            Console.WriteLine("[4] Auralis (Prison Planet)");
            Console.WriteLine("[5] Noctivis (Orbital Luxury Ring World)");
            Console.WriteLine("[6] Valtoria (Banking Capital World Trading)");
            Console.Write("Choice: ");
            int WorldChoice = Convert.ToInt32(Console.ReadLine());

            switch (WorldChoice) {
                case 1: World.HomeWorld = "Ashara"; break;
                case 2: World.HomeWorld = "Pyros IX"; break;
                case 3: World.HomeWorld = "Vextris"; break;
                case 4: World.HomeWorld = "Auralis"; break;
                case 5: World.HomeWorld = "Noctivis"; break;
                case 6: World.HomeWorld = "Valtoria"; break;
            }

            return World;
        }

         public OccupationStruct GetOccupation() {
            OccupationStruct Role = new OccupationStruct();

            Console.WriteLine(" ");
            Console.WriteLine("--Occupation--");
            Console.WriteLine("[1] StarShip Captain - Leads a spacecraft, guiding the crew through missions, " +
                "making key decisions, and handling interstellar challenges with leadership, strategy, and diplomacy.");
            Console.WriteLine("[2] Mercenary - A soldier for hire, fighting for profit rather than loyalty, " +
                "known for their combat skills and independence.");
            Console.WriteLine("[3] Merchant - A person who buys and sells goods for profit, often dealing in trade, commerce, or retail.");
            Console.WriteLine("[4] Hacker - Is someone skilled in computer systems who finds and exploits vulnerabilities, " +
                "often for accessing or manipulating data, either ethically or maliciously.");
            Console.WriteLine("[5] Sniper - A highly trained marksman specializing in long-range, precise shooting, " +
                "often used in military or tactical operations.");
            Console.WriteLine("[6] Mage - A practitioner of magic, skilled in casting spells and " +
                "manipulating mystical forces, often in fantasy settings.");
            Console.WriteLine("[7] Space Soldier - Is a combatant trained for warfare in outer space, often depicted " +
                "in science fiction. They are equipped with advanced technology and weaponry to engage " +
                "in battles on spacecraft or alien planets.");
            Console.Write("Choice: ");
            int OccupationChoice = Convert.ToInt32(Console.ReadLine());

            switch (OccupationChoice) {
                case 1: Role.Occupation = "StarShip Captain"; break;
                case 2: Role.Occupation = "Mercenary"; break;
                case 3: Role.Occupation = "Merchant"; break;
                case 4: Role.Occupation = "Hacker"; break;
                case 5: Role.Occupation = "Sniper"; break;
                case 6: Role.Occupation = "Mage"; break;
                case 7: Role.Occupation = "Space Soldier"; break;
            }

            return Role;     
         }

        public ApperanceStruct GetApperance() {
            ApperanceStruct Look = new ApperanceStruct();

            Console.WriteLine(" ");
            Console.WriteLine("--Appearance Customization--");
            Console.WriteLine("Hair Color:");
            Console.WriteLine("[1] Black");
            Console.WriteLine("[2] Brown");
            Console.WriteLine("[3] Blonde");
            Console.WriteLine("[4] Red");
            Console.WriteLine("[5] None (Bald)");
            Console.Write("Choice: ");
            int HairColorChoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Hair Type:");
            Console.WriteLine("[1] Straight");
            Console.WriteLine("[2] Curly");
            Console.WriteLine("[3] Long");
            Console.WriteLine("[4] Short");
            Console.WriteLine("[5] Crystalline");
            Console.Write("Choice: ");
            int HairTypeChoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Eye Color:");
            Console.WriteLine("[1] Blue");
            Console.WriteLine("[2] Green");
            Console.WriteLine("[3] Brown");
            Console.WriteLine("[4] Gold");
            Console.WriteLine("[5] Black");
            Console.Write("Choice: ");
            int EyeColorChoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Skin Tone:");
            Console.WriteLine("[1] Pale");
            Console.WriteLine("[2] Fair");
            Console.WriteLine("[3] Tan");
            Console.WriteLine("[4] Olive");
            Console.WriteLine("[5] Dark");
            Console.Write("Choice: ");
            int SkinToneChoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Head and Face Accessories:");
            Console.WriteLine("[1] Space Helmet");
            Console.WriteLine("[2] Goggles");
            Console.WriteLine("[3] Masks");
            Console.WriteLine("[4] Scouter");
            Console.WriteLine("[5] Earrings");
            Console.Write("Choice: ");
            int HeadAccessoryChoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Torso and Back Accessories:");
            Console.WriteLine("[1] Jetpacks");
            Console.WriteLine("[2] Backpack");
            Console.WriteLine("[3] Capes and Cloaks");
            Console.WriteLine("[4] Utility Belts");
            Console.Write("Choice: ");
            int BodyAccessoryChoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Arm and Hand Accessories:");
            Console.WriteLine("[1] Space Gloves");
            Console.WriteLine("[2] Rings");
            Console.WriteLine("[3] Arm Bracelet");
            Console.WriteLine("[4] Vortex Gauntlet");
            Console.Write("Choice: ");
            int ArmAccessoryChoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Leg and Foot Accessories:");
            Console.WriteLine("[1] Boots");
            Console.WriteLine("[2] Knee Pads");
            Console.WriteLine("[3] Slippers");
            Console.WriteLine("[4] Space Shoes");
            Console.Write("Choice: ");
            int LegAccessoryChoice = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine(" ");
            Console.WriteLine("Do you want a tail? [1] Yes [2] No");
            int TailChoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Aura:");
            Console.WriteLine("[1] Black");
            Console.WriteLine("[2] Red");
            Console.WriteLine("[3] Green");
            Console.WriteLine("[4] Blue");
            Console.WriteLine("[5] Pink");
            Console.Write("Choice: ");
            int AuraChoice = Convert.ToInt32(Console.ReadLine());

            switch (HairColorChoice) {
                case 1: Look.HairColor = "Black"; break;
                case 2: Look.HairColor = "Brown"; break;
                case 3: Look.HairColor = "Blonde"; break;
                case 4: Look.HairColor = "Red"; break;
                case 5: Look.HairColor = "None (Bald)"; break;
            }

            switch (HairTypeChoice) {
                case 1: Look.HairType = "Straight"; break;
                case 2: Look.HairType = "Curly"; break;
                case 3: Look.HairType = "Long"; break;
                case 4: Look.HairType = "Short"; break;
                case 5: Look.HairType = "Crystalline"; break;
            }

            switch (EyeColorChoice) {
                case 1: Look.EyeColor = "Blue"; break;
                case 2: Look.EyeColor = "Green"; break;
                case 3: Look.EyeColor = "Brown"; break;
                case 4: Look.EyeColor = "Gold"; break;
                case 5: Look.EyeColor = "Black"; break;
            }

             switch (SkinToneChoice) {
                case 1: Look.SkinTone = "Pale"; break;
                case 2: Look.SkinTone = "Fair"; break;
                case 3: Look.SkinTone = "Tan"; break;
                case 4: Look.SkinTone = "Olive"; break;
                case 5: Look.SkinTone = "Dark"; break;
            }

            switch (HeadAccessoryChoice) {
                case 1: Look.HeadAccessory = "Space Helmet"; break;
                case 2: Look.HeadAccessory = "Goggles"; break;
                case 3: Look.HeadAccessory = "Masks"; break;
                case 4: Look.HeadAccessory = "Scouter"; break;
                case 5: Look.HeadAccessory = "Earrings"; break;
            }

            switch (BodyAccessoryChoice) {
                case 1: Look.BodyAccessory = "Jetpacks"; break;
                case 2: Look.BodyAccessory = "Backpack"; break;
                case 3: Look.BodyAccessory = "Capes and Cloaks"; break;
                case 4: Look.BodyAccessory = "Utility Belts"; break;
            }

            switch (ArmAccessoryChoice) {
                case 1: Look.ArmAccessory = "Space Gloves"; break;
                case 2: Look.ArmAccessory = "Rings"; break;
                case 3: Look.ArmAccessory = "Arm Bracelet"; break;
                case 4: Look.ArmAccessory = "Vortex Gauntlet"; break;
            }

            switch (LegAccessoryChoice) {
                case 1: Look.LegAccessory = "Boots"; break;
                case 2: Look.LegAccessory = "Knee Pads"; break;
                case 3: Look.LegAccessory = "Slippers"; break;
                case 4: Look.LegAccessory = "Space Shoes"; break;
            }

            Look.Tail = (TailChoice == 1) ? "Has Tail" : "No Tail";

            switch (AuraChoice) {
                case 1: Look.Aura = "Black"; break;
                case 2: Look.Aura = "Red"; break;
                case 3: Look.Aura = "Green"; break;
                case 4: Look.Aura = "Blue"; break;
                case 5: Look.Aura = "Pink"; break;
            }

            return Look;
        }

        // public static void AbilitesTraits() {

        // }

        // public static void SpecialPowers() {

        // }

        // public static void Companion() {

        // }

        // public static void Weapon() {

        // }

        // public static string Primary() {
            
        // }

        // public static string Secondary() {

        // }

        // public static string Melee() {

        // }
    }
}
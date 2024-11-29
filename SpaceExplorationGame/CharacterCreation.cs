using CharacterStructure;
using Stats;

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

        public void Stats(AllocateStatPoints CharStat) {

            CharStat.AskStats();
        }

        public SpecialPowerStruct GetSpecialPower() {
            SpecialPowerStruct SP = new SpecialPowerStruct();

            Console.WriteLine(" ");
            Console.WriteLine("--Special Powers--");
            Console.WriteLine("Choose 1 Special Power:");
            Console.WriteLine("[1] Precognition: Have glimpses of the future, allowing for the anticipation of " +
                "danger or the prediction of events.");
            Console.WriteLine("[2] Technopathy: Control and interface with technology using the mind, a powerful " +
                "ability in a technologically advanced setting.");
            Console.WriteLine("[3] Enhanced Strength: Essential for dealing with the rigors of space travel " +
                "and potential physical threats.");
            Console.WriteLine("[4] Enhanced Durability: Withstand the harsh conditions of space and survive dangerous situations.");
            Console.WriteLine("[5] Gravity Manipulation: Control gravity to navigate zero-gravity environments, " +
                "create force fields, or even as a weapon.");
            Console.WriteLine("[6] Elemental Control: Control elements like fire, ice, or electricity, " +
                "potentially adapted to function in a space environment.");    
            Console.Write("Choice: ");
            int SPChoice = Convert.ToInt32(Console.ReadLine());

            switch (SPChoice) {
                case 1: SP.SpecialPower = "Precognition"; break;
                case 2: SP.SpecialPower = "Technopathy"; break;
                case 3: SP.SpecialPower = "Enhanced Strength"; break;
                case 4: SP.SpecialPower = "Enhanced Durability"; break;
                case 5: SP.SpecialPower = "Gravity Manipulation"; break;
                case 6: SP.SpecialPower = "Elemental Control"; break;
            }

            return SP;
        }

        public CompanionStruct GetCompanion() {
            CompanionStruct Partner = new CompanionStruct();

            Console.WriteLine(" ");
            Console.WriteLine("--Companion--");
            Console.WriteLine("Choose a Companion:");
            Console.WriteLine("[1] Sentinel - A Hybrid-Robot Companion");
            Console.WriteLine("[2] Beast - A Beast-type creature Companion");
            Console.Write("Choice: ");
            int CompanionChoice = Convert.ToInt32(Console.ReadLine());

            if (CompanionChoice == 1) {
                Console.WriteLine(" ");
                Console.WriteLine("Choose a Sentinel:");
                Console.WriteLine("[1] Diriga - A Jellyfish hybrid robot that has a sniper rifle weapon and zaps nearby enemies.");
                Console.WriteLine("[2] Nautilus - A Advanced Robot that is capable of pulling enemies and has an icy laser rifle.");
                Console.WriteLine("[3] Carrier - A carrier robot that provides ammo for its master and has shotgun rifle.");
                Console.Write("Choice: ");
                int SentinelChoice = Convert.ToInt32(Console.ReadLine());

                switch (SentinelChoice) {
                    case 1: Partner.Companion = "Diriga"; break;
                    case 2: Partner.Companion = "Nautilus"; break;
                    case 3: Partner.Companion = "Carrier"; break;
                }

            } else if (CompanionChoice ==2) {
                Console.WriteLine(" ");
                Console.WriteLine("Choose a Beast:");
                Console.WriteLine("[1] Smeeta - A Beast that provides buffs to its master for a short period of time.");
                Console.WriteLine("[2] Sunika Kubrow - A dog- like beast that protects its master from enemies, capable " +
                    "of launching thorns to enemies.");
                Console.WriteLine("[3] Hound - a dog-like beast that has flames to its body and capable of " +
                    "burning its surrounding up to 5 meters.");
                Console.Write("Choice: ");
                int BeastChoice = Convert.ToInt32(Console.ReadLine());

                switch (BeastChoice) {
                    case 1: Partner.Companion = "Smeeta"; break;
                    case 2: Partner.Companion = "Sunika Kubrow"; break;
                    case 3: Partner.Companion = "Hound"; break;
                }
            }

            return Partner;
        }

        public PrimaryWeapStruct GetPrimary() {
            PrimaryWeapStruct PryWeap = new PrimaryWeapStruct();

            Console.WriteLine(" ");
            Console.WriteLine("--Primary Weapons--");
            Console.WriteLine("Choose a Primary:");
            Console.WriteLine("[1] Assault Rifle - A rapid-fire, military-grade firearm designed for both short and " +
                "long-range combat. It typically uses detachable magazines and is capable of firing in both semi-automatic and fully automatic modes.");
            Console.WriteLine("[2] Battle Rifle - A military firearm designed for longer-range combat than an assault " +
                "rifle, typically chambered for a larger caliber round. It is often semi-automatic or selective-fire, " +
                "offering higher accuracy and power for engaging targets at greater distances.");
            Console.WriteLine("[3] Sniper Rifle - A precision firearm designed for long-range shooting, with a high " + 
                "accuracy and powerful optics, used by snipers for targeting distant or hidden enemies.");
            Console.WriteLine("[4] Submachine Gun (SMGs) - is a compact, fully automatic firearm that fires " +
                "pistol-caliber rounds, designed for close-range combat and high mobility.");
            Console.WriteLine("[5] Laser Gun - A weapon that uses focused beams of light or energy to damage targets.");
            Console.WriteLine("[6] Rail Gun - A weapon that uses electromagnetic forces to launch projectiles at " +
                "extremely high speeds, typically relying on powerful electric currents rather than traditional gunpowder.");
            Console.WriteLine("[7] Plasma Gun - A futuristic weapon that fires superheated ionized gas (plasma) at high velocity.");
            Console.WriteLine("[8] Blaster - A energy weapon that fires concentrated energy bolts, typically " +
                "using technologies like lasers or plasma to cause damage.");
            Console.WriteLine("[9] Acceltra - A Fast firing rifle that fires a barrage of rapid - plasma rockets.");
            Console.WriteLine("[10] Torid - A grenade rifle that makes gas clouds dealing toxin damage.");
            Console.WriteLine("[11] AX - 52 - A rifle that when firing gained an ammo efficiency and when aiming " +
                "headshot gained high critical chance.");
            Console.Write("Choice: ");
            int PWeapChoice = Convert.ToInt32(Console.ReadLine());

            switch (PWeapChoice) {
                case 1: PryWeap.PrimaryWeap = "Assault Rifle"; break;
                case 2: PryWeap.PrimaryWeap = "Battle Rifle"; break;
                case 3: PryWeap.PrimaryWeap = "Sniper Rifle"; break;
                case 4: PryWeap.PrimaryWeap = "Submachine Gun"; break;
                case 5: PryWeap.PrimaryWeap = "Laser Gun"; break;
                case 6: PryWeap.PrimaryWeap = "Rail Gun"; break;
                case 7: PryWeap.PrimaryWeap = "Plasma Gun"; break;
                case 8: PryWeap.PrimaryWeap = "Blaster"; break;
                case 9: PryWeap.PrimaryWeap = "Blaster"; break;
                case 10: PryWeap.PrimaryWeap = "Torid"; break;
                case 11: PryWeap.PrimaryWeap = "AX-52"; break;
            }

            return PryWeap;
        }

        public SecondaryWeapStruct GetSecondary() {
            SecondaryWeapStruct SdryWeap = new SecondaryWeapStruct();

            Console.WriteLine(" ");
            Console.WriteLine("--Secondary Weapons--");
            Console.WriteLine("Choose a Secondary:");
            Console.WriteLine("[1] Tactical Pistol - A handgun designed for precision and efficiency in combat or " +   
                "self-defense, often equipped with features like a suppressor, flashlight, or extended " +
                "magazine for enhanced performance.");
            Console.WriteLine("[2] Revolver - A type of handgun with a rotating cylinder that holds multiple rounds, " +
                "allowing for consecutive shots without reloading.");
            Console.WriteLine("[3] Ocucor - A laser pistol, When get kills spawn laser tendril (8 max) that reaches nearby target.");    
            Console.WriteLine("[4] Furis - The Furis delivers a high damage output in a short period of time thanks to its high fire rate.");    
            Console.WriteLine("[5] Mauser Pistol - Refers to a series of pistols produced by the German Mauser company, " +
                "known for their reliable design and use in both military and civilian contexts. The Mauser " +
                "C96, a notable model, is famous for its distinctive \"broomhandle\" grip and was widely " +
                "used during the early 20th century.");    
            Console.WriteLine("[6] Kompressa - A pistol that launches a volley of hyper pressurized water " +
                "globules that envelop targets and explode.");    
            Console.Write("Choice: ");
            int SWeapChoice = Convert.ToInt32(Console.ReadLine());

            switch (SWeapChoice) {
                case 1: SdryWeap.SecondaryWeap = "Tactical Pistol"; break;
                case 2: SdryWeap.SecondaryWeap = "Revolver"; break;
                case 3: SdryWeap.SecondaryWeap = "Ocucor"; break;
                case 4: SdryWeap.SecondaryWeap = "Furis"; break;
                case 5: SdryWeap.SecondaryWeap = "Mauser Pistol"; break;
                case 6: SdryWeap.SecondaryWeap = "Kompressa"; break;
            }

            return SdryWeap;
        }

        public MeleeStruct GetMelee() {
            MeleeStruct Melee = new MeleeStruct();

            Console.WriteLine(" ");
            Console.WriteLine("--Melee Weapons--");
            Console.WriteLine("Choose a Melee:");
            Console.WriteLine("[1] Spear - A pole weapon with a pointed tip, typically made of metal, " +
                "used for thrusting or throwing, and often employed in hunting or combat.");
            Console.WriteLine("[2] Butterfly Knife - A folding knife with two handles that rotate around " +
                "the blade, allowing it to be opened and closed quickly, often used in flipping tricks.");
            Console.WriteLine("[3] Katana - A traditional Japanese sword with a curved, single-edged blade, " +
                "known for its sharpness and craftsmanship, typically used by samurai.");
            Console.WriteLine("[4] NunChucks - Are a traditional martial arts weapon consisting of two short " +
                "sticks connected by a chain or rope, used for striking, blocking, and various defensive techniques.");
            Console.WriteLine("[5] KaliSticks - are long wooden training weapons used in Filipino martial arts, " +
                "particularly in Kali, Eskrima, and Arnis. They are typically used for striking, blocking, and practicing various combat techniques.");
            Console.WriteLine("[6] Axe - A tool or weapon with a heavy, sharp blade attached to a handle, used for " +
                "chopping, splitting, or cutting. In combat, it serves as a powerful melee weapon.");
            Console.WriteLine("[7] Broken War - A fragment of The Stalker’ War sword.");
            Console.WriteLine("[8] Magistar - Ancient Hammer that deal godly damage when doing slam attacks.");
            Console.WriteLine("[9] Ceramic Dagger - A Dagger that is made of ceramic. Has limited range but slices fast.");
            Console.WriteLine("[10] LightSaber - A laser sword that draws power from ancient crystals.");
            Console.Write("Choice: ");
            int MeleeChoice = Convert.ToInt32(Console.ReadLine());

            switch (MeleeChoice) {
                case 1: Melee.MeleeWeap = "Spear"; break;
                case 2: Melee.MeleeWeap = "Butterfly Knife"; break;
                case 3: Melee.MeleeWeap = "Katana"; break;
                case 4: Melee.MeleeWeap = "NunChucks"; break;
                case 5: Melee.MeleeWeap = "KaliSticks"; break;
                case 6: Melee.MeleeWeap = "Axe"; break;
                case 7: Melee.MeleeWeap = "Broken War"; break;
                case 8: Melee.MeleeWeap = "Magistar"; break;
                case 9: Melee.MeleeWeap = "Ceramic Dagger"; break;
                case 10: Melee.MeleeWeap = "Lightsaber"; break;
            }

            return Melee;
        }

        public GrenadeStruct GetGrenade() {
            GrenadeStruct Grenade = new GrenadeStruct();

            Console.WriteLine(" ");
            Console.WriteLine("--Grenades--");
            Console.WriteLine("Choose a Grenede:");
            Console.WriteLine("[1] Cluster Grenade - Is a type of explosive device designed to release multiple smaller " +
                "submunitions or grenades upon detonation, spreading shrapnel or explosives " +
                "over a wider area for greater impact.");
            Console.WriteLine("[2] Cryo Bomb - An explosive device designed to release a burst of extremely cold energy " +
                "or chemicals, freezing targets or the surrounding environment to cause damage or impair movement.");
            Console.WriteLine("[3] Impact Grenade - Is an explosive device that detonates upon contact with a surface or " +
                "target, designed to cause damage through the force of the explosion.");
            Console.WriteLine("[4] Flashbang Grenade - A non-lethal explosive device designed to disorient and temporarily " +
                "blind or deafening targets with a bright flash of light and a loud noise, commonly used in tactical  operations.");
            Console.WriteLine("[5] Gas Grenade - A grenade that produces gas clouds dealing toxin damage for a short period " +
                "of time with a range of 5 meters.");
            Console.WriteLine("[6] Stun Grenade - A grenade that produces a bright flash of light and a loud bang upon detonation. " +
                "The flash and bang can temporarily disorient and stun enemies.");
            Console.WriteLine("[7] Plasma Bomb - An explosive grenade that uses superheated plasma to cause damage.");
            Console.WriteLine("[8] Vortex Bomb - A grenade that creates a swirling vortex upon detonation. The vortex can suck " +
                "in enemies and deal damage.");
            Console.WriteLine("[9] Gravitational Grenade -  A grenade that creates a small localized gravity upon detonation. " +
                "The gravity can crush and immobilize enemies.");
            Console.Write("Choice: ");
            int GrenedeChoice = Convert.ToInt32(Console.ReadLine());

            switch (GrenedeChoice) {
                case 1: Grenade.GrenadeWeap = "Cluster Grenade"; break;
                case 2: Grenade.GrenadeWeap = "Cryo Bomb"; break;
                case 3: Grenade.GrenadeWeap = "Impact Grenade"; break;
                case 4: Grenade.GrenadeWeap = "Flashbang Grenade"; break;
                case 5: Grenade.GrenadeWeap = "Gas Grenade"; break;
                case 6: Grenade.GrenadeWeap = "Stun Grenade"; break;
                case 7: Grenade.GrenadeWeap = "Plasma Bomb"; break;
                case 8: Grenade.GrenadeWeap = "Vortex Bomb"; break;
                case 9: Grenade.GrenadeWeap = "Gravitational Grenade"; break;
            }

            return Grenade;
        }
    }
}
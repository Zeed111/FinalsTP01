using CharacterStructure;
using Stats;


namespace CharCreate {
    public class CharacterCreation {
        public BasicAttributesStruct Attributes = new BasicAttributesStruct("Unknown", "Unknown", "Unknown");
        public HomeWorldStruct World = new HomeWorldStruct("Unknown");
        public  OccupationStruct Role = new OccupationStruct("Unknown");
        public ApperanceStruct Look = new ApperanceStruct("Unknown", "Unknown", "Unknown", "Unknown", "Unknown", 
            "Unknown", "Unknown", "Unknown", "Unknown", "Unknown");
        public SpecialPowerStruct SP = new SpecialPowerStruct("Unknown");
        public CompanionStruct Partner = new CompanionStruct("Unknown");
        public PrimaryWeapStruct PryWeap = new PrimaryWeapStruct("Unknown");
        public SecondaryWeapStruct SdryWeap = new SecondaryWeapStruct("Unknown");
        public MeleeStruct Melee = new MeleeStruct("Unknown");
        public GrenadeStruct Grenade = new GrenadeStruct("Unknown");



        public void GetBasicAttributes() {
            string[,] SpeciesOptions = {
                {"Humans", ""},
                {"Titans", ""},
                {"Cyborg", ""},
                {"Shapeshifter", ""},
                {"Elves", ""},
            }; 

            string[,] GenderOptions = {
                {"Male", ""},
                {"Female", ""},
                {"Non-Binary", ""},
                {"Gay", ""},
                {"Lesbian", ""},
            };

            string[,] AgeOptions = {
                {"Rising Star", "- 50 to 100"},
                {"Super Rookie", "- 200 to 600"},
                {"Prime", "- 800 to 1,000"},
                {"Living Legend", "- 1,500 to 2,500"},
                {"Echoes of Past", "- 5,000 to 10,000"},
            };

            Console.WriteLine("--Basic Attributes--");
            Utility.DisplayOptions("Species", SpeciesOptions);
            int ChoiceSpecies = Utility.ValidateChoices("Choose a Species (1-5): ", 1, 5);
            
            Utility.DisplayOptions("Gender", GenderOptions);
            int ChoiceGender = Utility.ValidateChoices("Choose a Gender (1-5): ", 1, 5);

            Utility.DisplayOptions("Age", AgeOptions);
            int ChoiceAge = Utility.ValidateChoices("Choose a Age (1-5): ", 1, 5);

            Attributes.Species = SpeciesOptions[ChoiceSpecies -1, 0];
            Attributes.Gender = GenderOptions[ChoiceGender -1, 0];
            Attributes.Age = AgeOptions[ChoiceAge -1, 0];
        }

        public void GetHomeWorld() {
            string[,] HomeWorldOptions = {
                {"Ashara", "(High-Tech World)"},
                {"Pyros IX", "(Desert World)"},
                {"Vextris", " Wasted Earth version)"},
                {"Auralis", "(Prison Planet)"},
                {"Noctivis", " Orbital Luxury Ring World)"},
                {"Valtoria", "(Banking Capital World Trading)"}
            }; 

            Console.WriteLine(" ");
            Utility.DisplayOptions("HomeWorld", HomeWorldOptions);
            int ChoiceHomeWorld = Utility.ValidateChoices("Choose a HomeWorld (1-6): ", 1, 6);

            World.HomeWorld = HomeWorldOptions[ChoiceHomeWorld -1, 0];
        }

         public void GetOccupation() {
            string[,] OccupationOptions = {
                {"StarShip Captain", "- Leads a spacecraft, guiding the crew through missions, making key decisions, " +
                    "and handling interstellar challenges with leadership, strategy, and diplomacy."},
                {"Mercenary", "A soldier for hire, fighting for profit rather than loyalty, known for their " +
                    "combat skills and independence."},
                {"Merchant", "- A person who buys and sells goods for profit, often dealing in trade, commerce, or retail."},
                {"Hacker", "- Someone skilled in computer systems who finds and exploits vulnerabilities, often for " +
                    "accessing or manipulating data, either ethically or maliciously."},
                {"Sniper", "- A highly trained marksman specializing in long-range, precise shooting, often used in military " +
                    "or tactical operations."},
                {"Mage", "- A practitioner of magic, skilled in casting spells and manipulating mystical forces, often in fantasy settings."},
                {"Space Soldier", "- A combatant trained for warfare in outer space, often depicted in science fiction, " +
                    "equipped with advanced technology and weaponry to engage in battles on spacecraft or alien planets."}
            };

            Console.WriteLine(" ");
            Utility.DisplayOptions("Occupation", OccupationOptions);
            int ChoiceOccupation = Utility.ValidateChoices("Choose a Occupation (1-7): ", 1, 7);

            Role.Occupation = OccupationOptions[ChoiceOccupation -1, 0]; 
         }

        public void GetApperance() {
            Console.WriteLine(" ");
            Console.WriteLine("--Appearance Customization--");

            string[,] HairColorOptions = {
                {"Black", ""},
                {"Brown", ""},
                {"Blonde", ""},
                {"Red", ""},
                {"None (Bald)", ""}
            };
            
            string[,] HairTypeOptions = {
                {"Straight", ""},
                {"Curly", ""},
                {"Long", ""},
                {"Short", ""},
                {"Crystalline", ""}
            };

            string[,] EyeColorOptions = {
                {"Blue", ""},
                {"Green", ""},
                {"Brown", ""},
                {"Gold", ""},
                {"Black", ""}
            };

            string[,] SkinToneOptions = {
                {"Pale", ""},
                {"Fair", ""},
                {"Tan", ""},
                {"Olive", ""},
                {"Dark", ""}
            };

            string[,] HeadFaceAccessories = {
                {"Space Helmet", ""},
                {"Goggles", ""},
                {"Masks", ""},
                {"Scouter", ""},
                {"Earrings", ""}
            };

            string[,] TorsoBackAccessories = {
                {"Jetpacks", ""},
                {"Backpack", ""},
                {"Capes and Cloaks", ""},
                {"Utility Belts", ""}
            };

            string[,] ArmHandAccessories = {
                {"Space Gloves", ""},
                {"Rings", ""},
                {"Arm Bracelet", ""},
                {"Vortex Gauntlet", ""}
            };

            string[,] LegFootAccessories = {
                {"Boots", ""},
                {"Knee Pads", " "},
                {"Slippers", ""},
                {"Space Shoes", ""}
            }; 

            string[,] AuraOptions = {
                {"Black", ""},
                {"Red", ""},
                {"Green", ""},
                {"Blue", ""},
                {"Pink", ""}
            };

            
            Console.WriteLine(" ");
            Utility.DisplayOptions("Hair Color", HairColorOptions);
            int ChoiceHairColor = Utility.ValidateChoices("Choose a Hair Color (1-5): ", 1, 5);

            Console.WriteLine(" ");
            Utility.DisplayOptions("HairType", HairTypeOptions);
            int ChoiceHairType = Utility.ValidateChoices("Choose a Hair Type (1-5): ", 1, 5);

            Console.WriteLine(" ");
            Utility.DisplayOptions("Eye Color", EyeColorOptions);
            int ChoiceEyeColor = Utility.ValidateChoices("Choose a Eye Color (1-5): ", 1, 5);

            Console.WriteLine(" ");
            Utility.DisplayOptions("Skin Tone", SkinToneOptions);
            int ChoiceSkinTone = Utility.ValidateChoices("Choose a Skin Tone (1-5): ", 1, 5);

            Console.WriteLine(" ");
            Utility.DisplayOptions("Head Accessory", HeadFaceAccessories);
            int ChoiceHeadAccessory = Utility.ValidateChoices("Choose a Head Accessory (1-5): ", 1, 5);

            Console.WriteLine(" ");
            Utility.DisplayOptions("Body Accessory", TorsoBackAccessories);
            int ChoiceBodyAccessory = Utility.ValidateChoices("Choose a Body Accessory (1-4): ", 1, 4);

            Console.WriteLine(" ");
            Utility.DisplayOptions("Arm Accessory", ArmHandAccessories);
            int ChoiceArmAccessory = Utility.ValidateChoices("Choose a Arm Accessory (1-4): ", 1, 4);

            Console.WriteLine(" ");
            Utility.DisplayOptions("Leg Accessory", LegFootAccessories);
            int ChoiceLegAccessory = Utility.ValidateChoices("Choose a Leg Accessory (1-4): ", 1, 4);

            Console.WriteLine(" ");
            Utility.DisplayOptions("Aura", AuraOptions);
            int ChoiceAura = Utility.ValidateChoices("Choose a Aura (1-5): ", 1, 5);
            
            Look.HairColor = HairColorOptions[ChoiceHairColor -1, 0];
            Look.HairType = HairTypeOptions[ChoiceHairType -1, 0];
            Look.EyeColor = EyeColorOptions[ChoiceEyeColor -1, 0];
            Look.SkinTone = SkinToneOptions[ChoiceSkinTone -1, 0];
            Look.HeadAccessory = HeadFaceAccessories[ChoiceHeadAccessory -1, 0];
            Look.BodyAccessory = TorsoBackAccessories[ChoiceBodyAccessory -1, 0];
            Look.ArmAccessory = ArmHandAccessories[ChoiceArmAccessory -1, 0];
            Look.LegAccessory = LegFootAccessories[ChoiceLegAccessory -1, 0];
            Look.Aura = AuraOptions[ChoiceAura -1, 0];

            Console.WriteLine(" ");
            Console.WriteLine("Do you want a tail? [1] Yes [2] No");
            int TailChoice;

            while (true) {
                try {
                    TailChoice = Convert.ToInt32(Console.ReadLine());

                    switch (TailChoice) {
                        case 1:
                            Look.Tail = "Has Tail";
                            break;
                        case 2:
                            Look.Tail = "No Tail";
                            break;
                        default:
                            throw new Exception("Error 1 or 2 only");
                    }

                    break;
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void Stats(AllocateStatPoints CharStat) {
            CharStat.AskStats();
        }

        public void GetSpecialPower() {
            string[,] SpecialPowerOptions = {
                {"Precognition", "- Have glimpses of the future, allowing for the anticipation of danger or the prediction of events."},
                {"Technopathy", "- Control and interface with technology using the mind, a powerful ability in a technologically advanced setting."},
                {"Enhanced Strength", "- Essential for dealing with the rigors of space travel and potential physical threats."},
                {"Enhanced Durability", "- Withstand the harsh conditions of space and survive dangerous situations."},
                {"Gravity Manipulation", "- Control gravity to navigate zero-gravity environments, create force fields, or even as a weapon."},
                {"Elemental Control", "- Control elements like fire, ice, or electricity, potentially adapted to function in a space environment."}
            };

            Console.WriteLine(" ");
            Utility.DisplayOptions("Special Powers", SpecialPowerOptions);
            int ChoiceSpecialPower = Utility.ValidateChoices("Choose a Special Power (1-6): ", 1, 6);

            SP.SpecialPower = SpecialPowerOptions[ChoiceSpecialPower - 1, 0];
        }

        public void GetCompanion() {
            string[,] CompanionOptions = {
                {"Sentinel", "- A Hybrid-Robot Companion"},
                {"Beast", "- A Beast-type creature Companion"}
            };

            string[,] SentinelOptions = {
                {"Diriga", "- A Jellyfish hybrid robot that has a sniper rifle weapon and zaps nearby enemies."},
                {"Nautilus", "- An advanced robot capable of pulling enemies and equipped with an icy laser rifle."},
                {"Carrier", "- A carrier robot that provides ammo for its master and is equipped with a shotgun rifle."}
            };

            string[,] BeastOptions = {
                {"Smeeta", "- A beast that provides buffs to its master for a short period of time."},
                {"Sunika Kubrow", "- A dog-like beast that protects its master and is capable of launching thorns at enemies."},
                {"Hound", "- A dog-like beast with flames on its body, capable of burning its surroundings up to 5 meters."}
            };

            Console.WriteLine(" ");
            Utility.DisplayOptions("Companion", CompanionOptions);
            

            while (true) {
                try {
                    int CompanionChoice = Utility.ValidateChoices("Choose a Companion (1-2): ", 1, 2);
                    if (CompanionChoice == 1) {
                        Console.WriteLine(" ");
                        Utility.DisplayOptions("Sentinel", SentinelOptions);
                        int SentinelChoice = Utility.ValidateChoices("Choose a Sentinel (1-3): ", 1, 3);
                        Partner.Companion = SentinelOptions[SentinelChoice - 1, 0];
                    } else if (CompanionChoice == 2) {
                        Console.WriteLine(" ");
                        Utility.DisplayOptions("Beast", BeastOptions);
                        int BeastChoice = Utility.ValidateChoices("Choose a Beast (1-3): ", 1, 3);
                        Partner.Companion = BeastOptions[BeastChoice - 1, 0];
                    } else {
                        throw new Exception("Error!! Please choose 1 or 2");
                    }
                    break;
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void GetPrimary() {
            string[,] PrimaryWeaponOptions = {
                {"Assault Rifle", "- A rapid-fire, military-grade firearm designed for both short and long-range " +
                    "combat. It typically uses detachable magazines and is capable of firing in both semi-automatic " +
                    "and fully automatic modes."},
                {"Battle Rifle", "- A military firearm designed for longer-range combat than an assault rifle, " +
                    "typically chambered for a larger caliber round. It is often semi-automatic or selective-fire, " +
                    "offering higher accuracy and power for engaging targets at greater distances."},
                {"Sniper Rifle", "- A precision firearm designed for long-range shooting, with high accuracy and " +
                    "powerful optics, used by snipers for targeting distant or hidden enemies."},
                {"Submachine Gun", "- A compact, fully automatic firearm that fires pistol-caliber rounds, designed " +
                    "for close-range combat and high mobility."},
                {"Laser Gun", "- A weapon that uses focused beams of light or energy to damage targets."},
                {"Rail Gun", "- A weapon that uses electromagnetic forces to launch projectiles at extremely high " +
                    "speeds, typically relying on powerful electric currents rather than traditional gunpowder."},
                {"Plasma Gun", "- A futuristic weapon that fires superheated ionized gas (plasma) at high velocity."},
                {"Blaster", "- An energy weapon that fires concentrated energy bolts, typically using technologies " +
                    "like lasers or plasma to cause damage."},
                {"Acceltra", "- A fast-firing rifle that fires a barrage of rapid plasma rockets."},
                {"Torid", "- A grenade rifle that makes gas clouds dealing toxin damage."},
                {"AX-52", "- A rifle that gains ammo efficiency while firing and high critical chance when aiming for headshots."}
            };

            Console.WriteLine(" ");
            Utility.DisplayOptions("Primary Weapons", PrimaryWeaponOptions);
            int PrimaryWeaponChoice = Utility.ValidateChoices("Choose a Primary Weapon (1-11): ", 1, 11);

            PryWeap.PrimaryWeap = PrimaryWeaponOptions[PrimaryWeaponChoice - 1, 0];
        }

        public void GetSecondary() {
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
        }

        public void GetMelee() {
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
        }

        public void GetGrenade() {
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
        }
    }
}
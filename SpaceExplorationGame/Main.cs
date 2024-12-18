﻿using System;
using CharacterAbstruct;
using CharCreate;
using Stats;
using SpaceExplorationGameDatabase;
using System.Runtime.InteropServices;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Contracts;

public class SpaceExplorationGame {
    public static void Main(string[] args) {
        Database Connect = new Database();
        Connect.Connection();

        while (true) {
            Console.WriteLine("-----The Six keys of Destiny-----");
            Console.WriteLine("[1] New Game");
            Console.WriteLine("[2] Load Game");
            Console.WriteLine("[3] Campaign");
            Console.WriteLine("[4] Credits");
            Console.WriteLine("[5] Exit");
            Console.Write("Choice: ");

            try {
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("\x1b[3J");

                switch (choice) {
                    case 1:
                        NewGame();
                        break;
                    case 2:
                        LoadGame();
                        break;
                    case 3:
                        Campaign();
                        break;
                    case 4:
                        Credits();
                        break;   
                    case 5:
                        Environment.Exit(0); 
                        break;     
                    default:
                        throw new Exception("Error!! Please choose between 1 to 5");        
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                Thread.Sleep(2000);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.WriteLine(new string(' ', Console.WindowWidth));

                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("\x1b[3J");
            }
        }
    }

    public static void NewGame() {
        Character Create = new CharacterCreation();
        AllocateStatPoints CharStat = new AllocateStatPoints();
        var DBInsert = new Database();

        Console.Clear();
        Console.WriteLine("\x1b[3J");
        Create.GetBasicAttributes();
        Console.Clear();
        Create.GetHomeWorld();
        Console.Clear();
        Create.GetOccupation();
        Console.Clear();
        Create.GetApperance();
        Console.Clear();
        Create.GetSpecialPower();
        Console.Clear();
        Create.GetCompanion();
        Console.Clear();
        Create.GetPrimary();
        Console.Clear();
        Create.GetSecondary();
        Console.Clear();
        Create.GetMelee();
        Console.Clear();
        Create.GetGrenade();
        Console.Clear();
        Create.CharacterStats(CharStat);
        Console.Clear();

        Create.Attributes.Display();
        Create.World.Display();
        Create.Role.Display();
        Create.Look.Display();
        Create.SP.Display();
        Create.Partner.Display();
        Create.PryWeap.Display();
        Create.SdryWeap.Display();  
        Create.Melee.Display();
        Create.Grenade.Display();
        CharStat.Display();

        string TableName = "characters";

        var CharacterData = new Dictionary<string, object> {
            {"species", Create.Attributes.Species},
            {"gender", Create.Attributes.Gender},
            {"age", Create.Attributes.Age},
            {"home_world", Create.World.HomeWorld},
            {"occupation", Create.Role.Occupation},
            {"hair_color", Create.Look.HairColor},
            {"hair_type", Create.Look.HairType},
            {"eye_color", Create.Look.EyeColor},
            {"skin_tone", Create.Look.SkinTone},
            {"head_accessory", Create.Look.HeadAccessory},
            {"body_accessory", Create.Look.BodyAccessory},
            {"arm_accessory", Create.Look.ArmAccessory},
            {"leg_accessory", Create.Look.LegAccessory},
            {"tail", Create.Look.Tail},
            {"aura", Create.Look.Aura},
            {"special_power", Create.SP.SpecialPower},
            {"companion", Create.Partner.Companion},
            {"primary_weap", Create.PryWeap.PrimaryWeap},
            {"secondary_weap", Create.SdryWeap.SecondaryWeap},
            {"melee", Create.Melee.MeleeWeap},
            {"grenade", Create.Grenade.GrenadeWeap},
            {"strength", CharStat.Strength},
            {"dexterity", CharStat.Dexterity},
            {"constitution", CharStat.Constitution},
            {"intelligence", CharStat.Intelligence},
            {"wisdom", CharStat.Wisdom},
            {"charisma", CharStat.Charisma},

        };

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("\x1b[3J");

        bool Success = DBInsert.Create(TableName, CharacterData);

        Console.WriteLine("Loading....");
        Thread.Sleep(2000);
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.WriteLine(new string(' ', Console.WindowWidth));

        Console.WriteLine(Success ? "Your Character is Saved" : "Failed to save your Character" );

        Console.WriteLine("Loading....");
        Thread.Sleep(2000);
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.WriteLine(new string(' ', Console.WindowWidth));

        Console.WriteLine("Press any key to go back to main menu.");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("\x1b[3J");
    }

    public static void LoadGame() {
        var DB = new Database();
        string Tablename = "characters";

        while (true) {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            Console.WriteLine("-----Load Game-----");
            Console.WriteLine("[1] Load All Saved Character");
            Console.WriteLine("[2] Load Specific Saved Character");
            Console.WriteLine("[3] Go to Main Menu");
            Console.Write("Choice: ");

            try {
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("\x1b[3J");

                switch (choice) {
                    case 1:
                        LoadCharAll(DB, Tablename);
                        break;
                    case 2:
                        LoadChar(DB, Tablename);
                        break;
                    case 3:
                        return;
                    default:
                        throw new Exception("Error!! Please choose between 1 to 3");
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                Thread.Sleep(2000);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.WriteLine(new string(' ', Console.WindowWidth));

                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    public static void LoadCharAll(Database DB, string Tablename) { 
        try {
            var Data = DB.GetData(Tablename);

            if (Data.Count == 0) {
                Console.WriteLine("No saved characters found!");
                Console.WriteLine("Press any key to return to the menu.");
                Console.ReadKey();
                return;
            }

            int CharCount = 1;
            Console.WriteLine("Loading.....");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("\x1b[3J");

            foreach (var Character in Data) {
                Console.WriteLine($"-----Character {CharCount}-----");
                CharCount++;
                Console.WriteLine($"-----------------------------");
                foreach (var Column in Character) {
                    string DisplayName = Column.Key switch {
                        "id" => "ID",
                        "species" => "Species",
                        "gender" => "Gender",
                        "age" => "Age",
                        "home_world" => "HomeWorld",
                        "occupation" => "Occupation",
                        "hair_color" => "HairColor",
                        "hair_type" => "HairType",
                        "eye_color" => "EyeColor",
                        "skin_tone" => "Skin one",
                        "head_accessory" => "HeadAccessory",
                        "body_accessory" => "BodyAccessory",
                        "arm_accessory" => "ArmAccessory",
                        "leg_accessory" => "LegAccessory",
                        "tail" => "Tail",
                        "aura" => "Aura",
                        "special_power" => "SpecialPower",
                        "companion" => "Companion",
                        "primary_weap" => "PrimaryWeapon",
                        "secondary_weap" => "SecondaryWeapon",
                        "melee" => "Melee",
                        "grenade" => "Grenade",
                        "strength" => "Strength",
                        "dexterity" => "Dexterity",
                        "constitution" => "Constitution",
                        "intelligence" => "Intelligence",
                        "wisdom" => "Wisdom",
                        "charisma" => "Charisma",
                        _ => Column.Key
                    };

                    Console.WriteLine($"{DisplayName}: {Column.Value}");
                }

                Console.WriteLine($"-----------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Loading...");
                Thread.Sleep(1000);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.WriteLine(new string(' ', Console.WindowWidth));
            }

            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
            Console.WriteLine("Loading...");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("\x1b[3J");

        } catch (Exception e) {
            Console.WriteLine("There is an error while loading you character!!" + e.Message);
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
        }
    }

    public static void LoadChar(Database DB, string TableName) {
        try {
            var Data = DB.GetData(TableName);

            if (Data.Count == 0) {
                Console.WriteLine("No saved characters found!");
                Console.WriteLine("Press any key to return to the menu.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Loading.....");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            Console.WriteLine("----Saved Characters-----");

            for (int i = 0; i < Data.Count; i++) { 
                Console.WriteLine($"[{i + 1}] Character {i + 1}: {Data[i] ["species"]}");
            }

            Console.WriteLine("Select a number to view the details of the character: ");
            Console.Write("Choice: ");
            if (int.TryParse(Console.ReadLine(), out int Value) && Value >= 1 && Value <= Data.Count) { 
                var Character = Data[Value - 1];
                Console.Clear();
                Console.WriteLine("\x1b[3J");
                Console.WriteLine("-----Character Detail-----");
                Console.WriteLine($"-----------------------------");

                foreach (var Column in Character) {
                    string DisplayName = Column.Key switch {
                        "id" => "ID",
                        "species" => "Species",
                        "gender" => "Gender",
                        "age" => "Age",
                        "home_world" => "HomeWorld",
                        "occupation" => "Occupation",
                        "hair_color" => "HairColor",
                        "hair_type" => "HairType",
                        "eye_color" => "EyeColor",
                        "skin_tone" => "Skin one",
                        "head_accessory" => "HeadAccessory",
                        "body_accessory" => "BodyAccessory",
                        "arm_accessory" => "ArmAccessory",
                        "leg_accessory" => "LegAccessory",
                        "tail" => "Tail",
                        "aura" => "Aura",
                        "special_power" => "SpecialPower",
                        "companion" => "Companion",
                        "primary_weap" => "PrimaryWeapon",
                        "secondary_weap" => "SecondaryWeapon",
                        "melee" => "Melee",
                        "grenade" => "Grenade",
                        "strength" => "Strength",
                        "dexterity" => "Dexterity",
                        "constitution" => "Constitution",
                        "intelligence" => "Intelligence",
                        "wisdom" => "Wisdom",
                        "charisma" => "Charisma",
                        _ => Column.Key
                    };
                    
                    Console.WriteLine($"{DisplayName}: {Column.Value}");
                }

                Console.WriteLine($"-----------------------------");
                Console.WriteLine("Press 1 to DELETE or Press enter to return to the menu.");
                Console.Write("Choice: ");
                string WantToDelete = Console.ReadLine();

                if (WantToDelete == "1") {
                    Console.WriteLine("Type 'CONFIRM' to delete this character.");
                    Console.Write("Choice: ");
                    string ConfirmDelete = Console.ReadLine();
                    if (ConfirmDelete == "CONFIRM") {
                        int Id = Convert.ToInt32(Character["id"]);
                        if (DB.Delete(TableName, Id)) {
                            Console.WriteLine("Deleting...");
                            Thread.Sleep(3000);
                            Console.Clear();
                            Console.WriteLine("\x1b[3J");
                            Console.WriteLine("Deleted Successfully!!!!");
                            Console.WriteLine("Press any key to return to the menu.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("\x1b[3J");
                        } else {
                            Console.WriteLine("Failed to Delete!!!");
                        }
                    } else {
                        Console.WriteLine("Canceled...");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("\x1b[3J");
                        LoadGame();
                    }
                } else {
                    Console.WriteLine("Loading...");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("\x1b[3J");
                    LoadGame();
                }
            } else {
                Console.WriteLine("Loading...");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("\x1b[3J");
                Console.WriteLine("Error!!!");
                Console.WriteLine(" ");
                Console.WriteLine("Press any key to return to the menu.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("\x1b[3J");
            }
        } catch (Exception e) { 
            Console.WriteLine("There is an error while loading you character!!" + e.Message);
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
        }
    }

    public static void Campaign() {
        Console.WriteLine("-----Campaign-----");
        Console.WriteLine("");
        string Paragraph1 = $"In a distant galaxy, a person embarked on a mission\n" + 
            "to save their sibling, taken by a powerful organization obsessed with\n" + 
            "controlling The Laugh Tail, a planet where no one had ever survived.\n" + 
            "Legends spoke of its gates, sealed by six keys scattered across the\n" + 
            "galaxy. The first stop was Ashara, a high-tech world of towering\n" + 
            "cities and advanced AI. Navigating complex digital networks, the\n" + 
            "person earned the trust of Ashara’s sentient AI and secured the first\n" + 
            "key. With newfound cyber-skills, they set out, knowing greater challenges lay ahead.";

        foreach (char Letter in Paragraph1) {
            Console.Write(Letter);
            Thread.Sleep(45);
        }

        Console.WriteLine("");
        Console.WriteLine("Loading....");
        Thread.Sleep(5000);
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.WriteLine(new string(' ', Console.WindowWidth));

        string Paragraph2 = $"Next, they arrived on Pyros IX, a desert planet ruled by relentless\n" +
            "sandstorms and fierce nomadic tribes. The tribes, who revered the second\n" +
            "key as sacred, tested the person’s resolve through brutal survival trials.\n" +
            "After mastering desert warfare and proving their strength, the person earned\n" +
            "the tribes' respect and the key. On Vextris, a toxic wasteland plagued by acid\n" +
            "rains and monstrous mutations, their endurance was tested further. Battling the\n" +
            "harsh environment and mutated creatures, they unearthed the third key from the\n" +
            "ruins of a forgotten civilization.";

        foreach (char Letter in Paragraph2) {
            Console.Write(Letter);
            Thread.Sleep(45);
        }

        Console.WriteLine("");
        Console.WriteLine("Loading....");
        Thread.Sleep(5000);
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.WriteLine(new string(' ', Console.WindowWidth));

        string Paragraph3 = $"The journey then led to Auralis, a brutal prison planet where chaos\n" + 
            "reigned and violence was law. To claim the fourth key, the person infiltrated\n" + 
            "the prison hierarchy, forming uneasy alliances with the most dangerous inmates.\n" + 
            "Enduring brutal combat and navigating deadly power struggles, they emerged\n" + 
            "victorious, key in hand. From Auralis, they traveled to Noctivis, an opulent\n" + 
            "orbital ring world where luxury hid corruption. Using diplomacy and deception,\n" + 
            "they maneuvered through political intrigue, securing the fifth key through\n" + 
            "cunning and wit.";

        foreach (char Letter in Paragraph3) {
            Console.Write(Letter);
            Thread.Sleep(45);
        }

        Console.WriteLine("");
        Console.WriteLine("Loading....");
        Thread.Sleep(5000);  
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.WriteLine(new string(' ', Console.WindowWidth));

        string Paragraph4 = "Their final stop before The Laugh Tail was Valtoria, the galaxy’s financial\n" + 
            "hub, where wealth dictated power. The final key was locked in the vaults of\n" + 
            "Valtoria’s most powerful factions, requiring both strategy and risk. In a daring\n" + 
            "heist, the person outwitted the planet’s elite and secured the last key. With all\n" + 
            "six keys now in their possession, they prepared for the ultimate challenge. They\n" + 
            "knew the gates of The Laugh Tail would soon open, leading them to a fate no one\n" + 
            "else had survived.";

        foreach (char Letter in Paragraph4) {
            Console.Write(Letter);
            Thread.Sleep(45);
        }

        Console.WriteLine("");
        Console.WriteLine("Loading....");
        Thread.Sleep(5000);    
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.WriteLine(new string(' ', Console.WindowWidth));

        string Paragraph5 = "Standing at the gates of The Laugh Tail, the person felt the weight of their\n" + 
            "journey, but fear did not stop them. The fate of their sibling and the promise\n" + 
            "of survival drove them forward, ready to face whatever waited beyond. They had\n" + 
            "leveled up through every trial, mastering new skills and gaining allies in\n" + 
            "unexpected places. With a deep breath, they unlocked the gates, stepping into\n" + 
            "the unknown. What lay ahead would test everything they had become.";

        foreach (char Letter in Paragraph5) {
            Console.Write(Letter);
            Thread.Sleep(45);
        }

        Console.WriteLine("");
        Console.WriteLine("Loading....");
        Thread.Sleep(5000);    
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.WriteLine(new string(' ', Console.WindowWidth));


        Console.WriteLine("Press any key to go back to main menu.");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("\x1b[3J");
    }

    public static void Credits() {
        Console.WriteLine("");
        Console.WriteLine("Loading....");
        Thread.Sleep(2000);
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.WriteLine(new string(' ', Console.WindowWidth));

        string Credits = "-----Raven Villanueva-----\n" + "-----Daniel Gutierrez-------\n" + "-----Lenardo Jualo------";

        Console.WriteLine("-----Creators of the Game-----");

        foreach (char Letter in Credits) {
            Console.Write(Letter);
            Thread.Sleep(150);
        } 
        
        Console.WriteLine("");
        Console.WriteLine("Loading....");
        Thread.Sleep(2000);
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.WriteLine(new string(' ', Console.WindowWidth));

        Console.WriteLine("Press any key to go back to main menu.");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("\x1b[3J");
    }
}
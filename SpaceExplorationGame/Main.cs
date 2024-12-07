using System;
using CharacterAbstruct;
using CharCreate;
using Stats;
using SpaceExplorationGameDatabase;

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

                switch (choice) {
                    case 1:
                        Console.Clear();
                        NewGame();
                        break;
                    case 2:
                        Console.Clear();
                        LoadGame();
                        break;
                    case 3:
                        Console.Clear();
                        Campaign();
                        break;
                    case 4:
                        Console.Clear();
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
            }
        }
    }

    public static void NewGame() {
        Character Create = new CharacterCreation();
        AllocateStatPoints CharStat = new AllocateStatPoints();
        var DBInsert = new Database();

        Console.Clear();
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

        bool Success = DBInsert.Create(TableName, CharacterData);

        Console.WriteLine(Success ? "Your Character is Saved" : "Failed to save your Character" );

        Console.WriteLine("Loading....");
        Thread.Sleep(2000);
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.WriteLine(new string(' ', Console.WindowWidth));

        Console.WriteLine("Press any key to go back to main menu.");
        Console.ReadKey();
        Console.Clear();
    }

    public static void LoadGame() {
        var DBDelete = new Database();

    }

    public static void Campaign() {
        Console.WriteLine("");
        Console.WriteLine($"In a distant galaxy, a person embarked on a mission\n" + 
            "to save their sibling, taken by a powerful organization obsessed with\n" + 
            "controlling The Laugh Tail, a planet where no one had ever survived.\n" + 
            "Legends spoke of its gates, sealed by six keys scattered across the\n" + 
            "galaxy. The first stop was Ashara, a high-tech world of towering\n" + 
            "cities and advanced AI. Navigating complex digital networks, the\n" + 
            "person earned the trust of Ashara’s sentient AI and secured the first\n" + 
            "key. With newfound cyber-skills, they set out, knowing greater challenges lay ahead.");

        Console.WriteLine("");
        Console.WriteLine("Loading....");
        Thread.Sleep(5000);
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.WriteLine(new string(' ', Console.WindowWidth));

        Console.WriteLine($"Next, they arrived on Pyros IX, a desert planet ruled by relentless\n" +
            "sandstorms and fierce nomadic tribes. The tribes, who revered the second\n" +
            "key as sacred, tested the person’s resolve through brutal survival trials.\n" +
            "After mastering desert warfare and proving their strength, the person earned\n" +
            "the tribes' respect and the key. On Vextris, a toxic wasteland plagued by acid\n" +
            "rains and monstrous mutations, their endurance was tested further. Battling the\n" +
            "harsh environment and mutated creatures, they unearthed the third key from the\n" +
            "ruins of a forgotten civilization.");
        
        Console.WriteLine("");
        Console.WriteLine("Loading....");
        Thread.Sleep(5000);
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.WriteLine(new string(' ', Console.WindowWidth));

        Console.WriteLine($"The journey then led to Auralis, a brutal prison planet where chaos\n" + 
            "reigned and violence was law. To claim the fourth key, the person infiltrated\n" + 
            "the prison hierarchy, forming uneasy alliances with the most dangerous inmates.\n" + 
            "Enduring brutal combat and navigating deadly power struggles, they emerged\n" + 
            "victorious, key in hand. From Auralis, they traveled to Noctivis, an opulent\n" + 
            "orbital ring world where luxury hid corruption. Using diplomacy and deception,\n" + 
            "they maneuvered through political intrigue, securing the fifth key through\n" + 
            "cunning and wit.");

        Console.WriteLine("");
        Console.WriteLine("Loading....");
        Thread.Sleep(5000);  
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.WriteLine(new string(' ', Console.WindowWidth));
        
        Console.WriteLine("Their final stop before The Laugh Tail was Valtoria, the galaxy’s financial\n" + 
            "hub, where wealth dictated power. The final key was locked in the vaults of\n" + 
            "Valtoria’s most powerful factions, requiring both strategy and risk. In a daring\n" + 
            "heist, the person outwitted the planet’s elite and secured the last key. With all\n" + 
            "six keys now in their possession, they prepared for the ultimate challenge. They\n" + 
            "knew the gates of The Laugh Tail would soon open, leading them to a fate no one\n" + 
            "else had survived.");

        Console.WriteLine("");
        Console.WriteLine("Loading....");
        Thread.Sleep(5000);    
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.WriteLine(new string(' ', Console.WindowWidth));
        
        Console.WriteLine("Standing at the gates of The Laugh Tail, the person felt the weight of their\n" + 
            "journey, but fear did not stop them. The fate of their sibling and the promise\n" + 
            "of survival drove them forward, ready to face whatever waited beyond. They had\n" + 
            "leveled up through every trial, mastering new skills and gaining allies in\n" + 
            "unexpected places. With a deep breath, they unlocked the gates, stepping into\n" + 
            "the unknown. What lay ahead would test everything they had become.");

        Console.WriteLine("");
        Console.WriteLine("Loading....");
        Thread.Sleep(5000);    
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.WriteLine(new string(' ', Console.WindowWidth));


        Console.WriteLine("Press any key to go back to main menu.");
        Console.ReadKey();
        Console.Clear();
    }

    public static void Credits() {
        Console.WriteLine("");
        Console.WriteLine("Loading....");
        Thread.Sleep(2000);
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.WriteLine(new string(' ', Console.WindowWidth));

        Console.WriteLine("-----Raven Villanueva-----");
        Console.WriteLine("-----Lenardo Jualo------");
        Console.WriteLine("-----Daniel Gutierrez-------");

        Console.WriteLine("");
        Console.WriteLine("Loading....");
        Thread.Sleep(2000);
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.WriteLine(new string(' ', Console.WindowWidth));

        Console.WriteLine("Press any key to go back to main menu.");
        Console.ReadKey();
        Console.Clear();
    }
}
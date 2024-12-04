using System;
using CharacterAbstruct;
using CharCreate;
using Stats;

public class SpaceExplorationGame {
    public static void Main(string[] args) {
        while (true) {
            Console.WriteLine("-----Space Exploration Game-----");
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
                        NewGame();
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
            } catch (Exception) {
                Console.WriteLine(" ");
                Console.WriteLine("Please enter a number!");
            }
        }
    }

    public static void NewGame() {
        Character Create = new CharacterCreation();
        AllocateStatPoints CharStat = new AllocateStatPoints();

        Create.GetBasicAttributes();
        Create.GetHomeWorld();
        Create.GetOccupation();
        Create.GetApperance();
        Create.GetSpecialPower();
        Create.GetCompanion();
        Create.GetPrimary();
        Create.GetSecondary();
        Create.GetMelee();
        Create.GetGrenade();

        Create.CharacterStats(CharStat);
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

        Console.WriteLine("Loading....");
        Thread.Sleep(2000);
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.WriteLine(new string(' ', Console.WindowWidth));

        Console.WriteLine("Press any key to go back to main menu.");
        Console.ReadKey();
        Console.Clear();
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
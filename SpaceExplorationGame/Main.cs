using System;
using CharCreate;
using CharacterStructure;

public class SpaceExplorationGame {
    public static void Main(string[] args) {
        Console.WriteLine("-----Space Exploration Game-----");
        Console.WriteLine("[1] New Game");
        Console.WriteLine("[2] Load Game");
        Console.WriteLine("[3] Credits");
        Console.WriteLine("[4] Exit");
        Console.Write("Choice: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice) {
            case 1:
                NewGame();
                break;
            case 3:
                break;
            case 4:
                Environment.Exit(0); 
                break;         
        }
    }

    public static void NewGame() {
        CharacterCreation Create = new CharacterCreation();
        BasicAttributesStruct BasicAttri = Create.GetBasicAttributes();
        HomeWorldStruct World = Create.GetHomeWorld();
        OccupationStruct Occupation = Create.GetOccupation();
        ApperanceStruct Apperance = Create.GetApperance();

        BasicAttri.Display();
        World.Display();
        Occupation.Display();
        Apperance.Display();
    }
}
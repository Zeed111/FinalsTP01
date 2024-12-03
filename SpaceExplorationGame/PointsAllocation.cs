using CharacterStructure;

namespace Stats {
    public class AllocateStatPoints : IDisplayInfo {
        private int Strength { get; set; }
        private int Dexterity { get; set; }
        private int Constitution { get; set; }
        private int Intelligence { get; set; }
        private int Wisdom { get; set; }
        private int Charisma { get; set; }
        private int RemainingPoints { get; set; }
        private const int MaxPoints = 10;
        private const int AllocationPoints = 20;

        public AllocateStatPoints() {
            RemainingPoints = AllocationPoints;
        }

        public void AskStats() {
            Console.WriteLine(" ");
            Console.WriteLine($"You have {AllocationPoints} points to allocate across the following stats.");
            Console.WriteLine($"Each stat have maximum points of {MaxPoints}.");
           
            Strength = GetStatsPoints("Strength");
            if (RemainingPoints == 0) { AutoAllocate(); return; }

            Dexterity = GetStatsPoints("Dexterity");
            if (RemainingPoints == 0) { AutoAllocate(); return; }

            Constitution = GetStatsPoints("Constitution");
            if (RemainingPoints == 0) { AutoAllocate(); return; }

            Intelligence = GetStatsPoints("Intelligence");
            if (RemainingPoints == 0) { AutoAllocate(); return; }

            Wisdom = GetStatsPoints("Wisdom");
            if (RemainingPoints == 0) { AutoAllocate();return; }

            Charisma = GetStatsPoints("Charisma");
            if (RemainingPoints == 0) { AutoAllocate(); return; } 
        }

        public int GetStatsPoints(string  StatName) {
            while (true) {
                Console.WriteLine(" ");
                Console.WriteLine($"Remaining Points {RemainingPoints}.");
                Console.Write($"{StatName}: ");

                try {
                    int Points = Convert.ToInt32(Console.ReadLine());

                    if (Points < 0) {
                        throw new Exception("Points must be greater or equal than 0.");
                    } else if (Points > MaxPoints) {
                        throw new Exception("You cannot exceed over 10.");
                    } else if (Points > RemainingPoints) {
                        throw new Exception($"You only have {RemainingPoints} remaining.");
                    } else {
                        RemainingPoints -= Points;
                        return Points;
                    }
                } catch (FormatException fe) {
                    Console.WriteLine(fe.Message);
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void AutoAllocate() {
            if (Strength == 0) { Strength = 1;} 
            if (Dexterity == 0) { Dexterity = 1;} 
            if (Constitution == 0) { Constitution = 1; } 
            if (Intelligence == 0) { Intelligence = 1; } 
            if (Wisdom == 0) { Wisdom = 1; } 
            if (Charisma == 0) { Charisma = 1; }
        }

        public void Display() {
            Console.WriteLine($"Strength : {Strength}");
            Console.WriteLine($"Dexterity : {Dexterity}");
            Console.WriteLine($"Constitution : {Constitution}");
            Console.WriteLine($"Intelligence : {Intelligence}");
            Console.WriteLine($"Wisdom : {Wisdom}");
            Console.WriteLine($"Charisma : {Charisma}");
        }
    }
}
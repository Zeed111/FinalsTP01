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
}
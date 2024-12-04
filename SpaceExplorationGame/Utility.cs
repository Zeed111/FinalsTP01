using System.Text.RegularExpressions;

public static class Utility {
    public static void DisplayOptions(string Category, string[,] Options) {
        Console.WriteLine($"---{Category}---");
        for (int i = 0; i < Options.GetLength(0); i++) {
            Console.WriteLine($"[{i + 1}] {Options[ i, 0 ]} {Options[ i, 1 ]}");
        }
        Console.WriteLine(" ");
    }

    public static int ValidateChoices(string Propmt, int Min, int Max) {
        int Choice;
        string Input;

        string Pattern = @"^\d+$";
        Regex regex = new Regex(Pattern);

       while (true) {
            Console.Write(Propmt);
            Input = Console.ReadLine();

            try {
                if (!regex.IsMatch(Input)) {
                    throw new Exception("Error!! Please Enter Number Only\n");
                }

                Choice = Convert.ToInt32(Input);

                if (Choice < Min || Choice > Max) {
                    throw new Exception($"Error!! Please a number between {Min} to {Max} only!!\n");
                }

                return Choice;
            } catch (FormatException fe) {
                Console.WriteLine(fe.Message);
            } catch (ArgumentException ae) {
                Console.WriteLine(ae.Message);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
       }
    }
} 
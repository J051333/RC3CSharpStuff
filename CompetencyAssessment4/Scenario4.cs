namespace CompetencyAssessment4 {
    public abstract class Scenario4 {
        /// <summary>
        /// Scenario4's main method.
        /// </summary>
        public static void RunScenario4() {
            double n = TakeNumericalInput("Please enter the number to evaluate: ", 5);

            Console.WriteLine($"There are {CountDigits(n.ToString(), 0)} digits in {n}.");
        }

        public static double CountDigits(String n, int counter) {
            if (n == "") {
                return counter;
            }

            if (n[0] != '.') {
                counter++;
            }

            n = n.Remove(0, 1);
            return CountDigits(n, counter);
        }

        /// <summary>
        /// Prompts the user for a numerical value. If parsing is successful, returns the <c>int</c> form, else the default provided (duplicate method for standalone purposes).
        /// </summary>
        /// <param name="prompt">Text prompt for user.</param>
        /// <param name="def">Default value should parsing fail.</param>
        /// <returns></returns>
        private static double TakeNumericalInput(string prompt, double def) {
            Console.Write(prompt);

            try {
                string? input = Console.ReadLine();

                if (input == null || input == "") {
                    throw new Exception();
                }

                return double.Parse(input);
            } catch (Exception) {
                Console.WriteLine("Invalid value.");
                return def;
            }
        }
    }
}
